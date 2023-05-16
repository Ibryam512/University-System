namespace UniSystem.Controls.News
{
    partial class AddNewsControl
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
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            textBoxContent = new TextBox();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(596, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(305, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Добави новина";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(46, 117);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.PlaceholderText = "Заглавие";
            textBoxTitle.Size = new Size(1371, 43);
            textBoxTitle.TabIndex = 1;
            // 
            // textBoxContent
            // 
            textBoxContent.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContent.Location = new Point(46, 195);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.PlaceholderText = "Новината е...";
            textBoxContent.Size = new Size(1371, 286);
            textBoxContent.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(624, 527);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(277, 71);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добави";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddNewsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonAdd);
            Controls.Add(textBoxContent);
            Controls.Add(textBoxTitle);
            Controls.Add(labelTitle);
            Name = "AddNewsControl";
            Size = new Size(1461, 607);
            Load += AddNewsControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTitle;
        private TextBox textBoxContent;
        private Button buttonAdd;
    }
}
