using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("PATIENTACTIVITY", Schema = "CPARTNER")]
    public class PatientActivity : BaseEntity
    {
        #region Properties

        [Column("PERSONID")] public int PersonId { get; set; }

        [Column("ACTIVITYID")] public int ActivityId { get; set; }


        #endregion

        #region Constructors

        public PatientActivity()
        {
        }

        #endregion
    }
}