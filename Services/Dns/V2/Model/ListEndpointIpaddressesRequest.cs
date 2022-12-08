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
    public class ListEndpointIpaddressesRequest 
    {

        /// <summary>
        /// 待查询的ip地址列表所在的endpoint的ID。
        /// </summary>
        [SDKProperty("endpoint_id", IsPath = true)]
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEndpointIpaddressesRequest {\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEndpointIpaddressesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEndpointIpaddressesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndpointId == input.EndpointId ||
                    (this.EndpointId != null &&
                    this.EndpointId.Equals(input.EndpointId))
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
                return hashCode;
            }
        }
    }
}