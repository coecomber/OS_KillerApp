using Data.Contexts;
using Data.Interfaces;
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
