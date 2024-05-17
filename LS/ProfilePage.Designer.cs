namespace LS
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            BackButton = new Button();
            AboutTheUser = new ListBox();
            ProfileIcon = new PictureBox();
            UsernameLabel = new Label();
            UserActivity = new ListBox();
            TopProject = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProfileIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TopProject).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-42, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 118);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(0, 427);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(148, 27);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // AboutTheUser
            // 
            AboutTheUser.BackColor = SystemColors.Info;
            AboutTheUser.FormattingEnabled = true;
            AboutTheUser.ItemHeight = 15;
            AboutTheUser.Items.AddRange(new object[] { "About me", "", "I like to code games on Blocky Code. I created", "2 games. One called UNO, which is based on the", "card game called UNO. My second game is ", "called Monsters Survival it's a  game where ", "you have to defend your building aganist a ", "monster." });
            AboutTheUser.Location = new Point(0, 193);
            AboutTheUser.Name = "AboutTheUser";
            AboutTheUser.Size = new Size(295, 139);
            AboutTheUser.TabIndex = 14;
            // 
            // ProfileIcon
            // 
            ProfileIcon.Image = (Image)resources.GetObject("ProfileIcon.Image");
            ProfileIcon.Location = new Point(0, 131);
            ProfileIcon.Name = "ProfileIcon";
            ProfileIcon.Size = new Size(92, 56);
            ProfileIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ProfileIcon.TabIndex = 15;
            ProfileIcon.TabStop = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(33, 113);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(48, 15);
            UsernameLabel.TabIndex = 16;
            UsernameLabel.Text = "Alex383";
            // 
            // UserActivity
            // 
            UserActivity.BackColor = SystemColors.Info;
            UserActivity.FormattingEnabled = true;
            UserActivity.ItemHeight = 15;
            UserActivity.Items.AddRange(new object[] { "User activity", "", ">Alex383 shared the shared the project ", "\"Monster Survival\" (4 days ago)", "", ">Alex383 is now following \"Destiny78\" (7 days ago)" });
            UserActivity.Location = new Point(504, 193);
            UserActivity.Name = "UserActivity";
            UserActivity.Size = new Size(295, 139);
            UserActivity.TabIndex = 17;
            // 
            // TopProject
            // 
            TopProject.Image = (Image)resources.GetObject("TopProject.Image");
            TopProject.Location = new Point(301, 182);
            TopProject.Name = "TopProject";
            TopProject.Size = new Size(197, 150);
            TopProject.SizeMode = PictureBoxSizeMode.Zoom;
            TopProject.TabIndex = 18;
            TopProject.TabStop = false;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(TopProject);
            Controls.Add(UserActivity);
            Controls.Add(UsernameLabel);
            Controls.Add(ProfileIcon);
            Controls.Add(AboutTheUser);
            Controls.Add(BackButton);
            Controls.Add(panel1);
            Name = "ProfilePage";
            Text = "ProfilePage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProfileIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)TopProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button BackButton;
        private PictureBox pictureBox1;
        private ListBox AboutTheUser;
        private PictureBox ProfileIcon;
        private Label UsernameLabel;
        private ListBox UserActivity;
        private PictureBox TopProject;
    }
}