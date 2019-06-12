using Logic.Skill;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicUnitTests
{
    class SmithingLogicTests
    {
        SmithingLogic smithingLogic = new SmithingLogic();
        Character character = new Character();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void SmithBar_SmithIronBar_ReturnIronBarName()
        {
            //arange
            SmithingItem smithingItem = new SmithingItem();
            smithingItem.Name = "Iron ore";
            smithingItem.Amount = 1;
            character.mySmithingItems.Add(smithingItem);
            character.SmithingExperience += 50;
            string smithingItemInInventory = "";

            //act
            smithingLogic.SmithBar(character, "Iron ore");
            foreach(SmithingItem mySmithingItem in character.mySmithingItems)
            {
                if(mySmithingItem.Amount > 0)
                {
                    smithingItemInInventory = mySmithingItem.Name;
                }
            }

            //assert
            Assert.That(smithingItemInInventory, Is.EqualTo("Iron bar"));
        }
    }
}
