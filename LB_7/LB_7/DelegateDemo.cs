using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public static class DelegateDemo
    {
        private static OrderHandlerDelegate CreateOrderManager()
        {
            var favCustomerOrderHandler = new FavCustomerOrderHandler();
            var largeOrderHandler = new LargeOrderHandler();
            var defaultOrderHandler = new DefaultOrderHandler();
            var manager = new OrderHandlerDelegate(favCustomerOrderHandler.Process);
            manager += new OrderHandlerDelegate(largeOrderHandler.Process);
            manager += new OrderHandlerDelegate(defaultOrderHandler.Process);
            return manager;
        }
        public static void Execute()
        {
            OrderHandlerDelegate orderManager = CreateOrderManager();
            OrderData orderData = new OrderData() {
                Id = 0,
            Amount = 10,
            CustomerId = 5,
            ItemId = 8
          };
            orderManager(orderData);
        }
    }

}
