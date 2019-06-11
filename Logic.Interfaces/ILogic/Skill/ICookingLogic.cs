using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic.Skill
{
    public interface ICookingLogic
    {
        void CookFish(Character character, string fishItem);
    }
}
