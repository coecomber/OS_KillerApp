using Data.Interfaces.IRepository;
using DataFactory;
using Logic.Interfaces.ILogic;
using Logic.Item;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class EquippedContainerLogic : IEquippedContainerLogic
    {
        private IEquippedContainerRepository equippedContainerRepository = new EquippedContainerFactory().GetEquippedContainerRepository();

        public List<Equipped> GetAllEquipped()
        {
            return equippedContainerRepository.GetAllEquipped();
        }

        public void GetCharacterEquipped(Character character)
        {
            List<Equipped> equippeds = GetAllEquipped();

            foreach(var equipped in equippeds)
            {
                if(equipped.EquppedID == character.ID)
                {
                    //sets weapon
                    WeaponLogic weaponLogic = new WeaponLogic();
                    List<Weapon> weapons = weaponLogic.GetAllWeapons();
                    foreach(Weapon weapon in weapons)
                    {
                        if(weapon.ID == equipped.WeaponID)
                        {
                            character.EquipedWeapon = weapon;
                        }
                    }

                    //sets armour
                    ArmourLogic armourLogic = new ArmourLogic();
                    List<Armour> armours = armourLogic.GetAllArmours();
                    foreach(Armour armour in armours)
                    {
                        if (armour.ID == equipped.HelmetID)
                        {
                            character.EquipedHelmet = armour;
                        }
                        if (armour.ID == equipped.BodyID)
                        {
                            character.EquipedBody = armour;
                        }
                        if (armour.ID == equipped.LegsID)
                        {
                            character.EquipedLegs = armour;
                        }
                        if (armour.ID == equipped.FeetID)
                        {
                            character.EquipedFeet = armour;
                        }
                    }
                }
            }
        }
    }
}
