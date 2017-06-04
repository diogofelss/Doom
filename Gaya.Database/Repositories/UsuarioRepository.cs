using System.Collections.Generic;
using System.Linq;
using Gaya.Database.Repositories.Common;
using Gaya.Domain.Entities;
using Gaya.Domain.Interfaces;

namespace Gaya.Database.Repositories
{
    public class UsuarioRepository : CadastroRepository<Usuario>, IUsuarioRepository
    {
        

        public IEnumerable<Usuario> GetAllByEmpresa(int empresaId)
        {
            return Database.Usuario.Where(u => u.EmpresaId == empresaId).ToList();
        }

        public Usuario BuscarPorNome(string nome, int empresaId)
        {
            return Database.Usuario.FirstOrDefault(u => u.Nome == nome && u.EmpresaId == empresaId);
        }

        public Usuario BuscarUsuario(string nome, string password, int empresaId)
        {
            return Database.Usuario.FirstOrDefault(u => u.Nome == nome && u.Senha == password && u.EmpresaId == empresaId);
        }
    }
}
