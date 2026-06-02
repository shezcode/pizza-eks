using Microsoft.EntityFrameworkCore;

namespace PizzeriaApi.Data
{
    public class PizzeriaContext : DbContext
    {
        public PizzeriaContext(DbContextOptions<PizzeriaContext> options) : base(options)
        {
        }

        public DbSet<Pizza>? Pizzas { get; set; }
    }
}
