using System;
namespace FiorelloTask.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte PaymentType { get; set; }
        public byte OrderStatus { get; set; }
        public byte DeliveryStatus { get; set; }
        public decimal TotalAmount { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
