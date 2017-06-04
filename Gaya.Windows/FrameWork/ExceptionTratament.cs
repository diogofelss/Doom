using Gaya.Domain.FrameWork.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaya.Windows.FrameWork
{
    public class ExceptionTratament
    {
        public void TratarErro(Exception ex)
        {
            var tratamento = new ExceptionTratamento();

            Globals.Mensagens.ShowMessageError(string.Format("{0}. {1}", Mensagens.Internal.MSG0000, tratamento.Tratar(ex)));
        }
    }
}
