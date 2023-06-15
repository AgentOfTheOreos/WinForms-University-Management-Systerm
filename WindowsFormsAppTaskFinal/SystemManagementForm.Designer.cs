using System.ComponentModel;

namespace WindowsFormsAppTaskFinal
{
    partial class SystemManagementForm
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
            this.menuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dispRemStudsButton = new System.Windows.Forms.Button();
            this.dispRemLectsButton = new System.Windows.Forms.Button();
            this.dispRemTracksButton = new System.Windows.Forms.Button();
            this.createNewTrackButton = new System.Windows.Forms.Button();
            this.addNewCourseToTrackButton = new System.Windows.Forms.Button();
            this.dispRemCoursesButton = new System.Windows.Forms.Button();
            this.mainPanel = new WindowsFormsAppTaskFinal.Panels.CustomPanel();
            this.dispRemExersButton = new System.Windows.Forms.Button();
            this.assignToTrack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuButton.Location = new System.Drawing.Point(12, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(108, 52);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "Back to main menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Ac437 Apricot 200L", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(195, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "System Administration Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dispRemStudsButton
            // 
            this.dispRemStudsButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispRemStudsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dispRemStudsButton.Location = new System.Drawing.Point(121, 106);
            this.dispRemStudsButton.Name = "dispRemStudsButton";
            this.dispRemStudsButton.Size = new System.Drawing.Size(103, 61);
            this.dispRemStudsButton.TabIndex = 4;
            this.dispRemStudsButton.Text = "Display / Remove Students";
            this.dispRemStudsButton.UseVisualStyleBackColor = true;
            this.dispRemStudsButton.Click += new System.EventHandler(this.dispRemStudsButton_Click);
            // 
            // dispRemLectsButton
            // 
            this.dispRemLectsButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispRemLectsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dispRemLectsButton.Location = new System.Drawing.Point(230, 106);
            this.dispRemLectsButton.Name = "dispRemLectsButton";
            this.dispRemLectsButton.Size = new System.Drawing.Size(108, 61);
            this.dispRemLectsButton.TabIndex = 5;
            this.dispRemLectsButton.Text = "Display / Remove Lecturers";
            this.dispRemLectsButton.UseVisualStyleBackColor = true;
            this.dispRemLectsButton.Click += new System.EventHandler(this.dispRemLectsButton_Click);
            // 
            // dispRemTracksButton
            // 
            this.dispRemTracksButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispRemTracksButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dispRemTracksButton.Location = new System.Drawing.Point(458, 106);
            this.dispRemTracksButton.Name = "dispRemTracksButton";
            this.dispRemTracksButton.Size = new System.Drawing.Size(108, 61);
            this.dispRemTracksButton.TabIndex = 6;
            this.dispRemTracksButton.Text = "Display / Remove Tracks";
            this.dispRemTracksButton.UseVisualStyleBackColor = true;
            this.dispRemTracksButton.Click += new System.EventHandler(this.dispRemTracksButton_Click);
            // 
            // createNewTrackButton
            // 
            this.createNewTrackButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTrackButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createNewTrackButton.Location = new System.Drawing.Point(235, 173);
            this.createNewTrackButton.Name = "createNewTrackButton";
            this.createNewTrackButton.Size = new System.Drawing.Size(108, 62);
            this.createNewTrackButton.TabIndex = 7;
            this.createNewTrackButton.Text = "Create New Track";
            this.createNewTrackButton.UseVisualStyleBackColor = true;
            this.createNewTrackButton.Click += new System.EventHandler(this.addAssignTracksButton_Click);
            // 
            // addNewCourseToTrackButton
            // 
            this.addNewCourseToTrackButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCourseToTrackButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewCourseToTrackButton.Location = new System.Drawing.Point(458, 173);
            this.addNewCourseToTrackButton.Name = "addNewCourseToTrackButton";
            this.addNewCourseToTrackButton.Size = new System.Drawing.Size(108, 62);
            this.addNewCourseToTrackButton.TabIndex = 8;
            this.addNewCourseToTrackButton.Text = "Add New Courses to Tracks";
            this.addNewCourseToTrackButton.UseVisualStyleBackColor = true;
            this.addNewCourseToTrackButton.Click += new System.EventHandler(this.addCoursesToTracksButton_Click);
            // 
            // dispRemCoursesButton
            // 
            this.dispRemCoursesButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispRemCoursesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dispRemCoursesButton.Location = new System.Drawing.Point(572, 106);
            this.dispRemCoursesButton.Name = "dispRemCoursesButton";
            this.dispRemCoursesButton.Size = new System.Drawing.Size(108, 61);
            this.dispRemCoursesButton.TabIndex = 10;
            this.dispRemCoursesButton.Text = "Display / Remove Courses";
            this.dispRemCoursesButton.UseVisualStyleBackColor = true;
            this.dispRemCoursesButton.Click += new System.EventHandler(this.dispRemCoursesButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(12, 259);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 359);
            this.mainPanel.TabIndex = 11;
            // 
            // dispRemExersButton
            // 
            this.dispRemExersButton.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispRemExersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dispRemExersButton.Location = new System.Drawing.Point(344, 106);
            this.dispRemExersButton.Name = "dispRemExersButton";
            this.dispRemExersButton.Size = new System.Drawing.Size(108, 61);
            this.dispRemExersButton.TabIndex = 12;
            this.dispRemExersButton.Text = "Display / Remove Exercisors";
            this.dispRemExersButton.UseVisualStyleBackColor = true;
            this.dispRemExersButton.Click += new System.EventHandler(this.dispRemExersButton_Click);
            // 
            // assignToTrack
            // 
            this.assignToTrack.Font = new System.Drawing.Font("Perfect DOS VGA 437", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignToTrack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.assignToTrack.Location = new System.Drawing.Point(344, 173);
            this.assignToTrack.Name = "assignToTrack";
            this.assignToTrack.Size = new System.Drawing.Size(108, 62);
            this.assignToTrack.TabIndex = 14;
            this.assignToTrack.Text = "Assign Tracks";
            this.assignToTrack.UseVisualStyleBackColor = true;
            this.assignToTrack.Click += new System.EventHandler(this.assignToTrack_Click);
            // 
            // SystemManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.assignToTrack);
            this.Controls.Add(this.dispRemExersButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dispRemCoursesButton);
            this.Controls.Add(this.addNewCourseToTrackButton);
            this.Controls.Add(this.createNewTrackButton);
            this.Controls.Add(this.dispRemTracksButton);
            this.Controls.Add(this.dispRemLectsButton);
            this.Controls.Add(this.dispRemStudsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuButton);
            this.Name = "SystemManagementForm";
            this.Text = "SystemManagementForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button assignToTrack;

        private System.Windows.Forms.Button dispRemExersButton;

        private System.Windows.Forms.Button addNewCourseToTrackButton;
        private System.Windows.Forms.Button dispRemCoursesButton;
        private WindowsFormsAppTaskFinal.Panels.CustomPanel mainPanel;

        private System.Windows.Forms.Button createNewTrackButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dispRemStudsButton;
        private System.Windows.Forms.Button dispRemLectsButton;
        private System.Windows.Forms.Button dispRemTracksButton;

        private System.Windows.Forms.Button menuButton;

        #endregion
    }
}