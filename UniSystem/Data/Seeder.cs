using UniSystem.Data.Entities;

namespace UniSystem.Data
{
    public static class Seeder
    {
        public static void Seed(UniSystemDbContext context) 
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
    }
}
