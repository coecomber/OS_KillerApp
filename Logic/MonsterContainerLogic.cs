using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Interfaces.ILogic;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class MonsterContainerLogic : IMonsterContainerLogic
    {
        private IMonsterContainerRepository monsterContainerRepository = new MonsterContainerFactory().GetMonsterContainerRepository();

        public List<Monster> GetAllMonsters()
        {
            return monsterContainerRepository.GetAllMonsters();
        }
    }
}
