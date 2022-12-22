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
        /// 查询公网Zone的列表响应。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<EndpointResp> Endpoints { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociateEndpointIpaddressResponse {\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
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
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    input.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
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
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
