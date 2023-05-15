namespace UniSystem.Controls.Students
{
    partial class StudentDetailsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetailsControl));
            labelMobileNumber = new Label();
            labelGender = new Label();
            labelAverageGrade = new Label();
            labelFacultyNumber = new Label();
            labelClass = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            labelEGN = new Label();
            buttonBack = new Button();
            groupBoxGrades = new GroupBox();
            panelGrades = new Panel();
            buttonVisibleGrades = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxGrades.SuspendLayout();
            SuspendLayout();
            // 
            // labelMobileNumber
            // 
            labelMobileNumber.AutoSize = true;
            labelMobileNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMobileNumber.Location = new Point(38, 361);
            labelMobileNumber.Name = "labelMobileNumber";
            labelMobileNumber.Size = new Size(251, 41);
            labelMobileNumber.TabIndex = 13;
            labelMobileNumber.Text = "Мобилен номер:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelGender.Location = new Point(287, 195);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(80, 41);
            labelGender.TabIndex = 12;
            labelGender.Text = "Пол:";
            // 
            // labelAverageGrade
            // 
            labelAverageGrade.AutoSize = true;
            labelAverageGrade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAverageGrade.Location = new Point(287, 105);
            labelAverageGrade.Name = "labelAverageGrade";
            labelAverageGrade.Size = new Size(211, 41);
            labelAverageGrade.TabIndex = 11;
            labelAverageGrade.Text = "Среден успех:";
            // 
            // labelFacultyNumber
            // 
            labelFacultyNumber.AutoSize = true;
            labelFacultyNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelFacultyNumber.Location = new Point(38, 513);
            labelFacultyNumber.Name = "labelFacultyNumber";
            labelFacultyNumber.Size = new Size(279, 41);
            labelFacultyNumber.TabIndex = 10;
            labelFacultyNumber.Text = "Факултетен номер:";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelClass.Location = new Point(38, 437);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(204, 41);
            labelClass.TabIndex = 9;
            labelClass.Text = "Специалност:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(287, 34);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 41);
            labelName.TabIndex = 8;
            labelName.Text = "Име:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 202);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelEGN
            // 
            labelEGN.AutoSize = true;
            labelEGN.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelEGN.Location = new Point(38, 284);
            labelEGN.Name = "labelEGN";
            labelEGN.Size = new Size(75, 41);
            labelEGN.TabIndex = 14;
            labelEGN.Text = "ЕГН:";
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(1319, 19);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(122, 42);
            buttonBack.TabIndex = 15;
            buttonBack.Text = "Назад";
            buttonBack.Click += buttonBack_Click;
            // 
            // groupBoxGrades
            // 
            groupBoxGrades.BackColor = Color.White;
            groupBoxGrades.Controls.Add(panelGrades);
            groupBoxGrades.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGrades.Location = new Point(582, 85);
            groupBoxGrades.Name = "groupBoxGrades";
            groupBoxGrades.Size = new Size(859, 417);
            groupBoxGrades.TabIndex = 16;
            groupBoxGrades.TabStop = false;
            groupBoxGrades.Text = "Оценки";
            groupBoxGrades.Visible = false;
            // 
            // panelGrades
            // 
            panelGrades.AutoScroll = true;
            panelGrades.Location = new Point(6, 33);
            panelGrades.Name = "panelGrades";
            panelGrades.Size = new Size(880, 384);
            panelGrades.TabIndex = 1;
            // 
            // buttonVisibleGrades
            // 
            buttonVisibleGrades.AutoSize = true;
            buttonVisibleGrades.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVisibleGrades.Location = new Point(1059, 19);
            buttonVisibleGrades.Name = "buttonVisibleGrades";
            buttonVisibleGrades.Size = new Size(199, 42);
            buttonVisibleGrades.TabIndex = 17;
            buttonVisibleGrades.Text = "Покажи оценки";
            buttonVisibleGrades.Click += buttonVisibleGrades_Click;
            // 
            // StudentDetailsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonVisibleGrades);
            Controls.Add(groupBoxGrades);
            Controls.Add(buttonBack);
            Controls.Add(labelEGN);
            Controls.Add(labelMobileNumber);
            Controls.Add(labelGender);
            Controls.Add(labelAverageGrade);
            Controls.Add(labelFacultyNumber);
            Controls.Add(labelClass);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "StudentDetailsControl";
            Size = new Size(1461, 607);
            Load += StudentDetailsControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxGrades.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMobileNumber;
        private Label labelGender;
        private Label labelAverageGrade;
        private Label labelFacultyNumber;
        private Label labelClass;
        private Label labelName;
        private PictureBox pictureBox1;
        private Label labelEGN;
        private Button buttonBack;
        private GroupBox groupBoxGrades;
        private Panel panelGrades;
        private Button buttonVisibleGrades;
    }
}
