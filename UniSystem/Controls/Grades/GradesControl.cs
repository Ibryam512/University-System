namespace UniSystem.Controls.Grades
{
    public partial class GradesControl : UserControl
    {
        int y = 70;

        public GradesControl()
        {
            InitializeComponent();
            LoadGrades();

        }

        public void LoadGrades()
        {
            this.Controls.Clear();
            y = 70;
            var grades = Program.GradeService.GetGrades(LoggedUser.Id);

            foreach (var grade in grades)
            {
                Panel panelGrade = new Panel();
                Label labelGrade = new Label();
                Label labelDate = new Label();
                Label labelSubject = new Label();

                panelGrade.BackColor = Color.White;
                panelGrade.Controls.Add(labelGrade);
                panelGrade.Controls.Add(labelDate);
                panelGrade.Controls.Add(labelSubject);
                panelGrade.Location = new Point(224, y);
                panelGrade.Size = new Size(1057, 64);
                panelGrade.TabIndex = 0;

                labelGrade.AutoSize = true;
                labelGrade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelGrade.Location = new Point(961, 16);
                labelGrade.Size = new Size(58, 32);
                labelGrade.TabIndex = 1;
                labelGrade.Text = grade.Value.ToString("f2");

                labelDate.AutoSize = true;
                labelDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelDate.Location = new Point(37, 16);
                labelDate.Size = new Size(65, 32);
                labelDate.TabIndex = 1;
                labelDate.Text = grade.CreationDate.ToString("dd/MM/yyyy");

                labelSubject.AutoSize = true;
                labelSubject.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelSubject.Location = new Point(487, 16);
                labelSubject.Size = new Size(111, 32);
                labelSubject.TabIndex = 0;
                labelSubject.Text = grade.Subject;

                this.Controls.Add(panelGrade);
                y += 100;
            }
        }

        private void GradesControl_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }
    }
}
