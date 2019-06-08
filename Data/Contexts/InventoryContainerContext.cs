using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class InventoryContainerContext : Connection, IInventoryContainerContext
    {
        public List<Inventory> GetAllInventories()
        {
            List<Inventory> inventories = new List<Inventory>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllInventories", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["InventoryID"]);
                    int fishID = Convert.ToInt32(reader["FishID"]);
                    int weaponID = Convert.ToInt32(reader["WeaponID"]);
                    int armourID = Convert.ToInt32(reader["ArmourID"]);
                    int smithingItemID = Convert.ToInt32(reader["SmithingItemID"]);
                    int runeID = Convert.ToInt32(reader["RuneID"]);
                    int amount = Convert.ToInt32(reader["Amount"]);
                    int characterID = Convert.ToInt32(reader["CharacterID"]);

                    Inventory inventory = new Inventory(id, fishID, weaponID,
                        armourID, smithingItemID, runeID, amount, characterID);
                    inventories.Add(inventory);
                }
            }
            return inventories;
        }
    }
}
