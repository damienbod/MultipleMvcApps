using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcApp1.Areas.MvcApp1.Models;

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
