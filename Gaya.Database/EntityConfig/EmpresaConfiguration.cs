using Gaya.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Gaya.Database.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            HasKey(p => p.Id);
        }
    }
}
