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
        public DbSet<IServiceType> ServiceTypes { get; set; }
    }
}
