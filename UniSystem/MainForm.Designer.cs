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
            buttonGrades = new Button();
            buttonScholarships = new Button();
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
            buttonNews.Size = new Size(370, 56);
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
            buttonProfile.Location = new Point(370, 0);
            buttonProfile.Margin = new Padding(2);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(370, 56);
            buttonProfile.TabIndex = 1;
            buttonProfile.Text = "Профил";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += navigationButtonClick;
            // 
            // buttonGrades
            // 
            buttonGrades.Anchor = AnchorStyles.None;
            buttonGrades.BackColor = SystemColors.HotTrack;
            buttonGrades.FlatAppearance.BorderSize = 0;
            buttonGrades.FlatStyle = FlatStyle.Flat;
            buttonGrades.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGrades.Location = new Point(740, 0);
            buttonGrades.Margin = new Padding(2);
            buttonGrades.Name = "buttonGrades";
            buttonGrades.Size = new Size(370, 56);
            buttonGrades.TabIndex = 2;
            buttonGrades.Text = "Оценки";
            buttonGrades.UseVisualStyleBackColor = false;
            buttonGrades.Click += navigationButtonClick;
            // 
            // buttonScholarships
            // 
            buttonScholarships.Anchor = AnchorStyles.None;
            buttonScholarships.AutoSize = true;
            buttonScholarships.BackColor = SystemColors.HotTrack;
            buttonScholarships.FlatAppearance.BorderSize = 0;
            buttonScholarships.FlatStyle = FlatStyle.Flat;
            buttonScholarships.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonScholarships.Location = new Point(1110, 0);
            buttonScholarships.Margin = new Padding(2);
            buttonScholarships.Name = "buttonScholarships";
            buttonScholarships.Size = new Size(370, 56);
            buttonScholarships.TabIndex = 3;
            buttonScholarships.Text = "Стипендии";
            buttonScholarships.UseVisualStyleBackColor = false;
            buttonScholarships.Click += navigationButtonClick;
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
            Controls.Add(buttonScholarships);
            Controls.Add(panelMain);
            Controls.Add(buttonGrades);
            Controls.Add(buttonProfile);
            Controls.Add(buttonNews);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNews;
        private Button buttonProfile;
        private Button buttonGrades;
        private Button buttonScholarships;
        private Panel panelMain;
    }
}