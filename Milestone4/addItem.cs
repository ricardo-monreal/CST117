using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    public partial class addItem : Form
    {

        Form2 inventoryForm;
        InventoryManager newManager;
        

        public addItem(Form2 form2, InventoryManager inventoryManager)
        {
            InitializeComponent();
            inventoryForm = form2;
            newManager = inventoryManager;
        }
        // done
        private bool ErrorHandling()
        {
            return (
                !string.IsNullOrWhiteSpace(txt_addName.Text) &&
                decimal.TryParse(txt_addPrice.Text, out decimal price)) &&
                int.TryParse(txt_addQuantity.Text, out int quantity) &&
                double.TryParse(txt_addWeight.Text, out double weight) &&
                !string.IsNullOrWhiteSpace(txt_addDescription.Text);
        }

        // done
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ErrorHandling())
            {
                ProductInventory newItem = new ProductInventory(txt_addName.Text,
                                                                decimal.Parse(txt_addPrice.Text),
                                                                int.Parse(txt_addQuantity.Text),
                                                                double.Parse(txt_addWeight.Text),
                                                                txt_addDescription.Text);

                newManager.addItem(newItem);
                inventoryForm.UpdateInventoryList();
                this.Hide();
                txt_addName.Text = "";
                txt_addPrice.Text = "";
                txt_addQuantity.Text = "";
                txt_addWeight.Text = "";
                txt_addDescription.Text = "";
            }
            else
            {
                MessageBox.Show("Please correct the input fields to add a new item.");
            }

        }
    }
}
