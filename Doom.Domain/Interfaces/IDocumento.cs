using System;
using Doom.Domain.Enums;

namespace Doom.Domain.Interfaces
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