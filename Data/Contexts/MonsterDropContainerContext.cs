using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class MonsterDropContainerContext : Connection, IMonsterDropContainerContext
    {
        public List<MonsterDrop> GetAllMonsterDrops()
        {
            List<MonsterDrop> monsterDrops = new List<MonsterDrop>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllMonsterDrops", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["MonsterDropID"]);
                    int monsterID = Convert.ToInt32(reader["MonsterID"]);
                    int dropID = Convert.ToInt32(reader["DropID"]);
                    int chance = Convert.ToInt32(reader["Chance"]);

                    MonsterDrop monsterdrop = new MonsterDrop(id, monsterID, dropID, chance);
                    monsterDrops.Add(monsterdrop);
                }
            }
            return monsterDrops;
        }
    }
}
