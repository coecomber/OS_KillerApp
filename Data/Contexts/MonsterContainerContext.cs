using Data.IContexts;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class MonsterContainerContext : Connection, IMonsterContainerContext
    {
        public List<Monster> GetAllMonsters()
        {
            List<Monster> monsters = new List<Monster>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllMonsters", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["MonsterID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int health = Convert.ToInt32(reader["Health"]);
                    int magicDefence = Convert.ToInt32(reader["MagicDefence"]);
                    int meleeDefence = Convert.ToInt32(reader["MeleeDefence"]);
                    int rangedDefence = Convert.ToInt32(reader["RangedDefence"]);
                    string weakTo = Convert.ToString(reader["WeakTo"]);
                    string attackStyle = Convert.ToString(reader["AttackStyle"]);
                    int attackBonus = Convert.ToInt32(reader["AttackBonus"]);
                    Enum.TryParse(Convert.ToString(reader["Location"]), out Locations location);

                    Monster monster = new Monster(id, name, health, magicDefence,
                        meleeDefence, rangedDefence, weakTo, attackStyle, attackBonus, location);
                    monsters.Add(monster);
                }
            }
            return monsters;
        }
    }
}
