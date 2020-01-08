using Ardalis.GuardClauses;
using PatientCare.API.Framework.Core.Exceptions;
using PatientCare.API.Framework.Core.Entities.Logging;
using PatientCare.API.Framework.Core.Enums;
using PatientCare.API.Framework.Core.Interfaces.Logging;
using System;

namespace PatientCare.API.Framework.Infrastructure.Logging
{
    public class LoggerAdapter : IAppLogger, IDisposable
    {
        private LoggingFields logFields;
        private LoggingHelper loggingHelper = new LoggingHelper();

        public LoggerAdapter(string logFileUri)
        {
            loggingHelper.LogFileUri = logFileUri;
        }

        public string LogFileUri { get; set; }

        public bool LogWarning(string appName, string logMessage)
        {
            Guard.Against.LogAppNameEmpty(appName);
            Guard.Against.LogMessageEmpty(logMessage);

            logFields = new LoggingFields
            {
                AppName = appName,
                LogMessage = logMessage
            };

            return loggingHelper.ToFile(logFields, LoggingType.Warning);
        }

        public bool LogInformation(string appName, string logMessage)
        {
            Guard.Against.LogAppNameEmpty(appName);
            Guard.Against.LogMessageEmpty(logMessage);

            logFields = new LoggingFields
            {
                AppName = appName,
                LogMessage = logMessage
            };

            return loggingHelper.ToFile(logFields, LoggingType.Information);
        }

        public bool LogException(string appName, Exception ex)
        {
            Guard.Against.LogAppNameEmpty(appName);

            logFields = new LoggingFields
            {
                AppName = appName,
                ExceptionMessage = ex.Message,
                ExceptionStackTrace = ex.StackTrace
            };

            return loggingHelper.ToFile(logFields, LoggingType.Exception);
        }

        public bool LogExceptionWithMessage(string appName, Exception ex, string logMessage)
        {
            Guard.Against.LogAppNameEmpty(appName);

            logFields = new LoggingFields
            {
                AppName = appName,
                ExceptionMessage = ex.Message,
                ExceptionStackTrace = ex.StackTrace,
                LogMessage = logMessage
            };

            return loggingHelper.ToFile(logFields, LoggingType.Exception);
        }

        public bool LogPerformance(string appName, string logMessage, DateTime startTm, DateTime endTm)
        {
            Guard.Against.LogAppNameEmpty(appName);
            Guard.Against.LogMessageEmpty(logMessage);

            logFields = new LoggingFields
            {
                AppName = appName,
                LogMessage = logMessage,
                PerformanceStartTime = startTm,
                PerformanceEndTime = endTm
            };

            return loggingHelper.ToFile(logFields, LoggingType.Performance);
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    loggingHelper = null;
                    logFields = null;
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);

            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion
    }
}