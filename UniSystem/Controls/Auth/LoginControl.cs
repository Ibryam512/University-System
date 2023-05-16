using System;
using System.Windows.Forms;
using UniSystem.Models;

namespace UniSystem.Controls
{
    public partial class LoginControl : UserControl
    {
        private LoginBindingModel loginBindingModel;
        public LoginControl()
        {
            InitializeComponent();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            loginBindingModel = new LoginBindingModel();

            textBoxEmail.DataBindings.Add(new Binding("Text", loginBindingModel, "Email"));
            textBoxPassword.DataBindings.Add(new Binding("Text", loginBindingModel, "Password"));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool textBoxEmailValidated = textBoxEmail.Validate();
            bool textBoxPasswordValidated = textBoxPassword.Validate();

            if (!textBoxEmailValidated)
                return;

            if (!textBoxPasswordValidated)
                return;

            try
            {
                Program.AuthService.Login(loginBindingModel);
                ((Form)this.TopLevelControl).Hide();
                var mainForm = new MainForm();

                mainForm.Closed += (s, args) =>
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

                mainForm.Show();
                mainForm.MainPanel.Navigate("news");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("За вход на студенти имейлът е stu{фак. номер}@uni.bg, а паролата е ЕГН.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
