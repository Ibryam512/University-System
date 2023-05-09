using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                labelAverageGrade.Text = "Среден успех: " + student.AverageGrade;
                labelClass.Text = "Специалност: " + student.Class;
                labelFacultyNumber.Text = "Факултетен номер: " + student.FacultyNumber;
            }
        }
    }
}
