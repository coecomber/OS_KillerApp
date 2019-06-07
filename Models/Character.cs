using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Armour> EquipedArmour { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public int Gold { get; set; }

        //Skils exp
        public int FishingExperience { get; set; }
        public int CookingExperience { get; set; }
        public int SmithingExperience { get; set; }
        public int SlayerExperience { get; set; }
        public int StrengthExperience { get; set; }
        public int AttackExperience { get; set; }
        public int DefenceExperience { get; set; }
        public int HitpointsExperience { get; set; }
        public int RangedExperience { get; set; }
        public int MagicExperience { get; set; }

    }
}
