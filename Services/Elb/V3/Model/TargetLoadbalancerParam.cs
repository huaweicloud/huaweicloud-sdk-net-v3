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
    /// **参数解释**：负载均衡器复制新实例参数对象。  **约束限制**：不涉及
    /// </summary>
    public class TargetLoadbalancerParam 
    {

        /// <summary>
        /// **参数解释**：新实例名称。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不传时使用源ELB名称加\&quot;-copy-{x}\&quot;的后缀作为新实例名称。{x}代表数字序号。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：新实例所属可用区。  **约束限制**：仅支持源ELB独享型复制场景设置该字段。  **取值范围**：不涉及  **默认取值**：不传时使用源ELB的availability_zone_list。
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// **参数解释**：新实例所属子网的ipv4子网ID。  **约束限制**：所选子网必须与源ELB在同一个vpc内。  **取值范围**：不涉及  **默认取值**：不传时使用源ELB的vip_subnet_cidr_id。
        /// </summary>
        [JsonProperty("vip_subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetCidrId { get; set; }

        /// <summary>
        /// **参数解释**：新实例的ipv4私网地址。  **约束限制**：仅支持源ELB独享型复制场景、源ELB共享型复制为独享型场景支持设置该字段。  **取值范围**：不涉及  **默认取值**：不传时随机分配vip_subnet_cidr_id对应子网的可用IP地址。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// **参数解释**：新实例ipv6网络所属的子网网络ID。  **约束限制**： - 仅支持源ELB独享型复制场景设置该字段。 - 所选子网必须与源负载均衡器在同一个vpc内。  **取值范围**：不涉及  **默认取值**：不传时使用源ELB的ipv6_vip_virsubnet_id。
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**：新实例的ipv6地址。  **约束限制**：仅支持源ELB为独享型复制场景设置该字段。  **取值范围**：不涉及  **默认取值**：不传时随机分配ipv6_vip_virsubnet_id对应子网的可用IP地址。
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }

        /// <summary>
        /// **参数解释**：新实例后端子网的网络ID。  **约束限制**： - 仅支持源ELB独享型复制场景、源ELB共享型复制为独享型场景支持设置该字段。 - 所选子网必须与源负载均衡器在同一个vpc内。  **取值范围**：不涉及  **默认取值**：不传时使用源负载均衡器的后端子网。
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }

        /// <summary>
        /// **参数解释**：新实例4层规格。  **约束限制**：仅支持源ELB独享型复制场景、源ELB共享型复制为独享型场景支持设置该字段。  **取值范围**：不涉及  **默认取值**：不传时保持与源负载均衡器的4层规格一致。
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：新实例7层规格。  **约束限制**：仅支持源ELB独享型复制场景、源ELB共享型复制为独享型场景支持设置该字段。  **取值范围**：不涉及  **默认取值**：不传时保持与源负载均衡器的7层规格一致。
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：资源所属的企业项目ID。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不传时保持与源负载均衡器的企业项目一致。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**：新实例是否复用源ELB的后端服务器组。  **约束限制**： - 设置为true时，需要开启后端服务器组的多实例挂载功能。 - 请求参数enterprise_project_id使用与源ELB不同的其他企业项目时，该参数失效。 - 仅源ELB独享型复制场景、源ELB共享型复制为独享型场景支持设置为true。  **取值范围**： - false：新创建后端服务器组。 - true：复用源ELB的后端服务器组。  **默认取值**：false
        /// </summary>
        [JsonProperty("reuse_pool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReusePool { get; set; }

        /// <summary>
        /// **参数解释**：新实例类型。  **约束限制**：不涉及  **取值范围**： - false：复制为共享型实例，此时源ELB必须是共享型。 - true：复制为独享型实例，源ELB可以是共享型或独享型。  **默认取值**： - 源ELB是独享型复制场景默认为true。 - 源ELB是共享型复制场景默认为false。
        /// </summary>
        [JsonProperty("guaranteed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Guaranteed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetLoadbalancerParam {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  vipSubnetCidrId: ").Append(VipSubnetCidrId).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  reusePool: ").Append(ReusePool).Append("\n");
            sb.Append("  guaranteed: ").Append(Guaranteed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TargetLoadbalancerParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TargetLoadbalancerParam input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AvailabilityZoneList != input.AvailabilityZoneList || (this.AvailabilityZoneList != null && input.AvailabilityZoneList != null && !this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList))) return false;
            if (this.VipSubnetCidrId != input.VipSubnetCidrId || (this.VipSubnetCidrId != null && !this.VipSubnetCidrId.Equals(input.VipSubnetCidrId))) return false;
            if (this.VipAddress != input.VipAddress || (this.VipAddress != null && !this.VipAddress.Equals(input.VipAddress))) return false;
            if (this.Ipv6VipVirsubnetId != input.Ipv6VipVirsubnetId || (this.Ipv6VipVirsubnetId != null && !this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))) return false;
            if (this.Ipv6VipAddress != input.Ipv6VipAddress || (this.Ipv6VipAddress != null && !this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))) return false;
            if (this.ElbVirsubnetIds != input.ElbVirsubnetIds || (this.ElbVirsubnetIds != null && input.ElbVirsubnetIds != null && !this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds))) return false;
            if (this.L4FlavorId != input.L4FlavorId || (this.L4FlavorId != null && !this.L4FlavorId.Equals(input.L4FlavorId))) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && !this.L7FlavorId.Equals(input.L7FlavorId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ReusePool != input.ReusePool || (this.ReusePool != null && !this.ReusePool.Equals(input.ReusePool))) return false;
            if (this.Guaranteed != input.Guaranteed || (this.Guaranteed != null && !this.Guaranteed.Equals(input.Guaranteed))) return false;

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
                if (this.AvailabilityZoneList != null) hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.VipSubnetCidrId != null) hashCode = hashCode * 59 + this.VipSubnetCidrId.GetHashCode();
                if (this.VipAddress != null) hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null) hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.ElbVirsubnetIds != null) hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                if (this.L4FlavorId != null) hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ReusePool != null) hashCode = hashCode * 59 + this.ReusePool.GetHashCode();
                if (this.Guaranteed != null) hashCode = hashCode * 59 + this.Guaranteed.GetHashCode();
                return hashCode;
            }
        }
    }
}
