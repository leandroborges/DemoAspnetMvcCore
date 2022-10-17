using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoAspnetMvcCore.Models;

namespace DemoAspnetMvcCore.Data
{
    public class DemoAspnetMvcCoreContext : DbContext
    {
        public DemoAspnetMvcCoreContext (DbContextOptions<DemoAspnetMvcCoreContext> options)
            : base(options)
        {
        }

        public DbSet<DemoAspnetMvcCore.Models.Filme> Filme { get; set; }
    }
}
