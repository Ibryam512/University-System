namespace UniSystem.Controls.Students
{
    partial class EditStudentControl
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
            textBoxClass = new TextBox();
            buttonEditStudent = new Button();
            textBoxMobileNumber = new TextBox();
            groupBoxGender = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxEGN = new TextBox();
            textBoxFacultyNumber = new TextBox();
            panelGrades = new Panel();
            buttonAddSubject = new Button();
            groupBoxGrades = new GroupBox();
            groupBoxGender.SuspendLayout();
            panelGrades.SuspendLayout();
            groupBoxGrades.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxClass
            // 
            textBoxClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClass.Location = new Point(39, 161);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.PlaceholderText = "Специалност";
            textBoxClass.Size = new Size(313, 34);
            textBoxClass.TabIndex = 17;
            // 
            // buttonEditStudent
            // 
            buttonEditStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditStudent.Location = new Point(536, 506);
            buttonEditStudent.Name = "buttonEditStudent";
            buttonEditStudent.Size = new Size(227, 57);
            buttonEditStudent.TabIndex = 16;
            buttonEditStudent.Text = "Редактирай студент";
            buttonEditStudent.UseVisualStyleBackColor = true;
            buttonEditStudent.Click += buttonEditStudent_Click;
            // 
            // textBoxMobileNumber
            // 
            textBoxMobileNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMobileNumber.Location = new Point(39, 357);
            textBoxMobileNumber.Name = "textBoxMobileNumber";
            textBoxMobileNumber.PlaceholderText = "Мобилен номер";
            textBoxMobileNumber.Size = new Size(313, 34);
            textBoxMobileNumber.TabIndex = 14;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGender.Location = new Point(39, 419);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(313, 151);
            groupBoxGender.TabIndex = 13;
            groupBoxGender.TabStop = false;
            groupBoxGender.Text = "Пол";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Checked = true;
            radioButtonFemale.Location = new Point(21, 82);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(82, 32);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Жена";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(21, 34);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(78, 32);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.Text = "Мъж";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(39, 289);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(313, 34);
            textBoxLastName.TabIndex = 12;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(39, 225);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Име";
            textBoxFirstName.Size = new Size(313, 34);
            textBoxFirstName.TabIndex = 11;
            // 
            // textBoxEGN
            // 
            textBoxEGN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEGN.Location = new Point(39, 99);
            textBoxEGN.Name = "textBoxEGN";
            textBoxEGN.PlaceholderText = "ЕГН";
            textBoxEGN.ReadOnly = true;
            textBoxEGN.Size = new Size(313, 34);
            textBoxEGN.TabIndex = 10;
            // 
            // textBoxFacultyNumber
            // 
            textBoxFacultyNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFacultyNumber.Location = new Point(39, 37);
            textBoxFacultyNumber.Name = "textBoxFacultyNumber";
            textBoxFacultyNumber.PlaceholderText = "Факултетен номер";
            textBoxFacultyNumber.ReadOnly = true;
            textBoxFacultyNumber.Size = new Size(313, 34);
            textBoxFacultyNumber.TabIndex = 9;
            // 
            // panelGrades
            // 
            panelGrades.AutoScroll = true;
            panelGrades.Controls.Add(buttonAddSubject);
            panelGrades.Dock = DockStyle.Fill;
            panelGrades.Location = new Point(3, 30);
            panelGrades.Name = "panelGrades";
            panelGrades.Size = new Size(880, 384);
            panelGrades.TabIndex = 1;
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.Location = new Point(356, 30);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(149, 38);
            buttonAddSubject.TabIndex = 0;
            buttonAddSubject.Text = "Добави предмет";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += buttonAddSubject_Click;
            // 
            // groupBoxGrades
            // 
            groupBoxGrades.Controls.Add(panelGrades);
            groupBoxGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGrades.Location = new Point(536, 42);
            groupBoxGrades.Name = "groupBoxGrades";
            groupBoxGrades.Size = new Size(886, 417);
            groupBoxGrades.TabIndex = 15;
            groupBoxGrades.TabStop = false;
            groupBoxGrades.Text = "Оценки";
            // 
            // EditStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxClass);
            Controls.Add(buttonEditStudent);
            Controls.Add(textBoxMobileNumber);
            Controls.Add(groupBoxGender);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxEGN);
            Controls.Add(textBoxFacultyNumber);
            Controls.Add(groupBoxGrades);
            Name = "EditStudentControl";
            Size = new Size(1461, 607);
            Load += EditStudentControl_Load;
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            panelGrades.ResumeLayout(false);
            groupBoxGrades.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxClass;
        private Button buttonEditStudent;
        private TextBox textBoxMobileNumber;
        private GroupBox groupBoxGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxEGN;
        private TextBox textBoxFacultyNumber;
        private Panel panelGrades;
        private Button buttonAddSubject;
        private GroupBox groupBoxGrades;
    }
}
