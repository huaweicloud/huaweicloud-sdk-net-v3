using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BindPublicGatewayRequestBody 
    {

        /// <summary>
        /// **参数解释：** 公网NAT网关实例的ID。可以调用“查询公网NAT网关列表”接口获取。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// **参数解释：** 弹性公网IP的ID。可以调用“查询弹性公网IP列表”接口获取。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// **参数解释：** 弹性公网IP对外提供服务的端口号。 **约束限制：** 不涉及。 **取值范围：** 1~65535。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("external_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalServicePort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindPublicGatewayRequestBody {\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  externalServicePort: ").Append(ExternalServicePort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindPublicGatewayRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindPublicGatewayRequestBody input)
        {
            if (input == null) return false;
            if (this.NatGatewayId != input.NatGatewayId || (this.NatGatewayId != null && !this.NatGatewayId.Equals(input.NatGatewayId))) return false;
            if (this.PublicIpId != input.PublicIpId || (this.PublicIpId != null && !this.PublicIpId.Equals(input.PublicIpId))) return false;
            if (this.ExternalServicePort != input.ExternalServicePort || (this.ExternalServicePort != null && !this.ExternalServicePort.Equals(input.ExternalServicePort))) return false;

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
                if (this.NatGatewayId != null) hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                if (this.PublicIpId != null) hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.ExternalServicePort != null) hashCode = hashCode * 59 + this.ExternalServicePort.GetHashCode();
                return hashCode;
            }
        }
    }
}
