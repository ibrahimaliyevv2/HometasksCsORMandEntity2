using System;
using System.Collections.Generic;
using System.Linq;
using FiorelloTask.DAL;
using FiorelloTask.Entities;
using FiorelloTask.Exceptions;

namespace FiorelloTask.Services
{
    public class ProductService
    {
        TaskDbContext taskDbContext = new TaskDbContext();

        public void AddProduct(Product product)
        {
            var list = taskDbContext.Products.Where(x => x.Name == product.Name).ToList();
            if (list.Count>0)
            {
                throw new AlreadyExistException("Bele product artiq movcuddur!");
            }
            else
            {
                taskDbContext.Products.Add(product);
                taskDbContext.SaveChanges();
            }
        }

        public Product GetProductById(int id)
        {
            return taskDbContext.Products.Find(id);
        }

        public decimal ProductSalePriceAverage()
        {
            decimal sum = 0;
            int count = 0;
            foreach (var item in taskDbContext.Products)
            {
                sum += item.SalePrice;
                count++;
            }
            return sum / count;
        }

        public List<Comment> GetCommentsByProductId(int productId)
        {
            
             return taskDbContext.Comments.Where(x => x.ProductId == productId).ToList();
        }
    }
}
