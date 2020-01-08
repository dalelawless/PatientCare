using PatientCare.API.Framework.Core.Constants;
using PatientCare.API.Framework.Core.Entities.Logging;
using PatientCare.API.Framework.Core.Enums;
using System;
using System.IO;

namespace PatientCare.API.Framework.Infrastructure.Logging
{
    public class LoggingHelper
    {
        public string LogFileUri { get; set; }

        public bool ToFile(LoggingFields logFields, LoggingType loggingType)
        {
            bool retVal = false;

            string DtTm = DateTime.Now.ToString(LoggingConstants.LogDateTimeFormat);
            string fileName = string.Format(LoggingConstants.TextFileName, logFields.AppName, DateTime.Now.ToString(LoggingConstants.LogFileDateTimeFormat));
            string filePath = @LogFileUri + fileName;

            try
            {
                using (StreamWriter file = File.AppendText(filePath))
                {
                    switch (loggingType)
                    {
                        case LoggingType.Information:
                        case LoggingType.Warning:
                            file.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", DtTm, LoggingConstants.SourceLogName, loggingType, logFields.AppName, logFields.LogMessage));
                            retVal = true;
                            break;
                        case LoggingType.Exception:
                            file.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", DtTm, LoggingConstants.SourceLogName, loggingType, logFields.AppName, logFields.ExceptionMessage, logFields.ExceptionStackTrace));
                            retVal = true;
                            break;
                        case LoggingType.ExceptionWithMessage:
                            file.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", DtTm, LoggingConstants.SourceLogName, loggingType, logFields.AppName, logFields.ExceptionMessage, logFields.ExceptionStackTrace, logFields.LogMessage));
                            retVal = true;
                            break;
                        case LoggingType.Performance:
                            file.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", DtTm, LoggingConstants.SourceLogName, loggingType, logFields.AppName, logFields.PerformanceStartTime, logFields.PerformanceEndTime, logFields.LogMessage));
                            retVal = true;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                retVal = false;
                //throw new ArgumentException(LoggingConstants.Log_DirectoryNotFoundException);
            }
            catch
            {
                retVal = false;
            }

            return retVal;
        }
    }
}