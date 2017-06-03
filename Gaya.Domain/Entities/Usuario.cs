﻿using Gaya.Domain.FrameWork.Strings;

namespace Gaya.Domain.Entities
{
    public sealed class Usuario : Common.Cadastro
    {
        private CryptSecurity cryptSecurity;

        public Usuario()
        {
            cryptSecurity = new CryptSecurity();
        }

        #region private Property

        private string _senha;

        #endregion

        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string Senha
        {
            get
            {
                return cryptSecurity.Decrypt(_senha);
            }
            set
            {
                var senhacrypt = cryptSecurity.Encrypt(value);
            }
        }
        public bool Ativo { get; set; }
    }
}