namespace UniSystem.Controls.News
{
    partial class NewsDetailControl
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
            labelContent = new Label();
            labelDate = new Label();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(705, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(128, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Заглавие";
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelContent.Location = new Point(21, 111);
            labelContent.Name = "labelContent";
            labelContent.Size = new Size(177, 37);
            labelContent.TabIndex = 1;
            labelContent.Text = "Съдържание";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(21, 528);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(149, 37);
            labelDate.TabIndex = 2;
            labelDate.Text = "Качена на:";
            //
            // buttonBack
            //
            buttonBack.AutoSize = true;
            buttonBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(21, 27);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(122, 37);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Назад";
            buttonBack.Click += ButtonBack_Click;
            // 
            // NewsDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDate);
            Controls.Add(labelContent);
            Controls.Add(labelTitle);
            Controls.Add(buttonBack);
            Name = "NewsDetail";
            Size = new Size(1461, 607);
            Load += NewsDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelContent;
        private Label labelDate;
        private Button buttonBack;
    }
}
