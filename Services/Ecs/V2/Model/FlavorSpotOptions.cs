using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlavorSpotOptions 
    {

        /// <summary>
        /// 购买的竞价实例时长
        /// </summary>
        [JsonProperty("longest_spot_duration_hours", NullValueHandling = NullValueHandling.Ignore)]
        public int? LongestSpotDurationHours { get; set; }

        /// <summary>
        /// 购买的“竞价实例时长”的个数。
        /// </summary>
        [JsonProperty("largest_spot_duration_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LargestSpotDurationCount { get; set; }

        /// <summary>
        /// 竞价实例中断策略。  - immediate：立即释放 - delay：延迟释放
        /// </summary>
        [JsonProperty("interruption_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string InterruptionPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorSpotOptions {\n");
            sb.Append("  longestSpotDurationHours: ").Append(LongestSpotDurationHours).Append("\n");
            sb.Append("  largestSpotDurationCount: ").Append(LargestSpotDurationCount).Append("\n");
            sb.Append("  interruptionPolicy: ").Append(InterruptionPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorSpotOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorSpotOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LongestSpotDurationHours == input.LongestSpotDurationHours ||
                    (this.LongestSpotDurationHours != null &&
                    this.LongestSpotDurationHours.Equals(input.LongestSpotDurationHours))
                ) && 
                (
                    this.LargestSpotDurationCount == input.LargestSpotDurationCount ||
                    (this.LargestSpotDurationCount != null &&
                    this.LargestSpotDurationCount.Equals(input.LargestSpotDurationCount))
                ) && 
                (
                    this.InterruptionPolicy == input.InterruptionPolicy ||
                    (this.InterruptionPolicy != null &&
                    this.InterruptionPolicy.Equals(input.InterruptionPolicy))
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
                if (this.LongestSpotDurationHours != null)
                    hashCode = hashCode * 59 + this.LongestSpotDurationHours.GetHashCode();
                if (this.LargestSpotDurationCount != null)
                    hashCode = hashCode * 59 + this.LargestSpotDurationCount.GetHashCode();
                if (this.InterruptionPolicy != null)
                    hashCode = hashCode * 59 + this.InterruptionPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
