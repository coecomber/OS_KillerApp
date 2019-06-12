using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.IContexts
{
    public interface IEquippedContainerContext
    {
        List<Equipped> GetAllEquipped();
        void UpdateEquipped(Character character);
    }
}
