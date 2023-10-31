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
            Download_btn.BackColor = SystemColors.ControlText;
            Download_btn.Dock = DockStyle.Top;
            Download_btn.FlatStyle = FlatStyle.Flat;
            Download_btn.ForeColor = Color.White;
            Download_btn.Location = new Point(0, 0);
            Download_btn.Name = "Download_btn";
            Download_btn.Size = new Size(391, 32);
            Download_btn.TabIndex = 0;
            Download_btn.Text = "Show result";
            Download_btn.UseVisualStyleBackColor = false;
            Download_btn.Click += Download_btn_Click;
            // 
            // result_lbl
            // 
            result_lbl.Dock = DockStyle.Top;
            result_lbl.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            result_lbl.Location = new Point(0, 32);
            result_lbl.Name = "result_lbl";
            result_lbl.Size = new Size(391, 57);
            result_lbl.TabIndex = 1;
            result_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 374);
            Controls.Add(result_lbl);
            Controls.Add(Download_btn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Learn With Maral Mosafer";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Download_btn;
        private Label result_lbl;
    }
}