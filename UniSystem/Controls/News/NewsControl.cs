﻿namespace UniSystem.Controls.News
{
    public partial class NewsControl : UserControl
    {
        public NewsControl()
        {
            InitializeComponent();
            buttonAddNews.Visible = LoggedUser.Role == Common.Role.Admin;
            ShowNews();
        }

        public void ShowNews()
        {
            this.Controls.Clear();
            this.Controls.Add(buttonAddNews);

            var news = Program.NewsService.GetNews();

            if (news.Count == 0)
            {
                Label label = new Label();
                label.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
                label.Location = new Point(651, 15);
                label.Size = new Size(184, 37);
                label.TabIndex = 1;
                label.Text = "Няма новини";
                this.Controls.Add(label);
            }
            else
            {
                int y = 40;
                foreach (var post in news)
                {
                    Panel panel = new Panel();
                    LinkLabel linkLabel = new LinkLabel();
                    Label title = new Label();
                    Label date = new Label();

                    panel.BackColor = Color.White;
                    panel.Controls.Add(linkLabel);
                    panel.Controls.Add(title);
                    panel.Controls.Add(date);
                    panel.Location = new Point(33, y);
                    panel.Size = new Size(1386, 76);
                    panel.TabIndex = 0;

                    linkLabel.AutoSize = true;
                    linkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                    linkLabel.Location = new Point(1237, 23);
                    linkLabel.Name = $"linkLabel{post.Id}";
                    linkLabel.Size = new Size(134, 28);
                    linkLabel.TabIndex = 2;
                    linkLabel.TabStop = true;
                    linkLabel.Text = "Прочети още";
                    linkLabel.Click += (s, args) => ((Panel)this.Parent).Navigate($"news/{post.Id}");

                    date.AutoSize = true;
                    date.Location = new Point(18, 42);
                    date.Size = new Size(201, 20);
                    date.TabIndex = 1;
                    date.Text = $"Публикувана на {post.CreationDate.ToString("dd/MM/yyyy")}";

                    title.AutoSize = true;
                    title.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
                    title.Location = new Point(14, 5);
                    title.Size = new Size(264, 37);
                    title.TabIndex = 0;
                    title.Text = post.Title;

                    y += 100;
                    buttonAddNews.Location = new Point(618, y);
                    this.Controls.Add(panel);
                }
            }
        }

        private void buttonAddNews_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Navigate("news/add");
        }
    }
}
