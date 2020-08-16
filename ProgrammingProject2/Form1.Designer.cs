namespace ProgrammingProject2
{
    partial class ProgrammingProject2
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
            this.img_logo = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Flavors = new System.Windows.Forms.ListBox();
            this.radioButton_cup = new System.Windows.Forms.RadioButton();
            this.radioButton_cone = new System.Windows.Forms.RadioButton();
            this.checkedListBox_toppings = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_flavor = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_flavor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.SystemColors.Control;
            this.img_logo.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.img_logo.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            this.img_logo.IconColor = System.Drawing.Color.PaleVioletRed;
            this.img_logo.IconSize = 100;
            this.img_logo.Location = new System.Drawing.Point(186, 22);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(110, 100);
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            this.img_logo.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Title.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Title.Location = new System.Drawing.Point(302, 47);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(269, 44);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Lopes Ice Cream!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(293, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order your favorite Ice Cream on the go!";
            // 
            // listBox_Flavors
            // 
            this.listBox_Flavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Flavors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBox_Flavors.FormattingEnabled = true;
            this.listBox_Flavors.ItemHeight = 20;
            this.listBox_Flavors.Items.AddRange(new object[] {
            "Vanilla",
            "Chocolate",
            "Strawberry",
            "Butter Pecan",
            "Mint",
            "Coffee",
            "Cookies N\' Cream"});
            this.listBox_Flavors.Location = new System.Drawing.Point(11, 19);
            this.listBox_Flavors.Name = "listBox_Flavors";
            this.listBox_Flavors.Size = new System.Drawing.Size(179, 164);
            this.listBox_Flavors.TabIndex = 3;
            this.listBox_Flavors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButton_cup
            // 
            this.radioButton_cup.AutoSize = true;
            this.radioButton_cup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_cup.Location = new System.Drawing.Point(31, 48);
            this.radioButton_cup.Name = "radioButton_cup";
            this.radioButton_cup.Size = new System.Drawing.Size(56, 24);
            this.radioButton_cup.TabIndex = 4;
            this.radioButton_cup.TabStop = true;
            this.radioButton_cup.Text = "Cup";
            this.radioButton_cup.UseVisualStyleBackColor = true;
            // 
            // radioButton_cone
            // 
            this.radioButton_cone.AutoSize = true;
            this.radioButton_cone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_cone.Location = new System.Drawing.Point(31, 95);
            this.radioButton_cone.Name = "radioButton_cone";
            this.radioButton_cone.Size = new System.Drawing.Size(112, 24);
            this.radioButton_cone.TabIndex = 5;
            this.radioButton_cone.TabStop = true;
            this.radioButton_cone.Text = "Sugar Cone";
            this.radioButton_cone.UseVisualStyleBackColor = true;
            this.radioButton_cone.CheckedChanged += new System.EventHandler(this.radioButton_cone_CheckedChanged);
            // 
            // checkedListBox_toppings
            // 
            this.checkedListBox_toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_toppings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkedListBox_toppings.FormattingEnabled = true;
            this.checkedListBox_toppings.Items.AddRange(new object[] {
            "Rainbow Sprinkles",
            "Chocolate Chips",
            "Pecans",
            "Roasted Almonds",
            "M&M\'s",
            "Gummy Bears",
            "Mashmallows"});
            this.checkedListBox_toppings.Location = new System.Drawing.Point(11, 26);
            this.checkedListBox_toppings.Name = "checkedListBox_toppings";
            this.checkedListBox_toppings.Size = new System.Drawing.Size(177, 154);
            this.checkedListBox_toppings.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_cone);
            this.groupBox1.Controls.Add(this.radioButton_cup);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(297, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cup or Cone";
            // 
            // groupBox_flavor
            // 
            this.groupBox_flavor.Controls.Add(this.listBox_Flavors);
            this.groupBox_flavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_flavor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox_flavor.Location = new System.Drawing.Point(46, 167);
            this.groupBox_flavor.Name = "groupBox_flavor";
            this.groupBox_flavor.Size = new System.Drawing.Size(200, 190);
            this.groupBox_flavor.TabIndex = 8;
            this.groupBox_flavor.TabStop = false;
            this.groupBox_flavor.Text = "Select Flavor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox_toppings);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Location = new System.Drawing.Point(547, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 190);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Toppings";
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Order.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_Order.FlatAppearance.BorderSize = 2;
            this.btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Order.Location = new System.Drawing.Point(547, 392);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(100, 35);
            this.btn_Order.TabIndex = 10;
            this.btn_Order.Text = "Place Order!";
            this.btn_Order.UseVisualStyleBackColor = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(650, 392);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(100, 35);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear Form";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // ProgrammingProject2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_flavor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.img_logo);
            this.Name = "ProgrammingProject2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Project 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_flavor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox img_logo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Flavors;
        private System.Windows.Forms.RadioButton radioButton_cup;
        private System.Windows.Forms.RadioButton radioButton_cone;
        private System.Windows.Forms.CheckedListBox checkedListBox_toppings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_flavor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Clear;
    }
}

