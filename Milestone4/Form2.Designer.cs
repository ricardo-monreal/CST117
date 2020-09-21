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
            this.SuspendLayout();
            // 
            // inventoryListBox
            // 
            this.inventoryListBox.FormattingEnabled = true;
            this.inventoryListBox.ItemHeight = 20;
            this.inventoryListBox.Location = new System.Drawing.Point(31, 55);
            this.inventoryListBox.Name = "inventoryListBox";
            this.inventoryListBox.Size = new System.Drawing.Size(527, 244);
            this.inventoryListBox.TabIndex = 0;
            this.inventoryListBox.SelectedIndexChanged += new System.EventHandler(this.inventoryListBox_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(564, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameOutput
            // 
            this.nameOutput.AutoSize = true;
            this.nameOutput.Location = new System.Drawing.Point(619, 55);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(13, 20);
            this.nameOutput.TabIndex = 2;
            this.nameOutput.Text = ":";
            this.nameOutput.Click += new System.EventHandler(this.nameOutput_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(564, 97);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(564, 141);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(68, 20);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(564, 186);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(59, 20);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "Weight";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(564, 233);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            // 
            // priceOutput
            // 
            this.priceOutput.AutoSize = true;
            this.priceOutput.Location = new System.Drawing.Point(623, 96);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(13, 20);
            this.priceOutput.TabIndex = 7;
            this.priceOutput.Text = ":";
            // 
            // quantityOutput
            // 
            this.quantityOutput.AutoSize = true;
            this.quantityOutput.Location = new System.Drawing.Point(639, 140);
            this.quantityOutput.Name = "quantityOutput";
            this.quantityOutput.Size = new System.Drawing.Size(13, 20);
            this.quantityOutput.TabIndex = 8;
            this.quantityOutput.Text = ":";
            // 
            // weightOutput
            // 
            this.weightOutput.AutoSize = true;
            this.weightOutput.Location = new System.Drawing.Point(639, 186);
            this.weightOutput.Name = "weightOutput";
            this.weightOutput.Size = new System.Drawing.Size(13, 20);
            this.weightOutput.TabIndex = 9;
            this.weightOutput.Text = ":";
            // 
            // descriptionOutput
            // 
            this.descriptionOutput.AutoSize = true;
            this.descriptionOutput.Location = new System.Drawing.Point(660, 232);
            this.descriptionOutput.Name = "descriptionOutput";
            this.descriptionOutput.Size = new System.Drawing.Size(13, 20);
            this.descriptionOutput.TabIndex = 10;
            this.descriptionOutput.Text = ":";
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(31, 306);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(117, 20);
            this.label_search.TabIndex = 12;
            this.label_search.Text = "Search for item";
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(31, 368);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(163, 46);
            this.btn_addItem.TabIndex = 13;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Location = new System.Drawing.Point(218, 368);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(165, 47);
            this.btn_removeItem.TabIndex = 14;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_restockItem
            // 
            this.btn_restockItem.Location = new System.Drawing.Point(399, 368);
            this.btn_restockItem.Name = "btn_restockItem";
            this.btn_restockItem.Size = new System.Drawing.Size(159, 46);
            this.btn_restockItem.TabIndex = 15;
            this.btn_restockItem.Text = "Restock";
            this.btn_restockItem.UseVisualStyleBackColor = true;
            this.btn_restockItem.Click += new System.EventHandler(this.btn_restockItem_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(31, 329);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(167, 26);
            this.txt_search.TabIndex = 16;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_restockItem);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.label_search);
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
            this.Text = "Inventory Manager - CST 117 Milestone 4";
            this.Load += new System.EventHandler(this.Form2_Load);
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
    }
}