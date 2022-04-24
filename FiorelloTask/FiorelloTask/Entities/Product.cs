using System;
namespace FiorelloTask.Entities
{
    public class Product
    {
        public Product()
        {
            _id++;
            Id = _id;
        }

        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public string AboutText { get; set; }
        public string DescriptionTitle { get; set; }
        public string DescriptionText { get; set; }
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsNew { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
