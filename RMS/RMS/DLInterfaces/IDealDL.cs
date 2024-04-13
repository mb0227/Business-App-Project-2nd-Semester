﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IDealDL
    {
        List<Deal> GetDeals();
        void SaveDeal(Deal deal);
        void RemoveDeal(int id);
        Deal GetDeal(int id);
        Deal GetDeal(string name);
    }
}