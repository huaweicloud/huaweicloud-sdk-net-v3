using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// **参数解释**：监听器的状态信息。
    /// </summary>
    public class LoadBalancerStatusListener 
    {

        /// <summary>
        /// **参数解释**：监听器的名称。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：监听器的配置状态。  **取值范围**： - ACTIVE：使用中。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// **参数解释**：监听器下的所有后端服务器组的状态信息。
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<LoadBalancerStatusPool> Pools { get; set; }

        /// <summary>
        /// **参数解释**：监听器下的7层转发策略的状态信息。
        /// </summary>
        [JsonProperty("l7policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<LoadBalancerStatusPolicy> L7policies { get; set; }

        /// <summary>
        /// **参数解释**：监听器ID。  **取值范围**：不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：监听器的操作状态。  **取值范围**： - ONLINE：创建时默认状态，表示监听器正常运行。 - DEGRADED：该监听器下存在l7policy或l7rule的Provisioning_status&#x3D;ERROR时返回这个状态。或者状态树该监听器下存在member的operating_status&#x3D;OFFLINE。 - DISABLED：负载均衡器或监听器的admin_state_up&#x3D;false。  &gt; DEGRADED和DISABLED状态仅在当前接口返回，查询监听器详情等其他接口返回字段operating_status不存在这两个状态值。
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadBalancerStatusListener {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("  l7policies: ").Append(L7policies).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadBalancerStatusListener);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadBalancerStatusListener input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProvisioningStatus != input.ProvisioningStatus || (this.ProvisioningStatus != null && !this.ProvisioningStatus.Equals(input.ProvisioningStatus))) return false;
            if (this.Pools != input.Pools || (this.Pools != null && input.Pools != null && !this.Pools.SequenceEqual(input.Pools))) return false;
            if (this.L7policies != input.L7policies || (this.L7policies != null && input.L7policies != null && !this.L7policies.SequenceEqual(input.L7policies))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.OperatingStatus != input.OperatingStatus || (this.OperatingStatus != null && !this.OperatingStatus.Equals(input.OperatingStatus))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProvisioningStatus != null) hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Pools != null) hashCode = hashCode * 59 + this.Pools.GetHashCode();
                if (this.L7policies != null) hashCode = hashCode * 59 + this.L7policies.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperatingStatus != null) hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
