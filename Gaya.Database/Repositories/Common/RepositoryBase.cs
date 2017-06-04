using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Gaya.Database.Context;
using Gaya.Domain.Entities;
using Gaya.Domain.FrameWork.Exceptions;
using Gaya.Domain.Interfaces.Common;

namespace Gaya.Database.Repositories.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected GayaContext Database = new GayaContext();
        protected Validation Validation = new Validation();
        protected ExceptionTratamento Tratamento = new ExceptionTratamento();

        public Validation Add(T entity)
        {
            try
            {
                Database.Set<T>().Add(entity);
                Database.SaveChanges();
            }
            catch(Exception ex)
            {
                Validation.Id = -1;
                Validation.Mensagem = Tratamento.Tratar(ex);
            }

            return Validation;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(Database);
            GC.SuppressFinalize(Tratamento);
            GC.SuppressFinalize(Validation);
            GC.Collect();
        }

        public IEnumerable<T> GetAll()
        {
            return Database.Set<T>().ToList();
        }

        public T GetByKey(int key)
        {
            return Database.Set<T>().Find(key);
        }

        public Validation Update(T entity)
        {
            try
            {
                Database.Entry(entity).State = EntityState.Modified;
                Database.SaveChanges();
            }
            catch (Exception ex)
            {
                Validation.Id = -1;
                Validation.Mensagem = Tratamento.Tratar(ex);
            }

            return Validation;
        }
    }
}
