using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("STG_IVR", Schema = "CPARTNER_EXTR")]
    public class StageIVR
    {
        #region Properties

        [Column("ACTIVITYID")] public int ActivityId { get; set; }
        [Column("FILE_NAME")] public string FileName { get; set; }
        [Column("COMPLETE_CODE_ID")] public int CompleteCodeId { get; set; }
        [Column("COMPLETE_CODE")] public string CompleteCode { get; set; }
        [Column("COMPLETE_CODE_DESC")] public string CompleteCodeDesc { get; set; }
        [Column("CUST_CMPL_CODE_ID")] public int CustomCompletionCodeId { get; set; }
        [Column("CUST_CMPL_CODE")] public string CustomCompletionCode { get; set; }
        [Column("CUST_CMPL_CODE_DESC")] public string CustomCompletionCodeDesc { get; set; }
        [Column("CALL_TIME")] public DateTime CallTime { get; set; }
        [Column("PERSONREFERENCE")] public string PersonReference { get; set; }
        [Column("CASEREFERENCE")] public string CaseReference { get; set; }
        [Column("MEMBERDOB")] public string MemberDOB { get; set; }
        [Column("ATTEMPTNUMBER")] public int AtttemptNumber { get; set; }
        [Column("CONTACTLISTNAME")] public string ContactListName { get; set; }
        [Column("FIRSTNAME")] public string FirstName { get; set; }
        [Column("LASTNAME")] public string LastName { get; set; }
        [Column("CAMPAIGNNAME")] public string CampaignName { get; set; }
        [Column("PROCESSED_FLG")] public string ProcessFlag { get; set; }
        [Column("RESULT_ID")] public int ResultId { get; set; }

        #endregion

        #region Constructors

        public StageIVR()
        {
           
        }

        #endregion

    }
}
