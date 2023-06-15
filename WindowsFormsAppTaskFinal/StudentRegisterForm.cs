using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;
using static System.Double;

namespace WindowsFormsAppTaskFinal
{
    public partial class StudentRegisterForm : Form
    {
        private readonly TrackDirector _trackDirector;
        public StudentRegisterForm(TrackDirector trackDirector)
        {
            _trackDirector = trackDirector;
            InitializeComponent();
        }

        private void trackSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentYearlyDrainBox.Text = CalculateYearlyDrain(specilizationSelector.SelectedItem.ToString(),
                trackSelector.SelectedItem.ToString()).ToString(CultureInfo.InvariantCulture);
        }
        

        private async void finishRegButton_Click(object sender, EventArgs e)
        {
            idTextBox.BackColor = System.Drawing.Color.White;
            firstNameTextBox.BackColor = System.Drawing.Color.White;
            lastNameTextBox.BackColor = System.Drawing.Color.White;
            phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            emailTextBox.BackColor = System.Drawing.Color.White;
            passwordTextBox.BackColor = System.Drawing.Color.White;
            birthDatePicker.BackColor = System.Drawing.Color.White;
            // Perform the validations before proceeding with registration
            var ID = idTextBox.Text.Trim();
            var firstName = firstNameTextBox.Text.Trim();
            var lastName = lastNameTextBox.Text.Trim();
            var password = passwordTextBox.Text.Trim();
            var birthDate = birthDatePicker.Value;
            var phoneNumber = phoneNumberTextBox.Text.Trim();
            var email = emailTextBox.Text.Trim();
            var studentNumber = GenerateStudentNumber();
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ID) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName)
                || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(specilizationSelector.SelectedItem.ToString())
                || string.IsNullOrWhiteSpace(trackSelector.SelectedItem.ToString()))
            {
                MessageBox.Show(@"All fields must be filled out!");
                return;
            }
            var selectedSpecialization = specilizationSelector.SelectedItem.ToString();
            var selectedTrack = trackSelector.SelectedItem.ToString();
            var yearlyDrain = CalculateYearlyDrain(selectedSpecialization, selectedTrack);
            
            // Update the UI to show the calculated yearly drain
            currentYearlyDrainBox.Text = yearlyDrain.ToString(CultureInfo.InvariantCulture);

            // Validate Bank Balance
            var bankBalance = await ValidateBankBalanceAsync(balanceTextBox.Text.Trim());
            if (Math.Abs(bankBalance - -1.0) < Epsilon)
            {
                balanceTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }
            
            // Validate Id text box
            if (!int.TryParse(idTextBox.Text.Trim(), out var id) || ID.Length != 9 || !ID.All(char.IsDigit))
            {
                idTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }

            // Validate First Name text box
            if (firstName.Length > 25 || !Regex.IsMatch(firstName, @"^[a-zA-Z]+$"))
            {
                firstNameTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }

            // Validate Last Name text box
            if (lastName.Length > 25 || !Regex.IsMatch(lastName, @"^[a-zA-Z]+$"))
            {
                lastNameTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }
            
            if (password.Length < 10 || password.Length > 100 || !Regex.IsMatch(password, @"^[a-zA-Z0-9]+$"))
            {
                passwordTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }

            // Validate Birthdate picker
            var currentDate = DateTime.Now;
            var minDate = new DateTime(1910, 1, 1);
            var age = currentDate.Year - birthDate.Year;
            if (birthDate > currentDate || birthDate < minDate)
            {
                birthDatePicker.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            // Validate Phone Number text box
            if (!phoneNumber.StartsWith("05") || phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                phoneNumberTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }

            // Validate Email text box
            if (!IsValidEmail(email))
            {
                emailTextBox.BackColor = System.Drawing.Color.LightSalmon;
                isValid = false;
            }

            if (!isValid)
            {
                // Display an error message or take appropriate action
                MessageBox.Show(@"Please fix the highlighted fields before proceeding.");
                return;
            }
            
            // Registration logic
            Person registeredStudent;
            if (exerciserCheckBox.Checked)
            {
                var personExists = _trackDirector.Persons.Any(person => person.Email.Equals(email) || person.Id == id);

                if (personExists)
                {
                    MessageBox.Show(@"The user already exists in the system, you can try logging in instead.");
                    return;
                }
                registeredStudent = new Exerciser(id, firstName, lastName, age, phoneNumber, email, password, studentNumber,
                        selectedSpecialization, _trackDirector.ResponsibleTracks.Find(track => track.TrackName.Equals(selectedTrack)),
                        bankBalance, yearlyDrain, 0);
                _trackDirector.Persons.Add(registeredStudent);
            }
            else
            {
                var studentExists = _trackDirector.Students.Any(student => student.Email.Equals(email) || student.Id == id);

                if (studentExists)
                {
                    MessageBox.Show(@"The user already exists in the system, you can try logging in instead.");
                    return;
                }
                registeredStudent = new Student(id, firstName, lastName, age, phoneNumber, email, password, studentNumber,
                    selectedSpecialization, _trackDirector.ResponsibleTracks.Find(track => track.TrackName.Equals(selectedTrack)),
                    bankBalance, yearlyDrain, 0);
                _trackDirector.Students.Add((Student)registeredStudent);
            }
            await SaveTrackDirectorAsync(_trackDirector);
            MessageBox.Show(@"You have been successfully registered to our system! You will now be redirected to the login page.");
            Hide();
        }
        
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private static async Task<double> ValidateBankBalanceAsync(string balance)
        {
            await Task.Delay(1000);
            var valid =  TryParse(balance, out var bankBalance);
            if (valid)
                return bankBalance;
            return -1.0;
        }
        
        private async Task SaveTrackDirectorAsync(TrackDirector trackDirector)
        {
            // Add your asynchronous save logic here
            // For example, you can save the track director object to a database asynchronously
            await Task.Delay(1000); // Simulating an asynchronous operation

            FileHandler.SaveTrackDirector(trackDirector);
        }
        
        // Generate a random student number
        private int GenerateStudentNumber()
        {
            var random = new Random();
            int studentNumber;

            do
            {
                studentNumber = random.Next(1, 999999);
            } while (_trackDirector.Students.Exists(student => student.StudentNumber.Equals(studentNumber)));
            studentNumberTextBox.Text = studentNumber.ToString();
            return studentNumber;
        }
        
        private void specializationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the track list
            trackSelector.Items.Clear();

            // Get the selected specialization
            var selectedSpecialization = specilizationSelector.SelectedItem.ToString();

            switch (selectedSpecialization)
            {
                // Populate the track list based on the selected specialization
                // Implement your own logic here to retrieve appropriate tracks for the selected specialization
                // For demonstration purposes, I'll populate some sample tracks
                case "Architecture":
                    trackSelector.Items.Add("Architectural Design");
                    break;
                case "Exterior Blueprinting":
                    trackSelector.Items.Add("Architectural Design");
                    break;
                case "Floor Tiling":
                    trackSelector.Items.Add("Architectural Design");
                    break;
                case "Computer Science":
                    trackSelector.Items.Add("Cyber Security");
                    break;
                case "Software Engineering":
                    trackSelector.Items.Add("Cyber Security");
                    break;
                case "Data Science":
                    trackSelector.Items.Add("Cyber Security");
                    break;
                case "Sound Engineering":
                    trackSelector.Items.Add("Binaural Shape Waves");
                    break;
                case "Sound Design":
                    trackSelector.Items.Add("Binaural Shape Waves");
                    break;
                case "Audio Hardware Equipment":
                    trackSelector.Items.Add("Binaural Shape Waves");
                    break;
                case "Social Science":
                    trackSelector.Items.Add("Structural Management");
                    break;
                case "Political Science":
                    trackSelector.Items.Add("Structural Management");
                    break;
                case "Psychology":
                    trackSelector.Items.Add("Structural Management");
                    break;
                case "Machine Learning":
                    trackSelector.Items.Add("Cyber Security");
                    break;
                case "Business Management":
                    trackSelector.Items.Add("Structural Management");
                    break;
            }
            // Add more if-else conditions for other specializations

            // Select the first track by default
            if (trackSelector.Items.Count > 0)
            {
                trackSelector.SelectedIndex = 0;
            }
        }
        
        // Define the method to calculate yearly drain based on the specialization and track
        private static double CalculateYearlyDrain(string specialization, string track)
            {
                // Implement your own logic here to calculate the yearly drain based on the selected specialization and track
                // You can define your own criteria for each specialization and track
                // For demonstration purposes, I'll provide a sample implementation

                switch (specialization)
                {
                    // Sample criteria for yearly drain calculation
                    case "Architecture":
                        switch (track)
                        {
                            case "Architectural Design":
                                return 10000.00; // Sample yearly drain for Software Engineering track in Computer Science specialization
                        }

                        break;
                    case "Exterior Blueprinting":
                        switch (track)
                        {
                            case "Architectural Design":
                                return 8000.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    
                    case "Floor Tiling":
                        switch (track)
                        {
                            case "Architectural Design":
                                return 8500.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Computer Science":
                        switch (track)
                        {
                            case "Cyber Security":
                                return 9250.00;
                        }

                        break;
                    case "Software Engineering":
                        switch (track)
                        {
                            case "Cyber Security":
                                return 10200.00;
                        }

                        break;
                    case "Data Science":
                        switch (track)
                        {
                            case "Cyber Security":
                                return 8600.00;
                        }

                        break;
                    case "Sound Engineering":
                        switch (track)
                        {
                            case "Binaural Shape Waves":
                                return 8000.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Sound Design":
                        switch (track)
                        {
                            case "Binaural Shape Waves":
                                return 8620.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Audio Hardware Engineering":
                        switch (track)
                        {
                            case "Binaural Shape Waves":
                                return 12300.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Social Science":
                        switch (track)
                        {
                            case "Structural Management":
                                return 8000.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Political Science":
                        switch (track)
                        {
                            case "Structural Management":
                                return 6930.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Psychology":
                        switch (track)
                        {
                            case "Structural Management":
                                return 13900.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }

                        break;
                    case "Machine Learning":
                        switch (track)
                        {
                            case "Cyber Security":
                                return 19340.00;
                        }

                        break;
                    case "Business Management":
                        switch (track)
                        {
                            case "Structural Management":
                                return 18700.00; // Sample yearly drain for Marketing track in Business Administration specialization
                        }
                        break;
                }
                // Add more if-else conditions for other specializations and tracks

                // Return a default value if no matching criteria found
                return 0.00;
            }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}