using Logic;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicIntegrationTests
{
    class EquippedContainerLogicIntegrationTests
    {
        private EquippedContainerLogic myEquippedContainer;
        List<Equipped> equippeds = new List<Equipped>();

        [SetUp]
        public void Setup()
        {
            myEquippedContainer = new EquippedContainerLogic();
            equippeds = new List<Equipped>();
        }

        [Test]
        public void GetAllMonsters_GetsAllMonsters_ReturnsIDThatIsNotZero()
        {
            //Arange in Setup
            int equippedID = 0;

            //Act
            equippeds = myEquippedContainer.GetAllEquipped();

            foreach (Equipped myEquipped in equippeds)
            {
                equippedID = myEquipped.EquppedID;
            }

            //Assert
            Assert.That(equippedID, Is.Not.EqualTo(0));
        }
    }
}
