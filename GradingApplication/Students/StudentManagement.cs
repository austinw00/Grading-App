using System;
using System.Data;
using System.Windows.Forms;

namespace GradingApplication.Students
{
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            DataTable studentsTable = DatabaseHelper.GetAllStudents();
            studentsBindingSource.DataSource = studentsTable;
            studentGridView.DataSource = studentsBindingSource;
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
            // Refresh the DataGridView
            LoadStudents();
        }

        private void studentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            if (studentGridView.SelectedRows.Count > 0)
            {
                int studentId = Convert.ToInt32(studentGridView.SelectedRows[0].Cells["Id"].Value);
                DatabaseHelper.RemoveStudent(studentId);
                MessageBox.Show("Student removed successfully!");

                // Refresh the DataGridView
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
