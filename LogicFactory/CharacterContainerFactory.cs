using Logic;
using Logic.Interfaces.ILogic;
using System;

namespace LogicFactory
{
    public class CharacterContainerFactory
    {
        public ICharacterContainerLogic GetCharacterContainerLogic()
        {
            return new CharacterContainerLogic();
        }
    }
}
