namespace UniSystem
{
    public partial class MainForm : Form
    {
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
    }
}