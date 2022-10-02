using KrustyKrabPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace KrustyKrabPizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrderModel> PizzaOrders { get; set; } // Name of table

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
    }
}
