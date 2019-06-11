using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Interfaces.ILogic;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class CharacterContainerLogic : ICharacterContainerLogic
    {
        private ICharacterContainerRepository characterContainerRepository = new CharacterContainerFactory().GetCharacterContainerRepository();

        public List<Character> GetAllCharacters()
        {
            return characterContainerRepository.GetAllCharacters();
        }

        public Character GetCharacterByID(int ID)
        {
            return characterContainerRepository.GetCharacterByCharacterID(ID);
        }
    }
}
