using System;
using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;

namespace Gaya.Domain.Interfaces.Common
{
    public interface ICommonParametersRepository<T> : IDisposable where T : CommonParameters
    {
        Validation Add(CommonParameters commonParameters);

        T Get();
    }
}