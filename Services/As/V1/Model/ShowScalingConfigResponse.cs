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
    public class ShowScalingConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingConfiguration ScalingConfiguration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowScalingConfigResponse {\n");
            sb.Append("  scalingConfiguration: ").Append(ScalingConfiguration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowScalingConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowScalingConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingConfiguration == input.ScalingConfiguration ||
                    (this.ScalingConfiguration != null &&
                    this.ScalingConfiguration.Equals(input.ScalingConfiguration))
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
                if (this.ScalingConfiguration != null)
                    hashCode = hashCode * 59 + this.ScalingConfiguration.GetHashCode();
                return hashCode;
            }
        }
    }
}
