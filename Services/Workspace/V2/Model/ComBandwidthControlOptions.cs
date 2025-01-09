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
    /// 
    /// </summary>
    public class ComBandwidthControlOptions 
    {

        /// <summary>
        /// 串口带宽控制量（Kbps）。取值范围为[500-2000]。默认：1000。
        /// </summary>
        [JsonProperty("com_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComBandwidthControlOptions {\n");
            sb.Append("  comBandwidthControlValue: ").Append(ComBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.ComBandwidthControlValue != input.ComBandwidthControlValue || (this.ComBandwidthControlValue != null && !this.ComBandwidthControlValue.Equals(input.ComBandwidthControlValue))) return false;

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
                if (this.ComBandwidthControlValue != null) hashCode = hashCode * 59 + this.ComBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
