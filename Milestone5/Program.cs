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
        //static void Main(string[] args)
        //{


        //    InventoryManager intManager = new InventoryManager();
        //    ProductInventory AndisMaster = new ProductInventory("Andis Master", 99.99M, 2, 1.2, "Traditional hair clipper. Widely used");

        //    Console.WriteLine("###### Driver Test Class #######\n");
        //    intManager.addItem(AndisMaster);
        //    Console.WriteLine("Before Editing\n");
        //    Console.WriteLine("Product Name: " + AndisMaster.Name);
        //    Console.WriteLine("Price: " + AndisMaster.Price);
        //    Console.WriteLine("Quantity: " + AndisMaster.Quantity);
        //    Console.WriteLine("Weight: " + AndisMaster.Weight + " lbs");
        //    Console.WriteLine("Description: " + AndisMaster.Description);


           
        //    Console.WriteLine();
        //    Console.WriteLine("\nAfter Adding inventory and Adjusting price.");
        //    Console.WriteLine();
            
        //    AndisMaster.Quantity = 10;
        //    AndisMaster.Price = 133.99M;

        //    Console.WriteLine("Product Name: " + AndisMaster.Name);
        //    Console.WriteLine("Price: " + AndisMaster.Price);
        //    Console.WriteLine("Quantity: " + AndisMaster.Quantity);
        //    Console.WriteLine("Weight: " + AndisMaster.Weight + " lbs");
        //    Console.WriteLine("Description: " + AndisMaster.Description);

        //    Console.WriteLine();
        //    Console.WriteLine("\nAfter removing inventory, adjusting weight and changing description.");
        //    Console.WriteLine();


        //    AndisMaster.Quantity = 4;
        //    AndisMaster.Weight = 1.3;
        //    AndisMaster.Description = "High utility hair clipper";

        //    Console.WriteLine("Product Name: " + AndisMaster.Name);
        //    Console.WriteLine("Price: " + AndisMaster.Price);
        //    Console.WriteLine("Quantity: " + AndisMaster.Quantity);
        //    Console.WriteLine("Weight: " + AndisMaster.Weight + " lbs");
        //    Console.WriteLine("Description: " + AndisMaster.Description);

           
        //    Console.ReadLine();
            
        //}

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }

      
    }
}
