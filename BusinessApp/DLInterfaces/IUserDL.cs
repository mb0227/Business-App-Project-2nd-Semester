using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IUserDBDL
    {
        void StoreUserInDB(User user);
        string SearchCustomerForRole(string email, string password);
        int GetUserID(string email);
    }
}
