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
    }
}
