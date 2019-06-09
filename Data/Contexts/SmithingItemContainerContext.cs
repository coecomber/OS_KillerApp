using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class SmithingItemContainerContext : Connection, ISmithingItemContainerContext
    {
        public List<SmithingItem> GetAllSmithingItems()
        {
            List<SmithingItem> smithingItems = new List<SmithingItem>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllSmithingItems", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SmithingItemID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int isBar = Convert.ToInt32(reader["IsBar"]);
                    int value = Convert.ToInt32(reader["Value"]);
                    string description = Convert.ToString(reader["Description"]);

                    bool isBarBool = false;
                    if(isBar == 1)
                    {
                        isBarBool = true;
                    }

                    SmithingItem smithingItem = new SmithingItem(id, name, isBarBool, value, description);
                    smithingItems.Add(smithingItem);
                }
            }
            return smithingItems;
        }
    }
}
