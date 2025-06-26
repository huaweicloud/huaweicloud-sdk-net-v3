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
    public class PcscBandwidthControlOptions 
    {

        /// <summary>
        /// PCSC带宽控制量（Kbps）。取值范围为[1000-5000]。默认：2000。
        /// </summary>
        [JsonProperty("pcsc_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? PcscBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PcscBandwidthControlOptions {\n");
            sb.Append("  pcscBandwidthControlValue: ").Append(PcscBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PcscBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PcscBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.PcscBandwidthControlValue != input.PcscBandwidthControlValue || (this.PcscBandwidthControlValue != null && !this.PcscBandwidthControlValue.Equals(input.PcscBandwidthControlValue))) return false;

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
                if (this.PcscBandwidthControlValue != null) hashCode = hashCode * 59 + this.PcscBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
