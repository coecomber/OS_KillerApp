using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFactory.Item
{
    public class FishItemContainerFactory
    {
        public IFishContainerRepository GetFishContainerRepository()
        {
            return new FishContainerRepository(new FishContainerContext());
        }
    }
}
