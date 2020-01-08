using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("WORKGROUP", Schema = "CPARTNER")]
    public class WorkGroup : BaseEntity
    {
        #region Properties

        [Column("WORKGROUPID")] public int WorkGroupId { get; set; }
        [Column("WORKGROUPDBID")] public int WorkGroupDbId { get; set; }
        [Column("NAME")] public string Name { get; set; }
        [Column("DESCRIPTION")] public string Description { get; set; }

        #endregion

        #region Constructors

        public WorkGroup()
        {
        }

        #endregion
    }
}
