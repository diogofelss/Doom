using System;

namespace Gaya.Domain.Entities.Common
{
    public class Cadastro
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public int UsuarioCadastroId { get; set; }
    }
}
