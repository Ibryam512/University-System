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
            buttonHome = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panelMain = new Panel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // buttonHome
            // 
            buttonHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonHome.BackColor = SystemColors.HotTrack;
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Location = new Point(0, 0);
            buttonHome.Margin = new Padding(2, 2, 2, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(242, 56);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "Начало";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += navigationButtonClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.BackColor = SystemColors.HotTrack;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(242, 0);
            buttonAdd.Margin = new Padding(2, 2, 2, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(242, 56);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добави студент";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += navigationButtonClick;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEdit.BackColor = SystemColors.HotTrack;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(483, 0);
            buttonEdit.Margin = new Padding(2, 2, 2, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(242, 56);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактирай студент";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += navigationButtonClick;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelete.AutoSize = true;
            buttonDelete.BackColor = SystemColors.HotTrack;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(725, 0);
            buttonDelete.Margin = new Padding(2, 2, 2, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(242, 56);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Изтрий студент";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += navigationButtonClick;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(0, 55);
            panelMain.Margin = new Padding(2, 2, 2, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(966, 441);
            panelMain.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 56);
            panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 496);
            Controls.Add(panelMain);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonHome);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHome;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Panel panelMain;
        private Panel panel1;
    }
}