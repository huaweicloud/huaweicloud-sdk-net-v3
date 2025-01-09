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
    public class MultimediaBandwidthControlOptions 
    {

        /// <summary>
        /// 多媒体带宽控制量（Kbps）。取值范围为[5000-20000]。默认：15000。
        /// </summary>
        [JsonProperty("multimedia_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? MultimediaBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultimediaBandwidthControlOptions {\n");
            sb.Append("  multimediaBandwidthControlValue: ").Append(MultimediaBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultimediaBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultimediaBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.MultimediaBandwidthControlValue != input.MultimediaBandwidthControlValue || (this.MultimediaBandwidthControlValue != null && !this.MultimediaBandwidthControlValue.Equals(input.MultimediaBandwidthControlValue))) return false;

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
                if (this.MultimediaBandwidthControlValue != null) hashCode = hashCode * 59 + this.MultimediaBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
