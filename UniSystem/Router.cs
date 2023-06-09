﻿using UniSystem.Controls;
using UniSystem.Controls.Grades;
using UniSystem.Controls.News;
using UniSystem.Controls.Profile;
using UniSystem.Controls.Students;
using UniSystem.Models;

namespace UniSystem
{
    static class Router
    {
        private static Dictionary<string, UserControl> routes = new Dictionary<string, UserControl>
        {
            { "add", new AddStudentControl() },
            { "news", new NewsControl() },
            { "news/add", new AddNewsControl() },
            { "profile", new ProfileControl() },
            { "grades", new GradesControl() },
            { "students", new StudentsControl() }
        };

        static Router()
        {
            GenerateRoutesForStudents();
            GenerateRoutesForNews();

            ((AddStudentControl)routes["add"]).ButtonAddStudent.Click += (s, args) =>
            {
                ((StudentsControl)routes["students"]).RefreshTable();
                GetPanelFromRoute("add").Navigate("students");
                Router.RefreshRoute("add", new AddStudentControl());
            };

            ((AddNewsControl)routes["news/add"]).ButtonAddNews.Click += (s, args) =>
            {
                ((NewsControl)routes["news"]).ShowNews();
                GetPanelFromRoute("news/add").Navigate("news");
                RefreshRoute("news/add", new AddNewsControl());
            };
        }

        public static void Navigate(this Panel panel, string route)
        {
            panel.Controls.Clear();
            panel.Controls.Add(routes[route]);
        }

        public static void AddRoute(string route, UserControl userControl, string facultyNumber = "")
        {
            if (!routes.ContainsKey(route))
                routes.Add(route, userControl);

            if (userControl is EditStudentControl)
            {
                ((EditStudentControl)routes[route]).ButtonEditStudent.Click += (s, args) =>
                {
                    ((StudentsControl)routes["students"]).RefreshTable();
                    GetPanelFromRoute(route).Navigate("students");
                    RefreshRoute($"students/{facultyNumber}", new StudentDetailsControl(facultyNumber));
                };
            }
        }

        public static void RemoveRoute(string key)
        {
            routes.Remove(key);
        }

        public static void RefreshRoute(string key, UserControl userControl)
        {
            RemoveRoute(key);
            AddRoute(key, userControl);

            if (userControl is AddStudentControl)
            {
                ((AddStudentControl)routes["add"]).ButtonAddStudent.Click += (s, args) =>
                {
                    ((StudentsControl)routes["students"]).RefreshTable();
                    GetPanelFromRoute("add").Navigate("students");
                    Router.RefreshRoute("add", new AddStudentControl());
                };
            }

            if (userControl is AddNewsControl)
            {
                ((AddNewsControl)routes["news/add"]).ButtonAddNews.Click += (s, args) =>
                {
                    ((NewsControl)routes["news"]).ShowNews();
                    GetPanelFromRoute("news/add").Navigate("news");
                    RefreshRoute("news/add", new AddNewsControl());
                };
            }
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

        private static void GenerateRoutesForStudents()
        {
            var students = Program.StudentService.GetStudents();
            foreach (var student in students)
            {
                if (!routes.ContainsKey($"students/{student.FacultyNumber}"))
                    AddRoute($"students/{student.FacultyNumber}", new StudentDetailsControl(student.FacultyNumber));

                if (!routes.ContainsKey($"edit/{student.FacultyNumber}"))
                {
                    AddRoute($"edit/{student.FacultyNumber}", new EditStudentControl(new Models.StudentBindingModel
                    {
                        Id = student.Id,
                        FacultyNumber = student.FacultyNumber,
                        EGN = student.EGN,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        Class = student.Class,
                        MobileNumber = student.MobileNumber,
                        IsMale = student.Gender == Common.Gender.Male
                    }));
                }
            }
        }
    }
}