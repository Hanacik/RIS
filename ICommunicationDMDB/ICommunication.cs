﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseParser;

namespace ICommunicationDMDB
{
    public interface ICommunication
    {
        risTabulky risContext { get; }
        IList jedloList { get; }
    }
}
