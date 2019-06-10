using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class DropContainerRepository : IDropContainerRepository
    {
        private IDropContainerContext context;

        public DropContainerRepository(IDropContainerContext context)
        {
            this.context = context;
        }

        public List<Drop> GetAllDrops()
        {
            return context.GetAllDrops();
        }
    }
}
