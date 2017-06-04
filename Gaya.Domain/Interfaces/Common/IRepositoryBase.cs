using Gaya.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Gaya.Domain.Interfaces.Common
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        Validation Add(T entity);
        Validation Update(T entity);
        T GetByKey(int key);
        IEnumerable<T> GetAll();
    }
}
