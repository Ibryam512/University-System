namespace UniSystem.Controls.Students
{
    public partial class StudentDetailsControl : UserControl
    {
        private string facultyNumber;
        private int x = 356, y = 45;
        private bool areGradesVisible = false;

        public StudentDetailsControl(string facultyNumber)
        {
            InitializeComponent();
            this.facultyNumber = facultyNumber;
        }

        private void StudentDetailsControl_Load(object sender, EventArgs e)
        {
            var student = Program.StudentService.GetStudent(x => x.FacultyNumber == facultyNumber);

            labelName.Text = "Име: " + student.FullName();
            labelGender.Text = "Пол: " + (student.Gender == Common.Gender.Male ? "Мъж" : "Жена");
            labelMobileNumber.Text = "Мобилен номер: " + student.MobileNumber;
            labelEGN.Text = "ЕГН: " + student.EGN;
            labelAverageGrade.Text = "Среден успех: " + student.AverageGrade.ToString("f2");
            labelClass.Text = "Специалност: " + student.Class;
            labelFacultyNumber.Text = "Факултетен номер: " + student.FacultyNumber;

            var grades = Program.GradeService.GetGrades(student.Id);
            foreach (var grade in grades)
            {
                Label labelSubject = new Label();
                labelSubject.Text = $"{grade.Subject} - {grade.Value:f2}";
                labelSubject.Size = new Size(426, 34);
                labelSubject.TextAlign = ContentAlignment.MiddleCenter;
                labelSubject.Location = new Point(x - 127, y);
                y += 50;
                panelGrades.Controls.Add(labelSubject);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Navigate("students");
        }

        private void buttonVisibleGrades_Click(object sender, EventArgs e)
        {
            areGradesVisible = !areGradesVisible;
            groupBoxGrades.Visible = areGradesVisible;
            buttonVisibleGrades.Text = areGradesVisible ? "Скрий оценки" : "Покажи оценки";
        }
    }
}
