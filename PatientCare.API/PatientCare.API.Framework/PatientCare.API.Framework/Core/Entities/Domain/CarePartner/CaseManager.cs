using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("CASEMANAGER", Schema = "CPARTNER")]
    public class CaseManager : BaseEntity
    {
        [Column("CMID")] public int CmId { get; set; }
        [Column("CMDBID")] public int CmDbId { get; set; }
        [Column("NAMELAST")] public string NameLast { get; set; }
        [Column("NAMEFIRST")] public string NameFirst { get; set; }
        [Column("DEPTNAME")] public string DeptName { get; set; }
        [Column("EMAILADDRESS")] public string EmailAddress { get; set; }
        [Column("WORKFLOWADDRESS")] public string WorkflowAddress { get; set; }
        [Column("LOGINID")] public string LoginId { get; set; }
        [Column("PASSWORD")] public string Password { get; set; }
        [Column("PREFERREDDBID")] public int PreferredDbId { get; set; }
        [Column("CMDEACTIVATEDFLAG")] public int CmDeactivatedFlag { get; set; }
        [Column("REMOTEUSER")] public int RemoteUser { get; set; }
        [Column("DIALUSERNAME")] public string DialUserName { get; set; }
        [Column("DIALPASSWORD")] public string DialPassword { get; set; }
        [Column("CONNECTIONTYPE")] public int ConnectionType { get; set; }
        [Column("CONTACTPHONE")] public string ContactPhone { get; set; }
        [Column("RMTADMINNAME")] public string RmtAdminName { get; set; }
        [Column("RMTADMINPHN")] public string RmtAdminPhn { get; set; }
        [Column("TIMESYNC")] public int TimeSync { get; set; }
        [Column("TIMESYNCTYPE")] public string TimeSyncType { get; set; }
        [Column("TIMESYNCMAX")] public int TimeSyncMax { get; set; }
        [Column("TIMESYNCMAXTYPE")] public string TimeSyncMaxType { get; set; }
        [Column("SECPATIENT")] public string SecPatient { get; set; }
        [Column("SECDIAGGRP1")] public string SecDiagGrp1 { get; set; }
        [Column("SECDIAGGRP2")] public string SecDiagGrp2 { get; set; }
        [Column("SECDIAGGRP3")] public string SecDiagGrp3 { get; set; }
        [Column("SECDIAGGRP4")] public string SecDiagGrp4 { get; set; }
        [Column("SECACTIVITY")] public string SecActivity { get; set; }
        [Column("PCPASSWORD")] public string PcPassword { get; set; }
        [Column("MOBILE_CP_USER_TYPE")] public int MobileCpUserType { get; set; }
        [Column("DEPTSUBGROUP")] public string DeptSubGroup { get; set; }
        [Column("PWNEVEREXPIRE")] public int PwNeverExpire { get; set; }
        [Column("PWEXPIRED")] public int PwExpired { get; set; }
        [Column("LASTPASSWORDCHANGETS")] public DateTime LastPasswordChangeTs { get; set; }
        [Column("LASTLOGINTS")] public DateTime LastLoginTs { get; set; }
        [Column("CONSECUTIVEFAILURES")] public int ConsecutiveFailures { get; set; }
        [Column("HEALTH_ADVOCATE_FLAG_INT")] public int HealthAdvocateFlagInt { get; set; }
        [Column("GENERIC_CM_FLAG_INT")] public int GenericCmFlagInt { get; set; }
        [Column("RMTADMINTITLE_TXT")] public string RmtAdminTitleTxt { get; set; }
        [Column("RMTADMINALTPHN1_TXT")] public string RmtAdminAltPhn1Txt { get; set; }
        [Column("RMTADMINALTPHN2_TXT")] public string RmtAdminAltPhn2Txt { get; set; }
        [Column("BHSPECIALISTFLAGINT")] public int BhSpecialistFlagInt { get; set; }
        [Column("LANGUAGE1")] public string Language1 { get; set; }
        [Column("LANGUAGE2")] public string Language2 { get; set; }
        [Column("SYSTEM_ACCT_FLAG_INT")] public int SystemAcctFlagInt { get; set; }
        [Column("WINDOWSLOGINID")] public string WindowsLoginId { get; set; }
        [Column("LOGGINGFLAG")] public int LoggingFlag { get; set; }



    }
}
