namespace homeWork_Win2
{
    partial class Form1
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
            GameTitle = new Label();
            start_btn = new Button();
            SuspendLayout();
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.Font = new Font("Snap ITC", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            GameTitle.Location = new Point(236, 91);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(366, 72);
            GameTitle.TabIndex = 0;
            GameTitle.Text = "Game \"Guess Number\"\r\nWhat's your number?";
            GameTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // start_btn
            // 
            start_btn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            start_btn.Location = new Point(341, 214);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(125, 55);
            start_btn.TabIndex = 1;
            start_btn.Text = "Start";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(start_btn);
            Controls.Add(GameTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GameTitle;
        private Button start_btn;
    }
}
