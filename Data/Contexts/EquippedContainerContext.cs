using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class EquippedContainerContext : Connection, IEquippedContainerContext
    {
        public List<Equipped> GetAllEquipped()
        {
            List<Equipped> equippedItems = new List<Equipped>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllEquipped", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["EquippedID"]);
                    int weaponID = Convert.ToInt32(reader["Weapon"]);
                    int helmetID = Convert.ToInt32(reader["Helmet"]);
                    int bodyID = Convert.ToInt32(reader["Body"]);
                    int legsID = Convert.ToInt32(reader["Legs"]);
                    int feetID = Convert.ToInt32(reader["Feet"]);

                    Equipped equipped= new Equipped(id, weaponID, helmetID,
                        bodyID, legsID, feetID);
                    equippedItems.Add(equipped);
                }
            }
            return equippedItems;
        }
    }
}
