using Logic;
using Models;
using Models.Enums;
using NUnit.Framework;

namespace LogicUnitTests
{
    class CharacterLogicTests
    {
        CharacterLogic characterLogic = new CharacterLogic();
        Character character = new Character();
        Monster monster = new Monster();

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void MonsterKilled_KillsCow_Return1024AttackExperience()
        {
            //arrange
            character.AttackStyle = AttackStyles.Attack;
            character.AttackExperience = 1000;
            monster.Health = 8;

            //act
            character = characterLogic.MonsterKilled(character, monster);

            //assert
            Assert.That(character.AttackExperience, Is.EqualTo(1024));
        }

        [Test]
        public void GetNewSlayerTask_GetsRandomTask_ReturnCharacterWithATask()
        {
            //arrange

            //act
            character = characterLogic.GetNewSlayerTask(character);

            //assert
            Assert.That(character.SlayerMonsterName, Is.Not.EqualTo(null));
        }

        [Test]
        public void Die_CharacterDies_ReturnsCharacterWithMaxHealth()
        {
            //arrange
            character.HitpointsLevel = 10;
            character.CurrentHealth = 0;

            //act
            character = characterLogic.Die(character);

            //assert
            Assert.That(character.CurrentHealth, Is.Not.EqualTo(0));
        }

        [Test]
        public void CalculateMaxDamage_WithNineStrength_ReturnsCharaceterWithThreeMaxDamage()
        {
            //arrange
            character.StrengthLevel = 9;

            //act
            int maxDamage = characterLogic.CalculateDamage(character.StrengthLevel);

            //assert
            Assert.That(maxDamage, Is.EqualTo(3));
        }
    }
}
