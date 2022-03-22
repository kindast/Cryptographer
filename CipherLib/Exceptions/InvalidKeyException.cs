using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherLib.Exceptions
{
    public class InvalidKeyException : Exception
    {
        public InvalidKeyException() { }
        public InvalidKeyException(string message) : base(message) { }
    }
}
