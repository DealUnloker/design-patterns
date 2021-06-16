using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_7
{
    public class OrderManager
    {
        private List<IOrderHandler> _handlers = new List<IOrderHandler>();
        private IOrderHandler _defaultHandler;

        public OrderManager(IOrderHandler defaultHandler)
        {
            if (defaultHandler == null) { throw new NullReferenceException(); }

            this._defaultHandler = defaultHandler;
        }

        public void AddHandler(IOrderHandler handler)
        {
            this._handlers.Add(handler);
        }

        public void ProcessNewOrder(OrderData orderData)
        {
            foreach (IOrderHandler handler in this._handlers)
            {
                if (handler.Process(orderData))
                {
                    return;
                }
            }

            if (!this._defaultHandler.Process(orderData))
            {
                throw new InvalidOperationException();
            }
        }
    }

}
