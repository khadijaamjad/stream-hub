using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StreamHub.Models;

namespace StreamHub.Data
{
    public class StreamHubContext : DbContext
    {
        public StreamHubContext (DbContextOptions<StreamHubContext> options)
            : base(options)
        {
        }

        public DbSet<StreamHub.Models.Movie> Movie { get; set; } = default!;
    }
}
