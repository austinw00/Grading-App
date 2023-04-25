using GradingApplication.Courses;
using GradingApplication.Students;
using System;
using System.Data;
using System.Windows.Forms;

namespace GradingApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            DataTable coursesTable = DatabaseHelper.GetAllCourses();
            courseListBox.DisplayMember = "Name";
            courseListBox.ValueMember = "Id";
            courseListBox.DataSource = coursesTable;
        }

        private void courseListBox_DoubleClick(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem != null)
            {
                int courseId = Convert.ToInt32(courseListBox.SelectedValue);
                string courseName = courseListBox.Text;

                CourseForm courseForm = new CourseForm(courseId, courseName);
                courseForm.ShowDialog();
            }
        }


        private void manageStudents_Click(object sender, EventArgs e)
        {
            StudentManagement studentForm = new StudentManagement();
            studentForm.ShowDialog();
        }

        private void manageCoursesButton_Click(object sender, EventArgs e)
        {
            CourseManagement courseForm = new CourseManagement();
            courseForm.ShowDialog();
        }


    }
}
