using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces.IRepository
{
    public interface IEquippedContainerRepository
    {
        List<Equipped> GetAllEquipped();
        void UpdateEquipped(Character character);
    }
}
