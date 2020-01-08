using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("C_OUTREACH", Schema = "CPARTNER")]
    public class Outreach
    {
        #region Properties

        [Column("ACTIVITYID")] public int ActivityId { get; set; }

        [Column("REASONNOCONT")] public string ReasonNoContact { get; set; }

        #endregion

        #region Constructors

        public Outreach()
        {

        }

        #endregion

    }
}