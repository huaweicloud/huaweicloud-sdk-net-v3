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
    public class PcscBandwidthPercentageOptions 
    {

        /// <summary>
        /// PCSC带宽百分比控制量（%）。取值范围为[0-100]。默认：5。
        /// </summary>
        [JsonProperty("pcsc_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? PcscBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PcscBandwidthPercentageOptions {\n");
            sb.Append("  pcscBandwidthPercentageValue: ").Append(PcscBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PcscBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PcscBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.PcscBandwidthPercentageValue != input.PcscBandwidthPercentageValue || (this.PcscBandwidthPercentageValue != null && !this.PcscBandwidthPercentageValue.Equals(input.PcscBandwidthPercentageValue))) return false;

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
                if (this.PcscBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.PcscBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
