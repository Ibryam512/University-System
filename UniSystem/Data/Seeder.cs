using System.Runtime.CompilerServices;
using UniSystem.Data.Entities;
using UniSystem.Models;

namespace UniSystem.Data
{
    public static class Seeder
    {
        public static void Seed(UniSystemDbContext context)
        {
            AddAdmins(context);
            AddStudents(context);

        }

        private static void AddAdmins(UniSystemDbContext context)
        {
            if (context.Admins.Count == 0)
            {
                context.Admins.Add(new Admin
                {
                    FirstName = "root",
                    LastName = "root",
                    Position = "admin"
                });

                context.Users.Add(new User
                {
                    Email = "root",
                    Password = "root",
                    Role = Common.Role.Admin,
                    ProfileId = 1
                });
            }
        }

        private static void AddStudents(UniSystemDbContext context)
        {
            if (context.Students.Count == 0)
            {
                Program.StudentService.AddStudent(new StudentBindingModel
                {
                    FacultyNumber = "2201681062",
                    EGN = "0000000000",
                    FirstName = "Ибрям",
                    LastName = "Ибрямов",
                    MobileNumber = "+359898989898",
                    IsMale = true,
                    Grades = new Dictionary<string, double>
                    {
                        { "Увод в програмирането", 6},
                        { "Увод в уеб програмирането", 6 },
                        { "Линейна алгебра и аналитична геометрия", 6}
                    }
                }); ;
            }  
        }
    }
}
