using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Weapon
    {
        public int ID { get; set; }
        public string AttackStyle { get; set; }
        public int StrengthBonus { get; set; }
        public int AttackBonus { get; set; }
        public int AttackRequirement { get; set; }
        public int AttackStabBonus { get; set; }
        public int AttackSlashBonus { get; set; }
    }
}
