using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFactory
{
    public class ArmourContainerFactory
    {
        public IArmourContainerRepository GetArmourContainerRepository()
        {
            return new ArmourContainerRepository(new ArmourContainerContext());
        }
    }
}
