using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LS
{
    public partial class TeacherPortal : Form
    {
        public TeacherPortal()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }



        private void OverviewButton_Click(object sender, EventArgs e)
        {
            OverviewBox.Visible = !OverviewBox.Visible;
        }

        private void MyCourses_Click(object sender, EventArgs e)
        {
            MyCoursesBox.Visible = !MyCoursesBox.Visible;
        }

        private void MyFilesButton_Click(object sender, EventArgs e)
        {
            MyFiles.Visible = !MyFiles.Visible;
        }

        private void MyScheduleButton_Click(object sender, EventArgs e)
        {
            MySchedule.Visible = !MySchedule.Visible;
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            Directory.Visible = !Directory.Visible;
        }

        private void AdministerButton_Click(object sender, EventArgs e)
        {
            Administer.Visible = !Administer.Visible;
        }

        private void AssignmentsButton_Click(object sender, EventArgs e)
        {
            Assignments.Visible = !Assignments.Visible;
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            Attendance.Visible = !Attendance.Visible;
        }
    }
}
