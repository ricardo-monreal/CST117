using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Milestone2;
using System.Collections.Generic;

namespace Milestone3Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        


        public void AddItemsTest()
        {
            ProductInventory item = new ProductInventory("Test1", 49.99M, 20, 2.2, "Hair dryer");
            InventoryManager manager = new InventoryManager();

            ProductInventory itemReturned = manager.addItem(item);
            Assert.AreEqual(item, itemReturned);
            ProductInventory itemReturnedAgain = manager.addItem(item);
            Assert.AreEqual(item, itemReturnedAgain);
           
        }

    }
}
