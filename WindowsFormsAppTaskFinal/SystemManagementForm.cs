using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;

namespace WindowsFormsAppTaskFinal
{
    public partial class SystemManagementForm : Form
    {
        private readonly TrackDirector _trackDirector;
        public SystemManagementForm(TrackDirector trackDirector)
        {
            _trackDirector = trackDirector;
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dispRemStudsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel
    
            foreach (var student in _trackDirector.Students)
            {
                // Create a panel to display the student information
                var panel = new Panel
                {
                    Width = mainPanel.Width,
                    Height = mainPanel.Height / 2,
                    Dock = DockStyle.Top,
                    BackColor = Color.LightGray,
                    AutoScroll = true
                };

                // Create a label to display the student's information using the ToString() method
                var studentLabel = new Label
                {
                    Text = student.ToString(),
                    Width = mainPanel.Width - 100,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoSize = true// Set a minimum width for the label
                };
                
                // Create a horizontal line separator
                var separator = new Label
                {
                    BorderStyle = BorderStyle.Fixed3D,
                    Height = 2,
                    Dock = DockStyle.Bottom
                };

                // Create a remove button for the student
                var removeButton = new Button
                {
                    Text = @"Remove",
                    Width = 80,
                    Dock = DockStyle.Right,
                    Tag = student // Attach the student object to the button's Tag property
                };

                // Hook up the event handler for the remove button
                removeButton.Click += RemoveStudent_Click;

                // Add the label and remove button to the panel
                panel.Controls.Add(studentLabel);
                panel.Controls.Add(separator);
                panel.Controls.Add(removeButton);

                // Add the panel to the main panel
                mainPanel.Controls.Add(panel);
            }
        }
        
        private void dispRemLectsButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            foreach (var person in _trackDirector.Persons)
            {
                if (!person.SubclassIdentifier.Equals("Lecturer")) continue;
                var lecturer = (Lecturer)person;
                // Create a panel to display the student information
                var panel = new Panel
                {
                    Width = mainPanel.Width,
                    Height = mainPanel.Height,
                    Dock = DockStyle.Top,
                    BackColor = Color.LightGray,
                    AutoScroll = true
                };

                // Create a label to display the student's information using the ToString() method
                var lecturerLabel = new Label
                {
                    Text = lecturer.SimplifiedToString(),
                    Width = mainPanel.Width - 100,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoSize = true// Set a minimum width for the label
                };
                
                // Create a horizontal line separator
                var separator = new Label
                {
                    BorderStyle = BorderStyle.Fixed3D,
                    Height = 2,
                    Dock = DockStyle.Bottom
                };

                // Create a remove button for the student
                var removeButton = new Button
                {
                    Text = @"Remove",
                    Width = 80,
                    Dock = DockStyle.Right,
                    Tag = lecturer // Attach the student object to the button's Tag property
                };

                // Hook up the event handler for the remove button
                removeButton.Click += RemoveLecturer_Click;

                // Add the label and remove button to the panel
                panel.Controls.Add(lecturerLabel);
                panel.Controls.Add(separator);
                panel.Controls.Add(removeButton);

                // Add the panel to the main panel
                mainPanel.Controls.Add(panel);
            }
        }

