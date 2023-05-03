using System;
using System.Data;
using System.Windows.Forms;

namespace GradingApplication.Courses
{
    public partial class CourseManagement : Form
    {
        public CourseManagement()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            DataTable coursesTable = DatabaseHelper.GetAllCourses();
            courseGridView.DataSource = coursesTable;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
            // Refresh the DataGridView
            LoadCourses();
        }

        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            if (courseGridView.SelectedRows.Count > 0)
            {
                int courseId = Convert.ToInt32(courseGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseHelper.RemoveCourse(courseId);
                MessageBox.Show("Course removed successfully!");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Please select a course to remove.");
            }
        }

        private void courseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
