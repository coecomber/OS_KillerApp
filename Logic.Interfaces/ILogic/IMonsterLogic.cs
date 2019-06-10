using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface IMonsterLogic
    {
        Character AttackCharacter(Character character, Monster monster);
    }
}
