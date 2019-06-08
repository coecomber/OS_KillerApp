using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface ISkillLogic
    {
        int GetLevelByExperience(int experience);
        int GetExperienceByLevel(int level);
        void AddExperience(int experience);
        void SetCorrectLevels(Character character);
    }
}
