using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data.Contexts
{
    public class SlayerTaskContainerContext : Connection, ISlayerTaskContainerContext
    {
        public List<SlayerTask> GetAllSlayerTasks()
        {
            List<SlayerTask> slayerTasks = new List<SlayerTask>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("GetAllSlayerTasks", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SlayerTaskID"]);
                    int characterID = Convert.ToInt32(reader["CharacterID"]);
                    int monsterID = Convert.ToInt32(reader["MonsterID"]);
                    int amount = Convert.ToInt32(reader["Amount"]);

                    SlayerTask slayerTask = new SlayerTask(id, characterID, monsterID, amount);
                    slayerTasks.Add(slayerTask);
                }
            }
            return slayerTasks;
        }
    }
}
