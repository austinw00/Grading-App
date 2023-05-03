using System;
using System.Data;
using System.Windows.Forms;

namespace GradingApplication.Courses
{
    public partial class StudentGradesForm : Form
    {
        private int _studentId;
        private int _courseId;
        public StudentGradesForm(int studentId, int courseId)
        {
            InitializeComponent();
            _studentId = studentId;
            _courseId = courseId;

            string studentName = DatabaseHelper.GetStudentNameById(_studentId);
            string courseName = DatabaseHelper.GetCourseNameById(_courseId);
            studentNameLabel.Text = $"Student: {studentName}";
            courseNameLabel.Text = $"Course: {courseName}";

            LoadGrades();
        }

        public void LoadGrades()
        {
            // Retrieve the assignments and grades for the selected student and course
            DataTable dataTable = DatabaseHelper.GetStudentGrades(_studentId, _courseId);
            assignmentsDataGridView.DataSource = dataTable;

            // Get the student's grade in the course
            double grade = DatabaseHelper.GetStudentOverallScore(_studentId, _courseId);

            // Set the label's Text property to the grade value
            overallGradeLabel.Text = $"Grade in Course: {grade}%";

            // Get the student's grade in the course
            string letterGrade = ConvertScoreToLetterGrade(DatabaseHelper.GetStudentOverallScore(_studentId, _courseId));

            // Set the label's Text property to the grade value
            letterGradeLabel.Text = $"Letter Grade in Course: {letterGrade}";
        }

        public static string ConvertScoreToLetterGrade(double score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }


        private void AddAssignmentButton_Click1(object sender, EventArgs e)
        {
            string assignmentName = assignmentNameTxt.Text.Trim();
            string gradeText = gradeTxt.Text.Trim();
            string type = typeTxt.Text.Trim();

            // Validate the input
            if (string.IsNullOrEmpty(assignmentName))
            {
                MessageBox.Show("Please enter an assignment name.");
                return;
            }

            if (!int.TryParse(gradeText, out int grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("Please enter a valid grade (0-100).");
                return;
            }

            // Insert the new assignment into the Assignments table
            int assignmentId = DatabaseHelper.AddAssignment(assignmentName, _courseId, type.ToLower());

            if (type != "homework" && type != "test")
            {
                MessageBox.Show("An error occurred while adding the assignment. Please enter 'Homework' or 'Test' for the type.");
                return;
            }
            if (assignmentId == -1)
            {
                MessageBox.Show("An error occurred while adding the assignment.");
                return;
            }

            // Insert the grade for the new assignment into the Grades table
            int studentId = _studentId;
            bool success = DatabaseHelper.AddGrade(studentId, assignmentId, grade);

            if (success)
            {
                MessageBox.Show("Assignment and grade added successfully.");
                // Reload the assignments and grades
                DataTable dataTable = DatabaseHelper.GetStudentGrades(_studentId, _courseId);
                if (dataTable == null)
                {
                    MessageBox.Show("An error occurred while retrieving the grades.");
                    return;
                }
                assignmentsDataGridView.DataSource = dataTable;
                // Clear the input fields
                assignmentNameTxt.Clear();
                gradeTxt.Clear();
            }
            else
            {
                MessageBox.Show("An error occurred while adding the grade.");
            }

            LoadGrades();
        }

        private void assignmentsDataGridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int assignmentId = Convert.ToInt32(assignmentsDataGridView.Rows[e.RowIndex].Cells["AssignmentId"].Value);

            // Open the StudentGradesForm for the selected student and course
            AssignmentForm assignmentForm = new AssignmentForm(assignmentId, _courseId, _studentId);
            assignmentForm.ShowDialog();
        }
    }
}
