using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowScalingGroupResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_group", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingGroups ScalingGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowScalingGroupResponse {\n");
            sb.Append("  scalingGroup: ").Append(ScalingGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowScalingGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowScalingGroupResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingGroup == input.ScalingGroup ||
                    (this.ScalingGroup != null &&
                    this.ScalingGroup.Equals(input.ScalingGroup))
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
                if (this.ScalingGroup != null)
                    hashCode = hashCode * 59 + this.ScalingGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
