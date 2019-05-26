using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Abstract
{
    public abstract class SkillLogic
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }

        public int CalculateLevel()
        {
            int level = 1;

            return 1;
        }

        public void AddExperience(int experience)
        {
            Experience = Experience + experience;
        }
    }
}
