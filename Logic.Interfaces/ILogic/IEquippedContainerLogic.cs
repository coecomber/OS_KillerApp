using Models;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface IEquippedContainerLogic
    {
        List<Equipped> GetAllEquipped();
        void GetCharacterEquipped(Character character);
        Character EquipWeapon(Character character, int weaponID);
        Character EquipArmour(Character character, int armourID);
    }
}
