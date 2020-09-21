using System.Windows.Forms;
namespace Milestone2
{
    partial class addItem
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
            this.label_addItem = new System.Windows.Forms.Label();
            this.label_addPrice = new System.Windows.Forms.Label();
            this.label_addQuantity = new System.Windows.Forms.Label();
            this.label_addWeight = new System.Windows.Forms.Label();
            this.label_addDescription = new System.Windows.Forms.Label();
            this.label_add_item_title = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_addName = new System.Windows.Forms.TextBox();
            this.txt_addPrice = new System.Windows.Forms.TextBox();
            this.txt_addQuantity = new System.Windows.Forms.TextBox();
            this.txt_addWeight = new System.Windows.Forms.TextBox();
            this.txt_addDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_addItem
            // 
            this.label_addItem.AutoSize = true;
            this.label_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addItem.Location = new System.Drawing.Point(26, 83);
            this.label_addItem.Name = "label_addItem";
            this.label_addItem.Size = new System.Drawing.Size(105, 38);
            this.label_addItem.TabIndex = 0;
            this.label_addItem.Text = "Name:";
            // 
            // label_addPrice
            // 
            this.label_addPrice.AutoSize = true;
            this.label_addPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addPrice.Location = new System.Drawing.Point(26, 132);
            this.label_addPrice.Name = "label_addPrice";
            this.label_addPrice.Size = new System.Drawing.Size(93, 38);
            this.label_addPrice.TabIndex = 1;
            this.label_addPrice.Text = "Price:";
            // 
            // label_addQuantity
            // 
            this.label_addQuantity.AutoSize = true;
            this.label_addQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addQuantity.Location = new System.Drawing.Point(26, 185);
            this.label_addQuantity.Name = "label_addQuantity";
            this.label_addQuantity.Size = new System.Drawing.Size(137, 38);
            this.label_addQuantity.TabIndex = 2;
            this.label_addQuantity.Text = "Quantity:";
            // 
            // label_addWeight
            // 
            this.label_addWeight.AutoSize = true;
            this.label_addWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addWeight.Location = new System.Drawing.Point(26, 236);
            this.label_addWeight.Name = "label_addWeight";
            this.label_addWeight.Size = new System.Drawing.Size(120, 38);
            this.label_addWeight.TabIndex = 3;
            this.label_addWeight.Text = "Weight:";
            // 
            // label_addDescription
            // 
            this.label_addDescription.AutoSize = true;
            this.label_addDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addDescription.Location = new System.Drawing.Point(26, 285);
            this.label_addDescription.Name = "label_addDescription";
            this.label_addDescription.Size = new System.Drawing.Size(115, 25);
            this.label_addDescription.TabIndex = 4;
            this.label_addDescription.Text = "Description:";
            // 
            // label_add_item_title
            // 
            this.label_add_item_title.AutoSize = true;
            this.label_add_item_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add_item_title.Location = new System.Drawing.Point(25, 21);
            this.label_add_item_title.Name = "label_add_item_title";
            this.label_add_item_title.Size = new System.Drawing.Size(260, 38);
            this.label_add_item_title.TabIndex = 5;
            this.label_add_item_title.Text = "Enter the item info:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(217, 356);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(201, 55);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_addName
            // 
            this.txt_addName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addName.Location = new System.Drawing.Point(158, 80);
            this.txt_addName.Name = "txt_addName";
            this.txt_addName.Size = new System.Drawing.Size(260, 30);
            this.txt_addName.TabIndex = 7;
            // 
            // txt_addPrice
            // 
            this.txt_addPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addPrice.Location = new System.Drawing.Point(158, 125);
            this.txt_addPrice.Name = "txt_addPrice";
            this.txt_addPrice.Size = new System.Drawing.Size(260, 30);
            this.txt_addPrice.TabIndex = 8;
            // 
            // txt_addQuantity
            // 
            this.txt_addQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addQuantity.Location = new System.Drawing.Point(158, 178);
            this.txt_addQuantity.Name = "txt_addQuantity";
            this.txt_addQuantity.Size = new System.Drawing.Size(260, 30);
            this.txt_addQuantity.TabIndex = 9;
            // 
            // txt_addWeight
            // 
            this.txt_addWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addWeight.Location = new System.Drawing.Point(158, 226);
            this.txt_addWeight.Name = "txt_addWeight";
            this.txt_addWeight.Size = new System.Drawing.Size(260, 30);
            this.txt_addWeight.TabIndex = 10;
            // 
            // txt_addDescription
            // 
            this.txt_addDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addDescription.Location = new System.Drawing.Point(158, 282);
            this.txt_addDescription.Name = "txt_addDescription";
            this.txt_addDescription.Size = new System.Drawing.Size(260, 30);
            this.txt_addDescription.TabIndex = 11;
            // 
            // addItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 460);
            this.Controls.Add(this.txt_addDescription);
            this.Controls.Add(this.txt_addWeight);
            this.Controls.Add(this.txt_addQuantity);
            this.Controls.Add(this.txt_addPrice);
            this.Controls.Add(this.txt_addName);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label_add_item_title);
            this.Controls.Add(this.label_addDescription);
            this.Controls.Add(this.label_addWeight);
            this.Controls.Add(this.label_addQuantity);
            this.Controls.Add(this.label_addPrice);
            this.Controls.Add(this.label_addItem);
            this.Name = "addItem";
            this.Text = "Inventory Manager - Add Item";
            this.Load += new System.EventHandler(this.addItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Label label_addItem;
        private Label label_addPrice;
        private Label label_addQuantity;
        private Label label_addWeight;
        private Label label_addDescription;
        private Label label_add_item_title;
        private Button btn_add;
        private TextBox txt_addName;
        private TextBox txt_addPrice;
        private TextBox txt_addQuantity;
        private TextBox txt_addWeight;
        private TextBox txt_addDescription;
    }
}