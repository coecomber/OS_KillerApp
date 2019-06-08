using Logic.Item;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class WeaponLogicFactory
    {
        public IWeaponLogic GetWeaponLogic()
        {
            return new WeaponLogic();
        }
    }
}
