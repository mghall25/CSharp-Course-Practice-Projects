using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDb.Persistence
{
    public class OrderRepository
    {
        // for use in displaying orders in grid view
        public static List<DTO.Order> GetOrders()
        {
            PapaBobsEntities db = new PapaBobsEntities();
            var dbOrders = db.Orders.OrderBy(p=>p.Name).ToList();  

            var dtoOrders = new List<DTO.Order>();

            foreach (var dbOrder in dbOrders)
            {
                var dtoOrder = new DTO.Order();

                dtoOrder.OrderId = dbOrder.OrderId;
                dtoOrder.Size = dbOrder.Size;
                dtoOrder.Crust = dbOrder.Crust;
                dtoOrder.Sausage = (bool)dbOrder.Sausage;
                dtoOrder.Pepperoni = (bool)dbOrder.Pepperoni;
                dtoOrder.Onion = (bool)dbOrder.Onion;
                dtoOrder.GreenPepper = (bool)dbOrder.GreenPepper;
                dtoOrder.TotalCost = dbOrder.TotalCost;
                dtoOrder.Name = dbOrder.Name;
                dtoOrder.Address = dbOrder.Address;
                dtoOrder.Zip = dbOrder.Zip;
                dtoOrder.Phone = dbOrder.Phone;
                dtoOrder.PaymentType = dbOrder.PaymentType;
                dtoOrder.Completed = (bool)dbOrder.Completed;

                dtoOrders.Add(dtoOrder);
            }

            //return dbCustomers;
            return dtoOrders;
        }

        // add a order to the table - from DTO layer to this layer
        // accept order from DTO and add it to the Persistence layer
        public static void AddOrder(DTO.Order newOrder)
        {
            // ACMEEntities is the Data Entity Model used by the Persistence Layer
            PapaBobsEntities db = new PapaBobsEntities();
            var dbOrders = db.Orders;

            // create a new customer for the database (in ACMEEntities > persistence layer)
            var order = new Order();

            // validation of received data (entered by user on Presentation layer)
            if (newOrder.Name.Trim().Length == 0)                    // name not entered
                throw new Exception("Name is a required field.");       // later: define this exception in the domain layer
            // Other validations here -  to make sure entered info is valid before attempting to add it to the database


            // get customer data to the object used by the database layer
            order.OrderId = newOrder.OrderId;
            order.Size = newOrder.Size;
            order.Crust = newOrder.Crust;
            order.Sausage = newOrder.Sausage;
            order.Pepperoni = newOrder.Pepperoni;
            order.Onion = newOrder.Onion;
            order.GreenPepper = newOrder.GreenPepper;
            order.TotalCost = newOrder.TotalCost;
            order.Name = newOrder.Name;
            order.Address = newOrder.Address;
            order.Zip = newOrder.Zip;
            order.Phone = newOrder.Phone;
            order.PaymentType = newOrder.PaymentType;
            order.Completed = newOrder.Completed;

            // attempt to add customer to the database. Throw an exception if unsuccessful.
            try
            {
                // add order to database and commit the changes to the database
                dbOrders.Add(order);
                db.SaveChanges();               // write order into database
            }
            catch (Exception ex)
            {
                // Log the exception.
                throw ex;       // create custom exception later: put it into the Domain section or put in DTO
            }
        }
    }
}
