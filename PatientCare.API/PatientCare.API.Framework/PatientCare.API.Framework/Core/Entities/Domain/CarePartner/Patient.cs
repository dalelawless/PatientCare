using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("PATIENT", Schema = "CPARTNER")]
    public class Patient : BaseEntity
    {
        #region Properties

        [Column("PERSONID")] public int PersonId { get; set; }

        [Column("PERSONDBID")] public int PersonDbId { get; set; }

        [Column("DBID")] public int DbId { get; set; }

        [Column("PERSONREFERENCE")] public int PersonReference { get; set; }

        #endregion

        #region Constructors

        public Patient()
        {
            PersonDbId = DbId;
        }

        #endregion

    }
}