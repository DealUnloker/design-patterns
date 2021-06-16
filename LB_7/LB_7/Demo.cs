using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public static class Demo
    {
        private static OrderManager CreateOrderManager()
        {
            var manager = new OrderManager(new DefaultOrderHandler());

            manager.AddHandler(new FavCustomerOrderHandler());
            manager.AddHandler(new LargeOrderHandler());
            return manager;
        }
        public static void Execute()
        {
            OrderManager orderManager = CreateOrderManager();

            OrderData orderData = new OrderData() {
                Id = 0,
                Amount = 100,
                CustomerId = 15,
                ItemId = 8
           };
            orderManager.ProcessNewOrder(orderData);
        }
    }

}
