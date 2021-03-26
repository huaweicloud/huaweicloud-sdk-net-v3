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
    public class ShowScalingV2PolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingV2PolicyDetail ScalingPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowScalingV2PolicyResponse {\n");
            sb.Append("  scalingPolicy: ").Append(ScalingPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowScalingV2PolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowScalingV2PolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingPolicy == input.ScalingPolicy ||
                    (this.ScalingPolicy != null &&
                    this.ScalingPolicy.Equals(input.ScalingPolicy))
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
                if (this.ScalingPolicy != null)
                    hashCode = hashCode * 59 + this.ScalingPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
