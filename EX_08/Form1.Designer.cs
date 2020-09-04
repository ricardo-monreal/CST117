namespace EX_08
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_EnterValue = new System.Windows.Forms.Label();
            this.textBox_ValueInGrams = new System.Windows.Forms.TextBox();
            this.button_Fat = new System.Windows.Forms.Button();
            this.button_Carbs = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carbohydrates and Fat Calories Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_EnterValue
            // 
            this.label_EnterValue.AutoSize = true;
            this.label_EnterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EnterValue.Location = new System.Drawing.Point(42, 144);
            this.label_EnterValue.Name = "label_EnterValue";
            this.label_EnterValue.Size = new System.Drawing.Size(216, 25);
            this.label_EnterValue.TabIndex = 1;
            this.label_EnterValue.Text = "Enter a value in grams: ";
            this.label_EnterValue.Click += new System.EventHandler(this.label_Fat_Click);
            // 
            // textBox_ValueInGrams
            // 
            this.textBox_ValueInGrams.Location = new System.Drawing.Point(359, 145);
            this.textBox_ValueInGrams.Name = "textBox_ValueInGrams";
            this.textBox_ValueInGrams.Size = new System.Drawing.Size(235, 26);
            this.textBox_ValueInGrams.TabIndex = 3;
            this.textBox_ValueInGrams.TextChanged += new System.EventHandler(this.textBox_Fat_TextChanged);
            // 
            // button_Fat
            // 
            this.button_Fat.Location = new System.Drawing.Point(47, 216);
            this.button_Fat.Name = "button_Fat";
            this.button_Fat.Size = new System.Drawing.Size(235, 77);
            this.button_Fat.TabIndex = 5;
            this.button_Fat.Text = "Calculate Fat Calories";
            this.button_Fat.UseVisualStyleBackColor = true;
            this.button_Fat.Click += new System.EventHandler(this.button_Fat_Click);
            // 
            // button_Carbs
            // 
            this.button_Carbs.Location = new System.Drawing.Point(359, 216);
            this.button_Carbs.Name = "button_Carbs";
            this.button_Carbs.Size = new System.Drawing.Size(235, 78);
            this.button_Carbs.TabIndex = 6;
            this.button_Carbs.Text = "Calculate Carbs Calories";
            this.button_Carbs.UseVisualStyleBackColor = true;
            this.button_Carbs.Click += new System.EventHandler(this.button_Carbs_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Firebrick;
            this.button_Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Exit.Location = new System.Drawing.Point(239, 352);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(162, 57);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "Exit ";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 421);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Carbs);
            this.Controls.Add(this.button_Fat);
            this.Controls.Add(this.textBox_ValueInGrams);
            this.Controls.Add(this.label_EnterValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Exercise 8 - CST 117";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_EnterValue;
        private System.Windows.Forms.TextBox textBox_ValueInGrams;
        private System.Windows.Forms.Button button_Fat;
        private System.Windows.Forms.Button button_Carbs;
        private System.Windows.Forms.Button button_Exit;
    }
}

