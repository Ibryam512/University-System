namespace UniSystem
{
    partial class AddSubjectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSubject = new TextBox();
            numericUpDownGrade = new NumericUpDown();
            buttonAddSubject = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // textBoxSubject
            // 
            textBoxSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSubject.Location = new Point(12, 23);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.PlaceholderText = "Предмет";
            textBoxSubject.Size = new Size(206, 34);
            textBoxSubject.TabIndex = 0;
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.DecimalPlaces = 2;
            numericUpDownGrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownGrade.Location = new Point(297, 24);
            numericUpDownGrade.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(206, 34);
            numericUpDownGrade.TabIndex = 1;
            numericUpDownGrade.Value = new decimal(new int[] { 20, 0, 0, 65536 });
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.DialogResult = DialogResult.OK;
            buttonAddSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddSubject.Location = new Point(388, 107);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(115, 37);
            buttonAddSubject.TabIndex = 2;
            buttonAddSubject.Text = "Добави";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += buttonAddSubject_Click;
            // 
            // AddSubjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 168);
            Controls.Add(buttonAddSubject);
            Controls.Add(numericUpDownGrade);
            Controls.Add(textBoxSubject);
            Name = "AddSubjectForm";
            Text = "Добави оценка";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSubject;
        private NumericUpDown numericUpDownGrade;
        private Button buttonAddSubject;
    }
}