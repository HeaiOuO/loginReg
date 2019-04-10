using Microsoft.EntityFrameworkCore;
using logAndReg.Models;

namespace logAndReg.Models
{
    public class logRegContext : DbContext
    {
        public logRegContext(DbContextOptions<logRegContext> options) : base(options) {}

        public DbSet<User> users {get; set;}
    }
}