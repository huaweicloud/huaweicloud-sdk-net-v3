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
    public class ShowNatGatewayResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nat_gateway", NullValueHandling = NullValueHandling.Ignore)]
        public NatGatewayResponseBody NatGateway { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNatGatewayResponse {\n");
            sb.Append("  natGateway: ").Append(NatGateway).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNatGatewayResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNatGatewayResponse input)
        {
            if (input == null) return false;
            if (this.NatGateway != input.NatGateway || (this.NatGateway != null && !this.NatGateway.Equals(input.NatGateway))) return false;

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
                if (this.NatGateway != null) hashCode = hashCode * 59 + this.NatGateway.GetHashCode();
                return hashCode;
            }
        }
    }
}
