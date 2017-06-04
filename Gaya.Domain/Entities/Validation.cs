using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaya.Domain.Entities
{
    public class Validation
    {
        private int _id;
        private string message;

        public Validation()
        {
            _id = 0;
            message = string.Empty;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Mensagem { get { return message; } set { message = value; } }
    }
}
