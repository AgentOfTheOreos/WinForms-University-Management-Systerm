using System.ComponentModel;

namespace WindowsFormsAppTaskFinal
{
    partial class StudentRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.exerciserCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.studentNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.currentYearlyDrainBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.trackSelector = new System.Windows.Forms.ComboBox();
            this.finishRegButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.specilizationSelector = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Ac437 Apricot 200L", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(124, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 152);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(89, 225);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // exerciserCheckBox
            // 
            this.exerciserCheckBox.Font = new System.Drawing.Font("Ac437 ACM VGA 9x8", 9F);
            this.exerciserCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exerciserCheckBox.Location = new System.Drawing.Point(526, 374);
            this.exerciserCheckBox.Name = "exerciserCheckBox";
            this.exerciserCheckBox.Size = new System.Drawing.Size(201, 64);
            this.exerciserCheckBox.TabIndex = 3;
            this.exerciserCheckBox.Text = "I am an exerciser";
            this.exerciserCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exerciserCheckBox.UseVisualStyleBackColor = true;
            this.exerciserCheckBox.CheckedChanged += new System.EventHandler(this.exerciserCheckBox_CheckedChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(89, 270);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(89, 179);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(175, 20);
            this.idTextBox.TabIndex = 6;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // studentNumberTextBox
            // 
            this.studentNumberTextBox.Enabled = false;
            this.studentNumberTextBox.Location = new System.Drawing.Point(311, 315);
            this.studentNumberTextBox.Name = "studentNumberTextBox";
            this.studentNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.studentNumberTextBox.TabIndex = 8;
            this.studentNumberTextBox.TextChanged += new System.EventHandler(this.studentNumberTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(311, 225);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 20);
            this.emailTextBox.TabIndex = 9;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(311, 179);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // currentYearlyDrainBox
            // 
            this.currentYearlyDrainBox.Enabled = false;
            this.currentYearlyDrainBox.Location = new System.Drawing.Point(526, 316);
            this.currentYearlyDrainBox.Name = "currentYearlyDrainBox";
            this.currentYearlyDrainBox.Size = new System.Drawing.Size(175, 20);
            this.currentYearlyDrainBox.TabIndex = 11;
            this.currentYearlyDrainBox.TextChanged += new System.EventHandler(this.currentYearlyDrainBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(311, 270);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(175, 20);
            this.passwordTextBox.TabIndex = 12;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // trackSelector
            // 
            this.trackSelector.FormattingEnabled = true;
            this.trackSelector.Items.AddRange(new object[] { "Architectural Design", "Cyber Security", "Binaural Shape Waves", "Structural Management" });
            this.trackSelector.Location = new System.Drawing.Point(526, 224);
            this.trackSelector.Name = "trackSelector";
            this.trackSelector.Size = new System.Drawing.Size(175, 21);
            this.trackSelector.TabIndex = 19;
            this.trackSelector.SelectedIndexChanged += new System.EventHandler(this.trackSelector_SelectedIndexChanged);
            // 
            // finishRegButton
            // 
            this.finishRegButton.Font = new System.Drawing.Font("Mx437 HP 100LX 6x8", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishRegButton.Location = new System.Drawing.Point(335, 374);
            this.finishRegButton.Name = "finishRegButton";
            this.finishRegButton.Size = new System.Drawing.Size(137, 34);
            this.finishRegButton.TabIndex = 20;
            this.finishRegButton.Text = "Finish Registration";
            this.finishRegButton.UseVisualStyleBackColor = true;
            this.finishRegButton.Click += new System.EventHandler(this.finishRegButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(526, 270);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(175, 20);
            this.balanceTextBox.TabIndex = 13;
            this.balanceTextBox.TextChanged += new System.EventHandler(this.balanceTextBox_TextChanged);
            // 
            // specilizationSelector
            // 
            this.specilizationSelector.FormattingEnabled = true;
            this.specilizationSelector.Items.AddRange(new object[] { "Architecture", "Exterior Blueprinting", "Floor Tiling", "Computer Science", "Software Engineering", "Data Science", "Sound Engineering", "Sound Design", "Audio Hardware Engineering", "Social Science", "Political Science", "Psychology" });
            this.specilizationSelector.Location = new System.Drawing.Point(526, 178);
            this.specilizationSelector.Name = "specilizationSelector";
            this.specilizationSelector.Size = new System.Drawing.Size(175, 21);
            this.specilizationSelector.TabIndex = 21;
            this.specilizationSelector.SelectedIndexChanged += new System.EventHandler(this.specilizationSelector_SelectedIndexChanged);
            // 
            // IDLabel
            // 
            this.IDLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IDLabel.Location = new System.Drawing.Point(124, 148);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(117, 32);
            this.IDLabel.TabIndex = 22;
            this.IDLabel.Text = "Identification Number:";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstNameLabel.Location = new System.Drawing.Point(124, 202);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(100, 23);
            this.FirstNameLabel.TabIndex = 23;
            this.FirstNameLabel.Text = "First Name:";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LastNameLabel.Location = new System.Drawing.Point(124, 248);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(100, 23);
            this.LastNameLabel.TabIndex = 24;
            this.LastNameLabel.Text = "Last Name:";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(124, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Birth Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(345, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone Number:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(345, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(335, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "Password:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(345, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Student Number:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(562, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Specilization:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(562, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Academic Track:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(562, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "Bank Balance:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(526, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Current Yearly Drain:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(76, 319);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDatePicker.TabIndex = 34;
            // 
            // StudentRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
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
            this.Controls.Add(this.specilizationSelector);
            this.Controls.Add(this.finishRegButton);
            this.Controls.Add(this.trackSelector);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.currentYearlyDrainBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.studentNumberTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.exerciserCheckBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "StudentRegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker birthDatePicker;

        private System.Windows.Forms.TextBox studNumTextBox;

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.Label IDLabel;

        private System.Windows.Forms.ComboBox specilizationSelector;

        private System.Windows.Forms.TextBox balanceTextBox;

        private System.Windows.Forms.Button finishRegButton;

        private System.Windows.Forms.ComboBox trackSelector;

        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox studentNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox currentYearlyDrainBox;
        private System.Windows.Forms.TextBox passwordTextBox;

        private System.Windows.Forms.CheckBox exerciserCheckBox;

        private System.Windows.Forms.TextBox firstNameTextBox;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}