using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend_EXP.Models;

namespace Backend_EXP.Data
{
    public class Backend_EXPContext : DbContext
    {
        public Backend_EXPContext (DbContextOptions<Backend_EXPContext> options)
            : base(options)
        {
        }

        public DbSet<Backend_EXP.Models.Tree> Tree { get; set; } = default!;
    }
}
