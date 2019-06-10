using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFactory
{
    public class DropContainerFactory
    {
        public IDropContainerRepository GetDropContainerRepository()
        {
            return new DropContainerRepository(new DropContainerContext());
        }
    }
}
