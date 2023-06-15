using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal
{
    public partial class StudentCoursesViewForm : Form
    {
        private readonly Student _student;
        private SynchronizationContext _syncContext;

        public StudentCoursesViewForm(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        private void StudentCoursesViewForm_Load(object sender, EventArgs e)
        {
            _syncContext = SynchronizationContext.Current;

            label1.Text = @"Courses for the current track " + _student.AcademicTrack.TrackName + ':';

            var textBoxHeight = customPanel1.Height / 2;

            ThreadPool.QueueUserWorkItem(state =>
            {
                foreach (var course in _student.AcademicTrack.IncludedCourses)
                {
                    var courseTextBox = new RichTextBox();
                    courseTextBox.Text = course.ToStringStudentView();
                    courseTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
                    courseTextBox.Size = new Size(customPanel1.Width - SystemInformation.VerticalScrollBarWidth - 5, textBoxHeight);

                    var separatorLine = new Label();
                    separatorLine.BorderStyle = BorderStyle.Fixed3D;
                    separatorLine.AutoSize = false;
                    separatorLine.Height = 2;
                    separatorLine.Width = courseTextBox.Width;
                    separatorLine.Margin = new Padding(0, 10, 0, 10); // Add some vertical spacing

                    _syncContext.Post(callbackState =>
                    {
                        customPanel1.Controls.Add(courseTextBox);
                        customPanel1.Controls.Add(separatorLine);
                    }, null);
                }

                _syncContext.Post(callbackState =>
                {
                    // Adjust the size of the customPanel1 control to fit the added controls
                    customPanel1.AutoSize = true;
                    customPanel1.AutoScroll = true;
                }, null);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}