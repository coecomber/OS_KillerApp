using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class SmithingItemContainerRepository : ISmithingItemContainerRepository
    {
        private ISmithingItemContainerContext context;

        public SmithingItemContainerRepository(ISmithingItemContainerContext context)
        {
            this.context = context;
        }

        public List<SmithingItem> GetAllSmithingItems()
        {
            throw new NotImplementedException();
        }
    }
}
