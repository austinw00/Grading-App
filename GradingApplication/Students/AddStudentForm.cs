using System;
using System.Windows.Forms;

namespace GradingApplication
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void submitNewStudentButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;

            DatabaseHelper.AddStudent(firstName, lastName);

            MessageBox.Show("Student added successfully!");

            // Clear the input fields and close the form if necessary
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
