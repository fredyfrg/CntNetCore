using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CntNetCore.Models;

namespace CntNetCore.Data
{
    public class CntNetCoreContext : DbContext
    {
        public CntNetCoreContext (DbContextOptions<CntNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<CntNetCore.Models.Pacientes> Pacientes { get; set; }
    }
}
