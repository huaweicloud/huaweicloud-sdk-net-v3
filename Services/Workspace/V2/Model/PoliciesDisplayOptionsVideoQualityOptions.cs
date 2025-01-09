using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 视频质量控制选项。
    /// </summary>
    public class PoliciesDisplayOptionsVideoQualityOptions 
    {

        /// <summary>
        /// 视频平均质量。取值范围为[5-59]。默认：15。
        /// </summary>
        [JsonProperty("average_video_quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? AverageVideoQuality { get; set; }

        /// <summary>
        /// 视频最低质量。取值范围为[5-69]。默认：25。
        /// </summary>
        [JsonProperty("lowest_video_quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? LowestVideoQuality { get; set; }

        /// <summary>
        /// 视频最高质量。取值范围为[1-59]。默认：7。
        /// </summary>
        [JsonProperty("highest_video_quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? HighestVideoQuality { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplayOptionsVideoQualityOptions {\n");
            sb.Append("  averageVideoQuality: ").Append(AverageVideoQuality).Append("\n");
            sb.Append("  lowestVideoQuality: ").Append(LowestVideoQuality).Append("\n");
            sb.Append("  highestVideoQuality: ").Append(HighestVideoQuality).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplayOptionsVideoQualityOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplayOptionsVideoQualityOptions input)
        {
            if (input == null) return false;
            if (this.AverageVideoQuality != input.AverageVideoQuality || (this.AverageVideoQuality != null && !this.AverageVideoQuality.Equals(input.AverageVideoQuality))) return false;
            if (this.LowestVideoQuality != input.LowestVideoQuality || (this.LowestVideoQuality != null && !this.LowestVideoQuality.Equals(input.LowestVideoQuality))) return false;
            if (this.HighestVideoQuality != input.HighestVideoQuality || (this.HighestVideoQuality != null && !this.HighestVideoQuality.Equals(input.HighestVideoQuality))) return false;

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
                if (this.AverageVideoQuality != null) hashCode = hashCode * 59 + this.AverageVideoQuality.GetHashCode();
                if (this.LowestVideoQuality != null) hashCode = hashCode * 59 + this.LowestVideoQuality.GetHashCode();
                if (this.HighestVideoQuality != null) hashCode = hashCode * 59 + this.HighestVideoQuality.GetHashCode();
                return hashCode;
            }
        }
    }
}
