using Gaya.Domain.Entities;
using Gaya.Domain.Interfaces.Common;
using System.Collections.Generic;

namespace Gaya.Domain.Interfaces
{
    public interface IUsuarioRepository : ICadastroRepository<Usuario>
    {
        IEnumerable<Usuario> GetAllByEmpresa(int empresaId);

        Usuario BuscarPorNome(string Name, int empresaId);

        Usuario BuscarUsuario(string nome, string password, int empresaId);
    }
}