        private void dispRemExersButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            foreach (var person in _trackDirector.Persons)
            {
                if (!person.SubclassIdentifier.Equals("Exerciser")) continue;
                var exerciser = (Exerciser)person;
                // Create a panel to display the student information
                var panel = new Panel
                {
                    Width = mainPanel.Width,
                    Height = mainPanel.Height,
                    Dock = DockStyle.Top,
                    BackColor = Color.LightGray,
                    AutoScroll = true
                };

                // Create a label to display the student's information using the ToString() method
                var exerciserLabel = new Label
                {
                    Text = exerciser.SimplifiedToString(),
                    Width = mainPanel.Width - 100,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoSize = true// Set a minimum width for the label
                };
                
                // Create a horizontal line separator
                var separator = new Label
                {
                    BorderStyle = BorderStyle.Fixed3D,
                    Height = 2,
                    Dock = DockStyle.Bottom
                };

                // Create a remove button for the student
                var removeButton = new Button
                {
                    Text = @"Remove",
                    Width = 80,
                    Dock = DockStyle.Right,
                    Tag = exerciser // Attach the student object to the button's Tag property
                };

                // Hook up the event handler for the remove button
                removeButton.Click += RemoveExerciser_Click;

                // Add the label and remove button to the panel
                panel.Controls.Add(exerciserLabel);
                panel.Controls.Add(separator);
                panel.Controls.Add(removeButton);

                // Add the panel to the main panel
                mainPanel.Controls.Add(panel);
            }
        }

        private void dispRemTracksButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            foreach (var track in _trackDirector.ResponsibleTracks)
            {
                // Create a panel to display the student information
                var panel = new Panel
                {
                    Width = mainPanel.Width,
                    Height = mainPanel.Height,
                    Dock = DockStyle.Top,
                    BackColor = Color.LightGray,
                    AutoScroll = true
                };

                // Create a label to display the student's information using the ToString() method
                var trackLabel = new Label
                {
                    Text = track.SimplifiedToString(),
                    Width = mainPanel.Width - 100,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    AutoSize = true// Set a minimum width for the label
                };
                
                // Create a horizontal line separator
                var separator = new Label
                {
                    BorderStyle = BorderStyle.Fixed3D,
                    Height = 2,
                    Dock = DockStyle.Bottom
                };

                // Create a remove button for the student
                var removeButton = new Button
                {
                    Text = @"Remove",
                    Width = 80,
                    Dock = DockStyle.Right,
                    Tag = track // Attach the student object to the button's Tag property
                };

                // Hook up the event handler for the remove button
                removeButton.Click += RemoveTrack_Click;

                // Add the label and remove button to the panel
                panel.Controls.Add(trackLabel);
                panel.Controls.Add(separator);
                panel.Controls.Add(removeButton);

                // Add the panel to the main panel
                mainPanel.Controls.Add(panel);
            }
        }

        private void dispRemCoursesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            foreach (var track in _trackDirector.ResponsibleTracks)
            {
                foreach (var course in track.IncludedCourses)
                {
                    // Create a panel to display the student information
                    var panel = new Panel
                    {
                        Width = mainPanel.Width,
                        Height = mainPanel.Height,
                        Dock = DockStyle.Top,
                        BackColor = Color.LightGray,
                        AutoScroll = true
                    };

                    // Create a label to display the student's information using the ToString() method
                    var courseLabel = new Label
                    {
                        Text = course.SimplifiedToString(),
                        Width = mainPanel.Width - 100,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Dock = DockStyle.Fill,
                        AutoSize = true// Set a minimum width for the label
                    };
                    
                    // Create a horizontal line separator
                    var separator = new Label
                    {
                        BorderStyle = BorderStyle.Fixed3D,
                        Height = 2,
                        Dock = DockStyle.Bottom
                    };

                    // Create a remove button for the student
                    var removeButton = new Button
                    {
                        Text = @"Remove",
                        Width = 80,
                        Dock = DockStyle.Right,
                        Tag = course // Attach the student object to the button's Tag property
                    };

                    // Hook up the event handler for the remove button
                    removeButton.Click += RemoveCourse_Click;

                    // Add the label and remove button to the panel
                    panel.Controls.Add(courseLabel);
                    panel.Controls.Add(separator);
                    panel.Controls.Add(removeButton);

                    // Add the panel to the main panel
                    mainPanel.Controls.Add(panel);
                }
            }
        }
        
        private void addAssignTracksButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            // Create a TableLayoutPanel with 2 columns
            var tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Create a label for the track name input
            var nameLabel = new Label
            {
                Text = @"Track Name:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            // Create a text box for the track name input
            var nameTextBox = new TextBox
            {
                Dock = DockStyle.Fill
            };

            // Create a confirm button
            var confirmButton = new Button
            {
                Text = @"Confirm",
                Width = 80,
                Dock = DockStyle.Left
            };

            // Hook up the event handler for the confirm button
            confirmButton.Click += (confirmSender, confirmArgs) =>
            {
                // Create a new track object with the user inputted name
                var newTrackName = nameTextBox.Text;
                var newTrack = new Track(newTrackName);

                // Add the new track to the list of ResponsibleTracks in the _trackDirector
                _trackDirector.ResponsibleTracks.Add(newTrack);

                // Clear the main panel
                mainPanel.Controls.Clear();
                FileHandler.SaveTrackDirector(_trackDirector);
                MessageBox.Show($@"Track {newTrackName} added to the system successfully.");
            };

            // Add the controls to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel.Controls.Add(nameTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(confirmButton, 0, 1);

            // Set column widths
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            // Add the TableLayoutPanel to the main panel
            mainPanel.Controls.Add(tableLayoutPanel);
        }


        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            var removeButton = (Button)sender;
            var student = (Student)removeButton.Tag; // Retrieve the student object from the button's Tag property

            // Remove the student from the system
            if (_trackDirector.Students.Contains(student))
                _trackDirector.Students.Remove(student);
            // Remove the panel containing the student information from the main panel
            var panel = (Panel)removeButton.Parent;
            mainPanel.Controls.Remove(panel);
        }
        private void RemoveLecturer_Click(object sender, EventArgs e)
        {
            var removeButton = (Button)sender;
            var lecturer = (Lecturer)removeButton.Tag; // Retrieve the student object from the button's Tag property
            var personLect = (Person)lecturer;
            if (_trackDirector.Persons.Contains(personLect))
                _trackDirector.Persons.Remove(personLect);
            else MessageBox.Show(@"The lecturer was not found!!");
            var panel = (Panel)removeButton.Parent;
            mainPanel.Controls.Remove(panel);
        }
        
        private void RemoveExerciser_Click(object sender, EventArgs e)
        {
            var removeButton = (Button)sender;
            var exerciser = (Exerciser)removeButton.Tag; // Retrieve the student object from the button's Tag property
            var personExers = (Person)exerciser;
            if (_trackDirector.Persons.Contains(personExers))
                _trackDirector.Persons.Remove(personExers);
            else MessageBox.Show(@"The exerciser was not found!!");
            // Remove the panel containing the student information from the main panel
            var panel = (Panel)removeButton.Parent;
            mainPanel.Controls.Remove(panel);
        }
        
        private void RemoveTrack_Click(object sender, EventArgs e)
        {
            var removeButton = (Button)sender;
            var track = (Track)removeButton.Tag; // Retrieve the student object from the button's Tag property

            // Remove the student from the system
            if (_trackDirector.ResponsibleTracks.Contains(track))
                _trackDirector.ResponsibleTracks.Remove(track);
            // Remove the panel containing the student information from the main panel
            var panel = (Panel)removeButton.Parent;
            mainPanel.Controls.Remove(panel);
        }
        
        private void RemoveCourse_Click(object sender, EventArgs e)
        {
            var removeButton = (Button)sender;
            var course = (Course)removeButton.Tag; // Retrieve the student object from the button's Tag property

            // Remove the student from the system
            foreach (var track in _trackDirector.ResponsibleTracks.Where(track => track.IncludedCourses.Contains(course)))
            {
                track.IncludedCourses.Remove(course);
            }
            // Remove the panel containing the student information from the main panel
            var panel = (Panel)removeButton.Parent;
            mainPanel.Controls.Remove(panel);
        }

        private void assignToTrack_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            // Create a TableLayoutPanel for better layout
            var tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                AutoSize = true,
                Padding = new Padding(10),
                GrowStyle = TableLayoutPanelGrowStyle.AddRows
            };

            // Create labels and textboxes for the student number and track name input
            var studentNumberLabel = new Label
            {
                Text = @"Student Number:",
                Width = 120,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var studentNumberTextBox = new TextBox
            {
                Width = 200,
                Dock = DockStyle.Left
            };

            var trackNameLabel = new Label
            {
                Text = @"Track Name:",
                Width = 120,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var trackNameTextBox = new TextBox
            {
                Width = 200,
                Dock = DockStyle.Left
            };

            // Create a confirm button
            var confirmButton = new Button
            {
                Text = @"Confirm",
                Width = 80,
                Dock = DockStyle.Left
            };

            // Hook up the event handler for the confirm button
            confirmButton.Click += (confirmSender, confirmArgs) =>
            {
                if (!int.TryParse(studentNumberTextBox.Text, out var studentNumber))
                {
                    // Show an error message or handle the invalid input
                    MessageBox.Show(@"Invalid student number. Please enter a valid numeric value.");
                    return;
                }

                var trackName = trackNameTextBox.Text;

                // Find the student with the given student number
                var student = _trackDirector.Students.FirstOrDefault(s => s.StudentNumber == studentNumber);
                if (student != null)
                {
                    // Find the track with the given track name
                    var track = _trackDirector.ResponsibleTracks.FirstOrDefault(t => t.TrackName.Equals(trackName));
                    if (track != null)
                    {
                        // Assign the track to the student's AcademicTrack property
                        student.AcademicTrack = track;
                        FileHandler.SaveTrackDirector(_trackDirector);
                        MessageBox.Show(@"Track assigned to student successfully.");
                    }
                    else
                    {
                        MessageBox.Show(@"The track does not exist.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(@"The student does not exist.");
                    return;
                }

                // Clear the main panel
                mainPanel.Controls.Clear();
            };

            // Add the controls to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(studentNumberLabel, 0, 0);
            tableLayoutPanel.Controls.Add(studentNumberTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(trackNameLabel, 0, 1);
            tableLayoutPanel.Controls.Add(trackNameTextBox, 1, 1);

            // Create a panel to hold the confirm button
            var buttonPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            buttonPanel.Controls.Add(confirmButton);

            // Add the TableLayoutPanel and the button panel to the main panel
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Controls.Add(buttonPanel);
        }



        private void addCoursesToTracksButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear(); // Clear the main panel

            // Create a TableLayoutPanel with 2 columns
            var tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                Dock = DockStyle.Fill,
                AutoSize = true
            };

            // Create labels for the course details input
            var courseCodeLabel = new Label
            {
                Text = @"Course Code:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var courseNameLabel = new Label
            {
                Text = @"Course Name:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var courseDescriptionLabel = new Label
            {
                Text = @"Course Description:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var trackNameLabel = new Label
            {
                Text = @"Track Name:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var startDateLabel = new Label
            {
                Text = @"Start Date:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            var endDateLabel = new Label
            {
                Text = @"End Date:",
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            // Create text boxes for the course details input
            var courseCodeTextBox = new TextBox
            {
                Dock = DockStyle.Fill
            };

            var courseNameTextBox = new TextBox
            {
                Dock = DockStyle.Fill
            };

            var courseDescriptionTextBox = new TextBox
            {
                Dock = DockStyle.Fill
            };

            var trackNameTextBox = new TextBox
            {
                Dock = DockStyle.Fill
            };

            // Create date pickers for the start and end dates
            var startDatePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short
            };

            var endDatePicker = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short
            };

            // Create a confirm button
            var confirmButton = new Button
            {
                Text = @"Confirm",
                Width = 80,
                Dock = DockStyle.Left
            };

            // Hook up the event handler for the confirm button
            confirmButton.Click += (confirmSender, confirmArgs) =>
            {
                // Get the user inputted course details
                var courseCode = courseCodeTextBox.Text;
                var courseName = courseNameTextBox.Text;
                var courseDescription = courseDescriptionTextBox.Text;
                var trackName = trackNameTextBox.Text;
                var startDate = startDatePicker.Value;
                var endDate = endDatePicker.Value;

                // Find the track with the given track name
                var track = _trackDirector.ResponsibleTracks.FirstOrDefault(t => t.TrackName == trackName);
                if (track != null)
                {
                    // Create a new course object
                    var newCourse = new Course(courseCode, courseName, courseDescription, startDate, endDate);

                    // Add the new course to the list of IncludedCourses in the specified track
                    track.IncludedCourses.Add(newCourse);
                    FileHandler.SaveTrackDirector(_trackDirector);
                    MessageBox.Show(@"Course added to track successfully.");
                }
                else
                {
                    MessageBox.Show(@"The track does not exist.");
                }

                // Clear the main panel
                mainPanel.Controls.Clear();
            };

            // Add the controls to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(courseCodeLabel, 0, 0);
            tableLayoutPanel.Controls.Add(courseNameLabel, 0, 1);
            tableLayoutPanel.Controls.Add(courseDescriptionLabel, 0, 2);
            tableLayoutPanel.Controls.Add(trackNameLabel, 0, 3);
            tableLayoutPanel.Controls.Add(startDateLabel, 0, 4);
            tableLayoutPanel.Controls.Add(endDateLabel, 0, 5);
            tableLayoutPanel.Controls.Add(courseCodeTextBox, 1, 0);
            tableLayoutPanel.Controls.Add(courseNameTextBox, 1, 1);
            tableLayoutPanel.Controls.Add(courseDescriptionTextBox, 1, 2);
            tableLayoutPanel.Controls.Add(trackNameTextBox, 1, 3);
            tableLayoutPanel.Controls.Add(startDatePicker, 1, 4);
            tableLayoutPanel.Controls.Add(endDatePicker, 1, 5);
            tableLayoutPanel.Controls.Add(confirmButton, 1, 6);

            // Create a panel to hold the confirm button
            var buttonPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            buttonPanel.Controls.Add(confirmButton);

            // Add the TableLayoutPanel and the button panel to the main panel
            mainPanel.Controls.Add(tableLayoutPanel);
            mainPanel.Controls.Add(buttonPanel);
        }
    }
}