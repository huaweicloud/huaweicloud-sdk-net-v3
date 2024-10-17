using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateEndpointPolicyRequest 
    {

        /// <summary>
        /// 终端节点的ID。
        /// </summary>
        [SDKProperty("vpc_endpoint_id", IsPath = true)]
        [JsonProperty("vpc_endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateEndpointPolicyRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointPolicyRequest {\n");
            sb.Append("  vpcEndpointId: ").Append(VpcEndpointId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointPolicyRequest input)
        {
            if (input == null) return false;
            if (this.VpcEndpointId != input.VpcEndpointId || (this.VpcEndpointId != null && !this.VpcEndpointId.Equals(input.VpcEndpointId))) return false;
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
                if (this.VpcEndpointId != null) hashCode = hashCode * 59 + this.VpcEndpointId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
