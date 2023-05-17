namespace UniSystem
{
    public partial class AddSubjectForm : Form
    {
        public string Subject { get; set; }
        public double Grade { get; set; } = 2;

        public AddSubjectForm()
        {
            InitializeComponent();
            textBoxSubject.DataBindings.Add(new Binding("Text", this, "Subject"));
            numericUpDownGrade.DataBindings.Add(new Binding("Value", this, "Grade"));
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
