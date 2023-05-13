namespace UniSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNews = new Button();
            buttonProfile = new Button();
            buttonGradesAndStudents = new Button();
            panelMain = new Panel();
            SuspendLayout();
            // 
            // buttonNews
            // 
            buttonNews.Anchor = AnchorStyles.None;
            buttonNews.BackColor = SystemColors.HotTrack;
            buttonNews.FlatAppearance.BorderSize = 0;
            buttonNews.FlatStyle = FlatStyle.Flat;
            buttonNews.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNews.Location = new Point(0, 0);
            buttonNews.Margin = new Padding(2);
            buttonNews.Name = "buttonNews";
            buttonNews.Size = new Size(493, 56);
            buttonNews.TabIndex = 0;
            buttonNews.Text = "Новини";
            buttonNews.UseVisualStyleBackColor = false;
            buttonNews.Click += navigationButtonClick;
            // 
            // buttonProfile
            // 
            buttonProfile.Anchor = AnchorStyles.None;
            buttonProfile.BackColor = SystemColors.HotTrack;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProfile.Location = new Point(969, 0);
            buttonProfile.Margin = new Padding(2);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(493, 56);
            buttonProfile.TabIndex = 1;
            buttonProfile.Text = "Профил";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += navigationButtonClick;
            // 
            // buttonGradesAndStudents
            // 
            buttonGradesAndStudents.Anchor = AnchorStyles.None;
            buttonGradesAndStudents.BackColor = SystemColors.HotTrack;
            buttonGradesAndStudents.FlatAppearance.BorderSize = 0;
            buttonGradesAndStudents.FlatStyle = FlatStyle.Flat;
            buttonGradesAndStudents.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGradesAndStudents.Location = new Point(486, 0);
            buttonGradesAndStudents.Margin = new Padding(2);
            buttonGradesAndStudents.Name = "buttonGradesAndStudents";
            buttonGradesAndStudents.Size = new Size(493, 56);
            buttonGradesAndStudents.TabIndex = 2;
            buttonGradesAndStudents.Text = "Оценки";
            buttonGradesAndStudents.UseVisualStyleBackColor = false;
            buttonGradesAndStudents.Click += navigationButtonClick;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 56);
            panelMain.Margin = new Padding(2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1461, 607);
            panelMain.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 664);
            Controls.Add(buttonGradesAndStudents);
            Controls.Add(panelMain);
            Controls.Add(buttonProfile);
            Controls.Add(buttonNews);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Университетска система";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNews;
        private Button buttonProfile;
        private Button buttonGradesAndStudents;
        private Panel panelMain;
    }
}