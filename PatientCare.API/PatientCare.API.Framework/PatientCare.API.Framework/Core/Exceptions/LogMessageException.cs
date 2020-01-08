using PatientCare.API.Framework.Core.Constants;
using System;

namespace PatientCare.API.Framework.Core.Exceptions
{
    public class LogMessageException : Exception
    {
        public LogMessageException() : base(LoggingConstants.Log_MessageNotFoundException)
        {
        }
    }
}