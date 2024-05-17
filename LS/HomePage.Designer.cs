namespace LS
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            ProfileButton = new Button();
            Logo = new Panel();
            pictureBox1 = new PictureBox();
            CreateProjectButton = new Button();
            TitleLabel = new Label();
            LessonsButton = new Button();
            TeacherPortalButton = new Button();
            ParentPortalButton = new Button();
            BackgroundPhoto = new PictureBox();
            Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackgroundPhoto).BeginInit();
            SuspendLayout();
            // 
            // ProfileButton
            // 
            ProfileButton.BackColor = SystemColors.MenuBar;
            ProfileButton.Location = new Point(12, 190);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(75, 23);
            ProfileButton.TabIndex = 0;
            ProfileButton.Text = "Profile";
            ProfileButton.UseVisualStyleBackColor = false;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // Logo
            // 
            Logo.BackColor = SystemColors.HotTrack;
            Logo.Controls.Add(pictureBox1);
            Logo.Controls.Add(CreateProjectButton);
            Logo.Location = new Point(-5, -7);
            Logo.Name = "Logo";
            Logo.Size = new Size(809, 108);
            Logo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(324, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // CreateProjectButton
            // 
            CreateProjectButton.BackColor = SystemColors.Highlight;
            CreateProjectButton.ForeColor = SystemColors.ButtonHighlight;
            CreateProjectButton.Location = new Point(160, 39);
            CreateProjectButton.Name = "CreateProjectButton";
            CreateProjectButton.Size = new Size(97, 23);
            CreateProjectButton.TabIndex = 3;
            CreateProjectButton.Text = "Create Project";
            CreateProjectButton.UseVisualStyleBackColor = false;
            CreateProjectButton.Click += CreateProjectButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.BackColor = SystemColors.HotTrack;
            TitleLabel.ForeColor = SystemColors.ControlLightLight;
            TitleLabel.Location = new Point(240, 227);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(0, 15);
            TitleLabel.TabIndex = 3;
            // 
            // LessonsButton
            // 
            LessonsButton.Location = new Point(12, 248);
            LessonsButton.Name = "LessonsButton";
            LessonsButton.Size = new Size(75, 23);
            LessonsButton.TabIndex = 3;
            LessonsButton.Text = "Lessons";
            LessonsButton.UseVisualStyleBackColor = true;
            LessonsButton.Click += LessonsButton_Click;
            // 
            // TeacherPortalButton
            // 
            TeacherPortalButton.Location = new Point(551, 190);
            TeacherPortalButton.Name = "TeacherPortalButton";
            TeacherPortalButton.Size = new Size(89, 23);
            TeacherPortalButton.TabIndex = 4;
            TeacherPortalButton.Text = "Teacher Portal";
            TeacherPortalButton.UseVisualStyleBackColor = true;
            TeacherPortalButton.Click += TeacherPortalButton_Click;
            // 
            // ParentPortalButton
            // 
            ParentPortalButton.Location = new Point(551, 248);
            ParentPortalButton.Name = "ParentPortalButton";
            ParentPortalButton.Size = new Size(89, 23);
            ParentPortalButton.TabIndex = 5;
            ParentPortalButton.Text = "Parent Portal";
            ParentPortalButton.UseVisualStyleBackColor = true;
            ParentPortalButton.Click += ParentPortalButton_Click;
            // 
            // BackgroundPhoto
            // 
            BackgroundPhoto.Image = (Image)resources.GetObject("BackgroundPhoto.Image");
            BackgroundPhoto.Location = new Point(319, 156);
            BackgroundPhoto.Name = "BackgroundPhoto";
            BackgroundPhoto.Size = new Size(154, 115);
            BackgroundPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            BackgroundPhoto.TabIndex = 6;
            BackgroundPhoto.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(BackgroundPhoto);
            Controls.Add(TitleLabel);
            Controls.Add(ParentPortalButton);
            Controls.Add(TeacherPortalButton);
            Controls.Add(LessonsButton);
            Controls.Add(Logo);
            Controls.Add(ProfileButton);
            Name = "HomePage";
            Text = "Form1";
            Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackgroundPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ProfileButton;
        private Panel Logo;
        private Button CreateProjectButton;
        private Label TitleLabel;
        private Button LessonsButton;
        private Button TeacherPortalButton;
        private Button ParentPortalButton;
        private PictureBox pictureBox1;
        private PictureBox BackgroundPhoto;
    }
}
