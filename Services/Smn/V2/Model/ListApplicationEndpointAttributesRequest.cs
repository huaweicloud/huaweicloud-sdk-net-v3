using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListApplicationEndpointAttributesRequest 
    {

        /// <summary>
        /// Endpoint的唯一资源标识，可通过[查询Application的Endpoint列表](smn_api_58004.xml)获取该标识。
        /// </summary>
        [SDKProperty("endpoint_urn", IsPath = true)]
        [JsonProperty("endpoint_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationEndpointAttributesRequest {\n");
            sb.Append("  endpointUrn: ").Append(EndpointUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationEndpointAttributesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationEndpointAttributesRequest input)
        {
            if (input == null) return false;
            if (this.EndpointUrn != input.EndpointUrn || (this.EndpointUrn != null && !this.EndpointUrn.Equals(input.EndpointUrn))) return false;

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
                if (this.EndpointUrn != null) hashCode = hashCode * 59 + this.EndpointUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
