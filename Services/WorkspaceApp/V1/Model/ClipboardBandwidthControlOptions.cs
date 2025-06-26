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
    public class ClipboardBandwidthControlOptions 
    {

        /// <summary>
        /// 剪切板带宽控制量（Kbps）。取值范围为[100-2000]。默认：1000。
        /// </summary>
        [JsonProperty("clipboard_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClipboardBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClipboardBandwidthControlOptions {\n");
            sb.Append("  clipboardBandwidthControlValue: ").Append(ClipboardBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClipboardBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClipboardBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.ClipboardBandwidthControlValue != input.ClipboardBandwidthControlValue || (this.ClipboardBandwidthControlValue != null && !this.ClipboardBandwidthControlValue.Equals(input.ClipboardBandwidthControlValue))) return false;

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
                if (this.ClipboardBandwidthControlValue != null) hashCode = hashCode * 59 + this.ClipboardBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
