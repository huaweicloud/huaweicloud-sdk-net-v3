using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class NeutronRemoveFirewallRuleResponse : SdkResponse
    {

        /// <summary>
        /// 功能说明：网络ACL策略ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：网络ACL策略名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：网络ACL策略的描述信息 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：网络ACL策略关联的规则的ID列表
        /// </summary>
        [JsonProperty("firewall_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FirewallRules { get; set; }

        /// <summary>
        /// 功能说明：每次policy或者它相关的rule有变动，该参数将会被置为False
        /// </summary>
        [JsonProperty("audited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Audited { get; set; }

        /// <summary>
        /// 功能说明：网络ACL策略是否对其他网络ACL策略可见 取值范围：true(可见)、false(不可见)
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        /// <summary>
        /// 功能说明：网络ACL策略所属项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：网络ACL策略所属项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronRemoveFirewallRuleResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  firewallRules: ").Append(FirewallRules).Append("\n");
            sb.Append("  audited: ").Append(Audited).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronRemoveFirewallRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronRemoveFirewallRuleResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FirewallRules != input.FirewallRules || (this.FirewallRules != null && input.FirewallRules != null && !this.FirewallRules.SequenceEqual(input.FirewallRules))) return false;
            if (this.Audited != input.Audited || (this.Audited != null && !this.Audited.Equals(input.Audited))) return false;
            if (this.Public != input.Public || (this.Public != null && !this.Public.Equals(input.Public))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FirewallRules != null) hashCode = hashCode * 59 + this.FirewallRules.GetHashCode();
                if (this.Audited != null) hashCode = hashCode * 59 + this.Audited.GetHashCode();
                if (this.Public != null) hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
