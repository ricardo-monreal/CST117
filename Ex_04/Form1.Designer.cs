namespace Ex_04
{
    partial class SecondsConverter
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
            this.label_EnterSeconds = new System.Windows.Forms.Label();
            this.txt_EnterSeconds = new System.Windows.Forms.TextBox();
            this.lbl_DisplayResult = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Results_Text = new System.Windows.Forms.Label();
            this.img_logo = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_EnterSeconds
            // 
            this.label_EnterSeconds.AutoSize = true;
            this.label_EnterSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EnterSeconds.Location = new System.Drawing.Point(30, 162);
            this.label_EnterSeconds.Name = "label_EnterSeconds";
            this.label_EnterSeconds.Size = new System.Drawing.Size(152, 20);
            this.label_EnterSeconds.TabIndex = 0;
            this.label_EnterSeconds.Text = "Enter The Seconds";
            this.label_EnterSeconds.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_EnterSeconds
            // 
            this.txt_EnterSeconds.Location = new System.Drawing.Point(258, 164);
            this.txt_EnterSeconds.Name = "txt_EnterSeconds";
            this.txt_EnterSeconds.Size = new System.Drawing.Size(180, 20);
            this.txt_EnterSeconds.TabIndex = 1;
            this.txt_EnterSeconds.Text = "ds";
            this.txt_EnterSeconds.TextChanged += new System.EventHandler(this.txt_EnterSeconds_TextChanged);
            // 
            // lbl_DisplayResult
            // 
            this.lbl_DisplayResult.AutoSize = true;
            this.lbl_DisplayResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayResult.Location = new System.Drawing.Point(364, 229);
            this.lbl_DisplayResult.Name = "lbl_DisplayResult";
            this.lbl_DisplayResult.Size = new System.Drawing.Size(0, 20);
            this.lbl_DisplayResult.TabIndex = 3;
            this.lbl_DisplayResult.Visible = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(258, 305);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Enter";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(363, 305);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Results_Text
            // 
            this.lbl_Results_Text.AutoSize = true;
            this.lbl_Results_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Results_Text.Location = new System.Drawing.Point(30, 229);
            this.lbl_Results_Text.Name = "lbl_Results_Text";
            this.lbl_Results_Text.Size = new System.Drawing.Size(0, 20);
            this.lbl_Results_Text.TabIndex = 6;
            this.lbl_Results_Text.Visible = false;
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.SystemColors.Control;
            this.img_logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.img_logo.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.img_logo.IconColor = System.Drawing.SystemColors.ControlText;
            this.img_logo.IconSize = 70;
            this.img_logo.Location = new System.Drawing.Point(64, 12);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(102, 70);
            this.img_logo.TabIndex = 7;
            this.img_logo.TabStop = false;
            this.img_logo.Click += new System.EventHandler(this.img_logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seconds Converter";
            // 
            // SecondsConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.lbl_Results_Text);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_DisplayResult);
            this.Controls.Add(this.txt_EnterSeconds);
            this.Controls.Add(this.label_EnterSeconds);
            this.Name = "SecondsConverter";
            this.Text = "Exercise 04";
            this.Load += new System.EventHandler(this.SecondsConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_EnterSeconds;
        private System.Windows.Forms.TextBox txt_EnterSeconds;
        private System.Windows.Forms.Label lbl_DisplayResult;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Results_Text;
        private FontAwesome.Sharp.IconPictureBox img_logo;
        private System.Windows.Forms.Label label1;
    }
}

