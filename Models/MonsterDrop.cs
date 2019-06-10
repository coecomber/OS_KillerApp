using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MonsterDrop
    {
        public int ID { get; set; }
        public int MonsterID { get; set; }
        public int DropID { get; set; }
        public int Chance { get; set; }

        public MonsterDrop(int id, int monsterID, int dropID, int chance)
        {
            ID = id;
            MonsterID = monsterID;
            DropID = dropID;
            Chance = chance;
        }
    }
}
