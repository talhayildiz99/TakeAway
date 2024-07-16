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
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }

        private readonly string _connectionString;
        public IDbConnection CreateConnection()=>new SqlConnection(_connectionString);
    }
}
