using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Abstract;
using Logic.Interfaces.ILogic;
using Logic.Interfaces.ILogic.Item;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Item
{
    public class ArmourLogic : ItemLogic, IArmourLogic
    {
        private IArmourContainerRepository armourContainerRepository = new ArmourContainerFactory().GetArmourContainerRepository();

        public List<Armour> GetAllArmours()
        {
            return armourContainerRepository.GetAllArmours();
        }
    }
}
