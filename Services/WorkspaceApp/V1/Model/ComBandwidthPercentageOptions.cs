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
    public class ComBandwidthPercentageOptions 
    {

        /// <summary>
        /// 串口带宽百分比控制量（%）。取值范围为[0-100]。默认：3。
        /// </summary>
        [JsonProperty("com_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComBandwidthPercentageOptions {\n");
            sb.Append("  comBandwidthPercentageValue: ").Append(ComBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.ComBandwidthPercentageValue != input.ComBandwidthPercentageValue || (this.ComBandwidthPercentageValue != null && !this.ComBandwidthPercentageValue.Equals(input.ComBandwidthPercentageValue))) return false;

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
                if (this.ComBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.ComBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
