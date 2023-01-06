using Serilog;
using Serilog.Core;
using ILogger = Serilog.ILogger;

namespace BlazorServer.ExceptionHandlingAndLogging.Helpers
{
    public static class LogHelper
    {
        private static ILogger _logger;
        public static void Initiate(Logger logger)
        {
            _logger = logger;
        }

        public static void Information(string message)
        {
            _logger.Information(message);
        }
    }
}
