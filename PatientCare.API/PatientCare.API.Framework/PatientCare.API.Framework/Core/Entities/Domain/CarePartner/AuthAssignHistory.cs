using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("AUTHASSIGNHISTORY", Schema = "CPARTNER")]
    public class AuthAssignHistory : BaseEntity
    {
        #region Properties

        [Column("AUTHID")] public int AuthId { get; set; }
        [Column("AUTHDBID")] public int AuthDbId { get; set; }
        [Column("TIMEOFASSIGNMENT")] public DateTime TimeOfAssignment { get; set; }
        [Column("CMID")] public int CmId { get; set; }
        [Column("CMDBID")] public int CmDbId { get; set; }
        [Column("FROMWORKGROUPID")] public int? FromWorkGroupId { get; set; }
        [Column("FROMWORKGROUPDBID")] public int? FromWorkGroupDbId { get; set; }
        [Column("RULEUSED")] public string RuleUsed { get; set; }
        [Column("PRIORITYDESC")] public string PriorityDesc { get; set; }
        [Column("DUEDATE")] public DateTime? DueDate { get; set; }
        [Column("TOWORKGROUPID")] public int? ToWorkGroupId { get; set; }
        [Column("TOWORKGROUPDBID")] public int? ToWorkGroupDbId { get; set; }

        #endregion

        #region Constructors

        public AuthAssignHistory()
        {
            AuthDbId = CmDbId;
        }

        #endregion
    }
}
