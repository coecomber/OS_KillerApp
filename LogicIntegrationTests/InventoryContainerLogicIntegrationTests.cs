using Logic;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicIntegrationTests
{
    class InventoryContainerLogicIntegrationTests
    {
        private InventoryContainerLogic myInventoryContainer;
        List<Inventory> inventories = new List<Inventory>();

        [SetUp]
        public void Setup()
        {
            myInventoryContainer = new InventoryContainerLogic();
            inventories = new List<Inventory>();
        }

        [Test]
        public void GetAllInventories_GetsAllInventories_ReturnsIDThatIsNotZero()
        {
            //Arange in Setup
            int inventoryID = 0;

            //Act
            inventories = myInventoryContainer.GetAllInventories();

            foreach (Inventory inventory in inventories)
            {
                inventoryID = inventory.ID;
            }

            //Assert
            Assert.That(inventoryID, Is.Not.EqualTo(0));
        }
    }
}
