using Logic.Item;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces.ILogic.Item;

namespace LogicFactory.Item
{
    public class WeaponLogicFactory
    {
        public IWeaponLogic GetWeaponLogic()
        {
            return new WeaponLogic();
        }
    }
}
