using System;

namespace CipherLib.Exceptions
{

    public class InputIsEmptyException : Exception
    {
        public InputIsEmptyException() { }
        public InputIsEmptyException(string message) : base(message) { }
    }
}
