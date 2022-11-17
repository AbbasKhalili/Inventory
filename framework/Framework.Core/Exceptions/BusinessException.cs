using System;

namespace Framework.Core.Exceptions
{
    public class BusinessException : Exception
    {
        public int Code { get; }
        public string ExceptionMessage { get; }

        public BusinessException(int code, string message = "")
        {
            Code = code;
            ExceptionMessage = message;
        }
    }
}
