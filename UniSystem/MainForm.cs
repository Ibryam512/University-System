namespace UniSystem
{
    public partial class MainForm : Form
    {
        public Panel MainPanel { get => this.panelMain; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void navigationButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string route = button.Name.Replace("button", "").ToLower();
            panelMain.Navigate(route);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonGradesAndStudents.Name = LoggedUser.Role == Common.Role.Student ? "buttonGrades" : "buttonStudents";
            buttonGradesAndStudents.Text = LoggedUser.Role == Common.Role.Student ? "Оценки" : "Студенти";
        }
    }
}