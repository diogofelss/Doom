using System;
using Gaya.Domain.Interfaces;

namespace Gaya.Domain.Entities.Cadastros
{
    public class Empresa : ICadastro
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}