using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBestPracticeOverviewResponse : SdkResponse
    {

        /// <summary>
        /// 总分数
        /// </summary>
        [JsonProperty("total_score", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TotalScore { get; set; }

        /// <summary>
        /// 检测完成时间
        /// </summary>
        [JsonProperty("detect_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DetectTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organization_account", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem OrganizationAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identity_permission", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem IdentityPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_planning", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem NetworkPlanning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compliance_audit", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem ComplianceAudit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("financial_governance", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem FinancialGovernance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_boundary", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem DataBoundary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("om_monitor", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem OmMonitor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_management", NullValueHandling = NullValueHandling.Ignore)]
        public BestPracticeOverviewItem SecurityManagement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBestPracticeOverviewResponse {\n");
            sb.Append("  totalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  detectTime: ").Append(DetectTime).Append("\n");
            sb.Append("  organizationAccount: ").Append(OrganizationAccount).Append("\n");
            sb.Append("  identityPermission: ").Append(IdentityPermission).Append("\n");
            sb.Append("  networkPlanning: ").Append(NetworkPlanning).Append("\n");
            sb.Append("  complianceAudit: ").Append(ComplianceAudit).Append("\n");
            sb.Append("  financialGovernance: ").Append(FinancialGovernance).Append("\n");
            sb.Append("  dataBoundary: ").Append(DataBoundary).Append("\n");
            sb.Append("  omMonitor: ").Append(OmMonitor).Append("\n");
            sb.Append("  securityManagement: ").Append(SecurityManagement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBestPracticeOverviewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBestPracticeOverviewResponse input)
        {
            if (input == null) return false;
            if (this.TotalScore != input.TotalScore || (this.TotalScore != null && !this.TotalScore.Equals(input.TotalScore))) return false;
            if (this.DetectTime != input.DetectTime || (this.DetectTime != null && !this.DetectTime.Equals(input.DetectTime))) return false;
            if (this.OrganizationAccount != input.OrganizationAccount || (this.OrganizationAccount != null && !this.OrganizationAccount.Equals(input.OrganizationAccount))) return false;
            if (this.IdentityPermission != input.IdentityPermission || (this.IdentityPermission != null && !this.IdentityPermission.Equals(input.IdentityPermission))) return false;
            if (this.NetworkPlanning != input.NetworkPlanning || (this.NetworkPlanning != null && !this.NetworkPlanning.Equals(input.NetworkPlanning))) return false;
            if (this.ComplianceAudit != input.ComplianceAudit || (this.ComplianceAudit != null && !this.ComplianceAudit.Equals(input.ComplianceAudit))) return false;
            if (this.FinancialGovernance != input.FinancialGovernance || (this.FinancialGovernance != null && !this.FinancialGovernance.Equals(input.FinancialGovernance))) return false;
            if (this.DataBoundary != input.DataBoundary || (this.DataBoundary != null && !this.DataBoundary.Equals(input.DataBoundary))) return false;
            if (this.OmMonitor != input.OmMonitor || (this.OmMonitor != null && !this.OmMonitor.Equals(input.OmMonitor))) return false;
            if (this.SecurityManagement != input.SecurityManagement || (this.SecurityManagement != null && !this.SecurityManagement.Equals(input.SecurityManagement))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.TotalScore != null) hashCode = hashCode * 59 + this.TotalScore.GetHashCode();
                if (this.DetectTime != null) hashCode = hashCode * 59 + this.DetectTime.GetHashCode();
                if (this.OrganizationAccount != null) hashCode = hashCode * 59 + this.OrganizationAccount.GetHashCode();
                if (this.IdentityPermission != null) hashCode = hashCode * 59 + this.IdentityPermission.GetHashCode();
                if (this.NetworkPlanning != null) hashCode = hashCode * 59 + this.NetworkPlanning.GetHashCode();
                if (this.ComplianceAudit != null) hashCode = hashCode * 59 + this.ComplianceAudit.GetHashCode();
                if (this.FinancialGovernance != null) hashCode = hashCode * 59 + this.FinancialGovernance.GetHashCode();
                if (this.DataBoundary != null) hashCode = hashCode * 59 + this.DataBoundary.GetHashCode();
                if (this.OmMonitor != null) hashCode = hashCode * 59 + this.OmMonitor.GetHashCode();
                if (this.SecurityManagement != null) hashCode = hashCode * 59 + this.SecurityManagement.GetHashCode();
                return hashCode;
            }
        }
    }
}
