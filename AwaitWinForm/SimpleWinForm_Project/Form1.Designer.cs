namespace SimpleWinForm_Project
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
            Download_btn = new Button();
            result_lbl = new Label();
            SuspendLayout();
            // 
            // Download_btn
            // 
            Download_btn.Location = new Point(59, 38);
            Download_btn.Name = "Download_btn";
            Download_btn.Size = new Size(75, 23);
            Download_btn.TabIndex = 0;
            Download_btn.Text = "button1";
            Download_btn.UseVisualStyleBackColor = true;
            Download_btn.Click += Download_btn_Click;
            // 
            // result_lbl
            // 
            result_lbl.AutoSize = true;
            result_lbl.Location = new Point(280, 153);
            result_lbl.Name = "result_lbl";
            result_lbl.Size = new Size(38, 15);
            result_lbl.TabIndex = 1;
            result_lbl.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result_lbl);
            Controls.Add(Download_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Download_btn;
        private Label result_lbl;
    }
}