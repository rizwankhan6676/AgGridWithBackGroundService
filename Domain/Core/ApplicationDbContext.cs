using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder
            //    .Entity<EmergencyConnectivityFund>(
            //        eb =>
            //        {
            //            eb.HasNoKey();
            //        });

            base.OnModelCreating(builder);
        }

        public DbSet<EmergencyConnectivityFund> EmergencyConnectivityFund { get; set; }
    }
}
