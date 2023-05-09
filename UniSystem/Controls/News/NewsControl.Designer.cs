namespace UniSystem.Controls.News
{
    partial class NewsControl
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
            buttonAddNews = new Button();
            SuspendLayout();
            // 
            // buttonAddNews
            // 
            buttonAddNews.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddNews.Location = new Point(618, 93);
            buttonAddNews.Name = "buttonAddNews";
            buttonAddNews.Size = new Size(279, 50);
            buttonAddNews.TabIndex = 0;
            buttonAddNews.Text = "Добави новина";
            buttonAddNews.UseVisualStyleBackColor = true;
            buttonAddNews.Click += buttonAddNews_Click;
            // 
            // NewsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(buttonAddNews);
            Name = "NewsControl";
            Size = new Size(1461, 607);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddNews;
    }
}
