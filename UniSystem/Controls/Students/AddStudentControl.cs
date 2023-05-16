using UniSystem.Models;

namespace UniSystem.Controls
{
    public partial class AddStudentControl : UserControl
    {
        private int x = 356, y = 45;
        private StudentBindingModel studentBindingModel;

        public Button ButtonAddStudent { get => buttonAddStudent; }

        public AddStudentControl(bool edit = false)
        {
            InitializeComponent();
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

        private void AddStudentControl_Load(object sender, EventArgs e)
        {
            studentBindingModel = new StudentBindingModel();

            textBoxFacultyNumber.DataBindings.Add(new Binding("Text", studentBindingModel, "FacultyNumber"));
            textBoxClass.DataBindings.Add(new Binding("Text", studentBindingModel, "Class"));
            textBoxEGN.DataBindings.Add(new Binding("Text", studentBindingModel, "EGN"));
            textBoxFirstName.DataBindings.Add(new Binding("Text", studentBindingModel, "FirstName"));
            textBoxLastName.DataBindings.Add(new Binding("Text", studentBindingModel, "LastName"));
            textBoxMobileNumber.DataBindings.Add(new Binding("Text", studentBindingModel, "MobileNumber"));
            radioButtonMale.DataBindings.Add(new Binding("Checked", studentBindingModel, "IsMale"));
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (studentBindingModel.Grades == null || studentBindingModel.Grades.Count == 0)
            {
                studentBindingModel.Grades.Add("", 0);
            }

            Program.StudentService.AddStudent(studentBindingModel);
        }
    }
}
