using Microsoft.EntityFrameworkCore;
using Mango.Services.CouponAPI.Models;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        private DbSet<Coupon1> coupons;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
