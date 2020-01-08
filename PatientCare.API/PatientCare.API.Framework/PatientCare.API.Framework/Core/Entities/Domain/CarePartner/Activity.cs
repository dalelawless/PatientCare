using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("ACTIVITY", Schema = "CPARTNER")]
    public class Activity : BaseEntity
    {
        #region Properties

        [Column("ACTIVITYID")] public int ActivityId { get; set; }

        [Column("DESCRIPTION")] public string Description { get; set; }

        [Column("DATEDONE")] public DateTime? DateDone { get; set; }

        [Column("NOTE")] public string Note { get; set; }  

        #endregion

        #region Constructors

        public Activity()
        {
        }

        #endregion
    }
}
