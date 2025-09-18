using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateEndpointGroupRequest 
    {

        /// <summary>
        /// 终端节点组ID。
        /// </summary>
        [SDKProperty("endpoint_group_id", IsPath = true)]
        [JsonProperty("endpoint_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateEndpointGroupRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointGroupRequest {\n");
            sb.Append("  endpointGroupId: ").Append(EndpointGroupId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointGroupRequest input)
        {
            if (input == null) return false;
            if (this.EndpointGroupId != input.EndpointGroupId || (this.EndpointGroupId != null && !this.EndpointGroupId.Equals(input.EndpointGroupId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.EndpointGroupId != null) hashCode = hashCode * 59 + this.EndpointGroupId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
