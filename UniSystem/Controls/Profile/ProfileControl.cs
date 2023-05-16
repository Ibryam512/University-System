using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniSystem.Common;
using UniSystem.Controls.Grades;

namespace UniSystem.Controls.Profile
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private void ProfileControl_Load(object sender, EventArgs e)
        {
            if (LoggedUser.Role == Common.Role.Admin)
            {
                labelName.Text = "Име: " + LoggedUser.Name;
                labelGender.Text = "Позиция: " + LoggedUser.Position;
                labelMobileNumber.Text = "Имейл: " + LoggedUser.Email;
                labelAverageGrade.Text = "Среден успех: n/a";
                labelClass.Text = "Специалност: n/a";
                labelFacultyNumber.Text = "Факултетен номер: n/a";
            }
            else
            {
                var student = Program.StudentService.GetStudent(x => x.Id == LoggedUser.Id);

                labelName.Text = "Име: " + LoggedUser.Name;
                labelGender.Text = "Пол: " + (student.Gender == Common.Gender.Male ? "Мъж" : "Жена");
                labelMobileNumber.Text = "Мобилен номер: " + student.MobileNumber;
                labelAverageGrade.Text = "Среден успех: " + student.AverageGrade.ToString("f2");
                labelClass.Text = "Специалност: " + student.Class;
                labelFacultyNumber.Text = "Факултетен номер: " + student.FacultyNumber;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {   
            ((Form)this.TopLevelControl).Hide();
            AuthForm authForm = new AuthForm();

            authForm.Closed += (s, args) =>
            {
                try
                {
                    ((Form)this.TopLevelControl).Close();
                }
                catch (StackOverflowException)
                {
                    Environment.Exit(0);
                }
            };

            Router.RemoveRoute("profile");
            Router.AddRoute("profile", new ProfileControl());

            Router.RemoveRoute("grades");
            Router.AddRoute("grades", new GradesControl());

            authForm.Show();
        }
    }
}
