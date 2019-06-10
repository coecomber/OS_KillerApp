using Logic;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class MonsterFactory
    {
        public IMonsterLogic GetMonsterLogic()
        {
            return new MonsterLogic();
        }
    }
}
