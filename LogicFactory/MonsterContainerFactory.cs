using Logic;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class MonsterContainerFactory
    {
        public IMonsterContainerLogic GetMonsterContainerLogic()
        {
            return new MonsterContainerLogic();
        }
    }
}
