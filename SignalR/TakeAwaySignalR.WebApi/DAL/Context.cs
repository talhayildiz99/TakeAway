using Microsoft.EntityFrameworkCore;

namespace TakeAwaySignalR.WebApi.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DSQNOEI\\SQLEXPRESS03; initial catalog = TakeAwayDeliveryDb; integrated security = true");
        }
        public DbSet<Delivery> Deliveries { get; set; }
    }
}
