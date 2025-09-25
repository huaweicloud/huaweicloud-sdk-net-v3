using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AllowVpcEndpointsResult 
    {

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// VPC端点，例如：8di3jdu38d7jhfa7df68adyfiadfia6d。
        /// </summary>
        [JsonProperty("vpc_endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcEndpointId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowVpcEndpointsResult {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vpcEndpointId: ").Append(VpcEndpointId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowVpcEndpointsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllowVpcEndpointsResult input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VpcEndpointId != input.VpcEndpointId || (this.VpcEndpointId != null && !this.VpcEndpointId.Equals(input.VpcEndpointId))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VpcEndpointId != null) hashCode = hashCode * 59 + this.VpcEndpointId.GetHashCode();
                return hashCode;
            }
        }
    }
}
