using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class MonsterDropContainerRepository : IMonsterDropContainerRepository
    {
        private IMonsterDropContainerContext context;

        public MonsterDropContainerRepository(IMonsterDropContainerContext context)
        {
            this.context = context;
        }

        public List<MonsterDrop> GetAllMonsterDrops()
        {
            return context.GetAllMonsterDrops();
        }
    }
}
