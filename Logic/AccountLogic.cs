using Data.Interfaces;
using System;

namespace Logic
{
    public class AccountLogic
    {
        IAccountRepository accountRepository;

        public AccountLogic(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
    }
}
