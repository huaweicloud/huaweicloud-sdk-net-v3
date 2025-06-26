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
    public class TwainBandwidthControlOptions 
    {

        /// <summary>
        /// TWAIN带宽控制量（Kbps）。取值范围为[2000-10000]。默认：5000。
        /// </summary>
        [JsonProperty("twain_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? TwainBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwainBandwidthControlOptions {\n");
            sb.Append("  twainBandwidthControlValue: ").Append(TwainBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TwainBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TwainBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.TwainBandwidthControlValue != input.TwainBandwidthControlValue || (this.TwainBandwidthControlValue != null && !this.TwainBandwidthControlValue.Equals(input.TwainBandwidthControlValue))) return false;

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
                if (this.TwainBandwidthControlValue != null) hashCode = hashCode * 59 + this.TwainBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
