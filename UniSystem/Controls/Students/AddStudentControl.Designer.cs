namespace UniSystem.Controls
{
    partial class AddStudentControl
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
            textBoxFacultyNumber = new TextBox();
            textBoxEGN = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            groupBoxGender = new GroupBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            textBoxMobileNumber = new TextBox();
            groupBoxGrades = new GroupBox();
            buttonAddSubject = new Button();
            buttonAddStudent = new Button();
            groupBoxGender.SuspendLayout();
            groupBoxGrades.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxFacultyNumber
            // 
            textBoxFacultyNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFacultyNumber.Location = new Point(40, 31);
            textBoxFacultyNumber.Name = "textBoxFacultyNumber";
            textBoxFacultyNumber.PlaceholderText = "Факултетен номер";
            textBoxFacultyNumber.Size = new Size(239, 34);
            textBoxFacultyNumber.TabIndex = 0;
            // 
            // textBoxEGN
            // 
            textBoxEGN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEGN.Location = new Point(40, 87);
            textBoxEGN.Name = "textBoxEGN";
            textBoxEGN.PlaceholderText = "ЕГН";
            textBoxEGN.Size = new Size(239, 34);
            textBoxEGN.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(40, 193);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(239, 34);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(40, 143);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Име";
            textBoxFirstName.Size = new Size(239, 34);
            textBoxFirstName.TabIndex = 2;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGender.Location = new Point(40, 284);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(250, 139);
            groupBoxGender.TabIndex = 4;
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
            // textBoxMobileNumber
            // 
            textBoxMobileNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMobileNumber.Location = new Point(40, 244);
            textBoxMobileNumber.Name = "textBoxMobileNumber";
            textBoxMobileNumber.PlaceholderText = "Мобилен номер";
            textBoxMobileNumber.Size = new Size(239, 34);
            textBoxMobileNumber.TabIndex = 5;
            // 
            // groupBoxGrades
            // 
            groupBoxGrades.Controls.Add(buttonAddSubject);
            groupBoxGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGrades.Location = new Point(456, 31);
            groupBoxGrades.Name = "groupBoxGrades";
            groupBoxGrades.Size = new Size(487, 319);
            groupBoxGrades.TabIndex = 6;
            groupBoxGrades.TabStop = false;
            groupBoxGrades.Text = "Оценки";
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.Location = new Point(167, 61);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(149, 38);
            buttonAddSubject.TabIndex = 0;
            buttonAddSubject.Text = "Добави предмет";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += buttonAddSubject_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddStudent.Location = new Point(753, 366);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(174, 57);
            buttonAddStudent.TabIndex = 7;
            buttonAddStudent.Text = "Добави студент";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // AddStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAddStudent);
            Controls.Add(groupBoxGrades);
            Controls.Add(textBoxMobileNumber);
            Controls.Add(groupBoxGender);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxEGN);
            Controls.Add(textBoxFacultyNumber);
            Name = "AddStudentControl";
            Size = new Size(966, 441);
            Load += AddStudentControl_Load;
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            groupBoxGrades.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFacultyNumber;
        private TextBox textBoxEGN;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private GroupBox groupBoxGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private TextBox textBoxMobileNumber;
        private GroupBox groupBoxGrades;
        private Button buttonAddSubject;
        private Button buttonAddStudent;
    }
}
