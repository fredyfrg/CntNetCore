using CntNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CntNetCore.Data
{
    public class DbInitializer
    {
        public static void Initialize(CntNetCoreContext context)
        {
            context.Database.EnsureCreated();

            if (context.Pacientes.Any())
            {
                return;
            }
            context.SaveChanges();
        }
    }
}
