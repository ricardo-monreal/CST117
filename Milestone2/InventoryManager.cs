using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    public class InventoryManager
    {
        public List<ProductInventory> Inventory { get; private set; } = new List<ProductInventory>();

        public static int defaultQuantity { get; } = 10;

        public ProductInventory addItem(ProductInventory item)
        {
            if (ContainsItem(item))
            {
                ProductInventory foundItem = FindItem(item);
                foundItem.Quantity += item.Quantity;
                return foundItem;
            }
            else
            {
                Inventory.Add(item);
                return item;
            }
        }


        public bool ContainsItem(ProductInventory item)
        {
            return Inventory.Contains(item);
        }

        public ProductInventory FindItem(string itemName)
        {
            return Inventory.Find(x => x.Equals(itemName));
        }

        public ProductInventory FindItem(ProductInventory item)
        {
            return Inventory.Find(x => x.Equals(item));
        }


        public List<ProductInventory> FindItems(string itemName, string desc)
        {
            List<ProductInventory> searchResults = new List<ProductInventory>();
            return Inventory.FindAll(x => x.Equals(itemName, desc));
        }

        public List<ProductInventory> FindItemsUnder(decimal price)
        {
            List<ProductInventory> searchResults = new List<ProductInventory>();
            return Inventory.FindAll(x => x.Price < price);
        }

        public bool RemoveItem(ProductInventory item)
        {
            if (ContainsItem(item))
            {
                Inventory.Remove(item);
                return true;
            }
            else
            {
                return false;

            }
        }


        public void RestockItem(string item)
        {
            ProductInventory inventoryItem = FindItem(item);
            if (inventoryItem.OutOfStock())
            {
                inventoryItem.Quantity = defaultQuantity;
            }
            
        }

        public void RestockItem(ProductInventory item)
        {
            ProductInventory inventoryItem = FindItem(item);
            inventoryItem.Quantity = defaultQuantity;
        }

        public override string ToString()
        {
            string value = "";
            foreach  (ProductInventory item in Inventory)
            {
                value += "[" + item.ToString() + "]\n\n";
            }
            return value;
        }


    }
}
