namespace UniSystem.Controls.News
{
    public partial class NewsDetailControl : UserControl
    {
        public Data.Entities.News News { get; set; }
        public NewsDetailControl()
        {
            InitializeComponent();
        }

        private void NewsDetail_Load(object sender, EventArgs e)
        {
            labelTitle.Text = News.Title;
            labelContent.Text = News.Content;
            labelDate.Text = $"Качена на: {News.CreationDate.ToString("dd/MM/yyyy")}";
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Navigate("news");
        }
    }
}
