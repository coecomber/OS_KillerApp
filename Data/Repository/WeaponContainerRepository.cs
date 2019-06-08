using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System.Collections.Generic;

namespace Data.Repository
{
    public class WeaponContainerRepository : IWeaponContainerRepository
    {
        private IWeaponContainerContext context;

        public WeaponContainerRepository(IWeaponContainerContext context)
        {
            this.context = context;
        }

        public List<Weapon> GetAllWeapons()
        {
            return context.GetAllWeapons();
        }
    }
}
