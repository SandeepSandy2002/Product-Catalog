using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("int");  // Ensure Price is treated as an integer

            modelBuilder.Entity<Order>()
                .Property(o => o.Total)
                .HasColumnType("int");  // Ensure Total is treated as an integer

            // Seed Products (can be adjusted if needed)
            modelBuilder.Entity<Product>().HasData(
       new Product { Id = 10, Name = "Jeans", Price = 40, Category = "Clothes", ImageUrl = "https://images.unsplash.com/photo-1594902876423-bfbd3f4cb935" },
       new Product { Id = 6, Name = "Banana", Price = 1, Category = "Fruits", ImageUrl = "https://www.bigbasket.com/media/uploads/p/xxl/40129358_1-fresho-banana-robusta.jpg" },
       new Product { Id = 1, Name = "Laptop", Price = 1200, Category = "Electronics", ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8" },
       new Product { Id = 12, Name = "Sneakers", Price = 50, Category = "Clothes", ImageUrl = "https://images.unsplash.com/photo-1600185365005-6d1d02acdf04" },
       new Product { Id = 3, Name = "Headphones", Price = 150, Category = "Electronics", ImageUrl = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQPtqgtRPFysnPMlI3I3gOKV6wY7RyZ9hzsNecwy--WhyD17g50Zpk0aaQ3t_gKFnxQw8FKOsQnxC8j03py6vx92bM9omEAUrd0MNsJ3dQEZg11aFsfpwT1" },
       new Product { Id = 14, Name = "Book: ReactJS Guide", Price = 30, Category = "Books", ImageUrl = "https://images.unsplash.com/photo-1553729784-e91953dec042" },
       new Product { Id = 13, Name = "Rice (1kg)", Price = 2, Category = "Groceries", ImageUrl = "https://pureandsure.in/cdn/shop/files/broekn-rice_01549bc9-034b-45d1-9065-41a29613907d.jpg?v=1727177828" },
       new Product { Id = 8, Name = "Grapes", Price = 5, Category = "Fruits", ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/766/grapes-main-1506688521.jpg?crop=0.848xw:1xh" },
       new Product { Id = 7, Name = "Orange", Price = 2, Category = "Fruits", ImageUrl = "https://www.jiomart.com/images/product/original/590000025/orange-imported-1-kg-product-images-o590000025-p590000025-0-202410011652.jpg?im=Resize=(420,420)" },
       new Product { Id = 9, Name = "T-Shirt", Price = 20, Category = "Clothes", ImageUrl = "https://image.hm.com/assets/hm/8b/ea/8bea8bac07ed75596e5597f6d2997f07cfd81fac.jpg?imwidth=768" },
       new Product { Id = 2, Name = "Smartphone", Price = 800, Category = "Electronics", ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9" },
       new Product { Id = 4, Name = "Keyboard", Price = 100, Category = "Electronics", ImageUrl = "https://images.unsplash.com/photo-1587829741301-dc798b83add3" },
       new Product { Id = 11, Name = "Jacket", Price = 60, Category = "Clothes", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcREZodCYpCCPz_Q4BDiFpxZJAhU1piEp998Hw&s" },
       new Product { Id = 5, Name = "Apple", Price = 1, Category = "Fruits", ImageUrl = "https://images.unsplash.com/photo-1567306226416-28f0efdc88ce" },
       new Product { Id = 15, Name = "Book: JavaScript Mastery", Price = 25, Category = "Books", ImageUrl = "https://images.unsplash.com/photo-1524995997946-a1c2e315a42f" }
   );


        }
    }
}
