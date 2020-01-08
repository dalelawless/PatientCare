using System;

namespace PatientCare.API.Framework.Core.Interfaces.Logging
{
    /// <summary>
    /// This type eliminates the need to depend directly on the ASP.NET Core logging types.
    /// </summary>
    public interface IAppLogger
    {
        bool LogInformation(string appName, string logMessage);
        bool LogWarning(string appName, string logMessage);
        bool LogException(string appName, Exception ex);
        bool LogExceptionWithMessage(string appName, Exception ex, string logMessage);
        bool LogPerformance(string appName, string logMessage, DateTime startTm,DateTime endTm);
    }
}