using Logic;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicIntegrationTests
{
    class MonsterContainerLogicIntegrationTests
    {
        private MonsterContainerLogic myMonsterContainer;
        List<Monster> monsters = new List<Monster>();

        [SetUp]
        public void Setup()
        {
            myMonsterContainer = new MonsterContainerLogic();
            monsters = new List<Monster>();
        }

        [Test]
        public void GetAllMonsters_GetsAllMonsters_ReturnsIDThatIsNotZero()
        {
            //Arange in Setup
            int monsterID = 0;

            //Act
            monsters = myMonsterContainer.GetAllMonsters();

            foreach (Monster monster in monsters)
            {
                monsterID = monster.ID;
            }

            //Assert
            Assert.That(monsterID, Is.Not.EqualTo(0));
        }
    }
}
