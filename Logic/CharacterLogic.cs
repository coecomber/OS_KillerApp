using Logic.Abstract;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class CharacterLogic : LivingCreatureLogic
    {
        public int SlayerAmount { get; set; }

        public CharacterLogic(Character character)
        {
            Name = character.Name;
        }
    }
}
