﻿using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CharacterContainerRepository : ICharacterContainerRepository
    {
        private ICharacterContainerContext context;

        public CharacterContainerRepository(ICharacterContainerContext context)
        {
            this.context = context;
        }

        public Character GetCharacterByCharacterID(int characterID)
        {
            return context.GetCharacterByID(characterID);
        }

        public List<Character> GetAllCharacters() => context.GetAllCharacters();

        public void UpdateCharacter(Character character)
        {
            context.UpdateCharacter(character);
        }
    }
}
