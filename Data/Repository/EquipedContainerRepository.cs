using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class EquipedContainerRepository : IEquippedContainerRepository
    {
        private IEquippedContainerContext context;

        public EquipedContainerRepository(IEquippedContainerContext context)
        {
            this.context = context;
        }

        public List<Equipped> GetAllEquipped()
        {
            return context.GetAllEquipped();
        }

        public void UpdateEquipped(Character character)
        {
            context.UpdateEquipped(character);
        }
    }
}