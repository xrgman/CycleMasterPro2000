﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public interface ClientInterface
    {
        void loginResponse(bool loginOk, bool isPhysician);
    }
}
