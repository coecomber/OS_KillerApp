using Data.Interfaces.IRepository;
using DataFactory.Item;
using Logic.Abstract;
using Logic.Interfaces.ILogic.Item;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Item
{
    public class FishItemLogic : ItemLogic, IFishItemLogic
    {
        private IFishContainerRepository fishContainerRepository = new FishItemContainerFactory().GetFishContainerRepository();

        public List<FishItem> GetAllFishItems()
        {
            return fishContainerRepository.GetAllFishes();
        }
    }
}
