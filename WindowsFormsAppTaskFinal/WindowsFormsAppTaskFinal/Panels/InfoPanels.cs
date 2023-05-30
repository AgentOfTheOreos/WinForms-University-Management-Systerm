using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal.Panels
{
    public sealed class InfoPanels : Panel
    {
        private readonly List<RichTextBox> _lecturerTextBoxes;
        private readonly List<RichTextBox> _studentTextBoxes;

        public InfoPanels(List<Student> students, List<Lecturer> lecturers)
        {
            _studentTextBoxes = new List<RichTextBox>();
            _lecturerTextBoxes = new List<RichTextBox>();

            // Set the Dock property of the InfoPanels panel to Fill
            Dock = DockStyle.Fill;
            for (var i = 0; i < students.Count; i++)
            {
                var studentTextBox = new RichTextBox
                {
                    ReadOnly = true,
                    Dock = DockStyle.Top,
                    Height = 100
                };
                _studentTextBoxes.Add(studentTextBox);
                Controls.Add(studentTextBox);
            }

            var studentLabel = new Label
            {
                Text = @"Students",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            Controls.Add(studentLabel);

            for (var i = 0; i < lecturers.Count; i++)
            {
                var lecturerTextBox = new RichTextBox
                {
                    ReadOnly = true,
                    Dock = DockStyle.Top,
                    Height = 100
                };
                _lecturerTextBoxes.Add(lecturerTextBox);
                Controls.Add(lecturerTextBox);
            }

            var lecturerLabel = new Label
            {
                Text = @"Lecturers",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Top
            };
            Controls.Add(lecturerLabel);

            UpdateStudentTextBoxes(students);
            UpdateLecturerTextBoxes(lecturers);
        }

        public void UpdateStudentTextBoxes(List<Student> students)
        {
            for (var i = 0; i < students.Count; i++) _studentTextBoxes[i].Text = students[i].ToString();
        }

        public void UpdateLecturerTextBoxes(List<Lecturer> lecturers)
        {
            for (var i = 0; i < lecturers.Count; i++) _lecturerTextBoxes[i].Text = lecturers[i].ToString();
        }
    }
}