using System;
namespace FiorelloTask.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool PosterStatus { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
