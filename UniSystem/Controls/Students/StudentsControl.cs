using System.ComponentModel;
using System.Resources;
using UniSystem.Properties;

namespace UniSystem.Controls
{
    public partial class StudentsControl : UserControl
    {
        int y = 87;

        public StudentsControl()
        {
            InitializeComponent();
            RefreshTable();
        }

        public void RefreshTable()
        {
            this.Controls.Clear();
            this.Controls.Add(labelFacultyNumberHeader);
            this.Controls.Add(labelFirstNameHeader);
            this.Controls.Add(labelLastNameHeader);
            this.Controls.Add(labelAverageGradeHeader);

            var students = Program.StudentService.GetStudents();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(StudentsControl));

            foreach (var student in students)
            {
                Panel panelStudent = new Panel();
                Button buttonDelete = new Button();
                Button buttonEdit = new Button();
                Label fourthLine = new Label();
                Label thirdLine = new Label();
                Label secondLine = new Label();
                Label line = new Label();
                Label labelAverageGrade = new Label();
                Label labelLastName = new Label();
                Label labelFirstName = new Label();
                Label labelFacultyNumber = new Label();

                panelStudent.BackColor = Color.White;
                panelStudent.Controls.Add(buttonDelete);
                panelStudent.Controls.Add(buttonEdit);
                panelStudent.Controls.Add(fourthLine);
                panelStudent.Controls.Add(thirdLine);
                panelStudent.Controls.Add(secondLine);
                panelStudent.Controls.Add(line);
                panelStudent.Controls.Add(labelAverageGrade);
                panelStudent.Controls.Add(labelLastName);
                panelStudent.Controls.Add(labelFirstName);
                panelStudent.Controls.Add(labelFacultyNumber);
                panelStudent.Cursor = Cursors.Hand;
                panelStudent.Location = new Point(143, y);
                panelStudent.Name = student.FacultyNumber;
                panelStudent.Size = new Size(1160, 61);
                panelStudent.TabIndex = 0;
                panelStudent.DoubleClick += panelDoubleClick;

                buttonDelete.BackColor = Color.Transparent;
                buttonDelete.FlatAppearance.BorderSize = 0;
                buttonDelete.FlatStyle = FlatStyle.Flat;
                buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
                buttonDelete.Location = new Point(1074, 5);
                buttonDelete.Size = new Size(51, 53);
                buttonDelete.Name = student.FacultyNumber;
                buttonDelete.TabIndex = 7;
                buttonDelete.UseVisualStyleBackColor = false;
                buttonDelete.Click += buttonDelete_Click;

                buttonEdit.BackColor = Color.Transparent;
                buttonEdit.FlatAppearance.BorderSize = 0;
                buttonEdit.FlatStyle = FlatStyle.Flat;
                buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
                buttonEdit.Location = new Point(995, 5);
                buttonEdit.Size = new Size(51, 53);
                buttonEdit.Name = student.FacultyNumber;
                buttonEdit.TabIndex = 1;
                buttonEdit.UseVisualStyleBackColor = false;
                buttonEdit.Click += buttonEdit_Click;

                fourthLine.BackColor = Color.DarkGray;
                fourthLine.FlatStyle = FlatStyle.Flat;
                fourthLine.Location = new Point(964, 9);
                fourthLine.Size = new Size(1, 43);
                fourthLine.TabIndex = 6;

                thirdLine.BackColor = Color.DarkGray;
                thirdLine.FlatStyle = FlatStyle.Flat;
                thirdLine.Location = new Point(798, 9);
                thirdLine.Size = new Size(1, 43);
                thirdLine.TabIndex = 5;

                secondLine.BackColor = Color.DarkGray;
                secondLine.FlatStyle = FlatStyle.Flat;
                secondLine.Location = new Point(521, 9);
                secondLine.Size = new Size(1, 43);
                secondLine.TabIndex = 5;

                line.BackColor = Color.DarkGray;
                line.FlatStyle = FlatStyle.Flat;
                line.Location = new Point(243, 10);
                line.Size = new Size(1, 43);
                line.TabIndex = 4;

                labelAverageGrade.AutoSize = true;
                labelAverageGrade.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelAverageGrade.Location = new Point(849, 17);
                labelAverageGrade.Size = new Size(58, 32);
                labelAverageGrade.TabIndex = 3;
                labelAverageGrade.Text = student.AverageGrade.ToString("f2");

                labelLastName.AutoSize = true;
                labelLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelLastName.Location = new Point(536, 17);
                labelLastName.Size = new Size(98, 32);
                labelLastName.TabIndex = 2;
                labelLastName.Text = student.LastName;

                labelFirstName.AutoSize = true;
                labelFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelFirstName.Location = new Point(261, 17);
                labelFirstName.Size = new Size(71, 32);
                labelFirstName.TabIndex = 1;
                labelFirstName.Text = student.FirstName;

                labelFacultyNumber.AutoSize = true;
                labelFacultyNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                labelFacultyNumber.Location = new Point(25, 17);
                labelFacultyNumber.Size = new Size(144, 32);
                labelFacultyNumber.TabIndex = 0;
                labelFacultyNumber.Text = student.FacultyNumber;

                this.Controls.Add(panelStudent);
                y += 70;
            }
        }

        private void panelDoubleClick(object sender, EventArgs e)
        {
            string facultyNumber = ((Panel)sender).Name;
            //show info for student
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string facultyNumber = ((Button)sender).Name;
            //edit student
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string facultyNumber = ((Button)sender).Name;
            //delete student
        }
    }
}
