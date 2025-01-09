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
    public class MultimediaBandwidthPercentageOptions 
    {

        /// <summary>
        /// 多媒体带宽百分比控制量（%）。取值范围为[0-100]。默认：50。
        /// </summary>
        [JsonProperty("multimedia_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? MultimediaBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultimediaBandwidthPercentageOptions {\n");
            sb.Append("  multimediaBandwidthPercentageValue: ").Append(MultimediaBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultimediaBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultimediaBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.MultimediaBandwidthPercentageValue != input.MultimediaBandwidthPercentageValue || (this.MultimediaBandwidthPercentageValue != null && !this.MultimediaBandwidthPercentageValue.Equals(input.MultimediaBandwidthPercentageValue))) return false;

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
                if (this.MultimediaBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.MultimediaBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
