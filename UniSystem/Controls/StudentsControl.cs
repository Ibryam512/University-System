namespace UniSystem.Controls
{
    public partial class StudentsControl : UserControl
    {
        public StudentsControl()
        {
            InitializeComponent();
            RefreshTable();
        }

        public void RefreshTable()
        {
            var students = Program.StudentService.GetStudents();

            foreach (var student in students)
            {
                dataGridViewStudents.Rows.Add(student.FacultyNumber, student.FirstName, student.LastName, $"{student.AverageGrade:f2}");
            }
        }
    }
}
