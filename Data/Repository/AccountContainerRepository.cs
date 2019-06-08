using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;

namespace Data.Repository
{
    public class AccountContainerRepository : IAccountContainerRepository
    {
        private IAccountContainerContext context;

        public AccountContainerRepository(IAccountContainerContext context)
        {
            this.context = context;
        }

        public Account GetAccount(string username, string password)
        {
            return context.GetAccount(username, password);
        }

        public void InsertAccount(Account account) => context.InsertAccount(account);
    }
}
