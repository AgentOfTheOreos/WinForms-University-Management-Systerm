using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsAppTaskFinal.DataModels;
using WindowsFormsAppTaskFinal.DataModels.Persons;
using WindowsFormsAppTaskFinal.DataModels.Persons.Lecturers;
using WindowsFormsAppTaskFinal.DataModels.Persons.Students;
using Message = WindowsFormsAppTaskFinal.DataModels.Message;

namespace WindowsFormsAppTaskFinal
{
    public partial class MainForm : Form
    {
        private readonly TrackDirector _trackDirector;
        private readonly Person _user;
        private string _lastSelectedCategory;
        private string _lastSelectedQuery;

        public MainForm(Person user, TrackDirector trackDirector)
        {
            _user = user;
            _trackDirector = trackDirector;
            InitializeComponent();
        }

        public MainForm(TrackDirector trackDirector) : this(null, trackDirector)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = @"Welcome ";
            label1.Text += _user == null ? _trackDirector.FirstName : _user.FirstName;
            label3.Text = _user == null
                ? _trackDirector.SubclassIdentifier + " Actions"
                : _user.SubclassIdentifier + " Actions";
            if (_user == null)
            {
                studentCoursesButton.Hide();
                lecturerTracksButton.Hide();
            }
            else if (_user.SubclassIdentifier.Equals("Student") || _user.SubclassIdentifier.Equals("Exerciser"))
            {
                lecturerTracksButton.Hide();
                sysManMenuButton.Hide();
            }
            else
            {
                sysManMenuButton.Hide();
                studentCoursesButton.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void mainInfoButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var richTextBox = new RichTextBox();
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Size = new Size(mainPanel.Width / 2, mainPanel.Height);
            richTextBox.Location = new Point(0, mainPanel.Height - richTextBox.Height); // Align to bottom left
            var pictureBox = new PictureBox();
            pictureBox.Size = richTextBox.Size;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(mainPanel.Width - pictureBox.Width, 0); // Align to top right
            if (_user != null)
            {
                richTextBox.Text = _user.ToString();
                var imagePath = _user.FilePathWithEmail;
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else pictureBox.Text = @"No image for user available";
            }
            else
            {
                richTextBox.Text = _trackDirector.ToString();
                var imagePath = _trackDirector.FilePathWithEmail;
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
            mainPanel.Controls.Add(richTextBox);
            mainPanel.Controls.Add(pictureBox);
            richTextBox.Font = new Font("Helvetica Now Display", 12, FontStyle.Regular); // Change font and size
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form1 = new Form1(_trackDirector);
            form1.Show();
        }

        private void messagesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            if (_user == null && _trackDirector == null) return;
            var userSubclass = _user == null ? _trackDirector.SubclassIdentifier : _user.SubclassIdentifier;
            Debug.Assert(_user != null, nameof(_user) + " != null");
            var messages = userSubclass.Equals("TrackDirector") ? _trackDirector.Messages : _user.Messages;
            var panelWidth = mainPanel.Width - 40;
            const int barHeight = 40;
            const int barMargin = 10;
            // Add "Send a message to another user" button
            var sendButton = new Button();
            sendButton.Text = @"Send a message to another user";
            sendButton.AutoSize = true;
            sendButton.Font = new Font("Helvetica Now Display", 10, FontStyle.Bold);
            sendButton.Location = new Point(mainPanel.Width - sendButton.Width - 200, 
                mainPanel.Controls.Count * (barHeight + barMargin));
            sendButton.Click += (sendSender, sendEvent) =>
            {
                mainPanel.Controls.Clear();
                        
                var sendPanel = new Panel();
                sendPanel.BackColor = Color.White;
                sendPanel.BorderStyle = BorderStyle.FixedSingle;
                sendPanel.Size = new Size(panelWidth, mainPanel.Height - 20);
                sendPanel.Location = new Point(20, 10);
                mainPanel.Controls.Add(sendPanel);

                var senderLabel = new Label();
                senderLabel.Text = @"Sender: " + (userSubclass.Equals("TrackDirector") ? _trackDirector.Email : _user.Email);
                senderLabel.AutoSize = true;
                senderLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                senderLabel.Location = new Point(10, 10);
                sendPanel.Controls.Add(senderLabel);

                var recipientLabel = new Label();
                recipientLabel.Text = @"Recipient:";
                recipientLabel.AutoSize = true;
                recipientLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                recipientLabel.Location = new Point(10, 40);
                sendPanel.Controls.Add(recipientLabel);

                var recipientTextBox = new TextBox();
                recipientTextBox.Size = new Size(200, 20);
                recipientTextBox.Location = new Point(100, 40);
                sendPanel.Controls.Add(recipientTextBox);

                var titleLabel = new Label();
                titleLabel.Text = @"Title:";
                titleLabel.AutoSize = true;
                titleLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                titleLabel.Location = new Point(10, 70);
                sendPanel.Controls.Add(titleLabel);

                var titleTextBox = new TextBox();
                titleTextBox.Size = new Size(200, 20);
                titleTextBox.Location = new Point(100, 70);
                sendPanel.Controls.Add(titleTextBox);

                var contentLabel = new Label();
                contentLabel.Text = @"Content:";
                contentLabel.AutoSize = true;
                contentLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                contentLabel.Location = new Point(10, 100);
                sendPanel.Controls.Add(contentLabel);

                var contentTextBox = new TextBox();
                contentTextBox.Multiline = true;
                contentTextBox.Size = new Size(300, 100);
                contentTextBox.Location = new Point(100, 100);
                sendPanel.Controls.Add(contentTextBox);

                var sendMsgButton = new Button();
                sendMsgButton.Text = @"Send";
                sendMsgButton.AutoSize = true;
                sendMsgButton.Font = new Font("Helvetica Now Display", 10, FontStyle.Bold);
                sendMsgButton.Location = new Point(sendPanel.Width - sendMsgButton.Width - 10,
                    sendPanel.Height - sendMsgButton.Height - 10);
                sendMsgButton.Click += (sendMsgSender, sendMsgEvent) =>
                {
                    var recipientEmail = recipientTextBox.Text;
                    var title = titleTextBox.Text;
                    var content = contentTextBox.Text;
                    var date = DateTime.Now;

                    // Check if the recipient exists in the system
                    var recipient = _trackDirector.FindUserByEmail(recipientEmail);

                    if (recipient != null)
                    {
                        // Create a new message object
                        var message = new Message(_user.Email, recipientEmail, title, content, date, false);

                        // Add the message to the user's message list
                        _user.Messages.Add(message);
                        if (recipient.SubclassIdentifier.Equals("TrackDirector"))
                            _trackDirector.Messages.Add(message);
                        else
                            recipient.Messages.Add(message);
                        // Display a success message
                        MessageBox.Show(@"Message sent successfully!", @"Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        FileHandler.SaveTrackDirector(_trackDirector);
                        // Go back to the messages view
                        messagesButton_Click(sender, e);
                    }
                    else
                    {
                        // Display an error message if the recipient was not found
                        MessageBox.Show(@"Recipient not found. Please enter a valid email address.", @"Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                sendPanel.Controls.Add(sendMsgButton);
            };
            mainPanel.Controls.Add(sendButton);
            // Create panel for sort buttons
            var sortPanel = new Panel();
            sortPanel.Size = new Size(panelWidth, 50);
            sortPanel.Location = new Point(20, sendButton.Bottom + 10);
            sortPanel.BorderStyle = BorderStyle.FixedSingle; 
            var sortPanelHeight = sortPanel.Height;

            // Add sort buttons
            var sortDateButton = new Button();
            sortDateButton.Text = @"Sort by Date";
            sortDateButton.AutoSize = true;
            sortDateButton.Font = new Font("Helvetica Now Display", 10, FontStyle.Bold);
            sortDateButton.Location = new Point(20, sortPanelHeight - sortDateButton.Height - 10);
            sortDateButton.Click += (sortDateSender, sortDateEvent) =>
            {
                messages.Sort((msg1, msg2) => msg1.Date.CompareTo(msg2.Date));
                messagesButton_Click(sender, e);
            };
            sortPanel.Controls.Add(sortDateButton);

            var sortImportanceButton = new Button();
            sortImportanceButton.Text = @"Sort by Importance";
            sortImportanceButton.AutoSize = true;
            sortImportanceButton.Font = new Font("Helvetica Now Display", 10, FontStyle.Bold);
            sortImportanceButton.Location = new Point(sortDateButton.Right + 10, sortPanelHeight - sortImportanceButton.Height - 10);
            sortImportanceButton.Click += (sortImpSender, sortImpEvent) =>
            {
                messages.Sort((msg1, msg2) =>
                {
                    // Assign importance levels to sender subclasses
                    var importanceLevels = new Dictionary<string, int>()
                    {
                        { "TrackDirector", 0 },
                        { "Lecturer", 1 },
                        { "Exerciser", 2 },
                        { "Student", 3 }
                    };
                    var senderObject1 = _trackDirector.FindUserByEmail(msg1.Sender);
                    var senderObject2 = _trackDirector.FindUserByEmail(msg2.Sender);
                    var imp1 = importanceLevels.ContainsKey(senderObject1.SubclassIdentifier) ? importanceLevels[senderObject1.SubclassIdentifier] : int.MaxValue;
                    var imp2 = importanceLevels.ContainsKey(senderObject2.SubclassIdentifier) ? importanceLevels[senderObject2.SubclassIdentifier] : int.MaxValue;

                    return imp1.CompareTo(imp2);
                });
                messagesButton_Click(sender, e);
            };
            sortPanel.Controls.Add(sortImportanceButton);

            var sortTitleButton = new Button();
            sortTitleButton.Text = @"Sort by Title";
            sortTitleButton.AutoSize = true;
            sortTitleButton.Font = new Font("Helvetica Now Display", 10, FontStyle.Bold);
            sortTitleButton.Location = new Point(sortImportanceButton.Right + 10, sortPanelHeight - sortTitleButton.Height - 10);
            sortTitleButton.Click += (sortTitleSender, sortTitleEvent) =>
            {
                messages.Sort((msg1, msg2) => string.CompareOrdinal(msg1.Title, msg2.Title));
                messagesButton_Click(sender, e);
            };
            sortPanel.Controls.Add(sortTitleButton);
            mainPanel.Controls.Add(sortPanel); 
            if (messages.Count > 0)
            {
                var barsPanel = new Panel();
                barsPanel.Size = new Size(panelWidth, messages.Count * (barHeight + barMargin));
                barsPanel.Location = new Point(20, sortPanel.Bottom + 10);
                barsPanel.AutoScroll = true;
                foreach (var message in messages)
                {
                    var barPanel = new Panel();
                    barPanel.BackColor = Color.LightBlue;
                    barPanel.BorderStyle = BorderStyle.FixedSingle;
                    barPanel.Size = new Size(panelWidth, barHeight);
                    barPanel.Location = new Point(20, mainPanel.Controls.Count * 20);

                    var titleLabel = new Label();
                    titleLabel.Text = message.Title;
                    titleLabel.AutoSize = true;
                    titleLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                    titleLabel.Location = new Point(10, 10);
                    barPanel.Controls.Add(titleLabel);
                        
                    var senderLabel = new Label();
                    senderLabel.Text = @"From: " + message.Sender;
                    senderLabel.AutoSize = true;
                    senderLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                    senderLabel.Location = new Point((barPanel.Width - senderLabel.Width) / 2, 10);
                    mainPanel.Controls.Add(senderLabel);
                    mainPanel.AutoScroll = true;

                    var bookmarkLabel = new Label();
                    bookmarkLabel.Text = message.BookmarkStatus ? "-[ * ]-" : "-[   ]-";
                    bookmarkLabel.AutoSize = true;
                    bookmarkLabel.Location = new Point(barPanel.Width - 50, (barPanel.Height - bookmarkLabel.Height) / 2);
                    bookmarkLabel.Click += (deleteSender, deleteEvent) =>
                    {
                        if (bookmarkLabel.Text == @"-[ * ]-")
                        {
                            message.BookmarkStatus = false;
                            bookmarkLabel.Text = @"-[   ]-";
                        }
                        else
                        {
                            message.BookmarkStatus = true;
                            bookmarkLabel.Text = @"-[ * ]-";
                        }
                    };
                    mainPanel.Controls.Add(bookmarkLabel);

                    var dateLabel = new Label();
                    dateLabel.Text = message.Date.ToString("MM/dd/yyyy");
                    dateLabel.AutoSize = true;
                    dateLabel.Font = new Font("Helvetica Now Display", 10, FontStyle.Italic);
                    dateLabel.Location = new Point(barPanel.Width - dateLabel.Width - 10, 10);
                    barPanel.Controls.Add(dateLabel);

                    barPanel.Click += (barSender, barEvent) =>
                    {
                        // Handle click event for the bar
                        mainPanel.Controls.Clear();

                        var messagePanel = new Panel();
                        messagePanel.BackColor = Color.White;
                        messagePanel.BorderStyle = BorderStyle.FixedSingle;
                        messagePanel.Size = new Size(panelWidth, mainPanel.Height - 20);
                        messagePanel.Location = new Point(20, 10);
                        messagePanel.VerticalScroll.Enabled = true;
                        mainPanel.Controls.Add(messagePanel);

                        var receiverLabel = new Label();
                        receiverLabel.Text = @"To: " + message.Receiver;
                        receiverLabel.AutoSize = true;
                        receiverLabel.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                        receiverLabel.Location = new Point(300, 10);
                        messagePanel.Controls.Add(receiverLabel);

                        senderLabel.Location = new Point(10, 10);
                        messagePanel.Controls.Add(senderLabel);

                        bookmarkLabel.Location = new Point(50, 10);
                        messagePanel.Controls.Add(bookmarkLabel);

                        var messageDateLabel = new Label();
                        messageDateLabel.Text = message.Date.ToString("MM/dd/yyyy");
                        messageDateLabel.AutoSize = true;
                        messageDateLabel.Font = new Font("Helvetica Now Display", 10, FontStyle.Italic);
                        messageDateLabel.Location = new Point(messagePanel.Width - messageDateLabel.Width - 10, 40);
                        messagePanel.Controls.Add(messageDateLabel);

                        var titleLabel2 = new Label();
                        titleLabel2.Text = message.Title;
                        titleLabel2.AutoSize = true;
                        titleLabel2.Font = new Font("Helvetica Now Display", 12, FontStyle.Bold);
                        titleLabel2.Location = new Point(10, 40);
                        messagePanel.Controls.Add(titleLabel2);

                        var contentLabel = new Label();
                        contentLabel.Text = message.Content;
                        contentLabel.AutoSize = true;
                        contentLabel.Font = new Font("Helvetica Now Display", 10);
                        contentLabel.Location = new Point(10, 70);
                        messagePanel.Controls.Add(contentLabel);

                        var codeLabel = new Label();
                        codeLabel.Text = @"Code: " + message.MessageCode;
                        codeLabel.AutoSize = true;
                        codeLabel.Font = new Font("Helvetica Now Display", 8);
                        codeLabel.Location = new Point(messagePanel.Width - codeLabel.Width - 10,
                            messagePanel.Height - codeLabel.Height - 10);
                        messagePanel.Controls.Add(codeLabel);

                        var deleteButton = new Button();
                        deleteButton.Text = @"Delete";
                        deleteButton.AutoSize = true;
                        deleteButton.Font = new Font("Helvetica Now Display", 10, FontStyle.Bold);
                        deleteButton.Location = new Point(messagePanel.Width - deleteButton.Width - 10, 10);
                        deleteButton.Click += (deleteSender, deleteEvent) =>
                        {
                            _user.Messages.Remove(message);
                            mainPanel.Controls.Remove(barPanel);
                            mainPanel.Controls.Remove(messagePanel);
                            FileHandler.SaveTrackDirector(_trackDirector);
                        };
                        messagePanel.Controls.Add(deleteButton);
                    };

                    mainPanel.Controls.Add(barPanel);
                }
            }
            else
            {
                var noMessageLabel = new Label();
                noMessageLabel.Text = @"No messages found.";
                noMessageLabel.AutoSize = true;
                noMessageLabel.Font = new Font("Helvetica Now Display", 12);
                noMessageLabel.Location = new Point(20, 20);
                mainPanel.Controls.Add(noMessageLabel);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // Create a list of search options
            var searchOptions = new List<string>
            {
                "First Name",
                "Last Name",
                "Age",
                "Phone Number",
                "Email"
            };

            // Display a dialog for selecting the search option
            var selectedOption = ShowSearchOptionsDialog(searchOptions);
            if (selectedOption == null) return;
            // Display an input box for entering the search query
            var searchQuery = ShowInputDialog("Enter the search query");

            // Perform the search based on the selected option and query
            if (string.IsNullOrEmpty(searchQuery)) return;
            // Perform the search and display the results
            _lastSelectedCategory = selectedOption;
            _lastSelectedQuery = searchQuery;
            var searchResults = PerformSearch(selectedOption, searchQuery);
            DisplaySearchResults(searchResults);
        }
        private void DisplaySearchResults(List<Person> searchResults)
{
    // Clear the mainPanel
    mainPanel.Controls.Clear();

    if (searchResults.Count > 0)
    {
        // Create a panel to display the search results
        var resultsPanel = new Panel();
        resultsPanel.Dock = DockStyle.Fill;
        resultsPanel.AutoScroll = true;

        var y = 10;
        foreach (var person in searchResults)
        {
            // Create a button for each search result
            var resultButton = new Button();
            resultButton.Text = person.ToString();
            resultButton.AutoSize = true;
            resultButton.Location = new Point(10, y);
            resultButton.Click += (sender, e) => DisplayPersonDetails(person);

            resultsPanel.Controls.Add(resultButton);
            y += resultButton.Height + 10;
        }

        // Create a back button
        var backButton = new Button();
        backButton.Text = @"Back";
        backButton.AutoSize = true;
        backButton.Location = new Point(10, y);
        backButton.Click += (sender, e) => mainPanel.Controls.Clear();

        resultsPanel.Controls.Add(backButton);
        mainPanel.Controls.Add(resultsPanel);
    }
    else
    {
        MessageBox.Show(@"No results found.", @"Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

        private void DisplayPersonDetails(Person person)
{
    // Clear the mainPanel
    mainPanel.Controls.Clear();

    // Create a panel to display the person's details
    var detailsPanel = new Panel();
    detailsPanel.Dock = DockStyle.Fill;
    detailsPanel.AutoScroll = true;

    // Create a label to display the person's details
    var detailsLabel = new Label();
    detailsLabel.Text = person.ToString();
    detailsLabel.AutoSize = true;
    detailsLabel.Location = new Point(10, 10);

    detailsPanel.Controls.Add(detailsLabel);

    // Create a back button
    var backButton = new Button();
    backButton.Text = @"Back";
    backButton.AutoSize = true;
    backButton.Location = new Point(10, detailsLabel.Bottom + 10);
    backButton.Click += (sender, e) => DisplaySearchResults(PerformSearch(_lastSelectedCategory, _lastSelectedQuery));

    detailsPanel.Controls.Add(backButton);

    mainPanel.Controls.Add(detailsPanel);
}

        private static string ShowSearchOptionsDialog(List<string> options)
        {
    // Display a dialog for selecting the search option
    string selectedOption = null;
    using (var form = new Form())
    {
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;

        var comboBox = new ComboBox();
        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox.Items.AddRange(options.ToArray());
        comboBox.SelectedIndex = 0;
        comboBox.Location = new Point(10, 10);
        comboBox.Size = new Size(200, 25);

        var buttonOk = new Button();
        buttonOk.Text = @"OK";
        buttonOk.DialogResult = DialogResult.OK;
        buttonOk.Anchor = AnchorStyles.Right;
        buttonOk.Location = new Point(10, 45);
        buttonOk.Size = new Size(75, 30);

        var buttonCancel = new Button();
        buttonCancel.Text = @"Cancel";
        buttonCancel.DialogResult = DialogResult.Cancel;
        buttonCancel.Anchor = AnchorStyles.Right;
        buttonCancel.Location = new Point(90, 45);
        buttonCancel.Size = new Size(75, 30);

        form.ClientSize = new Size(220, 90);
        form.Controls.AddRange(new Control[] { comboBox, buttonOk, buttonCancel });
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;

        if (form.ShowDialog() == DialogResult.OK)
        {
            selectedOption = comboBox.SelectedItem.ToString();
        }

        return selectedOption;
    }
        }

        private static string ShowInputDialog(string prompt)
        {
            var promptForm = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = @"Enter the search query",
                StartPosition = FormStartPosition.CenterScreen
            };

            var promptLabel = new Label() { Left = 50, Top = 20, Text = prompt };
            var textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            var confirmButton = new Button() { Text = @"OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmButton.Click += (sender, e) => promptForm.Close();

            promptForm.Controls.Add(textBox);
            promptForm.Controls.Add(promptLabel);
            promptForm.Controls.Add(confirmButton);

            return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
        
        private List<Person> PerformSearch(string category, string query)
        {
            var searchResults = new List<Person>();

            // Perform the search based on the selected category and query
            switch (category)
            {
                case "First Name":
                    searchResults = SearchByFirstName(query);
                    break;
                case "Last Name":
                    searchResults = SearchByLastName(query);
                    break;
                case "Age":
                    searchResults = SearchByAge(query);
                    break;
                case "Phone Number":
                    searchResults = SearchByPhoneNumber(query);
                    break;
                case "Email":
                    searchResults = SearchByEmail(query);
                    break;
                default:
                    MessageBox.Show(@"Invalid search category");
                    break;
            }

            return searchResults;
        } 
        private List<Person> SearchByFirstName(string query)
        {
            var results = new List<Person>();
            if (_trackDirector.FirstName.Equals(query))
            {
                results.Add(_trackDirector);
            }
            results.AddRange(_trackDirector.Persons.Where(person => person.FirstName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
            results.AddRange(_trackDirector.Students.Where(student => student.FirstName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0));
            return results;
        }

        private List<Person> SearchByLastName(string query)
        {
            var results = new List<Person>();
            if (_trackDirector.LastName.Equals(query))
            {
                results.Add(_trackDirector);
            }
            results.AddRange(_trackDirector.Persons.Where(person => person.LastName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
            results.AddRange(_trackDirector.Students.Where(student => student.LastName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0));
            return results;
        }

        private List<Person> SearchByAge(string query)
        {
            var results = new List<Person>();
            if (!int.TryParse(query, out var age)) return results;

            if (_trackDirector.Age == age)
            {
                results.Add(_trackDirector);
            }
            results.AddRange(_trackDirector.Persons.Where(person => person.Age == age).ToList());
            results.AddRange(_trackDirector.Students.Where(student => student.Age == age).ToList());
            return results;
        }

        private List<Person> SearchByPhoneNumber(string query)
        {
            var results = new List<Person>();
            if (_trackDirector.PhoneNumber.Equals(query))
            {
                results.Add(_trackDirector);
            }
            results.AddRange(_trackDirector.Persons.Where(person => person.PhoneNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
            results.AddRange(_trackDirector.Students.Where(student => student.PhoneNumber.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0));
            return results;
        }

        private List<Person> SearchByEmail(string query)
        {
            var results = new List<Person>();
            if (_trackDirector.Email.Equals(query))
            {
                results.Add(_trackDirector);
            }
            results.AddRange(_trackDirector.Persons.Where(person => person.Email.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
            results.AddRange(_trackDirector.Students.Where(student => student.Email.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0));
            return results;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void studentCoursesButton_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                if (_user.SubclassIdentifier.Equals("Student") || _user.SubclassIdentifier.Equals("Exerciser"))
                {
                    var studentCoursesView = new StudentCoursesViewForm((Student)_user);
                    studentCoursesView.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"You are not a student, therefore, you do not have any courses to follow");
                }
            }
            else
            {
                MessageBox.Show(@"You cannot view the students' courses through this menu, please use the appropriate administration menu");
            }
        }

        private void lecturerTracksButton_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {
                if (_user.SubclassIdentifier.Equals("Lecturer"))
                {
                    var lectTrackCourStudView = new LectTrackCourStudViewForm((Lecturer)_user);
                    lectTrackCourStudView.ShowDialog();
                }
                else
                {
                    MessageBox.Show(@"You are not a lecturer");
                }
            }
            else
            {
                MessageBox.Show(@"You cannot view the lecturers' responsible courses, students and tracks through this menu, please use the appropriate administration menu");
            }
        }

        private void sysManMenuButton_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                var systemManagementForm = new SystemManagementForm(_trackDirector);
                systemManagementForm.ShowDialog();
            }
            else MessageBox.Show(@"You do not have access privileges to the administration menu.");
        }
    }
}
