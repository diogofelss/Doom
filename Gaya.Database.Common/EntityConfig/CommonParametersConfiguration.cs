using System.Data.Entity.ModelConfiguration;
using Gaya.Domain.Entities.Common;

namespace Gaya.Database.Common.EntityConfig
{
    public class CommonParametersConfiguration : EntityTypeConfiguration<CommonParameters>
    {
        public CommonParametersConfiguration()
        {
            HasKey(c => c.Key);
        }
    }
}