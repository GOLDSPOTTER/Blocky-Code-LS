namespace LS
{
    partial class ParentPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentPortal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            B = new ListBox();
            StudentAge = new ListBox();
            Alex = new ListBox();
            StudentUpdateList = new ListBox();
            StudentIcon = new PictureBox();
            StudentsAgeLabel = new Label();
            StudentsGradeLabel = new Label();
            StudentsNameLabel = new Label();
            StudentUpdatesLabel = new Label();
            BackButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-15, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 118);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(B);
            panel2.Controls.Add(StudentAge);
            panel2.Controls.Add(Alex);
            panel2.Controls.Add(StudentUpdateList);
            panel2.Controls.Add(StudentIcon);
            panel2.Controls.Add(StudentsAgeLabel);
            panel2.Controls.Add(StudentsGradeLabel);
            panel2.Controls.Add(StudentsNameLabel);
            panel2.Controls.Add(StudentUpdatesLabel);
            panel2.Location = new Point(128, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 280);
            panel2.TabIndex = 8;
            // 
            // B
            // 
            B.FormattingEnabled = true;
            B.ItemHeight = 15;
            B.Items.AddRange(new object[] { "B" });
            B.Location = new Point(3, 235);
            B.Name = "B";
            B.Size = new Size(189, 19);
            B.TabIndex = 8;
            // 
            // StudentAge
            // 
            StudentAge.FormattingEnabled = true;
            StudentAge.ItemHeight = 15;
            StudentAge.Items.AddRange(new object[] { "9" });
            StudentAge.Location = new Point(0, 174);
            StudentAge.Name = "StudentAge";
            StudentAge.Size = new Size(192, 19);
            StudentAge.TabIndex = 7;
            // 
            // Alex
            // 
            Alex.FormattingEnabled = true;
            Alex.ItemHeight = 15;
            Alex.Items.AddRange(new object[] { "Alex" });
            Alex.Location = new Point(3, 116);
            Alex.Name = "Alex";
            Alex.Size = new Size(189, 19);
            Alex.TabIndex = 6;
            // 
            // StudentUpdateList
            // 
            StudentUpdateList.AccessibleDescription = "";
            StudentUpdateList.FormattingEnabled = true;
            StudentUpdateList.ItemHeight = 15;
            StudentUpdateList.Items.AddRange(new object[] { "16/5/2024 Student has watched tutorials on how to create an app.", "", "5/5/2024 Student has created a project." });
            StudentUpdateList.Location = new Point(3, 18);
            StudentUpdateList.Name = "StudentUpdateList";
            StudentUpdateList.Size = new Size(356, 64);
            StudentUpdateList.TabIndex = 5;
            // 
            // StudentIcon
            // 
            StudentIcon.Image = (Image)resources.GetObject("StudentIcon.Image");
            StudentIcon.Location = new Point(442, 0);
            StudentIcon.Name = "StudentIcon";
            StudentIcon.Size = new Size(104, 101);
            StudentIcon.SizeMode = PictureBoxSizeMode.Zoom;
            StudentIcon.TabIndex = 4;
            StudentIcon.TabStop = false;
            // 
            // StudentsAgeLabel
            // 
            StudentsAgeLabel.AutoSize = true;
            StudentsAgeLabel.Location = new Point(0, 156);
            StudentsAgeLabel.Name = "StudentsAgeLabel";
            StudentsAgeLabel.Size = new Size(77, 15);
            StudentsAgeLabel.TabIndex = 3;
            StudentsAgeLabel.Text = "Students Age";
            // 
            // StudentsGradeLabel
            // 
            StudentsGradeLabel.AutoSize = true;
            StudentsGradeLabel.Location = new Point(-1, 205);
            StudentsGradeLabel.Name = "StudentsGradeLabel";
            StudentsGradeLabel.Size = new Size(87, 15);
            StudentsGradeLabel.TabIndex = 2;
            StudentsGradeLabel.Text = "Students Grade";
            // 
            // StudentsNameLabel
            // 
            StudentsNameLabel.AutoSize = true;
            StudentsNameLabel.Location = new Point(3, 98);
            StudentsNameLabel.Name = "StudentsNameLabel";
            StudentsNameLabel.Size = new Size(83, 15);
            StudentsNameLabel.TabIndex = 1;
            StudentsNameLabel.Text = "Student Name";
            // 
            // StudentUpdatesLabel
            // 
            StudentUpdatesLabel.AutoSize = true;
            StudentUpdatesLabel.Location = new Point(3, 0);
            StudentUpdatesLabel.Name = "StudentUpdatesLabel";
            StudentUpdatesLabel.Size = new Size(94, 15);
            StudentUpdatesLabel.TabIndex = 0;
            StudentUpdatesLabel.Text = "Student Updates";
            // 
            // BackButton
            // 
            BackButton.Location = new Point(0, 424);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(148, 27);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ParentPortal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BackButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ParentPortal";
            Text = "ParentPortal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label StudentUpdatesLabel;
        private Label StudentsAgeLabel;
        private Label StudentsGradeLabel;
        private Label StudentsNameLabel;
        private Button BackButton;
        private PictureBox StudentIcon;
        private ListBox StudentUpdateList;
        private ListBox B;
        private ListBox StudentAge;
        private ListBox Alex;
        private PictureBox pictureBox1;
    }
}