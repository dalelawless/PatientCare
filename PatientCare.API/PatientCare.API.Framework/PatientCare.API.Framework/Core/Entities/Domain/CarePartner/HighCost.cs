using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("C_HIGHCOST", Schema = "CPARTNER")]
    public class HighCost : BaseEntity
    {
        #region Properties

        [Column("ACTIVITYID")] public int ActivityId { get; set; }
        [Column("STARTDT")] public DateTime? StartDate { get; set; }
        [Column("ENDDT")] public DateTime? EndDate { get; set; }

        #endregion

        #region Constructors

        public HighCost()
        {
        }

        #endregion
    }
}
