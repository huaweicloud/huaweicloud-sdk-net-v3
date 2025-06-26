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
    public class DisplayBandwidthPercentageOptions 
    {

        /// <summary>
        /// 显示带宽百分比控制量（%）。取值范围为[0-100]。默认：65。
        /// </summary>
        [JsonProperty("display_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisplayBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplayBandwidthPercentageOptions {\n");
            sb.Append("  displayBandwidthPercentageValue: ").Append(DisplayBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisplayBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisplayBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.DisplayBandwidthPercentageValue != input.DisplayBandwidthPercentageValue || (this.DisplayBandwidthPercentageValue != null && !this.DisplayBandwidthPercentageValue.Equals(input.DisplayBandwidthPercentageValue))) return false;

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
                if (this.DisplayBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.DisplayBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
