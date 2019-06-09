using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFactory.Item
{
    public class SmithingItemContainerFactory
    {
        public ISmithingItemContainerRepository GetSmithingItemContainerRepository()
        {
            return new SmithingItemContainerRepository(new SmithingItemContainerContext());
        }
    }
}
