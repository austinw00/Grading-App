using System.Data;
using System.Windows.Forms;

namespace GradingApplication.Courses
{
    public partial class AssignmentForm : Form
    {
        private int _assignmentId;
        private int _courseId;
        private int _studentId;
        public AssignmentForm(int assignmentId, int courseId, int studentId)
        {
            _studentId = studentId;
            _courseId = courseId;
            _assignmentId = assignmentId;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void AssignmentForm_Load(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, System.EventArgs e)
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
            //int assignmentId = DatabaseHelper.AddAssignment(assignmentName, _courseId, type.ToLower());
            bool success = DatabaseHelper.UpdateAssignment(_assignmentId, assignmentName, _courseId, type.ToLower());

            if (type != "homework" && type != "test")
            {
                MessageBox.Show("An error occurred while adding the assignment. Please enter 'Homework' or 'Test' for the type.");
                return;
            }
            if (_assignmentId == -1)
            {
                MessageBox.Show("An error occurred while adding the assignment.");
                return;
            }

            // Insert the grade for the new assignment into the Grades table
            int studentId = _studentId;
            bool success2 = DatabaseHelper.UpdateGrade(studentId, _assignmentId, grade);


            if (success2)
            {
                MessageBox.Show("Assignment and grade added successfully.");
                // Reload the assignments and grades
                DataTable dataTable = DatabaseHelper.GetStudentGrades(_studentId, _courseId);
                if (dataTable == null)
                {
                    MessageBox.Show("An error occurred while retrieving the grades.");
                    return;
                }
                // Clear the input fields
                assignmentNameTxt.Clear();
                gradeTxt.Clear();
            }
            else
            {
                MessageBox.Show("An error occurred while adding the grade.");
            }


        }

        private void deleteAssignmentButton_Click(object sender, System.EventArgs e)
        {
            int assignmentId = _assignmentId;
            bool success = DatabaseHelper.DeleteAssignment(assignmentId);
            if (success)
            {
                MessageBox.Show("Assignment deleted successfully.");
            }
            else
            {
                MessageBox.Show("An error occurred while deleting the assignment.");
            }
        }
    }
}
