using System;

namespace OnlineShopTest.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }


        public DateTime OrderDate { get; set; }
    }
}
