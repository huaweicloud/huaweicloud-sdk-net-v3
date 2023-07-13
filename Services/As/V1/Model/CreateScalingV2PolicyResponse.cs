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
    public class CreateScalingV2PolicyResponse : SdkResponse
    {

        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScalingV2PolicyResponse {\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScalingV2PolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScalingV2PolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingPolicyId == input.ScalingPolicyId ||
                    (this.ScalingPolicyId != null &&
                    this.ScalingPolicyId.Equals(input.ScalingPolicyId))
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
                if (this.ScalingPolicyId != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
