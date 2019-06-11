using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic.Skill
{
    public interface IFishingLogic
    {
        Character CatchFish(Character character, string fishName);
    }
}
