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
    public class DisplayBandwidthControlOptions 
    {

        /// <summary>
        /// 显示带宽控制量（Kbps）。取值范围为[500-50000]。默认：20000。
        /// </summary>
        [JsonProperty("display_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisplayBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplayBandwidthControlOptions {\n");
            sb.Append("  displayBandwidthControlValue: ").Append(DisplayBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisplayBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisplayBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.DisplayBandwidthControlValue != input.DisplayBandwidthControlValue || (this.DisplayBandwidthControlValue != null && !this.DisplayBandwidthControlValue.Equals(input.DisplayBandwidthControlValue))) return false;

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
                if (this.DisplayBandwidthControlValue != null) hashCode = hashCode * 59 + this.DisplayBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
