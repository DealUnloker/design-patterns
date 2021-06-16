using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public class LargeOrderHandler : IOrderHandler
    {
        public bool Process(OrderData orderData)
        {
            if ((orderData.Id != 0) || (orderData.Amount < 20))
            {
                return false;
            }

            Console.WriteLine("Large order handler.");
            orderData.Id = 42;

            return true;
        }
    }

}
