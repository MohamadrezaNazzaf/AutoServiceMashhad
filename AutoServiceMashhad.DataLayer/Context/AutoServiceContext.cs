using AutoServiceMashhad.DataLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMashhad.DataLayer.Context
{
    public class AutoServiceContext : IdentityDbContext
    {
        public AutoServiceContext(DbContextOptions<AutoServiceContext> options)
            : base(options)
        {
        }
<<<<<<< HEAD
        public DbSet<IServiceType> ServiceTypes { get; set; }
=======
        public DbSet<ServiceType> ServiceTypes { get; set; }
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
    }
}
