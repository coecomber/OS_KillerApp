using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface IAccountContainerRepository
    {
        Account GetAccount(string username, string password);

        void InsertAccount(Account account);
    }
}
