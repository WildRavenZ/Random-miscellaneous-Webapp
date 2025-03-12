using Microsoft.EntityFrameworkCore;
using Random_miscellaneous.Models;

namespace Random_miscellaneous.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<OptionModel> Options { get; set; }
    }
}
