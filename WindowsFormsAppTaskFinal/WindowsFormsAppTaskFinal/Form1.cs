using System;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.Exceptions;
using WindowsFormsAppTaskFinal.Panels;

namespace WindowsFormsAppTaskFinal
{
    internal partial class Form1 : Form
    {
        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>

        private readonly InfoPanels _infopan;
        private readonly TrackDirector _trackDirector;

        public Form1(TrackDirector trackDirector1)
        {
            _trackDirector = trackDirector1;
            InitializeComponent();
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                var registerForm = new RegisterForm();
                registerForm.ShowDialog();
            }
            catch (FormAccessException x)
            {
                Console.WriteLine(x.Message);
            }*/
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            var email = emailBox.Text;
            var password = passwordBox.Text;
            if (string.IsNullOrWhiteSpace(email))
                throw new EmptyFieldException(nameof(Form1) + ": Email");
            if (string.IsNullOrWhiteSpace(password))
                throw new EmptyFieldException(nameof(Form1) + ": Password");
            Person user;
            if (_trackDirector.Email.Equals(email) && _trackDirector.Password.Equals(password))
                user = _trackDirector;

            else
            {
                user = _trackDirector.Students.Find(student =>
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
                passwordBox.Text = string.Empty;
                connectButton.Enabled = false;
                var mainForm = new MainForm(user);
                Close();
                mainForm.Show();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registerForm = new StudentRegisterForm(_trackDirector);
            registerForm.ShowDialog();
        }

        private void lecturerRegisterButton_Click(object sender, EventArgs e)
        {
            var registerForm = new LecturerRegisterForm();
            registerForm.Show();
            registerForm.Focus();
        }
    }
}