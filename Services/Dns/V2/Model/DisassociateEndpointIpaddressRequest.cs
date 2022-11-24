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
        /// 待解绑定的ip地址所属endpoint的ID。
        /// </summary>
        [SDKProperty("endpoint_id", IsPath = true)]
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// 待解绑定ip地址的ID。
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
            if (input == null)
                return false;

            return 
                (
                    this.EndpointId == input.EndpointId ||
                    (this.EndpointId != null &&
                    this.EndpointId.Equals(input.EndpointId))
                ) && 
                (
                    this.IpaddressId == input.IpaddressId ||
                    (this.IpaddressId != null &&
                    this.IpaddressId.Equals(input.IpaddressId))
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
                if (this.EndpointId != null)
                    hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.IpaddressId != null)
                    hashCode = hashCode * 59 + this.IpaddressId.GetHashCode();
                return hashCode;
            }
        }
    }
}
