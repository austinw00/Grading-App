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
            courseBindingSource.DataSource = coursesTable;
            courseDataGridView.DataSource = courseBindingSource;
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

        private void enterCourseButton_Click(object sender, EventArgs e)
        {
            if (courseDataGridView.SelectedRows.Count > 0)
            {
                int courseId = Convert.ToInt32(courseDataGridView.SelectedRows[0].Cells["Id"].Value);
                string courseName = courseDataGridView.SelectedRows[0].Cells["Name"].Value.ToString();

                CourseForm courseForm = new CourseForm(courseId, courseName);
                courseForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a course to enter.");
            }
        }
    }
}
