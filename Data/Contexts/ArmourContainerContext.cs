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
    public class ArmourContainerContext : Connection, IArmourContainerContext
    {
        public List<Armour> GetAllArmours()
        {
            List<Armour> armours = new List<Armour>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllArmours", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ArmourID"]);
                    string name = Convert.ToString(reader["Name"]);
                    int attackStabBonus = Convert.ToInt32(reader["AttackStabBonus"]);
                    int attackSlashBonus = Convert.ToInt32(reader["AttackSlashBonus"]);
                    int defenceStabBonus = Convert.ToInt32(reader["DefenceStabBonus"]);
                    int defenceSlashBonus = Convert.ToInt32(reader["DefenceSlashBonus"]);
                    int defenceRangedBonus = Convert.ToInt32(reader["DefenceRangedBonus"]);
                    int defenceMagicBonus = Convert.ToInt32(reader["DefenceMagicBonus"]);
                    Enum.TryParse(Convert.ToString(reader["Type"]), out ArmourTypes type);
                    int value = Convert.ToInt32(reader["Value"]);
                    string description = Convert.ToString(reader["Description"]);

                    Armour armour = new Armour(id, name, attackStabBonus, attackSlashBonus,
                        defenceStabBonus, defenceSlashBonus, defenceRangedBonus, defenceMagicBonus,
                        type, value, description);
                    armours.Add(armour);
                }
            }
            return armours;
        }
    }
}
