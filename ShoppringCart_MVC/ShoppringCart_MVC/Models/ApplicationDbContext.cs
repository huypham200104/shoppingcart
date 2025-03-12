using Microsoft.EntityFrameworkCore;
using ShoppringCart_MVC.Models.Entities;
namespace ShoppringCart_MVC.Models
{
    public class ApplicationDbContext : DbContext
{
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
     {
     }
     public DbSet<Product> Products { get; set; }
     public DbSet<Category> Categories { get; set; }
     public DbSet<Cart> Carts { get; set; }
     public DbSet<CartItem> CartItems { get; set; }
     public DbSet<Comment> Comments { get; set; }
     public DbSet<Favorite> favorites { get; set; }
     public DbSet<Order> orders { get; set; }
     public DbSet<User> users { get; set; }
    }
}
