using Demo.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.DbContext
{
    public class FMTContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public FMTContext(DbContextOptions<FMTContext> options) : base(options) { }

        public DbSet<BagType> BagType { get; set; }
        public DbSet<BagCategory> BagCategory { get; set; }
    }
}
