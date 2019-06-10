using Data.IContexts;
using Data.Interfaces.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class SlayerTaskContainerRepository : ISlayerTaskContainerRepository
    {
        private ISlayerTaskContainerContext context;

        public SlayerTaskContainerRepository(ISlayerTaskContainerContext context)
        {
            this.context = context;
        }

        public List<SlayerTask> GetAllSlayerTasks()
        {
            return context.GetAllSlayerTasks();
        }
    }
}
