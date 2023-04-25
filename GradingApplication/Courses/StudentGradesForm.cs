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

            // Retrieve the assignments and grades for the selected student and course
            DataTable dataTable = DatabaseHelper.GetStudentGrades(_studentId, _courseId);
            assignmentsDataGridView.DataSource = dataTable;
        }

        //private void StudentGradesForm_Load(object sender, EventArgs e)
        //{
        //    // Display the student name and course name in labels
        //    string studentName = DatabaseHelper.GetStudentNameById(_studentId);
        //    string courseName = DatabaseHelper.GetCourseNameById(_courseId);
        //    studentNameLabel.Text = $"Student: {studentName}";
        //    courseNameLabel.Text = $"Course: {courseName}";

        //    // Retrieve the assignments and grades for the selected student and course
        //    DataTable dataTable = DatabaseHelper.GetStudentGrades(_studentId, _courseId);
        //    assignmentsDataGridView.DataSource = dataTable;
        //}

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
        }

    }
}
