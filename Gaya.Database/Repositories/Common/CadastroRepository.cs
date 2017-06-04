using System;
using System.Collections.Generic;
using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;
using Gaya.Domain.Interfaces.Common;
using Gaya.Database.Repositories.Common;
using Gaya.Database.Context;
using Gaya.Domain.FrameWork.Exceptions;

namespace Gaya.Database.Repositories.Common
{
    public class CadastroRepository<T> : RepositoryBase<T>, ICadastroRepository<T> where T : Cadastro
    {
        protected new GayaContext database = new GayaContext();
        protected new Validation validation = new Validation();
        protected new ExceptionTratamento tratamento = new ExceptionTratamento();

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
                database.Set<T>().Remove(entity);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                validation.Id = -1;
                validation.Mensagem = tratamento.Tratar(ex);
            }

            return validation;
        }

        public new Validation Update(T entity)
        {
            return base.Update(entity);
        }
    }
}
