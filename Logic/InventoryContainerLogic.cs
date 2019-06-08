using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Interfaces.ILogic;
using Logic.Item;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class InventoryContainerLogic : IInventoryContainerLogic
    {
        private IInventoryContainerRepository InventoryContainerRepository = new InventoryContainerFactory().GetInventoryContainerRepository();

        public List<Inventory> GetAllInventories()
        {
            return InventoryContainerRepository.GetAllInventories();
        }

        public void GetCharacterWeapons(Character character)
        {
            List<Inventory> inventories = GetAllInventories();
            WeaponLogic weaponLogic = new WeaponLogic();
            List<Weapon> weapons = weaponLogic.GetAllWeapons();

            foreach(var inventory in inventories)
            {
                if(inventory.CharacterID == character.ID)
                {
                    foreach(var weapon in weapons)
                    {
                        if(weapon.ID == inventory.WeaponID)
                        {
                            character.myWeapons.Add(weapon);
                        }
                    }
                }
            }
        }
    }
}