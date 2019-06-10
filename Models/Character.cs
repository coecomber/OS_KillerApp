using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Character
    {
        //Base values from database
        public int ID { get; set; }
        public string Name { get; set; }
        public Armour EquipedHelmet { get; set; }
        public Armour EquipedBody { get; set; }
        public Armour EquipedLegs { get; set; }
        public Armour EquipedFeet { get; set; }
        public Weapon EquipedWeapon { get; set; }
        public int Gold { get; set; }

        //Location and health
        public Locations location { get; set; }
        public int CurrentHealth { get; set; }

        //Inventory
        public List<Weapon> myWeapons { get; set; }
        public List<Armour> myArmours { get; set; }
        public List<FishItem> myFishItems { get; set; }
        public List<SmithingItem> mySmithingItems { get; set; }

        //Skil exp
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

        //Skill levels
        public int FishingLevel { get; set; }
        public int CookingLevel { get; set; }
        public int SmithingLevel { get; set; }
        public int SlayerLevel { get; set; }
        public int StrengthLevel { get; set; }
        public int AttackLevel { get; set; }
        public int DefenceLevel { get; set; }
        public int HitpointsLevel { get; set; }
        public int RangedLevel { get; set; }
        public int MagicLevel { get; set; }

        public Character()
        {
            myWeapons = new List<Weapon>();
            myArmours = new List<Armour>();
            myFishItems = new List<FishItem>();
            mySmithingItems = new List<SmithingItem>();
        }

    }
}
