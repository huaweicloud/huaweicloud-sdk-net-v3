using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ServerRoceNetwork 
    {

        /// <summary>
        /// **参数解释**：RoCE网络id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：RoCE网络名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：项目ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**：状态。 **参数解释**：不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：租户id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释**：子网。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public string Subnets { get; set; }

        /// <summary>
        /// **参数解释**：RoCE网络类型。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("provider:network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvidernetworkType { get; set; }

        /// <summary>
        /// **参数解释**：实际物理网络。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("provider:physical_network", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderphysicalNetwork { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerRoceNetwork {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("  providernetworkType: ").Append(ProvidernetworkType).Append("\n");
            sb.Append("  providerphysicalNetwork: ").Append(ProviderphysicalNetwork).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerRoceNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerRoceNetwork input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Subnets != input.Subnets || (this.Subnets != null && !this.Subnets.Equals(input.Subnets))) return false;
            if (this.ProvidernetworkType != input.ProvidernetworkType || (this.ProvidernetworkType != null && !this.ProvidernetworkType.Equals(input.ProvidernetworkType))) return false;
            if (this.ProviderphysicalNetwork != input.ProviderphysicalNetwork || (this.ProviderphysicalNetwork != null && !this.ProviderphysicalNetwork.Equals(input.ProviderphysicalNetwork))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Subnets != null) hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                if (this.ProvidernetworkType != null) hashCode = hashCode * 59 + this.ProvidernetworkType.GetHashCode();
                if (this.ProviderphysicalNetwork != null) hashCode = hashCode * 59 + this.ProviderphysicalNetwork.GetHashCode();
                return hashCode;
            }
        }
    }
}
