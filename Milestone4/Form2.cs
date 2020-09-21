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
    public partial class Form2 : Form
    {
        public InventoryManager newManager { get; set; } = new InventoryManager();
        private addItem addItem;



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // create new Manager and adds default items to inventory
            ProductInventory newItemOne = new ProductInventory("Andis Master", 99.99M, 42, 2, "Cuts from 0 - 1");
            ProductInventory newItemTwo = new ProductInventory("Andis Outliner", 49.99M, 23, 1, "Used for outlines.");
            ProductInventory newItemThree = new ProductInventory("Oster Classic 76", 149.99M, 17, 2, "Takes attachements 0 - 3.5");
            newManager.addItem(newItemOne);
            newManager.addItem(newItemTwo);
            newManager.addItem(newItemThree);
            UpdateInventoryList();
            addItem = new addItem(this, newManager);



        }


        // done
        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                ProductInventory selectedItem = (ProductInventory)inventoryListBox.SelectedItem;
                UpdateSelected(selectedItem);
            }
            else
            {
                UpdateSelected();
            }
        }
        // done
        private void UpdateSelected()
        {
            nameOutput.Text = "";
            priceOutput.Text = "";
            quantityOutput.Text = "";
            weightOutput.Text = "";
            descriptionOutput.Text = "";
           
            
        }
        // done
        private void UpdateSelected(ProductInventory selectedItem)
        {
            nameOutput.Text = selectedItem.Name;
            priceOutput.Text = selectedItem.Price.ToString("C2");
            quantityOutput.Text = selectedItem.Quantity.ToString();
            weightOutput.Text = selectedItem.Weight.ToString() + " lbs";
            descriptionOutput.Text = selectedItem.Description;
        }

        private void nameOutput_Click(object sender, EventArgs e)
        {

        }

       
        // updat inventory list
        public void UpdateInventoryList()
        {
            txt_search.Text = "";
            inventoryListBox.ClearSelected();
            inventoryListBox.Items.Clear();
            foreach (ProductInventory item in newManager.Inventory)
            {
                inventoryListBox.Items.Add(item);
            }
            UpdateSelected();
        }


        // updates ProducutInventory  list with passaed parameters
        private void UpdateInventoryList(List<ProductInventory> inventory)
        {
            inventoryListBox.ClearSelected();
            inventoryListBox.Items.Clear();
            foreach ( ProductInventory item in inventory)
            {
                inventoryListBox.Items.Add(item);

            }
            UpdateSelected();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txt_search.Text))
        //    {
        //        UpdateInventoryList();
        //    }
        //    else
        //    {
        //        bool resultDecimal = decimal.TryParse(txt_search.Text, out decimal price);
        //        if (resultDecimal)
        //        {
        //            UpdateInventoryList(newManager.FindItemsUnder(price));
        //        }
        //        else
        //        {
        //            UpdateInventoryList(newManager.FindItems(txt_search.Text, txt_search.Text));
        //        }
        //    }
        //}
        

        // search function - updates inventory list if inpu text matches
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                UpdateInventoryList();
            }
            else
            {
                bool resultDecimal = decimal.TryParse(txt_search.Text, out decimal price);
                if (resultDecimal)
                {
                    UpdateInventoryList(newManager.FindItemsUnder(price));
                }
                else
                {
                    UpdateInventoryList(newManager.FindItems(txt_search.Text, txt_search.Text));
                }
            }
        }

        // done
        // opens addItem form 
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            addItem.ShowDialog();
        }

        // done
        // removes item from inventory list and updates list
        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                ProductInventory selecedItem = (ProductInventory)inventoryListBox.SelectedItem;
                newManager.RemoveItem(selecedItem);
                UpdateInventoryList();
            }
        }
        
        // done
        // restocks item to default (50) inventory list 
        private void btn_restockItem_Click(object sender, EventArgs e)
        {
            if(inventoryListBox.SelectedIndex != -1)
            {
                ProductInventory selectedItem = (ProductInventory)inventoryListBox.SelectedItem;
                newManager.RestockItem(selectedItem);
                UpdateSelected(selectedItem);
            }
        }

       
    }
}
