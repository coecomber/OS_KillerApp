using Data.Interfaces.IRepository;
using DataFactory.Item;
using Logic.Abstract;
using Logic.Interfaces.ILogic.Skill;
using Logic.Item;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Skill
{
    public class SmithingLogic : SkillLogic, ISmithingLogic
    {
        private ISmithingItemContainerRepository smithingItemContainerRepository = new SmithingItemContainerFactory().GetSmithingItemContainerRepository();

        public Character SmithBar(Character character, string oreName)
        {
            bool removedOre = false;
            //Loop trough all the smithing items of a character to see if it matches with the ore from the method parameter
            foreach (SmithingItem mySmithingItem in character.mySmithingItems)
            {
                if (mySmithingItem.Name == oreName)
                {
                    if (mySmithingItem.Amount > 0)
                    {
                        //Withdraw this ore from the players inventory.
                        mySmithingItem.AddToAmount(-1);
                        removedOre = true;
                    }
                }
            }

            if (removedOre)
            {
                bool addedBar = false;
                SmithingItem smithingItemToAdd = new SmithingItem();

                //Add cooked fish to characters inventory
                string smithingToAdd = oreName.Replace("ore", "bar");

                //Checks if we already have this item so we can increase the amount by one
                foreach (SmithingItem mySmithingItems in character.mySmithingItems)
                {
                    //we allready have the item
                    if (mySmithingItems.Name == smithingToAdd && addedBar == false)
                    {
                        mySmithingItems.AddToAmount(1);
                        addedBar = true;
                        character.SmithingExperience += 190;
                    }
                }

                //we don't have this item yet
                if (addedBar == false)
                {
                    foreach (SmithingItem allSmithingItems in smithingItemContainerRepository.GetAllSmithingItems())
                    {
                        if (smithingToAdd == allSmithingItems.Name)
                        {
                            smithingItemToAdd = allSmithingItems;
                            smithingItemToAdd.Amount = 1;
                            character.mySmithingItems.Add(smithingItemToAdd);
                            character.SmithingExperience += 190;
                        }
                    }
                }
            }

            return character;
        }

        public Character SmithItem(Character character, string barName, string itemCraftName, int barAmountToDistract)
        {
            //First we need to remove the amount of bars from the player that is needed to craft this item.
            bool removedBars = false;
            foreach(SmithingItem mySmithingItem in character.mySmithingItems)
            {
                if(mySmithingItem.Name == barName)
                {
                    if(mySmithingItem.Amount >= barAmountToDistract)
                    {
                        mySmithingItem.AddToAmount(-barAmountToDistract);
                        removedBars = true;
                    }
                }
            }

            if (removedBars)
            {
                string itemToMake = barName.Replace(" bar", "");
                itemToMake = itemToMake + " " + itemCraftName;

                //If the removal of the bars from the player was a succes we can now make and add the item to the players inventory.
                //This can either be a piece of armour or a weapon so we need to check both.
                WeaponLogic weaponLogic = new WeaponLogic();
                bool weaponAdded = false;
                foreach (Weapon weapon in weaponLogic.GetAllWeapons())
                {
                    //First we check if this is the item that we need to add to our inventory for every weapon.
                    if(weapon.Name == itemToMake)
                    {
                        //If the player already has this item we can add 1 to the amount.
                        foreach (Weapon myWeapon in character.myWeapons)
                        {
                            //We already have this weapon
                            if (myWeapon.Name == itemToMake)
                            {
                                myWeapon.Amount += 1;
                                character.SmithingExperience += 10;
                                weaponAdded = true;
                            }
                        }

                        //If the player doesn't have this item yet we can create it.
                        if (weapon.Name == itemToMake && !weaponAdded)
                        {
                            weapon.Amount = 1;
                            character.myWeapons.Add(weapon);
                            weaponAdded = true;
                        }
                    }
                }

                bool armourAdded = false;
                ArmourLogic armourLogic = new ArmourLogic();
                foreach(Armour armour in armourLogic.GetAllArmours())
                {
                    //First we check if this is the item that we need to add to our inventory for every piece of armour.
                    if (armour.Name == itemToMake)
                    {
                        //If the player already has this item we can add 1 to the amount.
                        foreach (Armour myArmour in character.myArmours)
                        {
                            //We already have this weapon
                            if (myArmour.Name == itemToMake)
                            {
                                myArmour.Amount += 1;
                                character.SmithingExperience += 10;
                                armourAdded = true;
                            }
                        }

                        //If the player doesn't have this item yet we can create it.
                        if (armour.Name == itemToMake && !armourAdded)
                        {
                            armour.Amount = 1;
                            character.myArmours.Add(armour);
                            armourAdded = true;
                        }
                    }
                }
            }

            return character;
        }
    }
}
