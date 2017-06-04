using System;
using System.Linq;
using Gaya.Database.Common.Context;
using Gaya.Domain.Entities;
using Gaya.Domain.Entities.Common;
using Gaya.Domain.FrameWork.Exceptions;
using Gaya.Domain.Interfaces.Common;

namespace Gaya.Database.Common.Repositories
{
    public class CommonParametersRepository : ICommonParametersRepository<CommonParameters>
    {
        protected CommonContext Database = new CommonContext();
        protected Validation Validation = new Validation();
        protected ExceptionTratamento Tratamento = new ExceptionTratamento();

        public Validation Add(CommonParameters commonParameters)
        {
            try
            {
                Database.CommonParameters.Add(commonParameters);
            }
            catch (Exception ex)
            {
                var tratado = Tratamento.Tratar(ex);

                Validation.Id = 999;
                Validation.Mensagem = tratado;
            }

            return Validation;
        }

        public CommonParameters Get()
        {
            return Database.CommonParameters.First();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(Database);
            GC.SuppressFinalize(Validation);
            GC.SuppressFinalize(Tratamento);
            GC.Collect();
        }
    }
}