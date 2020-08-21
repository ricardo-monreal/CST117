namespace EX_05
{
    partial class Ex_05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex_05));
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label_NumberOfTerms = new System.Windows.Forms.Label();
            this.txt_termsEntered = new System.Windows.Forms.TextBox();
            this.lbl_calculationTerms = new System.Windows.Forms.Label();
            this.lbl_calculationResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(255, 110);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(128, 53);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "CALCULATE";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label_NumberOfTerms
            // 
            this.label_NumberOfTerms.AutoSize = true;
            this.label_NumberOfTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NumberOfTerms.Location = new System.Drawing.Point(24, 64);
            this.label_NumberOfTerms.Name = "label_NumberOfTerms";
            this.label_NumberOfTerms.Size = new System.Drawing.Size(131, 20);
            this.label_NumberOfTerms.TabIndex = 1;
            this.label_NumberOfTerms.Text = "Enter # of terms: ";
            // 
            // txt_termsEntered
            // 
            this.txt_termsEntered.Location = new System.Drawing.Point(255, 66);
            this.txt_termsEntered.Name = "txt_termsEntered";
            this.txt_termsEntered.Size = new System.Drawing.Size(128, 20);
            this.txt_termsEntered.TabIndex = 2;
            // 
            // lbl_calculationTerms
            // 
            this.lbl_calculationTerms.AutoSize = true;
            this.lbl_calculationTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculationTerms.Location = new System.Drawing.Point(25, 185);
            this.lbl_calculationTerms.Name = "lbl_calculationTerms";
            this.lbl_calculationTerms.Size = new System.Drawing.Size(0, 20);
            this.lbl_calculationTerms.TabIndex = 3;
            // 
            // lbl_calculationResult
            // 
            this.lbl_calculationResult.AutoSize = true;
            this.lbl_calculationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calculationResult.Location = new System.Drawing.Point(25, 223);
            this.lbl_calculationResult.Name = "lbl_calculationResult";
            this.lbl_calculationResult.Size = new System.Drawing.Size(0, 20);
            this.lbl_calculationResult.TabIndex = 4;
            // 
            // Ex_05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 306);
            this.Controls.Add(this.lbl_calculationResult);
            this.Controls.Add(this.lbl_calculationTerms);
            this.Controls.Add(this.txt_termsEntered);
            this.Controls.Add(this.label_NumberOfTerms);
            this.Controls.Add(this.btn_Calculate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ex_05";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label_NumberOfTerms;
        private System.Windows.Forms.TextBox txt_termsEntered;
        private System.Windows.Forms.Label lbl_calculationTerms;
        private System.Windows.Forms.Label lbl_calculationResult;
    }
}

