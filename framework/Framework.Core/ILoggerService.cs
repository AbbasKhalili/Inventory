using System;

namespace Framework.Core
{
    public interface ILoggerService
    {
        void Information(string message);
        void Warning(string message);
        void Debug(string message);
        void Error(string message);
        void Error(Exception exception);
        void Error(Exception exception, string message);
    }
    public interface ILoggerService<T> : ILoggerService where T : class
    {

    }
}
