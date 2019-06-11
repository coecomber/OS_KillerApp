using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface ICharacterContainerLogic
    {
        List<Character> GetAllCharacters();
        Character GetCharacterByID(int ID);
        void UpdateCharacter(Character character);
    }
}
