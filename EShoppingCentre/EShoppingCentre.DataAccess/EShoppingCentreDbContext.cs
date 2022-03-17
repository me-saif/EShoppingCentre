using EShoppingCentre.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShoppingCentre.DataAccess
{
    public class EShoppingCentreDbContext : IdentityDbContext
    {
        public EShoppingCentreDbContext(DbContextOptions<EShoppingCentreDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}