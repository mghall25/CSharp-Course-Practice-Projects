using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersDb.DTO
{
    public class Order
    {
        public System.Guid OrderId { get; set; }
        public int Size { get; set; }
        public int Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onion { get; set; }
        public bool GreenPepper { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public int PaymentType { get; set; }
        public bool Completed { get; set; }
    }
}
