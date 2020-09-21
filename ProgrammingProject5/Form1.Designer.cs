namespace ProgrammingProject5
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
            this.label_birthYear = new System.Windows.Forms.Label();
            this.btn_getLucky = new System.Windows.Forms.Button();
            this.comboBox_year = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_birthYear
            // 
            this.label_birthYear.AutoSize = true;
            this.label_birthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_birthYear.Location = new System.Drawing.Point(36, 91);
            this.label_birthYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_birthYear.Name = "label_birthYear";
            this.label_birthYear.Size = new System.Drawing.Size(244, 29);
            this.label_birthYear.TabIndex = 0;
            this.label_birthYear.Text = "Select your birth year:";
            // 
            // btn_getLucky
            // 
            this.btn_getLucky.Location = new System.Drawing.Point(171, 452);
            this.btn_getLucky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_getLucky.Name = "btn_getLucky";
            this.btn_getLucky.Size = new System.Drawing.Size(306, 86);
            this.btn_getLucky.TabIndex = 8;
            this.btn_getLucky.Text = "Get Lucky Numbers!";
            this.btn_getLucky.UseVisualStyleBackColor = true;
            this.btn_getLucky.Click += new System.EventHandler(this.btn_getLucky_Click);
            // 
            // comboBox_year
            // 
            this.comboBox_year.FormattingEnabled = true;
            this.comboBox_year.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "Are you really that old?"});
            this.comboBox_year.Location = new System.Drawing.Point(340, 89);
            this.comboBox_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.Size = new System.Drawing.Size(248, 28);
            this.comboBox_year.TabIndex = 9;
            this.comboBox_year.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_month
            // 
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_month.Location = new System.Drawing.Point(340, 174);
            this.comboBox_month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(248, 28);
            this.comboBox_month.TabIndex = 11;
            this.comboBox_month.SelectedIndexChanged += new System.EventHandler(this.comboBox_month_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select your birth month:";
            // 
            // comboBox_day
            // 
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Location = new System.Drawing.Point(340, 255);
            this.comboBox_day.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(248, 28);
            this.comboBox_day.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select your birth day:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 612);
            this.Controls.Add(this.comboBox_day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.btn_getLucky);
            this.Controls.Add(this.label_birthYear);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lucky Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_birthYear;
        private System.Windows.Forms.Button btn_getLucky;
        private System.Windows.Forms.ComboBox comboBox_year;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.Label label2;
    }
}

