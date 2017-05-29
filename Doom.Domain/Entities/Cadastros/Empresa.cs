using System;
using Doom.Domain.Interfaces;

namespace Doom.Domain.Entities.Cadastros
{
    public class Empresa : ICadastro
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}