using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic.Skill
{
    public interface ISmithingLogic
    {
        Character SmithBar(Character character, string oreName);
        Character SmithItem(Character character, string barName, string itemCraftName, int barAmountToDistract);
    }
}
