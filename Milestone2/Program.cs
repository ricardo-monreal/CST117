using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInventory product = new ProductInventory("Andis Master", 99.99M, 2, 1.2, "Traditional hair clipper. Widely used");

         


            Console.WriteLine("Product Name: " + product.Name );
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Quantity: " + product.Quantity);
            Console.WriteLine("Weight: " + product.Weight);
            Console.WriteLine("Description: " + product.Description);

            Console.ReadLine();
        }
    }
}
