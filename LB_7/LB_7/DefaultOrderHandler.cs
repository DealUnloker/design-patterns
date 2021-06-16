using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public class DefaultOrderHandler : IOrderHandler
    {
        public bool Process(OrderData orderData)
        {
            if (orderData.Id  != 0) { return false; }

            Console.WriteLine("Default order handler");
            orderData.Id = 5;

            return true;
        }
    }

}
