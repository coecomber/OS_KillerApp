using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Armour
    {
        public int ID { get; set; }
        //TypeArmour
        public int AttackStabBonus { get; set; }
        public int AttackSlashBonus { get; set; }
        public int DefenceStabBonus { get; set; }
        public int DefenceSlashBonus { get; set; }
        public int DefenceRangedBonus { get; set; }
        public int DefenceMagicBonus { get; set; }
        public string ArmourSlot { get; set; }
    }
}
