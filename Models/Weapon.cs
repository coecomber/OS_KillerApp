using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AttackStyle { get; set; }
        public int StrengthBonus { get; set; }
        public int AttackBonus { get; set; }
        public int AttackRequirement { get; set; }
        public int AttackStabBonus { get; set; }
        public int AttackSlashBonus { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }


        public Weapon()
        {

        }

        public Weapon(int id, string name, string attackStyle,
            int strengthBonus, int attackBonus, int attackRequirement,
            int attackStabBonus, int attackSlashBonus, int value, string description)
        {
            ID = id;
            Name = name;
            AttackStyle = attackStyle;
            StrengthBonus = strengthBonus;
            AttackBonus = attackBonus;
            AttackRequirement = attackRequirement;
            AttackStabBonus = attackStabBonus;
            AttackSlashBonus = attackSlashBonus;
            Value = value;
            Description = description;
        }

        public void AddToAmount(int amount)
        {
            Amount += amount;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
