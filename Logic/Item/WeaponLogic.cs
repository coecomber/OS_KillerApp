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
    public class WeaponLogic : ItemLogic, IWeaponLogic
    {
        private IWeaponContainerRepository weaponContainerRepository = new WeaponContainerFactory().GetWeaponContainerRepository();

        public List<Weapon> GetAllWeapons()
        {
            return weaponContainerRepository.GetAllWeapons();
        }
    }
}
