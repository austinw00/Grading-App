using System;
using System.Windows.Forms;

namespace GradingApplication.Courses
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            string courseName = courseNameTxt.Text.Trim();

            if (!string.IsNullOrEmpty(courseName))
            {
                DatabaseHelper.AddCourse(courseName);
                MessageBox.Show("Course added successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a course name.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
