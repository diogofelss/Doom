using System;

namespace Gaya.Domain.FrameWork.Exceptions
{
    public class ExceptionTratamento
    {
        public string Tratar(Exception ex)
        {
            var msg = string.Empty;

            if (ex.InnerException != null)
            {
                Tratar(ex);
            }
            else
            {
                msg = ex.Message;
            }

            return msg;
        }
    }
}
