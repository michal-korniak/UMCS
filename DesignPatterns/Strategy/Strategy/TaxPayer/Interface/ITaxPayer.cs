﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    interface ITaxStrategy
    {
        double PayTax(double income);
    }
}
