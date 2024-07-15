using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TakeAway.Discount.Entities;

namespace TakeAway.Discount.Context
{
    public class DapperContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Key");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DSQNOEI\\SQLEXPRESS03; initial catalog = TakeAwayDiscountDb; integrated security = true");
        }
        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }

        private readonly string _connectionString;
        public IDbConnection CreateConnection()=>new SqlConnection(_connectionString);
    }
}
