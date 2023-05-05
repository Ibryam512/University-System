using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniSystem.Data;
using UniSystem.Data.Entities;
using UniSystem.Models;

namespace UniSystem.Services
{
    public class NewsService
    {
        private readonly UniSystemDbContext _context;

        public NewsService(UniSystemDbContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<News> GetNews() => this._context.News.ToList().OrderByDescending(x => x.CreationDate).ToList();

        public News GetNews(int id) => this._context.News.SingleOrDefault(x => x.Id == id);

        public void AddNews(NewsBindingModel newsBindingModel)
        {
            var news = new News
            {
                Title = newsBindingModel.Title,
                Content = newsBindingModel.Content
            };

            this._context.News.Add(news);
        }
    }
}
