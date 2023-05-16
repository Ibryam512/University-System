namespace UniSystem.Controls
{
    partial class LoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            labelLoginLink = new Label();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(108, 99, 255);
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Tahoma", 36F, FontStyle.Regular, GraphicsUnit.Pixel);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(98, 463);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(321, 68);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Tahoma", 32F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxPassword.Location = new Point(42, 339);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Парола";
            textBoxPassword.Size = new Size(435, 46);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Tahoma", 32F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxEmail.Location = new Point(42, 237);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Имейл";
            textBoxEmail.Size = new Size(435, 46);
            textBoxEmail.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(170, 103);
            label1.Name = "label1";
            label1.Size = new Size(177, 59);
            label1.TabIndex = 4;
            label1.Text = "В х о д";
            // 
            // labelLoginLink
            // 
            labelLoginLink.AutoSize = true;
            labelLoginLink.BackColor = Color.Transparent;
            labelLoginLink.Enabled = false;
            labelLoginLink.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelLoginLink.ForeColor = Color.FromArgb(68, 173, 232);
            labelLoginLink.Location = new Point(73, 600);
            labelLoginLink.Name = "labelLoginLink";
            labelLoginLink.Size = new Size(380, 30);
            labelLoginLink.TabIndex = 8;
            labelLoginLink.Text = "Нямаш акаунт? Регистрирай се!";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(410, 14);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 29);
            buttonHelp.TabIndex = 9;
            buttonHelp.Text = "Помощ";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 217, 217);
            Controls.Add(buttonHelp);
            Controls.Add(labelLoginLink);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(label1);
            Name = "LoginControl";
            Size = new Size(518, 678);
            Load += LoginControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private Label labelLoginLink;
        private Button buttonHelp;
    }
}
