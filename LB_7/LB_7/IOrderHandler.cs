﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public interface IOrderHandler
    {
        bool Process(OrderData orderData);
    }

}
