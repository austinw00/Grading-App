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
        }


    }
}
