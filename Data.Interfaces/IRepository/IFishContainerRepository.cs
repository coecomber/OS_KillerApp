﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces.IRepository
{
    public interface IFishContainerRepository
    {
        List<FishItem> GetAllFishes();
    }
}
