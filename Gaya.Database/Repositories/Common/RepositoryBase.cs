using System;
using System.Collections.Generic;
using Gaya.Domain.Entities;
using Gaya.Domain.Interfaces.Common;
using Gaya.Database.Context;
using Gaya.Domain.FrameWork.Exceptions;
using System.Linq;

namespace Gaya.Database.Repositories.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected GayaContext database = new GayaContext();
        protected Validation validation = new Validation();
        protected ExceptionTratamento tratamento = new ExceptionTratamento();

        public Validation Add(T entity)
        {
            try
            {
                database.Set<T>().Add(entity);
                database.SaveChanges();
            }
            catch(Exception ex)
            {
                validation.Id = -1;
                validation.Mensagem = tratamento.Tratar(ex);
            }

            return validation;
        }

        public void Dispose()
        {
            database = null;
            GC.Collect();
        }

        public IEnumerable<T> GetAll()
        {
            return database.Set<T>().ToList();
        }

        public T GetByKey(int key)
        {
            return database.Set<T>().Find(key);
        }

        public Validation Update(T entity)
        {
            try
            {
                database.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                validation.Id = -1;
                validation.Mensagem = tratamento.Tratar(ex);
            }

            return validation;
        }
    }
}
