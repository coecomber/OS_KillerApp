using Logic.Interfaces.ILogic;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class SkillLogic : ISkillLogic
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public int GetLevelByExperience(int experience)
        {
            //Your level of a skill is based on the amount of experience you got in that specific skill. To see a table
            //of what amount of experience you need for a set level please visit the following page: https://oldschool.tools/experience-table
            int level;

            for (level = 0; level < 120; level++)
            {
                if (GetExperienceByLevel(level + 1) > experience)
                    break;
            }

            if(level > 99)
            {
                level = 99;
            }

            return level;
        }

        public int GetExperienceByLevel(int level)
        {
            double total = 0;
            for (int i = 1; i < level; i++)
            {
                total += Math.Floor(i + 300 * Math.Pow(2, i / 7.0));
            }

            return (int)Math.Floor(total / 4);
        }

        public void AddExperience(int experience)
        {
            Experience = Experience + experience;
        }

        public void SetCorrectLevels(Character character)
        {
            character.FishingLevel = GetLevelByExperience(character.FishingExperience);
            character.CookingLevel = GetLevelByExperience(character.CookingExperience);
            character.SmithingLevel = GetLevelByExperience(character.SmithingExperience);
            character.SlayerLevel = GetLevelByExperience(character.SlayerExperience);
            character.StrengthLevel = GetLevelByExperience(character.StrengthExperience);
            character.AttackLevel = GetLevelByExperience(character.AttackExperience);
            character.DefenceLevel = GetLevelByExperience(character.DefenceExperience);
            character.HitpointsLevel = GetLevelByExperience(character.HitpointsExperience);
            character.RangedLevel = GetLevelByExperience(character.RangedExperience);
            character.MagicLevel = GetLevelByExperience(character.MagicExperience);
        }
    }
}
