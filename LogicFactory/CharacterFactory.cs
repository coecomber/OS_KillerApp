using Logic;
using Logic.Interfaces.ILogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicFactory
{
    public class CharacterFactory
    {
        public ICharacterLogic GetCharacterLogic()
        {
            return new CharacterLogic();
        }
    }
}
