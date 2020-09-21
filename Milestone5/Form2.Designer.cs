namespace Milestone2
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
            this.inventoryListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceOutput = new System.Windows.Forms.Label();
            this.quantityOutput = new System.Windows.Forms.Label();
            this.weightOutput = new System.Windows.Forms.Label();
            this.descriptionOutput = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_restockItem = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_version = new System.Windows.Forms.Label();
            this.label_App_Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 29;
            this.inventoryListBox.Location = new System.Drawing.Point(301, 102);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(574, 294);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(296, 443);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(64, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameOutput
            // 
            this.nameOutput.AutoSize = true;
            this.nameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(423, 443);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(18, 25);
            this.nameOutput.TabIndex = 2;
            this.nameOutput.Text = ":";
            this.nameOutput.Click += new System.EventHandler(this.nameOutput_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(296, 485);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(296, 529);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 25);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(296, 574);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(74, 25);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "Weight";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(296, 621);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(109, 25);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // priceOutput
            // 
            this.priceOutput.AutoSize = true;
            this.priceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutput.Location = new System.Drawing.Point(423, 485);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(18, 25);
            this.priceOutput.TabIndex = 7;
            this.priceOutput.Text = ":";
            // 
            // quantityOutput
            // 
            this.quantityOutput.AutoSize = true;
            this.quantityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityOutput.Location = new System.Drawing.Point(423, 529);
            this.quantityOutput.Name = "quantityOutput";
            this.quantityOutput.Size = new System.Drawing.Size(18, 25);
            this.quantityOutput.TabIndex = 8;
            this.quantityOutput.Text = ":";
            // 
            // weightOutput
            // 
            this.weightOutput.AutoSize = true;
            this.weightOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightOutput.Location = new System.Drawing.Point(423, 574);
            this.weightOutput.Name = "weightOutput";
            this.weightOutput.Size = new System.Drawing.Size(18, 25);
            this.weightOutput.TabIndex = 9;
            this.weightOutput.Text = ":";
            // 
            // descriptionOutput
            // 
            this.descriptionOutput.AutoSize = true;
            this.descriptionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionOutput.Location = new System.Drawing.Point(423, 621);
            this.descriptionOutput.Name = "descriptionOutput";
            this.descriptionOutput.Size = new System.Drawing.Size(18, 25);
            this.descriptionOutput.TabIndex = 10;
            this.descriptionOutput.Text = ":";
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.SystemColors.Control;
            this.label_search.Location = new System.Drawing.Point(27, 332);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(215, 38);
            this.label_search.TabIndex = 12;
            this.label_search.Text = "Search for item";
            this.label_search.Click += new System.EventHandler(this.label_search_Click);
            // 
            // btn_addItem
            // 
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(31, 110);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(163, 46);
            this.btn_addItem.TabIndex = 13;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.Location = new System.Drawing.Point(31, 180);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(165, 47);
            this.btn_removeItem.TabIndex = 14;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_restockItem
            // 
            this.btn_restockItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restockItem.Location = new System.Drawing.Point(31, 250);
            this.btn_restockItem.Name = "btn_restockItem";
            this.btn_restockItem.Size = new System.Drawing.Size(159, 46);
            this.btn_restockItem.TabIndex = 15;
            this.btn_restockItem.Text = "Restock";
            this.btn_restockItem.UseVisualStyleBackColor = true;
            this.btn_restockItem.Click += new System.EventHandler(this.btn_restockItem_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(31, 368);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(165, 26);
            this.txt_search.TabIndex = 16;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label_version);
            this.panel1.Controls.Add(this.btn_addItem);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label_search);
            this.panel1.Controls.Add(this.btn_restockItem);
            this.panel1.Controls.Add(this.btn_removeItem);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 822);
            this.panel1.TabIndex = 17;
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.ForeColor = System.Drawing.SystemColors.Control;
            this.label_version.Location = new System.Drawing.Point(53, 783);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(85, 20);
            this.label_version.TabIndex = 17;
            this.label_version.Text = "version 0.1";
            // 
            // label_App_Title
            // 
            this.label_App_Title.AutoSize = true;
            this.label_App_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_App_Title.ForeColor = System.Drawing.Color.DarkRed;
            this.label_App_Title.Location = new System.Drawing.Point(291, 26);
            this.label_App_Title.Name = "label_App_Title";
            this.label_App_Title.Size = new System.Drawing.Size(584, 55);
            this.label_App_Title.TabIndex = 18;
            this.label_App_Title.Text = "Barber Inventory Manager";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 824);
            this.Controls.Add(this.label_App_Title);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descriptionOutput);
            this.Controls.Add(this.weightOutput);
            this.Controls.Add(this.quantityOutput);
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryListBox);
            this.Name = "Form2";
            this.Text = "Inventory Manager - CST 117 Milestone 5";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceOutput;
        private System.Windows.Forms.Label quantityOutput;
        private System.Windows.Forms.Label weightOutput;
        private System.Windows.Forms.Label descriptionOutput;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_restockItem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_App_Title;
    }
}