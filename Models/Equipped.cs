using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Equipped
    {
        public int EquppedID { get; set; }
        public int WeaponID { get; set; }
        public int HelmetID { get; set; }
        public int BodyID { get; set; }
        public int LegsID { get; set; }
        public int FeetID { get; set; }

        public Equipped(int equippedID, int weaponID,
            int helmetID, int bodyID, int legsID, int feetID)
        {
            EquppedID = equippedID;
            WeaponID = weaponID;
            HelmetID = helmetID;
            BodyID = bodyID;
            LegsID = legsID;
            FeetID = feetID;
        }
    }
}
