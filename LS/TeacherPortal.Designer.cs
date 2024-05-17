namespace LS
{
    partial class TeacherPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPortal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            OverviewButton = new Button();
            MyCourses = new Button();
            MyFilesButton = new Button();
            MyScheduleButton = new Button();
            DirectoryButton = new Button();
            AnnoucementsLabel = new Label();
            AdministerButton = new Button();
            AssignmentsButton = new Button();
            AttendanceButton = new Button();
            BackButton = new Button();
            OverviewBox = new ListBox();
            MyCoursesBox = new ListBox();
            MyFiles = new ListBox();
            MySchedule = new ListBox();
            Directory = new ListBox();
            Administer = new ListBox();
            Assignments = new ListBox();
            Attendance = new ListBox();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 97);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // OverviewButton
            // 
            OverviewButton.Location = new Point(27, 96);
            OverviewButton.Name = "OverviewButton";
            OverviewButton.Size = new Size(90, 23);
            OverviewButton.TabIndex = 4;
            OverviewButton.Text = "Overview";
            OverviewButton.UseVisualStyleBackColor = true;
            OverviewButton.Click += OverviewButton_Click;
            // 
            // MyCourses
            // 
            MyCourses.Location = new Point(27, 135);
            MyCourses.Name = "MyCourses";
            MyCourses.Size = new Size(90, 23);
            MyCourses.TabIndex = 5;
            MyCourses.Text = "My Courses";
            MyCourses.UseVisualStyleBackColor = true;
            MyCourses.Click += MyCourses_Click;
            // 
            // MyFilesButton
            // 
            MyFilesButton.Location = new Point(27, 179);
            MyFilesButton.Name = "MyFilesButton";
            MyFilesButton.Size = new Size(90, 23);
            MyFilesButton.TabIndex = 6;
            MyFilesButton.Text = "My Files";
            MyFilesButton.UseVisualStyleBackColor = true;
            MyFilesButton.Click += MyFilesButton_Click;
            // 
            // MyScheduleButton
            // 
            MyScheduleButton.Location = new Point(27, 226);
            MyScheduleButton.Name = "MyScheduleButton";
            MyScheduleButton.Size = new Size(90, 23);
            MyScheduleButton.TabIndex = 7;
            MyScheduleButton.Text = "My Schedule";
            MyScheduleButton.UseVisualStyleBackColor = true;
            MyScheduleButton.Click += MyScheduleButton_Click;
            // 
            // DirectoryButton
            // 
            DirectoryButton.Location = new Point(27, 269);
            DirectoryButton.Name = "DirectoryButton";
            DirectoryButton.Size = new Size(90, 23);
            DirectoryButton.TabIndex = 8;
            DirectoryButton.Text = "Directory";
            DirectoryButton.UseVisualStyleBackColor = true;
            DirectoryButton.Click += DirectoryButton_Click;
            // 
            // AnnoucementsLabel
            // 
            AnnoucementsLabel.AutoSize = true;
            AnnoucementsLabel.Location = new Point(604, 100);
            AnnoucementsLabel.Name = "AnnoucementsLabel";
            AnnoucementsLabel.Size = new Size(88, 15);
            AnnoucementsLabel.TabIndex = 9;
            AnnoucementsLabel.Text = "Annoucements";
            // 
            // AdministerButton
            // 
            AdministerButton.Location = new Point(27, 334);
            AdministerButton.Name = "AdministerButton";
            AdministerButton.Size = new Size(90, 23);
            AdministerButton.TabIndex = 10;
            AdministerButton.Text = "Administer";
            AdministerButton.UseVisualStyleBackColor = true;
            AdministerButton.Click += AdministerButton_Click;
            // 
            // AssignmentsButton
            // 
            AssignmentsButton.Location = new Point(27, 375);
            AssignmentsButton.Name = "AssignmentsButton";
            AssignmentsButton.Size = new Size(90, 23);
            AssignmentsButton.TabIndex = 11;
            AssignmentsButton.Text = "Assignments";
            AssignmentsButton.UseVisualStyleBackColor = true;
            AssignmentsButton.Click += AssignmentsButton_Click;
            // 
            // AttendanceButton
            // 
            AttendanceButton.Location = new Point(27, 417);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(90, 23);
            AttendanceButton.TabIndex = 12;
            AttendanceButton.Text = "Attendance";
            AttendanceButton.UseVisualStyleBackColor = true;
            AttendanceButton.Click += AttendanceButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(652, 441);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(148, 27);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // OverviewBox
            // 
            OverviewBox.FormattingEnabled = true;
            OverviewBox.ItemHeight = 15;
            OverviewBox.Location = new Point(139, 96);
            OverviewBox.Name = "OverviewBox";
            OverviewBox.Size = new Size(274, 19);
            OverviewBox.TabIndex = 14;
            OverviewBox.Visible = false;
            // 
            // MyCoursesBox
            // 
            MyCoursesBox.FormattingEnabled = true;
            MyCoursesBox.ItemHeight = 15;
            MyCoursesBox.Location = new Point(139, 139);
            MyCoursesBox.Name = "MyCoursesBox";
            MyCoursesBox.Size = new Size(274, 19);
            MyCoursesBox.TabIndex = 15;
            MyCoursesBox.Visible = false;
            // 
            // MyFiles
            // 
            MyFiles.FormattingEnabled = true;
            MyFiles.ItemHeight = 15;
            MyFiles.Location = new Point(139, 183);
            MyFiles.Name = "MyFiles";
            MyFiles.Size = new Size(274, 19);
            MyFiles.TabIndex = 16;
            MyFiles.Visible = false;
            // 
            // MySchedule
            // 
            MySchedule.FormattingEnabled = true;
            MySchedule.ItemHeight = 15;
            MySchedule.Location = new Point(139, 226);
            MySchedule.Name = "MySchedule";
            MySchedule.Size = new Size(274, 19);
            MySchedule.TabIndex = 17;
            MySchedule.Visible = false;
            // 
            // Directory
            // 
            Directory.FormattingEnabled = true;
            Directory.ItemHeight = 15;
            Directory.Location = new Point(139, 269);
            Directory.Name = "Directory";
            Directory.Size = new Size(271, 19);
            Directory.TabIndex = 18;
            Directory.Visible = false;
            // 
            // Administer
            // 
            Administer.FormattingEnabled = true;
            Administer.ItemHeight = 15;
            Administer.Location = new Point(139, 334);
            Administer.Name = "Administer";
            Administer.Size = new Size(271, 19);
            Administer.TabIndex = 19;
            Administer.Visible = false;
            // 
            // Assignments
            // 
            Assignments.FormattingEnabled = true;
            Assignments.ItemHeight = 15;
            Assignments.Location = new Point(139, 375);
            Assignments.Name = "Assignments";
            Assignments.Size = new Size(271, 19);
            Assignments.TabIndex = 20;
            Assignments.Visible = false;
            // 
            // Attendance
            // 
            Attendance.FormattingEnabled = true;
            Attendance.ItemHeight = 15;
            Attendance.Location = new Point(139, 417);
            Attendance.Name = "Attendance";
            Attendance.Size = new Size(268, 19);
            Attendance.TabIndex = 21;
            Attendance.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(532, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(256, 304);
            listBox1.TabIndex = 22;
            // 
            // TeacherPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 466);
            Controls.Add(listBox1);
            Controls.Add(Attendance);
            Controls.Add(Assignments);
            Controls.Add(Administer);
            Controls.Add(Directory);
            Controls.Add(MySchedule);
            Controls.Add(MyFiles);
            Controls.Add(MyCoursesBox);
            Controls.Add(OverviewBox);
            Controls.Add(BackButton);
            Controls.Add(AttendanceButton);
            Controls.Add(AssignmentsButton);
            Controls.Add(AdministerButton);
            Controls.Add(AnnoucementsLabel);
            Controls.Add(DirectoryButton);
            Controls.Add(MyScheduleButton);
            Controls.Add(MyFilesButton);
            Controls.Add(MyCourses);
            Controls.Add(OverviewButton);
            Controls.Add(panel1);
            Name = "TeacherPortal";
            Text = "TeacherPortal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button OverviewButton;
        private Button MyCourses;
        private Button MyFilesButton;
        private Button MyScheduleButton;
        private Button DirectoryButton;
        private Label AnnoucementsLabel;
        private Button AdministerButton;
        private Button AssignmentsButton;
        private Button AttendanceButton;
        private Button BackButton;
        private PictureBox pictureBox1;
        private ListBox OverviewBox;
        private ListBox MyCoursesBox;
        private ListBox MyFiles;
        private ListBox MySchedule;
        private ListBox Directory;
        private ListBox Administer;
        private ListBox Assignments;
        private ListBox Attendance;
        private ListBox listBox1;
    }
}