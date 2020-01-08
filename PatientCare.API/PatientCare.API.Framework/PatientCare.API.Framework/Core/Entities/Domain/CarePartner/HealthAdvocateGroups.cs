using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("HPT_HEALTHADVOCATEGROUPS", Schema = "CPARTNER")]
    public class HealthAdvocateGroups : BaseEntity
    {
        #region Properties
      
        [Column("HAGID")] public int HagId { get; set; }
        [Column("HAGDBID")] public int HagDbId { get; set; }
        [Column("GROUPSID")] public int GroupsId { get; set; }
        [Column("GROUPSDBID")] public int GroupsDbId { get; set; }
        [Column("GROUPUSERID")] public string GroupUserId { get; set; }
        [Column("GROUPNAMETXT")] public string GroupName { get; set; }
        [Column("EHATFLAG")] public int EhatFlag { get; set; }

        #endregion

        #region Constructors

        public HealthAdvocateGroups()
        {
        }

        #endregion
    }
}
