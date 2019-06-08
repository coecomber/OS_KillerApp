using Logic;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class SkillLogicFactory
    {
        public ISkillLogic GetSkillLogic()
        {
            return new SkillLogic();
        }
    }
}
