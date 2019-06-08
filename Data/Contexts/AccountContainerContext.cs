using Data.IContexts;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Contexts
{
    public class AccountContainerContext : Connection, IAccountContainerContext
    {
        public void InsertAccount(Account account)
        {
            string username = account.Username;
            string password = account.Password;
            string email = account.Email;

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();
                    string query = "INSERT INTO [Account] (username, password, email) " +
                                    "VALUES " +
                                    "(@username, @password, @email)";
                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
                        cmd.Parameters["@username"].Value = username;
                        cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
                        cmd.Parameters["@password"].Value = password;
                        cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
                        cmd.Parameters["@email"].Value = email;

                        cmd.ExecuteNonQuery();
                    }
                    _conn.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public Account GetAccount(string username, string password)
        {
            Account account = new Account();
            SqlDataReader reader = null;

            try
            {
                using (SqlConnection _conn = new SqlConnection(connectionString))
                {
                    _conn.Open();

                    //Geef parameter mee met naam stored procedure en geef aan dat het om een stored procedure gaat
                    SqlCommand cmd = new SqlCommand("GetAccountByUsername", _conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Geeft parameters mee met de stored procedure welke mijn stored procedure verwacht/nodig heeft
                    cmd.Parameters.Add(new SqlParameter("@Username", username));

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        bool isAdmin = false;

                        account.Username = (Convert.ToString(reader["Username"]));
                        account.Email = (Convert.ToString(reader["Email"]));
                        account.ID = (Convert.ToInt32(reader["AccountID"]));
                        account.Password = (Convert.ToString(reader["Password"]));

                        if (Convert.ToInt32(reader["IsAdmin"]) == 1) isAdmin = true;
                        account.IsAdmin = isAdmin;
                    }

                    _conn.Close();
                }
            }
            catch (Exception ex)
            {

            }

            return account;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            SqlDataReader reader = null;

            using (SqlConnection _conn = new SqlConnection(connectionString))
            {
                _conn.Open();

                //Geef parameter mee met naam stored procedure en geef aan dat het om een stored procedure gaat
                SqlCommand cmd = new SqlCommand("GetAllAccounts", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["AccountID"]);
                    string username = Convert.ToString(reader["Username"]);
                    bool isAdmin = false;
                    if (Convert.ToInt32(reader["IsAdmin"]) == 1)
                    {
                        isAdmin = true;
                    }
                    string email = Convert.ToString(reader["Email"]);
                    string password = Convert.ToString(reader["Password"]);
                    int characterId = Convert.ToInt32(reader["CharacterID"]);

                    Account account = new Account(id, username, password, email, isAdmin, characterId);
                    accounts.Add(account);
                }
            }
            return accounts;
        }

        ///SAMENVATTING
        ///Hieronder zien we de methode "GetAllAccounts() zonder stored procedure.
        ///Ik heb ervoor gekozen deze te laten staan om ook aan te kunnen tonen
        ///Dat ik uiteraard ook weet hoe we data kunnen ophalen zonder stored procedure.
        //public List<Account> GetAllAccounts()
        //{
        //    List<Account> accounts = new List<Account>();

        //    using (SqlConnection _conn = new SqlConnection(connectionString))
        //    {
        //        _conn.Open();
        //        string query = "SELECT * FROM [Account]";
        //        using (SqlCommand cmd = new SqlCommand(query, _conn))
        //        {
        //            cmd.CommandType = System.Data.CommandType.Text;

        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        int id = Convert.ToInt32(reader["AccountID"]);
        //                        string username = Convert.ToString(reader["Username"]);
        //                        bool isAdmin = false;
        //                        if (Convert.ToInt32(reader["IsAdmin"]) == 1)
        //                        {
        //                            isAdmin = true;
        //                        }
        //                        string email = Convert.ToString(reader["Email"]);
        //                        string password = Convert.ToString(reader["Password"]);
        //                        int characterId = Convert.ToInt32(reader["CharacterID"]);

        //                        Account account = new Account(id, username, password, email, isAdmin, characterId);

        //                        accounts.Add(account);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return accounts;
        //}
    }
}