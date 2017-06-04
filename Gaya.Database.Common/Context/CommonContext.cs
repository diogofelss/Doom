using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Gaya.Database.Common.EntityConfig;
using Gaya.Domain.Entities.Common;

namespace Gaya.Database.Common.Context
{
    public class CommonContext : DbContext
    {
        public CommonContext() : base(GetConnectionString())
        {
        }

        private static string GetConnectionString()
        {
            return "Server=LAPTOP-AGMCP52N;Database=GAYA_COMMON;User Id=sa;Password = difel_123; ";
        }

        #region DBSet

        public DbSet<CommonParameters> CommonParameters { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(254));

            modelBuilder.Configurations.Add(new CommonParametersConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("InitialSystemDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("InitialSystemDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("InitialSystemDate").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("Version") != null))
            {
                entry.Property("Version").CurrentValue = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            
            return base.SaveChanges();
        }
    }
}