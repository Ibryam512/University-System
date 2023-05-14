using System.ComponentModel;

namespace UniSystem.Controls
{
    partial class StudentsControl
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
        /// 

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(StudentsControl));
            panelExample = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            fourthLine = new Label();
            thirdLine = new Label();
            secondLine = new Label();
            line = new Label();
            labelAverageGrade = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            labelFacultyNumber = new Label();
            labelFacultyNumberHeader = new Label();
            labelFirstNameHeader = new Label();
            labelLastNameHeader = new Label();
            labelAverageGradeHeader = new Label();
            buttonAddStudent = new Button();
            panelExample.SuspendLayout();
            SuspendLayout();
            // 
            // panelExample
            // 
            panelExample.BackColor = Color.White;
            panelExample.Controls.Add(buttonDelete);
            panelExample.Controls.Add(buttonEdit);
            panelExample.Controls.Add(fourthLine);
            panelExample.Controls.Add(thirdLine);
            panelExample.Controls.Add(secondLine);
            panelExample.Controls.Add(line);
            panelExample.Controls.Add(labelAverageGrade);
            panelExample.Controls.Add(labelLastName);
            panelExample.Controls.Add(labelFirstName);
            panelExample.Controls.Add(labelFacultyNumber);
            panelExample.Cursor = Cursors.Hand;
            panelExample.Location = new Point(143, 87);
            panelExample.Name = "panelExample";
            panelExample.Size = new Size(1160, 61);
            panelExample.TabIndex = 0;
            panelExample.DoubleClick += panelDoubleClick;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Transparent;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.Location = new Point(1074, 5);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(51, 53);
            buttonDelete.TabIndex = 7;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Transparent;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.Location = new Point(995, 5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(51, 53);
            buttonEdit.TabIndex = 1;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // fourthLine
            // 
            fourthLine.BackColor = Color.DarkGray;
            fourthLine.FlatStyle = FlatStyle.Flat;
            fourthLine.Location = new Point(964, 9);
            fourthLine.Name = "fourthLine";
            fourthLine.Size = new Size(1, 43);
            fourthLine.TabIndex = 6;
            // 
            // thirdLine
            // 
            thirdLine.BackColor = Color.DarkGray;
            thirdLine.FlatStyle = FlatStyle.Flat;
            thirdLine.Location = new Point(798, 9);
            thirdLine.Name = "thirdLine";
            thirdLine.Size = new Size(1, 43);
            thirdLine.TabIndex = 5;
            // 
            // secondLine
            // 
            secondLine.BackColor = Color.DarkGray;
            secondLine.FlatStyle = FlatStyle.Flat;
            secondLine.Location = new Point(521, 9);
            secondLine.Name = "secondLine";
            secondLine.Size = new Size(1, 43);
            secondLine.TabIndex = 5;
            // 
            // line
            // 
            line.BackColor = Color.DarkGray;
            line.FlatStyle = FlatStyle.Flat;
            line.Location = new Point(243, 10);
            line.Name = "line";
            line.Size = new Size(1, 43);
            line.TabIndex = 4;
            // 
            // labelAverageGrade
            // 
            labelAverageGrade.AutoSize = true;
            labelAverageGrade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAverageGrade.Location = new Point(849, 17);
            labelAverageGrade.Name = "labelAverageGrade";
            labelAverageGrade.Size = new Size(58, 32);
            labelAverageGrade.TabIndex = 3;
            labelAverageGrade.Text = "6.00";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastName.Location = new Point(536, 17);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(98, 32);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "Иванов";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(261, 17);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(71, 32);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "Иван";
            // 
            // labelFacultyNumber
            // 
            labelFacultyNumber.AutoSize = true;
            labelFacultyNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFacultyNumber.Location = new Point(25, 17);
            labelFacultyNumber.Name = "labelFacultyNumber";
            labelFacultyNumber.Size = new Size(144, 32);
            labelFacultyNumber.TabIndex = 0;
            labelFacultyNumber.Text = "2201681000";
            // 
            // labelFacultyNumberHeader
            // 
            labelFacultyNumberHeader.AutoSize = true;
            labelFacultyNumberHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFacultyNumberHeader.Location = new Point(158, 42);
            labelFacultyNumberHeader.Name = "labelFacultyNumberHeader";
            labelFacultyNumberHeader.Size = new Size(139, 32);
            labelFacultyNumberHeader.TabIndex = 8;
            labelFacultyNumberHeader.Text = "Фак. номер";
            labelFacultyNumberHeader.Click += labelFacultyNumberHeader_Click;
            // 
            // labelFirstNameHeader
            // 
            labelFirstNameHeader.AutoSize = true;
            labelFirstNameHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstNameHeader.Location = new Point(404, 42);
            labelFirstNameHeader.Name = "labelFirstNameHeader";
            labelFirstNameHeader.Size = new Size(62, 32);
            labelFirstNameHeader.TabIndex = 9;
            labelFirstNameHeader.Text = "Име";
            labelFirstNameHeader.Click += labelFirstNameHeader_Click;
            // 
            // labelLastNameHeader
            // 
            labelLastNameHeader.AutoSize = true;
            labelLastNameHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelLastNameHeader.Location = new Point(679, 42);
            labelLastNameHeader.Name = "labelLastNameHeader";
            labelLastNameHeader.Size = new Size(113, 32);
            labelLastNameHeader.TabIndex = 10;
            labelLastNameHeader.Text = "Фамилия";
            labelLastNameHeader.Click += labelLastNameHeader_Click;
            // 
            // labelAverageGradeHeader
            // 
            labelAverageGradeHeader.AutoSize = true;
            labelAverageGradeHeader.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAverageGradeHeader.Location = new Point(953, 42);
            labelAverageGradeHeader.Name = "labelAverageGradeHeader";
            labelAverageGradeHeader.Size = new Size(97, 32);
            labelAverageGradeHeader.TabIndex = 11;
            labelAverageGradeHeader.Text = "Оценка";
            labelAverageGradeHeader.Click += labelAverageGradeHeader_Click;
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(1278, 16);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(141, 34);
            buttonAddStudent.TabIndex = 12;
            buttonAddStudent.Text = "Добави студент";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // StudentsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            Controls.Add(buttonAddStudent);
            Controls.Add(labelAverageGradeHeader);
            Controls.Add(labelLastNameHeader);
            Controls.Add(labelFirstNameHeader);
            Controls.Add(labelFacultyNumberHeader);
            Controls.Add(panelExample);
            Margin = new Padding(2);
            Name = "StudentsControl";
            Size = new Size(1461, 607);
            panelExample.ResumeLayout(false);
            panelExample.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelExample;
        private Label labelLastName;
        private Label labelFirstName;
        private Label labelFacultyNumber;
        private Label line;
        private Label labelAverageGrade;
        private Label fourthLine;
        private Label thirdLine;
        private Label secondLine;
        private Button buttonEdit;
        private Button buttonDelete;
        private Label labelFacultyNumberHeader;
        private Label labelFirstNameHeader;
        private Label labelLastNameHeader;
        private Label labelAverageGradeHeader;
        private Button buttonAddStudent;
    }
}
