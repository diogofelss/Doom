using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaya.Interface.Windows.FrameWork
{
    public class ExceptionTratament
    {
        public void TratarErro(Exception ex)
        {
            if (ex.InnerException != null)
            {
                TratarErro(ex);
            }
            else
            {
                Globals.Mensagens.ShowMessageError(string.Format("{0}. {1}", Mensagens.Internal.MSG0000, ex.Message));
            }
        }
    }
}
