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
    public class ShowEndpointGroupRequest 
    {

        /// <summary>
        /// 终端节点组ID。
        /// </summary>
        [SDKProperty("endpoint_group_id", IsPath = true)]
        [JsonProperty("endpoint_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEndpointGroupRequest {\n");
            sb.Append("  endpointGroupId: ").Append(EndpointGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEndpointGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEndpointGroupRequest input)
        {
            if (input == null) return false;
            if (this.EndpointGroupId != input.EndpointGroupId || (this.EndpointGroupId != null && !this.EndpointGroupId.Equals(input.EndpointGroupId))) return false;

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
                return hashCode;
            }
        }
    }
}
