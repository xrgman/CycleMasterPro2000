﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public interface ServerInterface
    {
        void Login(string username, string password);
        void GiveUser(string username, bool allUsers);
    }
}
