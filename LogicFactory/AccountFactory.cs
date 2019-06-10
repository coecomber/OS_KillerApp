using Logic;
using Logic.Interfaces;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class AccountFactory
    {
        public IAccountLogic GetAccountLogic()
        {
            return new AccountLogic();
        }
    }
}
