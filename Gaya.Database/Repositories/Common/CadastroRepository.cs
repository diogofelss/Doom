using System;
using System.Collections.Generic;
using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;
using Gaya.Domain.Interfaces.Common;

namespace Gaya.Database.Repositories.Common
{
    public class CadastroRepository<T> : RepositoryBase<T>, ICadastroRepository<T> where T : Cadastro
    {
        public new Validation Add(T entity)
        {
            return base.Add(entity);
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public new IEnumerable<T> GetAll()
        {
            return base.GetAll();
        }

        public new T GetByKey(int key)
        {
            return base.GetByKey(key);
        }

        public Validation Remove(T entity)
        {
            try
            {
                Database.Set<T>().Remove(entity);
                Database.SaveChanges();
            }
            catch (Exception ex)
            {
                Validation.Id = -1;
                Validation.Mensagem = Tratamento.Tratar(ex);
            }

            return Validation;
        }

        public new Validation Update(T entity)
        {
            return base.Update(entity);
        }
    }
}
