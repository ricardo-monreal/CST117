namespace ProgrammingProject5
{
    partial class Form2
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
            this.label_form2_title = new System.Windows.Forms.Label();
            this.label_lucky_number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_form2_title
            // 
            this.label_form2_title.AutoSize = true;
            this.label_form2_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form2_title.Location = new System.Drawing.Point(87, 98);
            this.label_form2_title.Name = "label_form2_title";
            this.label_form2_title.Size = new System.Drawing.Size(483, 46);
            this.label_form2_title.TabIndex = 0;
            this.label_form2_title.Text = "Here\'s your lucky number!";
            // 
            // label_lucky_number
            // 
            this.label_lucky_number.AutoSize = true;
            this.label_lucky_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lucky_number.Location = new System.Drawing.Point(220, 268);
            this.label_lucky_number.Name = "label_lucky_number";
            this.label_lucky_number.Size = new System.Drawing.Size(0, 108);
            this.label_lucky_number.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 582);
            this.Controls.Add(this.label_lucky_number);
            this.Controls.Add(this.label_form2_title);
            this.Name = "Form2";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_form2_title;
        private System.Windows.Forms.Label label_lucky_number;
    }
}