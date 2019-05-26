using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;

namespace DataFactory
{
    public class CharacterContainerFactory
    {
        public ICharacterContainerRepository GetCharacterContainerRepository()
        {
            return new CharacterContainerRepository(new CharacterContainerContext());
        }
    }
}
