using Data.Interfaces.IRepository;
using DataFactory.Item;
using Logic.Abstract;
using Logic.Interfaces.ILogic.Skill;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Skill
{
    public class FishingLogic : SkillLogic, IFishingLogic
    {
        private IFishContainerRepository fishItemContainerRepository = new FishItemContainerFactory().GetFishContainerRepository();

        public Character CatchFish(Character character, string fishName, bool alwaysCatch)
        {
            List<FishItem> fishItems = fishItemContainerRepository.GetAllFishes();

            //Check what fish in the database we're catching
            foreach(FishItem fishItem in fishItems)
            {
                if(fishName == fishItem.Name)
                {
                    Random random = new Random();
                    int fishRoll = random.Next(1, 100);
                    int playerRoll = random.Next(character.FishingLevel, 100); //random number between players fishing level and 100

                    if(playerRoll < 90)
                    {
                        playerRoll =+ 10;
                    }
                    if(playerRoll >= 90)
                    {
                        playerRoll = 100;
                    }

                    //If players roll is higher than the fish we catch it.
                    if(playerRoll >= fishRoll || alwaysCatch)
                    {
                        character.FishingExperience = character.FishingExperience + 40;

                        bool added = false;
                        //If we already have this fish we need to increase the amount by 1
                        foreach(FishItem myFishItem in character.myFishItems)
                        {
                            if(myFishItem.Name == fishItem.Name)
                            {
                                added = true;
                                myFishItem.AddToAmount(1);
                            }
                        }

                        //If the character didn't already have such a fish then we need to add a new one:
                        if (!added)
                        {
                            fishItem.Amount = 1;
                            character.myFishItems.Add(fishItem);
                        }
                    }
                }
            }

            return character;
        }
    }
}
