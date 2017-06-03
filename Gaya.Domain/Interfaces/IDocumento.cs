using System;
using Gaya.Domain.Enums;

namespace Gaya.Domain.Interfaces
{
    public interface IDocumento
    {
        int Id { get; set; }
        string Numero { get; set; }
        string Serie { get; set; }
        DocumentEnum.EnStatusDocumento Status { get; set; }
        DateTime DataCriacao { get; set; }
    }
}