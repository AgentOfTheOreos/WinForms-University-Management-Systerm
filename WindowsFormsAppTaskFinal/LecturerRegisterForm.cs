using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.Exceptions;

namespace WindowsFormsAppTaskFinal
{
    public partial class LecturerRegisterForm : Form
    {
        private readonly TrackDirector _trackDirector;

        public LecturerRegisterForm(TrackDirector trackDirector)
        {
            _trackDirector = trackDirector;
            InitializeComponent();
        }

        private async void finishRegButton_Click_1(object sender, EventArgs e)
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
            var employeeNumber = await GenerateEmployeeNumberAsync();
            var selectedCourses = await GetListBoxItemsAsListAsync(coursesListBox);
            var isValid = true;
            var hasSelectedCourses = selectedCourses.Any();

            if (string.IsNullOrWhiteSpace(ID) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrEmpty(lastName)
                || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(specializationSelector.SelectedItem.ToString())
                || !hasSelectedCourses)
            {
                MessageBox.Show(@"All fields must be filled out!");
                return;
            }

            var selectedSpecialization = specializationSelector.SelectedItem.ToString();

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
            var personExists = await Task.Run(() =>
            {
                return _trackDirector.Persons.Any(person => person.Email.Equals(email) || person.Id == id);
            });

            if (personExists)
            {
                MessageBox.Show(@"The user already exists in the system, you can try logging in instead.");
                return;
            }

            var coursesToTeach = new List<Course>();

            foreach (var courseName in selectedCourses)
            {
                var trackWithCourse = _trackDirector.ResponsibleTracks.Find(track =>
                    track.IncludedCourses.Find(course => courseName.Equals(course.CourseName)) != null);

                if (trackWithCourse != null)
                {
                    var courseToTeach = trackWithCourse.IncludedCourses.Find(course =>
                        courseName.Equals(course.CourseName));

                    if (courseToTeach == null)
                    {
                        MessageBox.Show(
                            @"The entered course(s) were not found in the system, please contact a system administrator");
                        return;
                    }

                    coursesToTeach.Add(courseToTeach);
                }
                else
                {
                    MessageBox.Show(
                        @"The academic track that the entered course(s) belong to either does not exist anymore, or you have entered the name(s) of course(s) that do not exist in the system, please contact a system administrator");
                    return;
                }
            }

            Person registeredLecturer = new Lecturer(id, firstName, lastName, age, phoneNumber, email, password, employeeNumber,
                coursesToTeach, selectedSpecialization, 0);

            await Task.Run(() =>
            {
                _trackDirector.Persons.Add(registeredLecturer);
                FileHandler.SaveTrackDirector(_trackDirector);
            });

            MessageBox.Show(@"You have been successfully registered to our system! You will now be redirected to the login page.");
            Close();
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

        // Generate a random student number asynchronously
        private async Task<int> GenerateEmployeeNumberAsync()
        {
            var random = new Random();
            int employeeNumber;
            bool uniqueNumberNotFound;
            const int maxAttempts = 1000;
            var attemptCount = 0;

            do
            {
                employeeNumber = random.Next(1, 999999);

                uniqueNumberNotFound = await Task.Run(() =>
                {
                    return _trackDirector.Persons
                        .OfType<Lecturer>()
                        .Any(lect => lect.EmployeeNumber == employeeNumber);
                });

                attemptCount++;

                if (attemptCount >= maxAttempts)
                {
                    throw new AllNumbersAssignedException(_trackDirector.Email, _trackDirector.PhoneNumber);
                }
            } while (uniqueNumberNotFound);

            employeeNumberTextBox.Text = employeeNumber.ToString();
            return employeeNumber;
        }

        private async Task<List<string>> GetListBoxItemsAsListAsync(ListBox listBox)
        {
            var items = await Task.Run(() =>
            {
                return listBox
                    .Items.Cast<object>()
                    .Select(item => item.ToString())
                    .ToList();
            });

            return items;
        }

        private void specializationSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            coursesListBox.Items.Clear();

            var selectedSpecialization = specializationSelector.SelectedItem.ToString();

            switch (selectedSpecialization)
            {
                case "Architecture":
                    coursesListBox.Items.Add("Column Design");
                    coursesListBox.Items.Add("Interior Decor");
                    break;
                case "Exterior Blueprinting":
                    coursesListBox.Items.Add("Column Design");
                    coursesListBox.Items.Add("Interior Decor");
                    break;
                case "Floor Tiling":
                    coursesListBox.Items.Add("Column Design");
                    coursesListBox.Items.Add("Interior Decor");
                    break;
                case "Computer Science":
                    coursesListBox.Items.Add("Kotlin");
                    coursesListBox.Items.Add("Python Scripting");
                    break;
                case "Software Engineering":
                    coursesListBox.Items.Add("Kotlin");
                    coursesListBox.Items.Add("Python Scripting");
                    break;
                case "Data Science":
                    coursesListBox.Items.Add("Kotlin");
                    coursesListBox.Items.Add("Python Scripting");
                    break;
                case "Sound Engineering":
                    coursesListBox.Items.Add("Bass and Equalization");
                    coursesListBox.Items.Add("Audio Equipment Setup");
                    break;
                case "Sound Design":
                    coursesListBox.Items.Add("Bass and Equalization");
                    coursesListBox.Items.Add("Audio Equipment Setup");
                    break;
                case "Audio Hardware Equipment":
                    coursesListBox.Items.Add("Bass and Equalization");
                    coursesListBox.Items.Add("Audio Equipment Setup");
                    break;
                case "Social Science":
                    coursesListBox.Items.Add("Social Engineering");
                    coursesListBox.Items.Add("Negotiation");
                    coursesListBox.Items.Add("Leadership Skills");
                    break;
                case "Political Science":
                    coursesListBox.Items.Add("Social Engineering");
                    coursesListBox.Items.Add("Negotiation");
                    coursesListBox.Items.Add("Leadership Skills");
                    break;
                case "Psychology":
                    coursesListBox.Items.Add("Social Engineering");
                    coursesListBox.Items.Add("Negotiation");
                    coursesListBox.Items.Add("Leadership Skills");
                    break;
                case "Machine Learning":
                    coursesListBox.Items.Add("Kotlin");
                    coursesListBox.Items.Add("Python Scripting");
                    break;
                case "Business Management":
                    coursesListBox.Items.Add("Social Engineering");
                    coursesListBox.Items.Add("Negotiation");
                    coursesListBox.Items.Add("Leadership Skills");
                    break;
            }
            // Add more if-else conditions for other specializations

            // Select the first track by default
            if (coursesListBox.Items.Count > 0)
            {
                coursesListBox.SelectedIndex = 0;
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}