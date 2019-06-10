using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int CurrentHealth { get; set; }
        public int MagicDefence { get; set; }
        public int MeleeDefence { get; set; }
        public int RangedDefence { get; set; }
        public string WeakTo { get; set; }
        public string AttackStyle { get; set; }
        public int AttackBonus { get; set; }
        public Locations Location { get; set; }

        public Monster()
        {

        }

        public Monster(int id, string name,
            int health, int magicDefence, int meleeDefence, 
            int rangedDefence, string weakTo, string attackStyle,
            int attackBonus, Locations location)
        {
            ID = id;
            Name = name;
            Health = health;
            CurrentHealth = health;
            MagicDefence = magicDefence;
            MeleeDefence = meleeDefence;
            RangedDefence = rangedDefence;
            WeakTo = weakTo;
            AttackStyle = attackStyle;
            AttackBonus = attackBonus;
            Location = location;
        }
    }
}
