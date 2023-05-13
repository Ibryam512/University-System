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
            textBoxClass = new TextBox();
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
            textBoxFacultyNumber.Size = new Size(313, 34);
            textBoxFacultyNumber.TabIndex = 0;
            // 
            // textBoxEGN
            // 
            textBoxEGN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEGN.Location = new Point(40, 137);
            textBoxEGN.Name = "textBoxEGN";
            textBoxEGN.PlaceholderText = "ЕГН";
            textBoxEGN.Size = new Size(313, 34);
            textBoxEGN.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(40, 242);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Фамилия";
            textBoxLastName.Size = new Size(313, 34);
            textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(40, 190);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "Име";
            textBoxFirstName.Size = new Size(313, 34);
            textBoxFirstName.TabIndex = 2;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(radioButtonFemale);
            groupBoxGender.Controls.Add(radioButtonMale);
            groupBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGender.Location = new Point(40, 359);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(313, 151);
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
            textBoxMobileNumber.Location = new Point(40, 296);
            textBoxMobileNumber.Name = "textBoxMobileNumber";
            textBoxMobileNumber.PlaceholderText = "Мобилен номер";
            textBoxMobileNumber.Size = new Size(313, 34);
            textBoxMobileNumber.TabIndex = 5;
            // 
            // groupBoxGrades
            // 
            groupBoxGrades.Controls.Add(buttonAddSubject);
            groupBoxGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGrades.Location = new Point(537, 31);
            groupBoxGrades.Name = "groupBoxGrades";
            groupBoxGrades.Size = new Size(886, 417);
            groupBoxGrades.TabIndex = 6;
            groupBoxGrades.TabStop = false;
            groupBoxGrades.Text = "Оценки";
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.Location = new Point(356, 54);
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
            buttonAddStudent.Location = new Point(537, 495);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(174, 57);
            buttonAddStudent.TabIndex = 7;
            buttonAddStudent.Text = "Добави студент";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // textBoxClass
            // 
            textBoxClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClass.Location = new Point(40, 85);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.PlaceholderText = "Специалност";
            textBoxClass.Size = new Size(313, 34);
            textBoxClass.TabIndex = 8;
            // 
            // AddStudentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxClass);
            Controls.Add(buttonAddStudent);
            Controls.Add(groupBoxGrades);
            Controls.Add(textBoxMobileNumber);
            Controls.Add(groupBoxGender);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxEGN);
            Controls.Add(textBoxFacultyNumber);
            Name = "AddStudentControl";
            Size = new Size(1461, 607);
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
        private TextBox textBoxClass;
    }
}
