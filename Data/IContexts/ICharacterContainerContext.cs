using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.IContexts
{
    public interface ICharacterContainerContext
    {
        List<Character> GetAllCharacters();
        Character GetCharacterByID(int characterID);
        void UpdateCharacter(Character character);
    }
}
