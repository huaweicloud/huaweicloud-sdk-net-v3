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
    public class SecureChannelBandwidthPercentageOptions 
    {

        /// <summary>
        /// 安全通道带宽百分比控制量（%）。取值范围为[0-100]。默认：30。
        /// </summary>
        [JsonProperty("secure_channel_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? SecureChannelBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecureChannelBandwidthPercentageOptions {\n");
            sb.Append("  secureChannelBandwidthPercentageValue: ").Append(SecureChannelBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecureChannelBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecureChannelBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.SecureChannelBandwidthPercentageValue != input.SecureChannelBandwidthPercentageValue || (this.SecureChannelBandwidthPercentageValue != null && !this.SecureChannelBandwidthPercentageValue.Equals(input.SecureChannelBandwidthPercentageValue))) return false;

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
                if (this.SecureChannelBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.SecureChannelBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
