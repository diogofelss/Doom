using Gaya.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Gaya.Database.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome).IsRequired().HasMaxLength(30);
            Property(c => c.Senha).IsRequired();
            Property(c => c.EmpresaId).IsRequired();
            Property(c => c.Ativo).IsRequired();
        }
    }
}
