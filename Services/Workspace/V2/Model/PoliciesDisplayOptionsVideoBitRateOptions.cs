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
    /// 视频码率控制选项。
    /// </summary>
    public class PoliciesDisplayOptionsVideoBitRateOptions 
    {

        /// <summary>
        /// 视频平均码率（Kbps）。取值范围为[256-100000]。默认：18000。
        /// </summary>
        [JsonProperty("average_video_bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? AverageVideoBitRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplayOptionsVideoBitRateOptions {\n");
            sb.Append("  averageVideoBitRate: ").Append(AverageVideoBitRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplayOptionsVideoBitRateOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplayOptionsVideoBitRateOptions input)
        {
            if (input == null) return false;
            if (this.AverageVideoBitRate != input.AverageVideoBitRate || (this.AverageVideoBitRate != null && !this.AverageVideoBitRate.Equals(input.AverageVideoBitRate))) return false;

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
                if (this.AverageVideoBitRate != null) hashCode = hashCode * 59 + this.AverageVideoBitRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
