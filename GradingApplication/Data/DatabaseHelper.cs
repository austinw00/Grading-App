using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

public class DatabaseHelper
{
    private const string DatabaseFileName = "GradeMate.db";
    private static string DatabaseFilePath => Path.Combine(Directory.GetCurrentDirectory(), DatabaseFileName);

    public static void InitializeDatabase()
    {
        if (!File.Exists(DatabaseFilePath))
        {
            SQLiteConnection.CreateFile(DatabaseFilePath);
            CreateTables();
        }
    }

    private static void CreateTables()
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = @"
            CREATE TABLE IF NOT EXISTS Courses (
                Id INTEGER PRIMARY KEY,
                Name TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Students (
                Id INTEGER PRIMARY KEY,
                FirstName TEXT NOT NULL,
                LastName TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Assignments (
                Id INTEGER PRIMARY KEY,
                Name TEXT NOT NULL,
                Type TEXT NOT NULL CHECK (Type IN ('homework', 'test')),
                CourseId INTEGER NOT NULL,
                FOREIGN KEY (CourseId) REFERENCES Courses (Id)
            );

            CREATE TABLE IF NOT EXISTS Grades (
                Id INTEGER PRIMARY KEY,
                AssignmentId INTEGER NOT NULL,
                StudentId INTEGER NOT NULL,
                Grade REAL NOT NULL,
                FOREIGN KEY (AssignmentId) REFERENCES Assignments (Id),
                FOREIGN KEY (StudentId) REFERENCES Students (Id)
            );

            CREATE TABLE IF NOT EXISTS Enrollments (
                Id INTEGER PRIMARY KEY,
                StudentId INTEGER NOT NULL,
                CourseId INTEGER NOT NULL,
                FOREIGN KEY (StudentId) REFERENCES Students (Id),
                FOREIGN KEY (CourseId) REFERENCES Courses (Id),
                UNIQUE(StudentId, CourseId) -- To prevent duplicate enrollments
            );

            CREATE TABLE IF NOT EXISTS StudentCourseRelations (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                StudentId INTEGER NOT NULL,
                CourseId INTEGER NOT NULL,
                FOREIGN KEY (StudentId) REFERENCES Students (Id) ON DELETE CASCADE,
                FOREIGN KEY (CourseId) REFERENCES Courses (Id) ON DELETE CASCADE
            );";



            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    #region Student Management
    public static void AddStudent(string firstName, string lastName)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = "INSERT INTO Students (FirstName, LastName) VALUES (@FirstName, @LastName);";
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);

                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
    public static void RemoveStudent(int studentId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = "DELETE FROM Students WHERE Id = @StudentId;";
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
    public static string GetStudentNameById(int studentId)
    {
        string sql = "SELECT FirstName || ' ' || LastName AS FullName FROM Students WHERE Id = @StudentId";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentId);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return "";
                }
            }
        }
    }
    public static DataTable GetStudentsByCourseId(int courseId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = @"
            SELECT Students.*
            FROM Students
            JOIN StudentCourseRelations ON Students.Id = StudentCourseRelations.StudentId
            WHERE StudentCourseRelations.CourseId = @CourseId;";

            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@CourseId", courseId);
                DataTable studentsTable = new DataTable();
                adapter.Fill(studentsTable);

                connection.Close();

                return studentsTable;
            }
        }
    }

    public static DataTable GetStudentGrades(int studentId, int courseId)
    {
        try
        {
            string sql = @"
        SELECT A.Name AS AssignmentName, G.Grade
        FROM Assignments A
        LEFT JOIN Grades G ON A.Id = G.AssignmentId AND G.StudentId = @StudentId
        WHERE A.CourseId = @CourseId";

            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@StudentId", studentId);
                    adapter.SelectCommand.Parameters.AddWithValue("@CourseId", courseId);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while retrieving the student grades: {ex.Message}");
            return null; // or return an empty DataTable or throw the exception
        }
    }




    public static DataTable GetAllStudents()
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = "SELECT * FROM Students;";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
            {
                DataTable studentsTable = new DataTable();
                adapter.Fill(studentsTable);

                connection.Close();

                return studentsTable;
            }
        }
    }

    #endregion

    #region Course Management
    public static void AddCourse(string courseName)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = "INSERT INTO Courses (Name) VALUES (@CourseName);";
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@CourseName", courseName);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public static void RemoveCourse(int courseId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = "DELETE FROM Courses WHERE Id = @CourseId;";
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@CourseId", courseId);
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
    public static DataTable GetAllCourses()
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = "SELECT * FROM Courses;";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection))
            {
                DataTable coursesTable = new DataTable();
                adapter.Fill(coursesTable);

                connection.Close();

                return coursesTable;
            }
        }
    }

    #endregion

    #region Individual Course Management
    public static bool AddStudentToCourse(int studentId, int courseId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = @"
        INSERT INTO StudentCourseRelations (StudentId, CourseId)
        VALUES (@StudentId, @CourseId);";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@CourseId", courseId);

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }
        }
    }

    public static bool RemoveStudentFromCourse(int studentId, int courseId)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();

            string sql = @"
        DELETE FROM StudentCourseRelations
        WHERE StudentId = @StudentId AND CourseId = @CourseId;";

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@CourseId", courseId);

                int rowsAffected = command.ExecuteNonQuery();
                connection.Close();

                return rowsAffected > 0;
            }
        }
    }

    public static string GetCourseNameById(int courseId)
    {
        string sql = "SELECT Name FROM Courses WHERE Id = @CourseId";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@CourseId", courseId);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return "";
                }
            }
        }
    }

    #endregion

    #region Grades and Assignments

    public static bool AddGrade(int studentId, int assignmentId, double grade)
    {
        try
        {
            string sql = "INSERT INTO Grades (StudentId, AssignmentId, Grade) VALUES (@StudentId, @AssignmentId, @Grade)";
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@AssignmentId", assignmentId);
                    command.Parameters.AddWithValue("@Grade", grade);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while adding the grade: {ex.Message}");
            return false;
        }
    }

    public static int AddAssignment(string name, int courseId, string type)
    {
        try
        {
            string sql = @"INSERT INTO Assignments (Name, CourseId, Type) VALUES (@Name, @CourseId, @Type);
                   SELECT last_insert_rowid();";
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={DatabaseFilePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    command.Parameters.AddWithValue("@Type", type);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while adding the assignment: {ex.Message}");
            return -1;
        }
    }



    #endregion
}
