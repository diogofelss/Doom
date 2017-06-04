namespace Gaya.Domain.Entities
{
    public class Empresa : Common.Cadastro
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
    }
}
