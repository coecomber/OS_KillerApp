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
    public class SmithingItemLogic : ItemLogic, ISmithingItemLogic
    {
        private ISmithingItemContainerRepository smithingContainerRepository = new SmithingItemContainerFactory().GetSmithingItemContainerRepository();

        public List<SmithingItem> GetAllSmithingItems()
        {
            return smithingContainerRepository.GetAllSmithingItems();
        }
    }
}
