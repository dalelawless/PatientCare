using System;
using System.Collections.Generic;
using System.Text;

namespace PatientCare.API.Framework.Core.Dto
{
    public class Eligibility
    {
        public int EligibilityId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Licensing_State { get; set; }
        public string FinAdmFlag { get; set; }
        public string BenefitPlan { get; set; }
        public string Erisa_Status { get; set; }
        public string Insured_Type { get; set; }
        public string SiteDef1 { get; set; }
        public string SiteDef2 { get; set; }
        public string SiteDef3 { get; set; }
        public string SiteDef4 { get; set; }
        public string Purchaser_Type { get; set; }
        public string Purchaser_Subtype { get; set; }
        public string ParentGroupName { get; set; }
        public string ParentGroupUserId { get; set; }
        public string GroupName { get; set; }
        public string GroupUserId { get; set; }
        public bool DefaultElig { get; set; }
        public bool UsesDefContract { get; set; }
    }
}