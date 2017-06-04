using System.Collections.Generic;
using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;
using Gaya.Domain.Enums;
using Gaya.Domain.Interfaces.Common;

namespace Gaya.Database.Repositories.Common
{
    public class DocumentoRepository<T> : RepositoryBase<T>, IDocumentoRepository<T> where T : Documento
    {
        public new Validation Add(T entity)
        {
            return base.Add(entity);
        }

        public Validation Cancel(T entity)
        {
            entity.Cancelado = true;
            entity.Status = DocumentEnum.EnStatusDocumento.Cancelado;

            return Update(entity);
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

        public Validation Restore(T entity)
        {
            entity.Cancelado = false;
            entity.Status = DocumentEnum.EnStatusDocumento.Aberto;

            return Update(entity);
        }

        public new Validation Update(T entity)
        {
            return base.Update(entity);
        }
    }
}
