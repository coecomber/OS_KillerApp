using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;

namespace DataFactory
{
    public class WeaponContainerFactory
    {
        public IWeaponContainerRepository GetWeaponContainerRepository()
        {
            return new WeaponContainerRepository(new WeaponContainerContext());
        }
    }
}
