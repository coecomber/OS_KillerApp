using Data.Interfaces.IRepository;
using DataFactory;
using DataFactory.Item;
using Logic.Abstract;
using Logic.Interfaces.ILogic.Skill;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Skill
{
    public class CookingLogic : SkillLogic, ICookingLogic
    {
        private IFishContainerRepository fishContainerRepository = new FishItemContainerFactory().GetFishContainerRepository();

        public void CookFish(Character character, string fishItem)
        {
            bool cookedFish = false;
            //Loop trough all the fishes of a character to see if it matches with the string parameter of this method
            foreach(FishItem myFishItem in character.myFishItems)
            {
                if(myFishItem.Name == fishItem)
                {
                    if(myFishItem.Amount > 0)
                    {
                        //Withdraw this fish from the players inventory and set bool so we know we cooked the fish
                        myFishItem.AddToAmount(-1);
                        cookedFish = true;
                    }
                }
            }

            if (cookedFish)
            {
                bool addedFish = false;
                FishItem fishItemToAdd = new FishItem();

                //Add cooked fish to characters inventory
                string fishToAdd = fishItem.Replace("Raw ", "");

                //Checks if we already have this item so we can increase the amount by one
                foreach (FishItem myFishItems in character.myFishItems)
                {
                    //we allready have the item
                    if (myFishItems.Name == fishToAdd && addedFish == false)
                    {
                        myFishItems.AddToAmount(1);
                        character.CookingExperience += 44;
                        addedFish = true;
                    }
                }

                //we don't have this item yet
                if (addedFish == false)
                {
                    foreach (FishItem allfishItem in fishContainerRepository.GetAllFishes())
                    {
                        if(fishToAdd == allfishItem.Name)
                        {
                            fishItemToAdd = allfishItem;
                            fishItemToAdd.Amount = 1;
                            fishItemToAdd.Name = fishToAdd;
                            character.myFishItems.Add(fishItemToAdd);
                            character.CookingExperience += 44;
                        }
                    }
                }
            }
        }
    }
}