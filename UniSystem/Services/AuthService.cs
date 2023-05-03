using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UniSystem.Data;
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

            if (user.Password != login.Password)
                throw new ArgumentException("The email or password are wrong.");

            LoggedUser.Email = user.Email;
            LoggedUser.Role = user.Role;
        }
    }
}
