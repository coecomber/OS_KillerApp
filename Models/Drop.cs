using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Drop
    {
        public int DropID { get; set; }
        public int FishID { get; set; }
        public int WeaponID { get; set; }
        public int ArmourID { get; set; }
        public int SmithingItemID { get; set; }
        public int RuneID { get; set; }
        public int Amount { get; set; }

        public Drop(int dropID, int fishID, int weaponID, int armourID,
            int smithingItemID, int runeID, int amount)
        {
            DropID = dropID;
            FishID = fishID;
            WeaponID = weaponID;
            ArmourID = armourID;
            SmithingItemID = smithingItemID;
            RuneID = runeID;
            Amount = amount;
        }
    }
}
