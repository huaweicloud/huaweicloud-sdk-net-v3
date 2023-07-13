using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListNatGatewaysResponse : SdkResponse
    {

        /// <summary>
        /// 查询公网NAT网关实例列表的响应体。 详见NatGateway字段说明。
        /// </summary>
        [JsonProperty("nat_gateways", NullValueHandling = NullValueHandling.Ignore)]
        public List<NatGatewayResponseBody> NatGateways { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNatGatewaysResponse {\n");
            sb.Append("  natGateways: ").Append(NatGateways).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNatGatewaysResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNatGatewaysResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NatGateways == input.NatGateways ||
                    this.NatGateways != null &&
                    input.NatGateways != null &&
                    this.NatGateways.SequenceEqual(input.NatGateways)
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
                if (this.NatGateways != null)
                    hashCode = hashCode * 59 + this.NatGateways.GetHashCode();
                return hashCode;
            }
        }
    }
}
