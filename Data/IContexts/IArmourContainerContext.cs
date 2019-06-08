using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.IContexts
{
    public interface IArmourContainerContext
    {
        List<Armour> GetAllArmours();
    }
}
