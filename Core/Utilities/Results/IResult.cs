﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{// TEMEL VOİDLER İÇİN BAŞLANGIÇ

    public interface IResult
    {
        bool Success { get; }//sadece get yapan
        string  Message { get; }//
    }
}
