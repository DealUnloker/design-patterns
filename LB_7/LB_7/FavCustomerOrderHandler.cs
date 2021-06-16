using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public class FavCustomerOrderHandler : IOrderHandler
    {
        public bool Process(OrderData orderData)
        {
            if ((orderData.Id != 0) || (orderData.CustomerId > 10))
            {
                return false;
            }

            Console.WriteLine("Favorite customer order handler.");
            orderData.Id = 77;
            return true;
        }
    }
}
