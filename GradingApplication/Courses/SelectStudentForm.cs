using System;
using System.Data;
using System.Windows.Forms;

namespace GradingApplication.Courses
{
    public partial class SelectStudentForm : Form
    {
        public SelectStudentForm()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            DataTable studentsTable = DatabaseHelper.GetAllStudents();
            studentsBindingSource.DataSource = studentsTable;
            studentsGridView.DataSource = studentsBindingSource;
        }

        private void createNewStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm();
            if (studentForm.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }

            LoadStudents();
        }

        private void submitStudentButton_Click(object sender, EventArgs e)
        {
            int selectedStudentId = Convert.ToInt32(studentsGridView.SelectedRows[0].Cells["Id"].Value);
            this.Tag = selectedStudentId;
            this.DialogResult = DialogResult.OK;

            LoadStudents();
        }
    }
}
