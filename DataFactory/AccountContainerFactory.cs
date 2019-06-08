using Data.Contexts;
using Data.Interfaces.IRepository;
using Data.Repository;

namespace DataFactory
{
    public class AccountContainerFactory
    {
        public IAccountContainerRepository GetAccountContainerRepository()
        {
            return new AccountContainerRepository(new AccountContainerContext());
        }
    }
}
