namespace ProgrammingProject3
{
    partial class ProgrammingProject3
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
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.txt_results = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(19, 329);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(154, 51);
            this.btn_OpenFile.TabIndex = 0;
            this.btn_OpenFile.Text = "Open A File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // dlg
            // 
            this.dlg.FileName = "dlg";
            this.dlg.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txt_results
            // 
            this.txt_results.Location = new System.Drawing.Point(19, 36);
            this.txt_results.Margin = new System.Windows.Forms.Padding(2);
            this.txt_results.Multiline = true;
            this.txt_results.Name = "txt_results";
            this.txt_results.Size = new System.Drawing.Size(425, 269);
            this.txt_results.TabIndex = 1;
            this.txt_results.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(290, 329);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(154, 51);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // saveDlg
            // 
            this.saveDlg.FileName = "ProcessedFile.txt";
            // 
            // ProgrammingProject3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_results);
            this.Controls.Add(this.btn_OpenFile);
            this.Name = "ProgrammingProject3";
            this.Text = "Programming Project 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.TextBox txt_results;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.SaveFileDialog saveDlg;



    }
}

