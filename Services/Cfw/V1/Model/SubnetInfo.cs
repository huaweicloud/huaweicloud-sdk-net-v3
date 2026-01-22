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
    /// **参数解释**： 管理子网信息 **取值范围**： 不涉及
    /// </summary>
    public class SubnetInfo 
    {

        /// <summary>
        /// **参数解释**： 子网所在的可用区标识，从终端节点获取，参考[终端节点](cfw_02_0000.xml) **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释**： 虚拟私有云下可用子网的范围 **取值范围**： 10.0.0.0/8~24 172.16.0.0/12~24 192.168.0.0/16~24
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// **参数解释**： 子网名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 子网id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 子网的网关 **取值范围**： 子网网段cidr中的IP地址
        /// </summary>
        [JsonProperty("gateway_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIp { get; set; }

        /// <summary>
        /// **参数解释**： 创建VPC产生的uuid **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持ipv6 **取值范围**： - true：是 - false：否
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubnetInfo {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gatewayIp: ").Append(GatewayIp).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubnetInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubnetInfo input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GatewayIp != input.GatewayIp || (this.GatewayIp != null && !this.GatewayIp.Equals(input.GatewayIp))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.Ipv6Enable != input.Ipv6Enable || (this.Ipv6Enable != null && !this.Ipv6Enable.Equals(input.Ipv6Enable))) return false;

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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GatewayIp != null) hashCode = hashCode * 59 + this.GatewayIp.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Ipv6Enable != null) hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
