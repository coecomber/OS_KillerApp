using Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class EquippedContainerLogicFactory
    {
        public EquippedContainerLogic GetEquippedLogic()
        {
            return new EquippedContainerLogic();
        }
    }
}
