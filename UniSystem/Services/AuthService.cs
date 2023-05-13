using UniSystem.Data;
using UniSystem.Data.Entities;
using UniSystem.Models;

namespace UniSystem.Services
{
    public class AuthService
    {
        private readonly UniSystemDbContext context;

        public AuthService(UniSystemDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Login(LoginBindingModel login)
        {
            var user = this.context.Users.SingleOrDefault(x => x.Email == login.Email);

            if (user == null || user.Password != login.Password)
                throw new ArgumentException("The email or password are wrong.");

            LoggedUser.Id = user.ProfileId;
            LoggedUser.Email = user.Email;
            LoggedUser.Role = user.Role;
            LoggedUser.Position = (user.Role == Common.Role.Student)
                ? "Студент"
                : this.context.Admins.SingleOrDefault(x => x.Id == user.ProfileId).Position;
            LoggedUser.Name = (user.Role == Common.Role.Student)
                ? this.context.Students.SingleOrDefault(x => x.Id == user.ProfileId).FullName()
                : this.context.Admins.SingleOrDefault(x => x.Id == user.ProfileId).FullName();
        }

        public void AddStudentAccount(Student student)
        {
            var user = new User
            {
                Email = $"stu{student.FacultyNumber}@uni.bg",
                Password = student.EGN,
                Role = Common.Role.Student,
                ProfileId = student.Id
            };

            this.context.Users.Add(user);
        }
    }
}
