namespace PatientCare.API.Framework.Core.Constants
{
    public class LoggingConstants
    {
        public const string AppName = "PatientCare";
        public const string DefaultLogUri = "C:\\Logs\\PatientCare\\";
        public const string DefaultLogUriFail = "C:\\Logs\\PatientCare_Fail\\";
        public const string LogDateTimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
        public const string LogFileDateTimeFormat = "yyyyMMdd";
        public const string Log_AppNameNotFoundException = "Log application name can not be blank";
        public const string Log_MessageNotFoundException = "Log message can not be blank";
        public const string Log_DirectoryNotFoundException = "Directory Not Found Exception";
        public const string SourceLogName = "PatientCare";
        public const string TextFileName = "PatientCare-{0}-Logs-{1}.txt";
    }
}