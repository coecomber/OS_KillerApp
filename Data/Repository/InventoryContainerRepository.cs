using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class InventoryContainerRepository : IInventoryContainerRepository
    {
        private IInventoryContainerContext context;

        public InventoryContainerRepository(IInventoryContainerContext context)
        {
            this.context = context;
        }

        public List<Inventory> GetAllInventories()
        {
            return context.GetAllInventories();
        }
    }
}