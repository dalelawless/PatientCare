using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("AUTHORIZATION", Schema = "CPARTNER")]
    public class Authorization : BaseEntity
    {
        [Column("AUTHID")] public int AuthId { get; set; }
        [Column("AUTHDBID")] public int AuthDbId { get; set; }
        [Column("TYPE")] public string Type { get; set; }
        [Column("CATEGORY")] public string Category { get; set; }
        [Column("SUBTYPE1")] public string SubType1 { get; set; }
        [Column("SUBTYPE2")] public string SubType2 { get; set; }
        [Column("SUBTYPE3")] public string SubType3 { get; set; }
        [Column("PERSONID")] public int PersonId { get; set; }
        [Column("PERSONDBID")] public int PersonDbid { get; set; }
        [Column("STATEID")] public int StateId { get; set; }
        [Column("CREATEDBY")] public string CreatedBy {get;set;}
        [Column("ACTDOSSTART")] public DateTime ActDosStart { get; set; }
        [Column("ACTDOSEND")] public DateTime ActDoSend { get; set; }
        [Column("ELIGIBILITYID")] public int EligibilityId { get; set; }
        [Column("ELIGIBILITYDBID")] public int EligibilityDbId { get; set; }
    }
}