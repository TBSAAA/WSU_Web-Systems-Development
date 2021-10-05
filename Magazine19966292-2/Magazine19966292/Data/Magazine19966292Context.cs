using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Magazine19966292.Model;

namespace Magazine19966292.Data
{
    public class Magazine19966292Context : DbContext
    {
        public Magazine19966292Context (DbContextOptions<Magazine19966292Context> options)
            : base(options)
        {
        }

        public DbSet<Magazine19966292.Model.Magazine> Magazine { get; set; }

        public DbSet<Magazine19966292.Model.Customer> Customer { get; set; }
    }
}
