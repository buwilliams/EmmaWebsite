using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesFriendContext : DbContext
    {
        public RazorPagesFriendContext (DbContextOptions<RazorPagesFriendContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Friend> Friend { get; set; } = default!;
    }
}
