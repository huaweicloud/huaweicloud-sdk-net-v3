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
    /// 
    /// </summary>
    public class NeutronFirewallPolicy 
    {

        /// <summary>
        /// 审计标记。
        /// </summary>
        [JsonProperty("audited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Audited { get; set; }

        /// <summary>
        /// 网络ACL防火墙策略描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 策略引用的网络ACL防火墙规则链。
        /// </summary>
        [JsonProperty("firewall_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FirewallRules { get; set; }

        /// <summary>
        /// 网络ACL防火墙策略uuid标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 网络ACL防火墙策略名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否支持跨租户共享。
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronFirewallPolicy {\n");
            sb.Append("  audited: ").Append(Audited).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  firewallRules: ").Append(FirewallRules).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
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
            return this.Equals(input as NeutronFirewallPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronFirewallPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Audited == input.Audited ||
                    (this.Audited != null &&
                    this.Audited.Equals(input.Audited))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FirewallRules == input.FirewallRules ||
                    this.FirewallRules != null &&
                    input.FirewallRules != null &&
                    this.FirewallRules.SequenceEqual(input.FirewallRules)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Public == input.Public ||
                    (this.Public != null &&
                    this.Public.Equals(input.Public))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Audited != null)
                    hashCode = hashCode * 59 + this.Audited.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FirewallRules != null)
                    hashCode = hashCode * 59 + this.FirewallRules.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Public != null)
                    hashCode = hashCode * 59 + this.Public.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
