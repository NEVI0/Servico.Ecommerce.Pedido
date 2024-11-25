using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Pedido
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().ToTable("Pedido");
            base.OnModelCreating(modelBuilder);
        }
    }
}