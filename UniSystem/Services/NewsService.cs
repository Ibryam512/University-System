using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UniSystem.Controls.News;
using UniSystem.Data;
using UniSystem.Data.Entities;
using UniSystem.Models;

namespace UniSystem.Services
{
    public class NewsService
    {
        private readonly UniSystemDbContext context;

        public NewsService(UniSystemDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<News> GetNews() => this.context.News.ToList().OrderByDescending(x => x.CreationDate).ToList();

        public News GetNews(int id) => this.context.News.SingleOrDefault(x => x.Id == id);

        public void AddNews(NewsBindingModel newsBindingModel)
        {
            var news = new News
            {
                Title = newsBindingModel.Title,
                Content = newsBindingModel.Content
            };

            this.context.News.Add(news);
            Router.AddRoute($"news/{news.Id}", new NewsDetailControl
            {
                News = news
            });
        }
    }
}
