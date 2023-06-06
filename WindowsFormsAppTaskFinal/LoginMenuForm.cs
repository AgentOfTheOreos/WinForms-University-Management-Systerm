using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.Exceptions;

namespace WindowsFormsAppTaskFinal
{
    internal partial class Form1 : Form
    {
        private readonly TrackDirector _trackDirector;

        public Form1(TrackDirector trackDirector)
        {
            _trackDirector = trackDirector;
            InitializeComponent();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            var email = emailBox.Text;
            var password = passwordBox.Text;
            if (string.IsNullOrWhiteSpace(email))
                throw new EmptyFieldException(nameof(Form1) + ": Email");
            if (string.IsNullOrWhiteSpace(password))
                throw new EmptyFieldException(nameof(Form1) + ": Password");

            // Execute the connection process asynchronously using Task.Run
            try
            {
                await Task.Run(() => ConnectUser(email, password));
            }
            catch (EmptyFieldException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConnectUser(string email, string password)
        {
            if (_trackDirector.Email.Equals(email) && _trackDirector.Password.Equals(password))
            {
                passwordBox.Invoke(new Action(() => passwordBox.Text = string.Empty));
                connectButton.Invoke(new Action(() => connectButton.Enabled = false));

                var mainForm = new MainForm(_trackDirector);
                Invoke(new Action(() =>
                {
                    Hide();
                    mainForm.Show();
                }));
            }
            else
            {
                Person user = _trackDirector.Students.Find(student =>
                    student.Email.Equals(email) && student.Password.Equals(password));

                if (user == null)
                {
                    user = _trackDirector.Persons.Find(person =>
                        person.Email.Equals(email) && person.Password.Equals(password));
                    if (user == null)
                    {
                        MessageBox.Show(@"User is not existent in the system, consider registering a new account.");
                        return;
                    }
                }
                passwordBox.Invoke(new Action(() => passwordBox.Text = string.Empty));
                connectButton.Invoke(new Action(() => connectButton.Enabled = false));

                var mainForm = new MainForm(user, _trackDirector);
                Invoke(new Action(() =>
                {
                    Hide();
                    mainForm.Show();
                }));
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Run the registration process asynchronously using Task.Run
            Task.Run(() =>
            {
                var registerForm = new StudentRegisterForm(_trackDirector);
                registerForm.ShowDialog();
            });
        }

        private void lecturerRegisterButton_Click(object sender, EventArgs e)
        {
            // Run the registration process asynchronously using Task.Run
            Task.Run(() =>
            {
                var registerForm = new LecturerRegisterForm(_trackDirector);
                registerForm.ShowDialog();
            });
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
