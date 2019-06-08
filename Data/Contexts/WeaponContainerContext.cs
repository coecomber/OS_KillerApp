using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Contexts
{
    public class WeaponContainerContext : Connection, IWeaponContainerContext
    {
        public List<Weapon> GetAllWeapons()
        {
            List<Weapon> weapons = new List<Weapon>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllWeapons", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["WeaponID"]);
                    string name = Convert.ToString(reader["Name"]);
                    string attackStyle = Convert.ToString(reader["AttackStyle"]);
                    int strengthBonus = Convert.ToInt32(reader["StrengthBonus"]);
                    int attackBonus = Convert.ToInt32(reader["AttackBonus"]);
                    int attackRequirement = Convert.ToInt32(reader["AttackRequirement"]);
                    int attackStabBonus = Convert.ToInt32(reader["AttackStabBonus"]);
                    int attackSlashBonus = Convert.ToInt32(reader["AttackSlashBonus"]);
                    int value = Convert.ToInt32(reader["Value"]);
                    string description = Convert.ToString(reader["Description"]);

                    Weapon weapon = new Weapon(id, name, attackStyle, strengthBonus,
                        attackBonus, attackRequirement, attackStabBonus, attackSlashBonus,
                        value, description);
                    weapons.Add(weapon);
                }
            }
            return weapons;
        }
    }
}
