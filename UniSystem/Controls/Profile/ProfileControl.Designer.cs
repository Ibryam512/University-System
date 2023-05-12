namespace UniSystem.Controls.Profile
{
    partial class ProfileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelClass = new Label();
            labelFacultyNumber = new Label();
            labelAverageGrade = new Label();
            labelGender = new Label();
            labelMobileNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 202);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(294, 31);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 41);
            labelName.TabIndex = 1;
            labelName.Text = "Име:";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelClass.Location = new Point(45, 390);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(404, 41);
            labelClass.TabIndex = 2;
            labelClass.Text = "Специалност:";
            // 
            // labelFacultyNumber
            // 
            labelFacultyNumber.AutoSize = true;
            labelFacultyNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelFacultyNumber.Location = new Point(45, 483);
            labelFacultyNumber.Name = "labelFacultyNumber";
            labelFacultyNumber.Size = new Size(279, 41);
            labelFacultyNumber.TabIndex = 3;
            labelFacultyNumber.Text = "Факултетен номер:";
            // 
            // labelAverageGrade
            // 
            labelAverageGrade.AutoSize = true;
            labelAverageGrade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAverageGrade.Location = new Point(38, 297);
            labelAverageGrade.Name = "labelAverageGrade";
            labelAverageGrade.Size = new Size(211, 41);
            labelAverageGrade.TabIndex = 4;
            labelAverageGrade.Text = "Среден успех:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelGender.Location = new Point(294, 201);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(80, 41);
            labelGender.TabIndex = 5;
            labelGender.Text = "Пол:";
            // 
            // labelMobileNumber
            // 
            labelMobileNumber.AutoSize = true;
            labelMobileNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelMobileNumber.Location = new Point(294, 110);
            labelMobileNumber.Name = "labelMobileNumber";
            labelMobileNumber.Size = new Size(251, 41);
            labelMobileNumber.TabIndex = 6;
            labelMobileNumber.Text = "Мобилен номер:";
            // 
            // ProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMobileNumber);
            Controls.Add(labelGender);
            Controls.Add(labelAverageGrade);
            Controls.Add(labelFacultyNumber);
            Controls.Add(labelClass);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "ProfileControl";
            Size = new Size(1461, 607);
            Load += ProfileControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelName;
        private Label labelClass;
        private Label labelFacultyNumber;
        private Label labelAverageGrade;
        private Label labelGender;
        private Label labelMobileNumber;
    }
}
