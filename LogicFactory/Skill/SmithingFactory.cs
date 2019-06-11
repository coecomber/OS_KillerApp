using Logic.Interfaces.ILogic.Skill;
using Logic.Skill;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory.Skill
{
    public class SmithingFactory
    {
        public ISmithingLogic GetSmithingLogic()
        {
            return new SmithingLogic();
        }
    }
}
