namespace LS
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfilePage f2 = new ProfilePage();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }

        private void LessonsButton_Click(object sender, EventArgs e)
        {
            LessonsPage f3 = new LessonsPage();
            f3.Owner = this;
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = this.Location;
            f3.Show();
            this.Hide();
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            ProjectEditor f4 = new ProjectEditor();
            f4.Owner = this;
            f4.StartPosition = FormStartPosition.Manual;
            f4.Location = this.Location;
            f4.Show();
            this.Hide();
        }

        private void TeacherPortalButton_Click(object sender, EventArgs e)
        {
            TeacherPortal f5 = new TeacherPortal();
            f5.Owner = this;
            f5.StartPosition = FormStartPosition.Manual;
            f5.Location = this.Location;
            f5.Show();
            this.Hide();
        }

        private void ParentPortalButton_Click(object sender, EventArgs e)
        {
            ParentPortal f6 = new ParentPortal();
            f6.Owner = this;
            f6.StartPosition = FormStartPosition.Manual;
            f6.Location = this.Location;
            f6.Show();
            this.Hide();
        }
    }
}

      