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

        public void GetCharacterInventory(Character character)
        {
            GetCharacterWeapons(character);
            GetCharacterArmours(character);
            GetCharacterFishes(character);
            GetCharacterSmithingItems(character);
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

        public void GetCharacterArmours(Character character)
        {
            List<Inventory> inventories = GetAllInventories();
            ArmourLogic armourLogic = new ArmourLogic();
            List<Armour> armours = armourLogic.GetAllArmours();

            foreach (var inventory in inventories)
            {
                if (inventory.CharacterID == character.ID)
                {
                    foreach (var armour in armours)
                    {
                        if (armour.ID == inventory.ArmourID)
                        {
                            character.myArmours.Add(armour);
                        }
                    }
                }
            }
        }

        public void GetCharacterFishes(Character character)
        {
            List<Inventory> inventories = GetAllInventories();
            FishItemLogic fishItemLogic = new FishItemLogic();
            List<FishItem> fishItems = fishItemLogic.GetAllFishItems();

            foreach (var inventory in inventories)
            {
                if (inventory.CharacterID == character.ID)
                {
                    foreach (var fishItem in fishItems)
                    {
                        if (fishItem.ID == inventory.FishID)
                        {
                            character.myFishItems.Add(fishItem);
                        }
                    }
                }
            }
        }

        public void GetCharacterSmithingItems(Character character)
        {
            List<Inventory> inventories = GetAllInventories();
            SmithingItemLogic smithingItemLogic = new SmithingItemLogic();
            List<SmithingItem> smithingItems = smithingItemLogic.GetAllSmithingItems();

            foreach (var inventory in inventories)
            {
                if (inventory.CharacterID == character.ID)
                {
                    foreach (var smithingItem in smithingItems)
                    {
                        if (smithingItem.ID == inventory.SmithingItemID)
                        {
                            character.mySmithingItems.Add(smithingItem);
                        }
                    }
                }
            }
        }
    }
}