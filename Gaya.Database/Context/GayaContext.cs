using Gaya.Domain.Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Gaya.Database.Context
{
    public class GayaContext : DbContext
    {
        public GayaContext() : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            return string.Empty;
        }

        #region DB Set

        public DbSet<Usuario> USUARIO { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(254));
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DataAtualizacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAtualizacao").CurrentValue = null;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("Senha") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAtualizacao").CurrentValue = null;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAtualizacao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
