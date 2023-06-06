using System.ComponentModel;

namespace WindowsFormsAppTaskFinal
{
    partial class LecturerRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerRegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.specializationSelector = new System.Windows.Forms.ComboBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.coursesListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.finishRegButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 152);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(110, 174);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(175, 20);
            this.idTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(110, 223);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(110, 268);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(99, 315);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDatePicker.TabIndex = 35;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(319, 265);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(175, 20);
            this.passwordTextBox.TabIndex = 38;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(319, 174);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.phoneNumberTextBox.TabIndex = 37;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(319, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 20);
            this.emailTextBox.TabIndex = 36;
            // 
            // specializationSelector
            // 
            this.specializationSelector.FormattingEnabled = true;
            this.specializationSelector.Items.AddRange(new object[] { "Architecture", "Exterior Blueprinting", "Floor Tiling", "Computer Science", "Software Engineering", "Data Science", "Sound Engineering", "Sound Design", "Audio Hardware Engineering", "Social Science", "Political Science", "Psychology" });
            this.specializationSelector.Location = new System.Drawing.Point(519, 174);
            this.specializationSelector.Name = "specializationSelector";
            this.specializationSelector.Size = new System.Drawing.Size(175, 21);
            this.specializationSelector.TabIndex = 40;
            this.specializationSelector.SelectedIndexChanged += new System.EventHandler(this.specializationSelector_SelectedIndexChanged);
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Enabled = false;
            this.employeeNumberTextBox.Location = new System.Drawing.Point(319, 315);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.employeeNumberTextBox.TabIndex = 39;
            // 
            // coursesListBox
            // 
            this.coursesListBox.FormattingEnabled = true;
            this.coursesListBox.Location = new System.Drawing.Point(519, 220);
            this.coursesListBox.Name = "coursesListBox";
            this.coursesListBox.Size = new System.Drawing.Size(175, 49);
            this.coursesListBox.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(551, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Specilization:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(343, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "Employee Number:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(343, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Password:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(360, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(360, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "Phone Number:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(147, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Birth Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LastNameLabel.Location = new System.Drawing.Point(147, 246);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(100, 23);
            this.LastNameLabel.TabIndex = 44;
            this.LastNameLabel.Text = "Last Name:";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstNameLabel.Location = new System.Drawing.Point(147, 197);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(100, 23);
            this.FirstNameLabel.TabIndex = 43;
            this.FirstNameLabel.Text = "First Name:";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IDLabel.Location = new System.Drawing.Point(147, 143);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(117, 32);
            this.IDLabel.TabIndex = 42;
            this.IDLabel.Text = "Identification Number:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(542, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 23);
            this.label11.TabIndex = 51;
            this.label11.Text = "Courses to teach:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishRegButton
            // 
            this.finishRegButton.Font = new System.Drawing.Font("Mx437 HP 100LX 6x8", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishRegButton.Location = new System.Drawing.Point(333, 370);
            this.finishRegButton.Name = "finishRegButton";
            this.finishRegButton.Size = new System.Drawing.Size(137, 34);
            this.finishRegButton.TabIndex = 52;
            this.finishRegButton.Text = "Finish Registration";
            this.finishRegButton.UseVisualStyleBackColor = true;
            this.finishRegButton.Click += new System.EventHandler(this.finishRegButton_Click_1);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Font = new System.Drawing.Font("Mx437 HP 100LX 6x8", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.Location = new System.Drawing.Point(12, 404);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(137, 34);
            this.MainMenuButton.TabIndex = 53;
            this.MainMenuButton.Text = "Back to main menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Ac437 Apricot 200L", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(121, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 60);
            this.label1.TabIndex = 54;
            this.label1.Text = "Lecturer Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LecturerRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.finishRegButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.coursesListBox);
            this.Controls.Add(this.specializationSelector);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LecturerRegisterForm";
            this.Text = "LecturerRegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button MainMenuButton;

        private System.Windows.Forms.Button finishRegButton;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label IDLabel;

        private System.Windows.Forms.CheckedListBox coursesListBox;

        private System.Windows.Forms.ComboBox specializationSelector;
        private System.Windows.Forms.TextBox employeeNumberTextBox;

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;

        private System.Windows.Forms.DateTimePicker birthDatePicker;

        private System.Windows.Forms.TextBox lastNameTextBox;

        private System.Windows.Forms.TextBox firstNameTextBox;

        private System.Windows.Forms.TextBox idTextBox;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}