using Microsoft.EntityFrameworkCore;
using ShoppingHub.Models;
using SellerProductManagement.Models;
using static SellerProductManagement.Models.WishListItems;

namespace ShoppingHub.Data
{
    public class ApplicationDbContext:DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>Options):base(Options)
        {
                
        }
        public DbSet<Seller>Sellers { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Product>Product
        { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }
    }
}
