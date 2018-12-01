using Microsoft.EntityFrameworkCore;

namespace MvcApp1.Models
{
    public class SomeDataContext : DbContext
    {
        public SomeDataContext (DbContextOptions<SomeDataContext> options)
            : base(options)
        {
        }

        public DbSet<MvcApp1.Areas.MvcApp1.Models.SomeData> SomeData { get; set; }
    }
}
