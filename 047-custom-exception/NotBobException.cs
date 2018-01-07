using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _047_custom_exception
{
    class NotBobException : Exception
    {
        public string BadInput { get; set; }
        public override string Message
        {
            get
            {
                return "WARNING: '" + BadInput + "' is not Bob";
            }
        }

        public NotBobException(string BadInput)
        {
            this.BadInput = BadInput;
        }
    }
}
