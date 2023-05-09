using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSystem.Models;

namespace UniSystem.Controls.News
{
    public partial class AddNewsControl : UserControl
    {
        private NewsBindingModel newsBindingModel;

        public Button ButtonAddNews { get => this.buttonAdd; }

        public AddNewsControl()
        {
            InitializeComponent();
        }

        private void AddNewsControl_Load(object sender, EventArgs e)
        {
            this.newsBindingModel = new NewsBindingModel();
            textBoxTitle.DataBindings.Add(new Binding("Text", newsBindingModel, "Title"));
            textBoxContent.DataBindings.Add(new Binding("Text", newsBindingModel, "Content"));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Program.NewsService.AddNews(this.newsBindingModel);
        }
    }
}
