using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SlayerTask
    {
        public int ID { get; set; }
        public int CharacterID { get; set; }
        public int MonsterID { get; set; }
        public int Amount { get; set; }

        public SlayerTask(int id, int characterID, int monsterID, int amount)
        {
            ID = id;
            CharacterID = characterID;
            MonsterID = monsterID;
            Amount = amount;
        }
    }
}
