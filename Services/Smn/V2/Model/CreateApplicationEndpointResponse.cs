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
    /// Response Object
    /// </summary>
    public class CreateApplicationEndpointResponse : SdkResponse
    {

        /// <summary>
        /// 请求的唯一标识ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Endpoint的唯一资源标识。
        /// </summary>
        [JsonProperty("endpoint_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUrn { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApplicationEndpointResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  endpointUrn: ").Append(EndpointUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApplicationEndpointResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApplicationEndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.EndpointUrn == input.EndpointUrn ||
                    (this.EndpointUrn != null &&
                    this.EndpointUrn.Equals(input.EndpointUrn))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.EndpointUrn != null)
                    hashCode = hashCode * 59 + this.EndpointUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
