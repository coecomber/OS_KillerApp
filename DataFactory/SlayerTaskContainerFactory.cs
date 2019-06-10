using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFactory
{
    public class SlayerTaskContainerFactory
    {
        public ISlayerTaskContainerRepository GetSlayerTaskContainerRepository()
        {
            return new SlayerTaskContainerRepository(new SlayerTaskContainerContext());
        }
    }
}
