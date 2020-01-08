using Ardalis.GuardClauses;

namespace PatientCare.API.Framework.Core.Exceptions
{
    public static class GuardExtensions
    {
        public static void LogAppNameEmpty(this IGuardClause guardClause, string appName)
        {
            if (string.IsNullOrWhiteSpace(appName))
                throw new LogAppNameException();
        }

        public static void LogMessageEmpty(this IGuardClause guardClause, string logMessage)
        {
            if (string.IsNullOrWhiteSpace(logMessage))
                throw new LogMessageException();
        }
    }
}