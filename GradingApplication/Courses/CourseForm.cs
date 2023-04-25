using System;
using System.Data;
using System.Windows.Forms;

namespace GradingApplication.Courses
{
    public partial class CourseForm : Form
    {
        private int _courseId;
        private string _courseName;
        public CourseForm(int courseId, string courseName)
        {
            InitializeComponent();
            _courseId = courseId;
            _courseName = courseName;
            this.Text = $"Students in {_courseName}";
            LoadStudents();
        }
        private void LoadStudents()
        {
            DataTable studentsTable = DatabaseHelper.GetStudentsByCourseId(_courseId);
            studentsGridView.DataSource = studentsTable;
        }

        private void removeStudentButton_Click(object sender, System.EventArgs e)
        {
            if (studentsGridView.SelectedRows.Count > 0)
            {
                int selectedStudentId = Convert.ToInt32(studentsGridView.SelectedRows[0].Cells["Id"].Value);

                if (DatabaseHelper.RemoveStudentFromCourse(selectedStudentId, _courseId))
                {
                    MessageBox.Show("Student removed from the course successfully.");
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("An error occurred while removing the student from the course.");
                }
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            SelectStudentForm selectStudentForm = new SelectStudentForm();
            if (selectStudentForm.ShowDialog() == DialogResult.OK)
            {
                int selectedStudentId = (int)selectStudentForm.Tag;
                if (DatabaseHelper.AddStudentToCourse(selectedStudentId, _courseId))
                {
                    MessageBox.Show("Student added to the course successfully.");
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the student to the course.");
                }
            }
        }

        private void studentsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the ID of the selected student
            int studentId = (int)studentsGridView.Rows[e.RowIndex].Cells["Id"].Value;

            // Open the StudentGradesForm for the selected student and course
            StudentGradesForm studentGradesForm = new StudentGradesForm(studentId, _courseId);
            studentGradesForm.ShowDialog();
        }
    }
}
