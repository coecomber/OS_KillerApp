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

        public void UpdateEquipped(Character character)
        {
            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                SqlDataReader reader = null;

                _conn.Open();

                //Geef parameter mee met naam stored procedure en geef aan dat het om een stored procedure gaat
                SqlCommand cmd = new SqlCommand("UpdateEquipped", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //Geeft parameters mee met de stored procedure welke mijn stored procedure verwacht/nodig heeft
                cmd.Parameters.Add(new SqlParameter("@EquippedID", character.ID));
                if(character.EquipedWeapon != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@Weapon", character.EquipedWeapon.ID));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Weapon", 1));
                }
                
                if(character.EquipedHelmet != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@Helmet", character.EquipedHelmet.ID));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Helmet", 1));
                }
                
                if(character.EquipedBody != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@Body", character.EquipedBody.ID));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Body", 2));
                }

                if(character.EquipedLegs != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@Legs", character.EquipedLegs.ID));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Legs", 6));
                }

                if(character.EquipedFeet != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@Feet", character.EquipedFeet.ID));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Feet", 5));
                }
               
                cmd.Parameters.Add(new SqlParameter("@Shield", 7));

                reader = cmd.ExecuteReader();

                _conn.Close();
            }
        }
    }
}
