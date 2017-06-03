using Gaya.Domain.FrameWork.Strings;

namespace Gaya.Domain.Entities
{
    public class LogOn
    {
        public LogOn()
        {
            validacao = new Validation();

            validacao.Id = 0;
        }

        public int IdEmpresa { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        private Validation validacao { get; set; }

        public Validation Valido()
        {
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                validacao.Id = -1;
                validacao.Mensagem = Mensagens.LogOnMessages.VAL0001;
                return validacao;
            }

            if (string.IsNullOrWhiteSpace(Senha))
            {
                validacao.Id = -1;
                validacao.Mensagem = Mensagens.LogOnMessages.VAL0002;
                return validacao;
            }

            return validacao;
        }
    }
}
