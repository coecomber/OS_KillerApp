using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFactory
{
    public class EquippedContainerFactory
    {
        public IEquippedContainerRepository GetEquippedContainerRepository()
        {
            return new EquipedContainerRepository(new EquippedContainerContext());
        }
    }
}
