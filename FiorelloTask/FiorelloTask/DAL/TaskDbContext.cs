using System;
using FiorelloTask.Entities;
using Microsoft.EntityFrameworkCore;

namespace FiorelloTask.DAL
{
    public class TaskDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=FiorelloDB;User Id=sa;Password=MyPass@word");
        }
    }
}
