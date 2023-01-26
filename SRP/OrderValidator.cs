using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class OrderValidator
    {
        public bool Validate(Order order)
        {
            // Lógica de validação do pedido
            if (order.Amount <= 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(order.CustomerName))
            {
                return false;
            }
            if (string.IsNullOrEmpty(order.ShippingAddress))
            {
                return false;
            }
            return true;
        }
    }
}
