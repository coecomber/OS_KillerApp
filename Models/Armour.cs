using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Armour
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AttackStabBonus { get; set; }
        public int AttackSlashBonus { get; set; }
        public int DefenceStabBonus { get; set; }
        public int DefenceSlashBonus { get; set; }
        public int DefenceRangedBonus { get; set; }
        public int DefenceMagicBonus { get; set; }
        public ArmourTypes ArmourType { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

        public Armour(int id, string name, int attackStabBonus, int attackSlashBonus,
            int defenceStabBonus, int defenceSlashBonus, int defenceRangedBonus,
            int defenceMagicBonus, ArmourTypes armourType, int value, string description)
        {
            ID = id;
            Name = name;
            AttackStabBonus = attackStabBonus;
            AttackSlashBonus = attackSlashBonus;
            DefenceStabBonus = defenceStabBonus;
            DefenceSlashBonus = defenceSlashBonus;
            DefenceRangedBonus = defenceRangedBonus;
            DefenceMagicBonus = defenceMagicBonus;
            ArmourType = armourType;
            Value = value;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
