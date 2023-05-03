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
            try
            {
                //Service.AuthService.Login(loginDTO);
                ((Form)this.TopLevelControl).Hide();
                var mainForm = new MainForm();
                mainForm.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
                mainForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
