using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    public class ProductInventory
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public string Description { get; set; }



        public ProductInventory(string name, decimal price, int quantity,
                    double weight, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Weight = weight;
            this.Description = description;
        }


        public bool OutOfStock()
        {
            return Quantity == 0;
        }

        private bool QuantityPurchasable(int requested)
        {
            return Quantity >= requested;
        }


        public bool PurchaseItem(int requested)
        {
            if (requested > 0 && !OutOfStock() && QuantityPurchasable(requested))
            {
                Quantity = Quantity - requested;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return (obj is ProductInventory) && ((ProductInventory)obj).Name == Name;
        }

        public bool Equals(string name)
        {
            return name == Name;
        }

        public bool Equals(string name, string desc)
        {
            return name == Name || desc == Description;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n " + "Description: " + Description + "\n" + "Quantity: " + Quantity;
        }

    }
}
