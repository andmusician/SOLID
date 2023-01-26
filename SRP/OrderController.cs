using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public  class OrderController
    {
        private OrderValidator _orderValidator;
        private OrderProcessor _orderProcessor;

        public OrderController(OrderValidator orderValidator, OrderProcessor orderProcessor)
        {
            _orderValidator = orderValidator;
            _orderProcessor = orderProcessor;
        }

        public void PlaceOrder(Order order)
        {
            if (_orderValidator.Validate(order))
            {
                _orderProcessor.Process(order);
            }
        }
    }
}
