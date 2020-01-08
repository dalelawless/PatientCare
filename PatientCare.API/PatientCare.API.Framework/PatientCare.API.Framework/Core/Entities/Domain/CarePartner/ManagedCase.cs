using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("ManagedCase", Schema = "CPARTNER")]
    public class ManagedCase : BaseEntity
    {
        #region Properties

        [Column("CASEID")] public int CaseId { get; set; }
        [Column("CASEDBID")] public int CaseDbId { get; set; }
        [Column("CASEREFERENCE")] public int CaseReference { get; set; }

        [Column("DBID")] public int DbId { get; set; }
        [Column("OWNERDBID")] public int OwnerDbId { get; set; }

        [Column("PERSONID")] public int PersonId { get; set; }
        [Column("PERSONDBID")] public int PersonDbId { get; set; }

        #endregion

        #region Constructors

        public ManagedCase()
        {
            CaseDbId = PersonDbId = OwnerDbId = DbId;
        }

        #endregion

    }
}
