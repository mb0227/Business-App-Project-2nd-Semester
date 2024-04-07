using RMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.DL
{
    public interface IWaiterDL
    {
        void SaveWaiter(Waiter waiter);
        List<Waiter> GetWaiters();

    }
}
