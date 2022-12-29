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
    /// Response Object
    /// </summary>
    public class DisassociateEndpointIpaddressResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointResp Endpoint { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateEndpointIpaddressResponse {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociateEndpointIpaddressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociateEndpointIpaddressResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
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
                if (this.Endpoint != null)
                    hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
