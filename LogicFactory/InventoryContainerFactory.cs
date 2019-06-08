using Logic;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class InventoryContainerFactory
    {
        public IInventoryContainerLogic GetInventoryContainerLogic()
        {
            return new InventoryContainerLogic();
        }
    }
}
