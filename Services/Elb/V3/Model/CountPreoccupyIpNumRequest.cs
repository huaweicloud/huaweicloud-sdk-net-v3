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
    /// Request Object
    /// </summary>
    public class CountPreoccupyIpNumRequest 
    {

        /// <summary>
        /// **参数解释**：负载均衡器七层规格的ID。传入该字段表示计算创建该规格的LB的预占IP数量，或变更LB的原七层规格到该规格所需要的新增预占IP数量。  **约束限制**：仅支持创建LB、变更LB规格场景。  **取值范围**：不涉及  **默认取值**：不涉及  [不支持传入l7_flavor_id。](tag:hcso,hk_vdf,srg,fcs)
        /// </summary>
        [SDKProperty("l7_flavor_id", IsQuery = true)]
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：IP类型后端转发开关。  **约束限制**：仅支持创建LB、LB开启IP类型后端转发场景。  **取值范围**： - 取值true表示计算创建开启IP类型后端转发的LB的预占IP数量，或开启IP类型后端转发所需要的新增预占IP数量。 - 取值false表示计算创建不开启IP类型后端转发的LB的预占IP。 - 不传等价false。  **默认取值**：false [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("ip_target_enable", IsQuery = true)]
        [JsonProperty("ip_target_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpTargetEnable { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器IP地址类型，取值4、6 。  **约束限制**：仅支持创建LB场景。  **取值范围**： - 取值4表示计算创建支持IPv4地址的LB的预占IP。 - 取值6表示计算创建支持IPv6地址的LB的预占IP。  **默认取值**：不涉及  [不支持IPv6，请勿设置为6。](tag:dt)
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// **参数解释**：负载均衡器ID。计算LB变更或创建LB中的第一个七层监听器的新增预占IP。  **约束限制**：仅支持变更LB规格、开启IP类型后端转发、开启/不开启地址转换功能、创建LB中的第一个七层监听器场景。  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// **参数解释**：计算创建AZ列表为availability_zone_id的负载均衡器实例的预占IP。  **约束限制**： - 仅支持创建LB场景。 - 传入loadbalancer_id时，该参数无效。  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [SDKProperty("availability_zone_id", IsQuery = true)]
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneId { get; set; }

        /// <summary>
        /// **参数解释**：计算共享型升级为独享型ELB负载均衡器实例的所需预占IP。  **约束限制**： - 仅支持共享型升级为独享型ELB场景。 - 必须同时传入loadbalancer_id。  **取值范围**：UPGRADE - 共享型升级为独享型ELB场景。  **默认取值**：不涉及
        /// </summary>
        [SDKProperty("scene", IsQuery = true)]
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// **参数解释**：开启地址转换。传入该字段表示计算创建LB及该LB下开启/不开启地址转换特性的监听器所需要的预占IP，或者指定LB创建开启/不开启地址转换特性的监听器所需要的新增预占IP。  **约束限制**： - 仅支持计算ELB实例开启NAT64特性场景。  **取值范围**： - true：开启地址转换特性。 - false：不开启地址转换特性。  **默认取值**：false
        /// </summary>
        [SDKProperty("nat64_enable", IsQuery = true)]
        [JsonProperty("nat64_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nat64Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountPreoccupyIpNumRequest {\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  ipTargetEnable: ").Append(IpTargetEnable).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  nat64Enable: ").Append(Nat64Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountPreoccupyIpNumRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountPreoccupyIpNumRequest input)
        {
            if (input == null) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && !this.L7FlavorId.Equals(input.L7FlavorId))) return false;
            if (this.IpTargetEnable != input.IpTargetEnable || (this.IpTargetEnable != null && !this.IpTargetEnable.Equals(input.IpTargetEnable))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && !this.LoadbalancerId.Equals(input.LoadbalancerId))) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && input.AvailabilityZoneId != null && !this.AvailabilityZoneId.SequenceEqual(input.AvailabilityZoneId))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;
            if (this.Nat64Enable != input.Nat64Enable || (this.Nat64Enable != null && !this.Nat64Enable.Equals(input.Nat64Enable))) return false;

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
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.IpTargetEnable != null) hashCode = hashCode * 59 + this.IpTargetEnable.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.Nat64Enable != null) hashCode = hashCode * 59 + this.Nat64Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
