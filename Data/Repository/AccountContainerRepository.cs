using Data.IContexts;
using Data.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class AccountContainerRepository : IAccountContainerRepository
    {
        private IAccountContainerContext context;

        public AccountContainerRepository(IAccountContainerContext context)
        {
            this.context = context;
        }

        public Account GetAccount(string username, string password)
        {
            return context.GetAccount(username, password);
        }

        public void InsertAccount(Account account) => context.InsertAccount(account);
    }
}
