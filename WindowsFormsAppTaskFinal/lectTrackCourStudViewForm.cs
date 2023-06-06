using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;

namespace WindowsFormsAppTaskFinal
{
    public partial class LectTrackCourStudViewForm : Form
    {
        private readonly Lecturer _lecturer;
        public LectTrackCourStudViewForm(Lecturer lecturer)
        {
            _lecturer = lecturer;
            InitializeComponent();
        }

        private void lectTrackCourStudViewForm_Load(object sender, EventArgs e)
        {
            label1.Text = @"The following menu displays each of your tracks, courses and students: "; 
            foreach (var course in _lecturer.CoursesTaught)
            {
                var courseTextBox = new RichTextBox();
                courseTextBox.Text = course.ToString();
                courseTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
                courseTextBox.Size = new Size(customPanel1.Width - SystemInformation.VerticalScrollBarWidth - 5, customPanel1.Height);

                customPanel1.Controls.Add(courseTextBox);

                var separatorLine = new Label();
                separatorLine.BorderStyle = BorderStyle.Fixed3D;
                separatorLine.AutoSize = false;
                separatorLine.Height = 2;
                separatorLine.Width = courseTextBox.Width;
                separatorLine.Margin = new Padding(0, 10, 0, 10); // Add some vertical spacing

                customPanel1.Controls.Add(separatorLine);
            }
            
            // Adjust the size of the customPanel1 control to fit the added controls
            customPanel1.AutoSize = true;
            customPanel1.AutoScroll = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}