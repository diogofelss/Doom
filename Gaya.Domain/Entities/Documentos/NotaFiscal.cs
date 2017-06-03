using System;
using Gaya.Domain.Enums;
using Gaya.Domain.Interfaces;

namespace Gaya.Domain.Entities.Documentos
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