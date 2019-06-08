using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface IInventoryContainerLogic
    {
        List<Inventory> GetAllInventories();
        void GetCharacterWeapons(Character character);
    }
}
