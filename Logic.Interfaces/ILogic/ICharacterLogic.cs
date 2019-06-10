using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface ICharacterLogic
    {
        Monster AttackMonster(Character character, Monster monster);
        int CalculateMaxDamage(int totalStrength);
        Character MonsterKilled(Character character, Monster monster);
    }
}