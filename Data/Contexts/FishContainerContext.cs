using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class FishContainerContext : Connection, IFishContainerContext
    {
        public List<FishItem> GetAllFishes()
        {
            List<FishItem> fishes = new List<FishItem>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllFishes", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["FishID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int isRaw = Convert.ToInt32(reader["IsRaw"]);
                    int healValue = Convert.ToInt32(reader["HealValue"]);
                    int value = Convert.ToInt32(reader["Value"]);
                    string description = Convert.ToString(reader["Description"]);
                    bool isRawBool = false;

                    if(isRaw == 1)
                    {
                        isRawBool = true;
                    }

                    FishItem fish = new FishItem(id, name, isRawBool,
                        healValue, value, description);
                    fishes.Add(fish);
                }
            }
            return fishes;
        }
    }
}
