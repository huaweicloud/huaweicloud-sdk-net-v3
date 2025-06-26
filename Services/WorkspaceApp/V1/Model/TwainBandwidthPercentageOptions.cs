using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TwainBandwidthPercentageOptions 
    {

        /// <summary>
        /// TWAIN带宽百分比控制量（%）。取值范围为[0-100]。默认：15。
        /// </summary>
        [JsonProperty("twain_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? TwainBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwainBandwidthPercentageOptions {\n");
            sb.Append("  twainBandwidthPercentageValue: ").Append(TwainBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TwainBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TwainBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.TwainBandwidthPercentageValue != input.TwainBandwidthPercentageValue || (this.TwainBandwidthPercentageValue != null && !this.TwainBandwidthPercentageValue.Equals(input.TwainBandwidthPercentageValue))) return false;

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
                if (this.TwainBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.TwainBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
