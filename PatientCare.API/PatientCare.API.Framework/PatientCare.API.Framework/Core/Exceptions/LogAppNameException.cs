using PatientCare.API.Framework.Core.Constants;
using System;

namespace PatientCare.API.Framework.Core.Exceptions
{
    public class LogAppNameException : Exception
    {
        public LogAppNameException() : base(LoggingConstants.Log_AppNameNotFoundException)
        {
        }
    }
}