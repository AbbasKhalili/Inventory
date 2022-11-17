using NLog;

namespace Framework.Logger
{
    public static class NLogConfigure
    {
        public static void Config(string nlogConfigFile = "./nlog.config")
        {
            LogManager.LoadConfiguration(nlogConfigFile).GetCurrentClassLogger();
        }
    }
}
