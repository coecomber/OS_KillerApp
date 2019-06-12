using Logic;
using Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicIntegrationTests
{
    class CharacterContainerLogicIntegrationTests
    {
        private CharacterContainerLogic myCharacterContainer;
        List<Character> characters = new List<Character>();
        Character character = new Character();

        [SetUp]
        public void Setup()
        {
            myCharacterContainer = new CharacterContainerLogic();
            characters = new List<Character>();
        }

        [Test]
        public void GetAllCharacters_GetsAllCharacter_ReturnsIDThatIsNotZero()
        {
            //Arange in Setup
            int characterID = 0;

            //Act
            characters = myCharacterContainer.GetAllCharacters();

            foreach (Character character in characters)
            {
                characterID = character.ID;
            }

            //Assert
            Assert.That(characterID, Is.Not.EqualTo(0));
        }

        [Test]
        public void GetCharacterByID_GetsOneCharacter_ReturnsCharacterIDThatIsNotZero()
        {
            //Arange in Setup

            //Act
            character = myCharacterContainer.GetCharacterByID(11);

            //Assert
            Assert.That(character.ID, Is.Not.EqualTo(0));
        }
    }
}
