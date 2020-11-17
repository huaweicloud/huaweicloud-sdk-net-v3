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
    /// Request Object
    /// </summary>
    public class DeleteNatGatewayRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("nat_gateway_id", IsPath = true)]
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatGatewayId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNatGatewayRequest {\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNatGatewayRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNatGatewayRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NatGatewayId == input.NatGatewayId ||
                    (this.NatGatewayId != null &&
                    this.NatGatewayId.Equals(input.NatGatewayId))
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
                if (this.NatGatewayId != null)
                    hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                return hashCode;
            }
        }
    }
}
