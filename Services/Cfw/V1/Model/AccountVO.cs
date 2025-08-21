using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountVO 
    {

        /// <summary>
        /// **参数解释**： 账号ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// **参数解释**： 账号名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// **参数解释**： 防护的EIP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("eip_count_protected", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipCountProtected { get; set; }

        /// <summary>
        /// **参数解释**： EIP总数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("eip_count_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipCountTotal { get; set; }

        /// <summary>
        /// **参数解释**： 未开启防护的EIP数量 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("eip_count_unprotected", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipCountUnprotected { get; set; }

        /// <summary>
        /// **参数解释**： 组织ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 项目名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountVO {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  eipCountProtected: ").Append(EipCountProtected).Append("\n");
            sb.Append("  eipCountTotal: ").Append(EipCountTotal).Append("\n");
            sb.Append("  eipCountUnprotected: ").Append(EipCountUnprotected).Append("\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountVO input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.EipCountProtected != input.EipCountProtected || (this.EipCountProtected != null && !this.EipCountProtected.Equals(input.EipCountProtected))) return false;
            if (this.EipCountTotal != input.EipCountTotal || (this.EipCountTotal != null && !this.EipCountTotal.Equals(input.EipCountTotal))) return false;
            if (this.EipCountUnprotected != input.EipCountUnprotected || (this.EipCountUnprotected != null && !this.EipCountUnprotected.Equals(input.EipCountUnprotected))) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.EipCountProtected != null) hashCode = hashCode * 59 + this.EipCountProtected.GetHashCode();
                if (this.EipCountTotal != null) hashCode = hashCode * 59 + this.EipCountTotal.GetHashCode();
                if (this.EipCountUnprotected != null) hashCode = hashCode * 59 + this.EipCountUnprotected.GetHashCode();
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
