using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DisassociateEndpointIpaddressRequest 
    {

        /// <summary>
        /// 终端节点ID。
        /// </summary>
        [SDKProperty("endpoint_id", IsPath = true)]
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// IP地址ID。
        /// </summary>
        [SDKProperty("ipaddress_id", IsPath = true)]
        [JsonProperty("ipaddress_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpaddressId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateEndpointIpaddressRequest {\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  ipaddressId: ").Append(IpaddressId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateEndpointIpaddressRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateEndpointIpaddressRequest input)
        {
            if (input == null) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.IpaddressId != input.IpaddressId || (this.IpaddressId != null && !this.IpaddressId.Equals(input.IpaddressId))) return false;

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
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.IpaddressId != null) hashCode = hashCode * 59 + this.IpaddressId.GetHashCode();
                return hashCode;
            }
        }
    }
}
