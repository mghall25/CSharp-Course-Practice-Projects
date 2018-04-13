using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDb.Domain
{
    public class OrderManager
    {
        // for use in displaying customer in gridview
        public static List<DTO.Order> GetOrders()
        {
            var orders = Persistence.OrderRepository.GetOrders();
            return orders;
        }

        // receive customer from DTO layer to Domain layer (DTO received it from Presentation layer)
        public static void AddOrder(DTO.Order order)
        {
            try
            {
                // pass customer to persistence layer
                Persistence.OrderRepository.AddOrder(order);
            }
            catch (Exception)
            {
                // Log it
                throw;
            }
        }

    }
}
