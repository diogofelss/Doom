﻿using System;

namespace Doom.Domain.Interfaces
{
    public interface ICadastro
    {
        int Id { get; set; }
        string Codigo { get; set; }
        DateTime DataCriacao { get; set; }
        DateTime DataAtualizacao { get; set; }
    }
}