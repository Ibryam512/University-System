using UniSystem.Controls;
using UniSystem.Controls.News;

namespace UniSystem
{
    static class Router
    {
        private static Dictionary<string, UserControl> routes = new Dictionary<string, UserControl>
        {
            { "home", new StudentsControl() },
            { "add", new AddStudentControl() },
            { "news", new NewsControl() },
            { "profile", new StudentsControl() },
            { "grades", new StudentsControl() },
            { "scholarships", new StudentsControl() }
        };

        static Router()
        {
            ((AddStudentControl)routes["add"]).ButtonAddStudent.Click += (s, args) 
                => ((StudentsControl)routes["home"]).RefreshTable();
        }

        public static void Navigate(this Panel panel, string route)
        {
            panel.Controls.Clear();
            panel.Controls.Add(routes[route]);
        }
    }
}
