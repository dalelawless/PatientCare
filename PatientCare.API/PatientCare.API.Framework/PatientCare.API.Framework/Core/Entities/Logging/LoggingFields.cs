using System;
using System.Collections.Generic;
using System.Text;

namespace PatientCare.API.Framework.Core.Entities.Logging
{
   public class LoggingFields
   {
        public string AppName { get; set; }

        public string LogMessage { get; set; }
        public string LogType { get; set; }

        public string ExceptionMessage { get; set; }
        public string ExceptionStackTrace { get; set; }

        public DateTime PerformanceStartTime { get; set; }
        public DateTime PerformanceEndTime { get; set; }
   }
}