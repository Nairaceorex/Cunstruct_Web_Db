using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;

namespace Cunstruct_Web_Db.Data
{
    public class Cunstruct_Web_DbContext : DbContext
    {
        public Cunstruct_Web_DbContext (DbContextOptions<Cunstruct_Web_DbContext> options)
            : base(options)
        {
        }

        public DbSet<ConstructDB.Models.Staff> Staff { get; set; }
    }
}
