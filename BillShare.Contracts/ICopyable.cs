﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BillShare.Contracts
{
    public partial interface ICopyable<T>
    {
        void copyProperties(T other);
    }
}
