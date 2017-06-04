using Gaya.Database.EntityConfig;
using Gaya.Domain.Entities;
using Gaya.Domain.FrameWork.Strings;
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
            return "Server=LAPTOP-AGMCP52N;Database=GAYA_DIFEL;User Id=sa;Password = difel_123; ";
        }

        #region DB Set

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Empresa> Empresa { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(254));

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new EmpresaConfiguration());
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
                var originalValue = entry.Property("Senha").CurrentValue.ToString();

                var crypt = new CryptSecurity();

                entry.Property("Senha").CurrentValue = crypt.Encrypt(originalValue);
            }

            return base.SaveChanges();
        }
    }
}