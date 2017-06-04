using Gaya.Database.Repositories;

namespace Gaya.Windows.Controllers
{
    public class UsuarioController
    {
        public bool Exists(string nome, string senha, int empresaId)
        {
            using (var repository = new UsuarioRepository())
            {
                var usuario = repository.BuscarUsuario(nome, senha, empresaId);

                if (usuario == null)
                    return false;
            }

            return true;
        }
    }
}
