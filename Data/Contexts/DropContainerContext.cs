using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class DropContainerContext : Connection, IDropContainerContext
    {
        public List<Drop> GetAllDrops()
        {
            List<Drop> drops = new List<Drop>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllDrops", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["DropID"]);
                    int fishID = Convert.ToInt32(reader["FishID"]);
                    int weaponID = Convert.ToInt32(reader["WeaponID"]);
                    int armourID = Convert.ToInt32(reader["ArmourID"]);
                    int smithingItemID = Convert.ToInt32(reader["SmithingItemID"]);
                    int runeID = Convert.ToInt32(reader["RuneID"]);
                    int amount = Convert.ToInt32(reader["Amount"]);

                    Drop drop = new Drop(id, fishID, weaponID, armourID, 
                        smithingItemID, runeID, amount);
                    drops.Add(drop);
                }
            }
            return drops;
        }
    }
}
