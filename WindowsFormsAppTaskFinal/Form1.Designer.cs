namespace WindowsFormsAppTaskFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.signInLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.studentRegisterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lecturerRegisterButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 21.75F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleLabel.Location = new System.Drawing.Point(45, 51);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(391, 80);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Ariel Staff Management System";
            // 
            // signInLabel
            // 
            this.signInLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 14.25F);
            this.signInLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signInLabel.Location = new System.Drawing.Point(349, 160);
            this.signInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(176, 47);
            this.signInLabel.TabIndex = 6;
            this.signInLabel.Text = "Please Sign In";
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 14.25F);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(94, 211);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(176, 47);
            this.emailLabel.TabIndex = 9;
            this.emailLabel.Text = "Enter Email Address:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 14.25F);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(94, 278);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(176, 47);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Enter Password:";
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 15.75F);
            this.connectButton.Location = new System.Drawing.Point(349, 342);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(139, 51);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // studentRegisterButton
            // 
            this.studentRegisterButton.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 15.75F);
            this.studentRegisterButton.Location = new System.Drawing.Point(13, 386);
            this.studentRegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.studentRegisterButton.Name = "studentRegisterButton";
            this.studentRegisterButton.Size = new System.Drawing.Size(139, 51);
            this.studentRegisterButton.TabIndex = 12;
            this.studentRegisterButton.Text = "Student Registration";
            this.studentRegisterButton.UseVisualStyleBackColor = true;
            this.studentRegisterButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-1, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 10);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(503, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 128);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // lecturerRegisterButton
            // 
            this.lecturerRegisterButton.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 15.75F);
            this.lecturerRegisterButton.Location = new System.Drawing.Point(160, 386);
            this.lecturerRegisterButton.Margin = new System.Windows.Forms.Padding(4);
            this.lecturerRegisterButton.Name = "lecturerRegisterButton";
            this.lecturerRegisterButton.Size = new System.Drawing.Size(139, 51);
            this.lecturerRegisterButton.TabIndex = 15;
            this.lecturerRegisterButton.Text = "Lecturer Registration";
            this.lecturerRegisterButton.UseVisualStyleBackColor = true;
            this.lecturerRegisterButton.Click += new System.EventHandler(this.lecturerRegisterButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(304, 210);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(221, 20);
            this.emailBox.TabIndex = 16;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(304, 278);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(221, 20);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Ac437 CL EagleIII 8x16", 15.75F);
            this.exitButton.Location = new System.Drawing.Point(648, 386);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 51);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lecturerRegisterButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentRegisterButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;


        private System.Windows.Forms.Button lecturerRegisterButton;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button studentRegisterButton;

        private System.Windows.Forms.Button connectButton;
        
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;

        private System.Windows.Forms.Label signInLabel;

        private System.Windows.Forms.Label titleLabel;

        #endregion
    }
}