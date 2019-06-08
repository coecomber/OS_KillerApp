using Data.IContexts;
using Data.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class EquipedContainerRepository : IEquippedContainerRepository
    {
        private IEquippedContainerContext context;

        public EquipedContainerRepository(IEquippedContainerContext context)
        {
            this.context = context;
        }
    }
}