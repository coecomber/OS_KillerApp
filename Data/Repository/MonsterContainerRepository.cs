using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class MonsterContainerRepository : IMonsterContainerRepository
    {
        private IMonsterContainerContext context;

        public MonsterContainerRepository(IMonsterContainerContext context)
        {
            this.context = context;
        }

        public List<Monster> GetAllMonsters()
        {
            return context.GetAllMonsters();
        }
    }
}
