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
    /// Request Object
    /// </summary>
    public class ShowScalingConfigRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("scaling_configuration_id", IsPath = true)]
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowScalingConfigRequest {\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowScalingConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowScalingConfigRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingConfigurationId == input.ScalingConfigurationId ||
                    (this.ScalingConfigurationId != null &&
                    this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))
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
                if (this.ScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                return hashCode;
            }
        }
    }
}
