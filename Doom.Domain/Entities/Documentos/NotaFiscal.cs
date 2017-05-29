using System;
using Doom.Domain.Enums;
using Doom.Domain.Interfaces;

namespace Doom.Domain.Entities.Documentos
{
    public class NotaFiscal : IDocumento
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Serie { get; set; }
        public DocumentEnum.EnStatusDocumento Status { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}