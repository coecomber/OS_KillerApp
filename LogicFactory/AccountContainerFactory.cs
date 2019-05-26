using Logic;
using Logic.Interfaces.ILogic;
using System;

namespace LogicFactory
{
    public class AccountContainerFactory
    {
        public IAccountContainerLogic GetAccountContainerLogic()
        {
            return new AccountContainerLogic();
        }
    }
}
