using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateClouddcnSubnetRequest 
    {

        /// <summary>
        /// clouddcn子网ID
        /// </summary>
        [SDKProperty("clouddcn_subnet_id", IsPath = true)]
        [JsonProperty("clouddcn_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClouddcnSubnetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateClouddcnSubnetRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateClouddcnSubnetRequest {\n");
            sb.Append("  clouddcnSubnetId: ").Append(ClouddcnSubnetId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateClouddcnSubnetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateClouddcnSubnetRequest input)
        {
            if (input == null) return false;
            if (this.ClouddcnSubnetId != input.ClouddcnSubnetId || (this.ClouddcnSubnetId != null && !this.ClouddcnSubnetId.Equals(input.ClouddcnSubnetId))) return false;
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
                if (this.ClouddcnSubnetId != null) hashCode = hashCode * 59 + this.ClouddcnSubnetId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
