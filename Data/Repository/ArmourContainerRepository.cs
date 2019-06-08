using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class ArmourContainerRepository : IArmourContainerRepository
    {
        private IArmourContainerContext context;

        public ArmourContainerRepository(IArmourContainerContext context)
        {
            this.context = context;
        }

        public List<Armour> GetAllArmours()
        {
            throw new NotImplementedException();
        }
    }
}
