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

    }
}
