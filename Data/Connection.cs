using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Connection
    {
        public string connectionString;

        public Connection()
        {
            string connectionString = @"Server=tcp:oskillerapp.database.windows.net,1433;Initial Catalog=OSDatabase;Persist Security Info=False;User ID=Joost;Password=Varken12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=20;";
        }
    }
}
