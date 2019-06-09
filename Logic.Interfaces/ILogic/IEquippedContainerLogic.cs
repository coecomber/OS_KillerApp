using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface IEquippedContainerLogic
    {
        List<Equipped> GetAllEquipped();
        void GetCharacterEquipped(Character character);
    }
}
