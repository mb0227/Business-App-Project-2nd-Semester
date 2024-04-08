﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IUserDL
    {
        void SaveUser(User user);
        string SearchUserForRole(string email);
        int GetUserID(string email);
        bool EmailAlreadyExists(string email);
        int GetUserID(int id);
    }
}
