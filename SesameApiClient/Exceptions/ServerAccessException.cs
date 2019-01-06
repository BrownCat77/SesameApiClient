using System;

namespace SesameApiClient.Exceptions
{
    public class ServerAccessException : Exception
    {
        public ServerAccessException() { }
        public ServerAccessException(string message) : base(message) { }
        public ServerAccessException(string message, Exception inner) : base(message, inner) { }
    }
}
