using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    class FishContainerRepository : IFishContainerRepository
    {
        private IFishContainerContext context;

        public FishContainerRepository(IFishContainerContext context)
        {
            this.context = context;
        }

        public List<FishItem> GetAllFishes()
        {
            throw new NotImplementedException();
        }
    }
}
