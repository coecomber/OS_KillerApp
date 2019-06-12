using Logic.Skill;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicUnitTests
{
    class FishingLogicTests
    {
        FishingLogic fishingLogic = new FishingLogic();
        Character character = new Character();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CatchFish_CatchLobster_ReturnCatchedFishName()
        {
            //arange
            string fishInInventory = "";

            //act
            fishingLogic.CatchFish(character, "Raw Lobster", true);
            
            foreach(FishItem myFishItem in character.myFishItems)
            {
                fishInInventory = myFishItem.Name;
            }

            //assert
            Assert.That(fishInInventory, Is.EqualTo("Raw Lobster"));
        }
    }
}
