using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class CharacterContainerContext : Connection, ICharacterContainerContext
    {
        public Character GetCharacterByID(int characterID)
        {
            Character character = new Character();
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();

                    //Geef parameter mee met naam stored procedure en geef aan dat het om een stored procedure gaat
                    SqlCommand cmd = new SqlCommand("GetCharacterByCharacterID", _conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Geeft parameters mee met de stored procedure welke mijn stored procedure verwacht/nodig heeft
                    cmd.Parameters.Add(new SqlParameter("@CharacterID", characterID));

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        character.ID = (Convert.ToInt32(reader["CharacterID"]));
                        character.Name = (Convert.ToString(reader["Username"]));
                        character.Gold = (Convert.ToInt32(reader["Gold"]));

                        character.FishingExperience = (Convert.ToInt32(reader["FishingExperience"]));
                        character.CookingExperience = (Convert.ToInt32(reader["CookingExperience"]));
                        character.SmithingExperience = (Convert.ToInt32(reader["SmithingExperience"]));
                        character.SlayerExperience = (Convert.ToInt32(reader["SlayerExperience"]));
                        character.StrengthExperience = (Convert.ToInt32(reader["StrengthExperience"]));
                        character.AttackExperience = (Convert.ToInt32(reader["AttackExperience"]));
                        character.DefenceExperience = (Convert.ToInt32(reader["DefenceExperience"]));
                        character.HitpointsExperience = (Convert.ToInt32(reader["HitpointsExperience"]));
                        character.RangedExperience = (Convert.ToInt32(reader["RangedExperience"]));
                        character.MagicExperience = (Convert.ToInt32(reader["MagicExperience"]));
                    }

                    _conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return character;
        }

        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }
    }
}