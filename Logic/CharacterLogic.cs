using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Abstract;
using Logic.Interfaces.ILogic;
using Logic.Item;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class CharacterLogic : LivingCreatureLogic, ICharacterLogic
    {
        private IMonsterDropContainerRepository monsterDropContainerRepository = new MonsterDropContainerFactory().GetMonsterDropContainerRepository();
        private IDropContainerRepository dropContainerRepository = new DropContainerFactory().GetDropContainerRepository();


        public int SlayerAmount { get; set; }

        public CharacterLogic()
        {

        }

        public Monster AttackMonster(Character character, Monster monster)
        {
            //First calculate damage, then distract that from the monsters hp and return the monster after.
            Monster damagedMonster = monster;
            Character hittingCharacter = character;

            //TO-DO: Also calculate str from armours here.
            int totalStrength = hittingCharacter.StrengthLevel;
            if(character.EquipedWeapon != null)
            {
                totalStrength = totalStrength + character.EquipedWeapon.StrengthBonus;
            }
            
            //Calulcates damage here
            totalStrength = RandomizeNumerWithMaxValue(totalStrength);
            int finalDamage = CalculateDamage(totalStrength);
            damagedMonster.CurrentHealth = (damagedMonster.CurrentHealth - finalDamage);

            //If the health is lower than 0 after damaging the monster we set it back to 0 before returning the monster.
            if(damagedMonster.CurrentHealth < 0)
            {
                damagedMonster.CurrentHealth = 0;
            }

            return damagedMonster;
        }

        public Character MonsterKilled(Character character, Monster monster)
        {
            //Loops through all monsterdrops to see if defeating this monster offers a chance on one or multiple items
            foreach(MonsterDrop monsterDrop in monsterDropContainerRepository.GetAllMonsterDrops())
            {
                if(monsterDrop.ID == monster.ID)
                {
                    //Picks a random number 1-100. If this numbers is the same or lower as the chance to get it the player will get it
                    //(this way we created a drop system with drops based on percentages).
                    Random random = new Random();
                    int number = random.Next(1, 100);

                    if(number <= monsterDrop.Chance)
                    {
                        foreach(Drop drop in dropContainerRepository.GetAllDrops())
                        {
                            if(monsterDrop.DropID == drop.DropID)
                            {
                                //If the ID of a item isn't 0 that means it dropped something of that category.
                                //Weapon drop
                                if (drop.WeaponID != 0)
                                {
                                    WeaponLogic weaponLogic = new WeaponLogic();
                                    List<Weapon> weapons = weaponLogic.GetAllWeapons();
                                    foreach (Weapon weapon in weapons)
                                    {
                                        if (weapon.ID == drop.WeaponID)
                                        {
                                            bool added = false;
                                            //If character already has the weapon it needs to up the amount by 1.
                                            foreach(Weapon myWeapon in character.myWeapons)
                                            {
                                                if(myWeapon.Name == weapon.Name)
                                                {
                                                    added = true;
                                                    myWeapon.AddToAmount(1);
                                                }
                                            }

                                            //If the weapon wasn't in the inventory already then add a new one:
                                            if (!added)
                                            {
                                                character.myWeapons.Add(weapon);
                                            }
                                        }
                                    }
                                }

                                //Armour drop
                                if (drop.ArmourID != 0)
                                {
                                    ArmourLogic armourLogic = new ArmourLogic();
                                    List<Armour> armours = armourLogic.GetAllArmours();
                                    foreach (Armour armour in armours)
                                    {
                                        if (armour.ID == drop.ArmourID)
                                        {
                                            armour.Amount = 1;
                                            character.myArmours.Add(armour);
                                        }
                                    }
                                }

                                //Fish drop
                                if(drop.FishID != 0)
                                {
                                    FishItemLogic fishItemLogic = new FishItemLogic();
                                    List<FishItem> fishItems = fishItemLogic.GetAllFishItems();
                                    foreach(FishItem fish in fishItems)
                                    {
                                        if(fish.ID == drop.FishID)
                                        {
                                            fish.Amount = 1;
                                            character.myFishItems.Add(fish);
                                        }
                                    }
                                }

                                //Smithing item drop
                                if(drop.SmithingItemID != 0)
                                {
                                    SmithingItemLogic smithingItemLogic = new SmithingItemLogic();
                                    List<SmithingItem> smithingItems = smithingItemLogic.GetAllSmithingItems();
                                    foreach(SmithingItem smithItem in smithingItems)
                                    {
                                        if(smithItem.ID == drop.SmithingItemID)
                                        {
                                            smithItem.Amount = 1;
                                            character.mySmithingItems.Add(smithItem);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return character;
        }

        public int RandomizeNumerWithMaxValue(int value)
        {
            int randomized = 0;

            Random random = new Random();
            randomized = random.Next(0, value);

            return randomized;
        }

        public int CalculateMaxDamage(int totalStrength)
        {
            int maxDamage = CalculateDamage(totalStrength);

            return maxDamage;
        }
    }
}
