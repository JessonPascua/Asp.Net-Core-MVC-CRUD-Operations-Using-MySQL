using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models;
using Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Models.Entities;

namespace Asp.Net_Core_MVC_CRUD_Operations_Using_MySQL.Data
{
    public class HealthCareDbContext : DbContext
    {
        public HealthCareDbContext (DbContextOptions<HealthCareDbContext> options)
            : base(options)
        {
        }
        public DbSet<Patients> Patients { get; set; } = default!;
        public DbSet<Physicians> Physicians { get; set; } = default!;
        public DbSet<Specializations> Specializations { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
