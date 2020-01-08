using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientCare.API.Framework.Core.Entities.Domain.CarePartner
{
    [Table("HPT_CMPGN_MBR_IDENT", Schema = "CPARTNER")]
    public class HptCmpgnMbrIdent
    {
        #region Properties

        [Column("PERSONID")] public int PersonId { get; set; }
        [Column("PERSONDBID")] public int PersonDbId { get; set; }
        [Column("PERSONREFERENCE")] public string PersonReference { get; set; }

        [Column("CAMPAIGN_ID")] public int CampaignId { get; set; }
        [Column("PROGRAM_NAME")] public string ProgramName { get; set; }

        [Column("AUTOBUILD_DATE")] public DateTime AutoBuildDate { get; set; }

        [Column("CASEID")] public int CaseId { get; set; }
        [Column("CASEDBID")] public int CaseDbId { get; set; }
        [Column("CASEREFERENCENUM")] public string CaseReferenceNumber { get; set; }

        [Column("ACTIVITYID")] public int ActivityId { get; set; }
        [Column("ACTIVITYDBID")] public int ActivityDbId { get; set; }

        [Column("HA_ACTIVITYID")] public int HealthActionActivityId { get; set; }
        [Column("HA_ACTIVITYDBID")] public int HealthActionActivityDbId { get; set; }

        #endregion

        #region Constructors

        public HptCmpgnMbrIdent()
        {

        }

        #endregion

    }
}
