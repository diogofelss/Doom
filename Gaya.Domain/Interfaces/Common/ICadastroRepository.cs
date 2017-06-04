using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;

namespace Gaya.Domain.Interfaces.Common
{
    public interface ICadastroRepository<T> : IRepositoryBase<T> where T : Cadastro
    {
        Validation Remove(T entity);
    }
}
