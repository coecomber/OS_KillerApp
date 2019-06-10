using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Interfaces.ILogic;
using Logic.Item;
using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class EquippedContainerLogic : IEquippedContainerLogic
    {
        private IEquippedContainerRepository equippedContainerRepository = new EquippedContainerFactory().GetEquippedContainerRepository();

        public Character EquipArmour(Character character, int armourID)
        {
            throw new NotImplementedException();
        }

        public Character EquipWeapon(Character character, int weaponID)
        {
            bool needToAddAmountToCurrentWeapon = false;

            //If the player currently has a weapon equipped it needs to return to the inventory first
            if (character.EquipedWeapon != null)
            {
                //Loops through all items in inventory so we can add 1 to ammount if it's an item we already have in the inventory
                foreach (Weapon weapon in character.myWeapons)
                {
                    //The item is already in the inventory, this means we need to add the amount of this weapon by 1
                    if (weapon.ID == character.EquipedWeapon.ID)
                    {
                        needToAddAmountToCurrentWeapon = true;
                        weapon.AddToAmount(1);
                    }

                }
            }

            //We didn't add amount by 1 to an item so we need to add the currently equipped weapon to the list as a new weapon
            if (!needToAddAmountToCurrentWeapon)
            {
                if (character.EquipedWeapon != null)
                {
                    Weapon weaponToAdd = character.EquipedWeapon;
                    weaponToAdd.Amount = 1;
                    character.myWeapons.Add(weaponToAdd);
                }
            }

            bool removeWeapon = false;
            int removeWeaponIndex = 0;

            WeaponLogic weaponLogic = new WeaponLogic();
            //Gets all weapons
            List<Weapon> weapons = weaponLogic.GetAllWeapons();
            foreach(Weapon weapon in weapons)
            {
                if(weapon.ID == weaponID)
                {
                    character.EquipedWeapon = weapon;
                    foreach(Weapon myWeapon in character.myWeapons)
                    {
                        if(myWeapon.ID == weaponID)
                        {
                            myWeapon.Amount -= 1;

                            if(myWeapon.Amount == 0)
                            {
                                removeWeapon = true;
                                removeWeaponIndex = character.myWeapons.IndexOf(myWeapon);
                            }
                        }
                    }
                }
            }

            if (removeWeapon)
            {
                List<Weapon> newWeapons = character.myWeapons;
                newWeapons.RemoveAt(removeWeaponIndex);
                character.myWeapons = newWeapons;
            }

            return character;
        }

        public List<Equipped> GetAllEquipped()
        {
            return equippedContainerRepository.GetAllEquipped();
        }

        public void GetCharacterEquipped(Character character)
        {
            List<Equipped> equippeds = GetAllEquipped();

            foreach(var equipped in equippeds)
            {
                if(equipped.EquppedID == character.ID)
                {
                    //sets weapon
                    WeaponLogic weaponLogic = new WeaponLogic();
                    List<Weapon> weapons = weaponLogic.GetAllWeapons();
                    foreach(Weapon weapon in weapons)
                    {
                        if(weapon.ID == equipped.WeaponID)
                        {
                            character.EquipedWeapon = weapon;
                        }
                    }

                    //sets armour
                    ArmourLogic armourLogic = new ArmourLogic();
                    List<Armour> armours = armourLogic.GetAllArmours();
                    foreach(Armour armour in armours)
                    {
                        if (armour.ID == equipped.HelmetID)
                        {
                            character.EquipedHelmet = armour;
                        }
                        if (armour.ID == equipped.BodyID)
                        {
                            character.EquipedBody = armour;
                        }
                        if (armour.ID == equipped.LegsID)
                        {
                            character.EquipedLegs = armour;
                        }
                        if (armour.ID == equipped.FeetID)
                        {
                            character.EquipedFeet = armour;
                        }
                    }
                }
            }
        }
    }
}
