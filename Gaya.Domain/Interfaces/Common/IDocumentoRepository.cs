using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;

namespace Gaya.Domain.Interfaces.Common
{
    public interface IDocumentoRepository<T> : IRepositoryBase<T> where T : Documento
    {
        Validation Cancel(T entity);
        Validation Restore(T entity);
    }
}
