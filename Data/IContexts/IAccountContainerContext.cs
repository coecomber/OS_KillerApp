using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.IContexts
{
    public interface IAccountContainerContext
    {
        List<Account> GetAllAccounts();

        Account GetAccount(string username, string password);

        void InsertAccount(Account account);
    }
}
