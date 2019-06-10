using Logic.Abstract;
using Logic.Interfaces.ILogic;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;

namespace Logic
{
    public class MonsterLogic : LivingCreatureLogic, IMonsterLogic
    {
        public Character AttackCharacter(Character character, Monster monster)
        {
            //Randomizes the max attackbonus of a monster, divide this amount by 3 and withdraw this amount of health from the player.
            Random random = new Random();
            int damage = random.Next(0, monster.AttackBonus) / 3;

            character.CurrentHealth = character.CurrentHealth - damage;

            if(character.CurrentHealth < 0)
            {
                character.CurrentHealth = 0;
            }

            return character;
        }
    }
}
