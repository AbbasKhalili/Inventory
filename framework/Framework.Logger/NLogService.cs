using Framework.Core;
using NLog;
using System;

namespace Framework.Logger
{
    public abstract class NLogService
    {
        private readonly ILogger _logger;

        protected NLogService(ILogger logger)
        {
            _logger = logger;
        }
        public void Information(string message)
        {
            _logger.Info(message);
        }

        public void Warning(string message)
        {
            _logger.Warn(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }

        public void Error(Exception exception, string message)
        {
            _logger.Error(exception, message);
        }
    }
    public class NLoggerService : NLogService, ILoggerService
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public NLoggerService() : base(Logger)
        {
        }
    }

    public class NLoggerService<T> : NLogService, ILoggerService<T> where T : class
    {
        private static readonly ILogger Logger = LogManager.LogFactory.GetLogger(typeof(T).FullName);

        public NLoggerService() : base(Logger)
        {

        }
    }
}
