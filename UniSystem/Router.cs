using System.Runtime.CompilerServices;
using UniSystem.Controls;
using UniSystem.Controls.News;
using UniSystem.Controls.Profile;

namespace UniSystem
{
    static class Router
    {
        private static Dictionary<string, UserControl> routes = new Dictionary<string, UserControl>
        {
            { "home", new StudentsControl() },
            { "add", new AddStudentControl() },
            { "news", new NewsControl() },
            { "news/add", new AddNewsControl() },
            { "profile", new ProfileControl() },
            { "grades", new StudentsControl() },
            { "students", new StudentsControl() }
        };

        public static MainForm MainForm { get; private set; }

        static Router()
        {
            GenerateRoutesForNews();

            ((AddStudentControl)routes["add"]).ButtonAddStudent.Click += (s, args) 
                => ((StudentsControl)routes["home"]).RefreshTable();

            ((AddNewsControl)routes["news/add"]).ButtonAddNews.Click += (s, args) =>
            {
                ((NewsControl)routes["news"]).ShowNews();
                GetPanelFromRoute("news/add").Navigate("news");
            };
        }

        public static void Navigate(this Panel panel, string route)
        {
            panel.Controls.Clear();
            panel.Controls.Add(routes[route]);
        }

        public static void AddRoute(string route, UserControl userControl)
        {
            routes.Add(route, userControl);
        }

        private static Panel GetPanelFromRoute(string route)
        {
            UserControl control = routes[route];
            return control.Parent as Panel;
        }

        private static void GenerateRoutesForNews()
        {
            var news = Program.NewsService.GetNews();
            foreach (var post in news)
            {
                AddRoute($"news/{post.Id}", new NewsDetailControl
                {
                    News = post
                });
            }
        }
    }
}
