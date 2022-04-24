using System;
namespace FiorelloTask.Entities
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal UnitCostPrice { get; set; }
        public decimal UnitSalePrice { get; set; }
        public decimal UnitDiscountPercent { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
