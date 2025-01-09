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
    public class ClipboardBandwidthPercentageOptions 
    {

        /// <summary>
        /// 剪切板带宽百分比控制量（%）。取值范围为[0-100]。默认：3。
        /// </summary>
        [JsonProperty("clipboard_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClipboardBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClipboardBandwidthPercentageOptions {\n");
            sb.Append("  clipboardBandwidthPercentageValue: ").Append(ClipboardBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClipboardBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClipboardBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.ClipboardBandwidthPercentageValue != input.ClipboardBandwidthPercentageValue || (this.ClipboardBandwidthPercentageValue != null && !this.ClipboardBandwidthPercentageValue.Equals(input.ClipboardBandwidthPercentageValue))) return false;

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
                if (this.ClipboardBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.ClipboardBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
