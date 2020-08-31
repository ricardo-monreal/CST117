using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Milestone2;

namespace Milestone2Tests
{
    [TestClass]
    public class ProductInventoryTests
    {

        private string name = "Test Prodcut";
        private decimal price = 98.99m;
        private int quantity = 10;
        private double weight = 1.2;
        private string description = "This is test product";



        [TestMethod]
        public void TestMethod1()
        {
            ProductInventory product = new ProductInventory(name, price, quantity, weight, description);
            
            // Asssert
            Assert.IsNotNull(product);
            Assert.AreEqual(name, product.Name);
            Assert.AreEqual(price, product.Price);
            Assert.AreEqual(quantity, product.Quantity);
            Assert.AreEqual(weight, product.Weight);
            Assert.AreEqual(description, product.Description);

        }
    }
}
