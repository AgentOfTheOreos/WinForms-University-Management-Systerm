using System.ComponentModel;

namespace WindowsFormsAppTaskFinal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new WindowsFormsAppTaskFinal.Panels.CustomPanel();
            this.customPanel2 = new WindowsFormsAppTaskFinal.Panels.CustomPanel();
            this.studentCoursesButton = new System.Windows.Forms.Button();
            this.lecturerTracksButton = new System.Windows.Forms.Button();
            this.sysManMenuButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.mainInfoButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.messagesButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Static Displa", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Static Displa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(353, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main section";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Static Displa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(291, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 41);
            this.label3.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Location = new System.Drawing.Point(1, 150);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(907, 297);
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // customPanel2
            // 
            this.customPanel2.Controls.Add(this.studentCoursesButton);
            this.customPanel2.Controls.Add(this.lecturerTracksButton);
            this.customPanel2.Controls.Add(this.sysManMenuButton);
            this.customPanel2.Location = new System.Drawing.Point(291, 590);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(343, 97);
            this.customPanel2.TabIndex = 7;
            // 
            // studentCoursesButton
            // 
            this.studentCoursesButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCoursesButton.Location = new System.Drawing.Point(113, 22);
            this.studentCoursesButton.Name = "studentCoursesButton";
            this.studentCoursesButton.Size = new System.Drawing.Size(113, 57);
            this.studentCoursesButton.TabIndex = 11;
            this.studentCoursesButton.Text = "View my Courses";
            this.studentCoursesButton.UseVisualStyleBackColor = true;
            this.studentCoursesButton.Click += new System.EventHandler(this.studentCoursesButton_Click);
            // 
            // lecturerTracksButton
            // 
            this.lecturerTracksButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerTracksButton.Location = new System.Drawing.Point(76, 19);
            this.lecturerTracksButton.Name = "lecturerTracksButton";
            this.lecturerTracksButton.Size = new System.Drawing.Size(180, 62);
            this.lecturerTracksButton.TabIndex = 14;
            this.lecturerTracksButton.Text = "View my students, tracks and courses";
            this.lecturerTracksButton.UseVisualStyleBackColor = true;
            this.lecturerTracksButton.Click += new System.EventHandler(this.lecturerTracksButton_Click);
            // 
            // sysManMenuButton
            // 
            this.sysManMenuButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sysManMenuButton.Location = new System.Drawing.Point(67, 24);
            this.sysManMenuButton.Name = "sysManMenuButton";
            this.sysManMenuButton.Size = new System.Drawing.Size(206, 57);
            this.sysManMenuButton.TabIndex = 12;
            this.sysManMenuButton.Text = "Open System Management Menu";
            this.sysManMenuButton.UseVisualStyleBackColor = true;
            this.sysManMenuButton.Click += new System.EventHandler(this.sysManMenuButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(781, 103);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(113, 41);
            this.settingsButton.TabIndex = 10;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // mainInfoButton
            // 
            this.mainInfoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainInfoButton.Location = new System.Drawing.Point(10, 103);
            this.mainInfoButton.Name = "mainInfoButton";
            this.mainInfoButton.Size = new System.Drawing.Size(215, 41);
            this.mainInfoButton.TabIndex = 11;
            this.mainInfoButton.Text = "Display my information";
            this.mainInfoButton.UseVisualStyleBackColor = true;
            this.mainInfoButton.Click += new System.EventHandler(this.mainInfoButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(233, 103);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(212, 41);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search other users";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // messagesButton
            // 
            this.messagesButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagesButton.Location = new System.Drawing.Point(451, 103);
            this.messagesButton.Name = "messagesButton";
            this.messagesButton.Size = new System.Drawing.Size(113, 41);
            this.messagesButton.TabIndex = 13;
            this.messagesButton.Text = "Messages";
            this.messagesButton.UseVisualStyleBackColor = true;
            this.messagesButton.Click += new System.EventHandler(this.messagesButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(12, 9);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(113, 41);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(907, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(647, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(908, 699);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.messagesButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mainInfoButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.customPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button logoutButton;

        private System.Windows.Forms.Button lecturerTracksButton;

        private System.Windows.Forms.Button messagesButton;

        private System.Windows.Forms.Button mainInfoButton;
        private System.Windows.Forms.Button searchButton;

        private System.Windows.Forms.Button studentCoursesButton;
        private System.Windows.Forms.Button sysManMenuButton;

        private System.Windows.Forms.Button settingsButton;

        private WindowsFormsAppTaskFinal.Panels.CustomPanel customPanel2;

        private WindowsFormsAppTaskFinal.Panels.CustomPanel mainPanel;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}