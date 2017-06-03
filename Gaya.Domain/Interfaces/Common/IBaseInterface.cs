using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doom.Domain.Interfaces.Common
{
    public interface IBaseInterface
    {
        int Id { get; set; }

        DateTime DataCriacao { get; set; }
    }
}
