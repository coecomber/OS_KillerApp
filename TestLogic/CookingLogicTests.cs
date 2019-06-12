using Logic.Skill;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicUnitTests
{
    class CookingLogicTests
    {
        CookingLogic cookingLogic = new CookingLogic();
        Character character = new Character();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CookFish_CooksLobster_ReturnsCharacterWithLobster()
        {
            //arange
            FishItem fishItem = new FishItem(1, "Raw Lobster", true, 0, 0, "");
            fishItem.Amount = 1;
            character.myFishItems.Add(fishItem);

            //act
            cookingLogic.CookFish(character, "Raw Lobster");
            string fishInInventory = "";

            foreach (var myFishItem in character.myFishItems)
            {
                fishInInventory = myFishItem.Name;
            }

            //assert
            Assert.That(fishInInventory, Is.EqualTo("Lobster"));
        }
    }
}