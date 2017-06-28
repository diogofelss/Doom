using Gaya.Domain.FrameWork.Strings;
using Gaya.Domain.Mensagens;

namespace Gaya.Domain.Entities
{
    public class LogOn
    {
        private CryptSecurity cryptSecurity;
        private int _idempresa;
        private string _senha;
        private string _usuario;

        public LogOn()
        {
            validacao = new Validation();
            cryptSecurity = new CryptSecurity();

            validacao.Id = 0;
        }

        public int IdEmpresa
        {
            get { return _idempresa; }
            set { _idempresa = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = cryptSecurity.Encrypt(value); }
        }

        private Validation validacao { get; }

        public Validation Valido()
        {
            if (string.IsNullOrWhiteSpace(Usuario))
            {
                validacao.Id = -1;
                validacao.Mensagem = LogOnMessages.VAL0001;
                return validacao;
            }

            if (string.IsNullOrWhiteSpace(Senha))
            {
                validacao.Id = -1;
                validacao.Mensagem = LogOnMessages.VAL0002;
                return validacao;
            }

            return validacao;
        }
    }
}