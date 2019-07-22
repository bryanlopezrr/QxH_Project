using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QxHOracleLoader.Models
{
    public class LoaderContext : DbContext
    {
        public LoaderContext (DbContextOptions<LoaderContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
    }
}
