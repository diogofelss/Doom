using Doom.Domain.FrameWork.Strings;

namespace Doom.Domain.Entities
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
        public PassWordString Senha { get; set; }

        private Validation validacao { get; set; }

        public Validation Valido()
        {
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                validacao.Id = -1;
                validacao.Mensagem = Mensagens.LogOnMessages.VAL0001;
                return validacao;
            }

            if (Senha.IsNullOrWhiteSpace)
            {
                validacao.Id = -1;
                validacao.Mensagem = Mensagens.LogOnMessages.VAL0002;
                return validacao;
            }

            return validacao;
        }
    }
}
