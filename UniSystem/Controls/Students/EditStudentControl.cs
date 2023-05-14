using UniSystem.Models;

namespace UniSystem.Controls.Students
{
    public partial class EditStudentControl : UserControl
    {
        private StudentBindingModel studentBindingModel;
        private int x = 356, y = 45;

        public Button ButtonEditStudent { get => buttonEditStudent; }

        public EditStudentControl(StudentBindingModel studentBindingModel)
        {
            InitializeComponent();
            this.studentBindingModel = studentBindingModel;
        }

        private void EditStudentControl_Load(object sender, EventArgs e)
        {
            textBoxFacultyNumber.DataBindings.Add(new Binding("Text", studentBindingModel, "FacultyNumber"));
            textBoxClass.DataBindings.Add(new Binding("Text", studentBindingModel, "Class"));
            textBoxEGN.DataBindings.Add(new Binding("Text", studentBindingModel, "EGN"));
            textBoxFirstName.DataBindings.Add(new Binding("Text", studentBindingModel, "FirstName"));
            textBoxLastName.DataBindings.Add(new Binding("Text", studentBindingModel, "LastName"));
            textBoxMobileNumber.DataBindings.Add(new Binding("Text", studentBindingModel, "MobileNumber"));
            radioButtonMale.DataBindings.Add(new Binding("Checked", studentBindingModel, "IsMale"));

            var grades = Program.GradeService.GetGrades(studentBindingModel.Id);
            foreach (var grade in grades)
            {
                Label labelSubject = new Label();
                labelSubject.Text = $"{grade.Subject} - {grade.Value:f2}";
                labelSubject.Size = new Size(426, 34);
                labelSubject.TextAlign = ContentAlignment.MiddleCenter;
                labelSubject.Location = new Point(x - 127, y);
                y += 50;
                buttonAddSubject.Location = new Point(x, y);
                panelGrades.Controls.Add(labelSubject);
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            Program.StudentService.EditStudent(studentBindingModel);
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            var addSubjectForm = new AddSubjectForm();
            if (addSubjectForm.ShowDialog() == DialogResult.OK)
            {
                Label labelSubject = new Label();
                labelSubject.Text = $"{addSubjectForm.Subject} - {addSubjectForm.Grade:f2}";
                labelSubject.Size = new Size(426, 34);
                labelSubject.TextAlign = ContentAlignment.MiddleCenter;
                labelSubject.Location = new Point(x - 127, y);
                y += 50;
                buttonAddSubject.Location = new Point(x, y);
                panelGrades.Controls.Add(labelSubject);
                studentBindingModel.Grades.Add(addSubjectForm.Subject, addSubjectForm.Grade);
            }
        }
    }
}
