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
    public class CameraBandwidthPercentageOptions 
    {

        /// <summary>
        /// 摄像头带宽百分比控制量（%）。取值范围为[0-100]。默认：30。
        /// </summary>
        [JsonProperty("camera_bandwidth_percentage_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? CameraBandwidthPercentageValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CameraBandwidthPercentageOptions {\n");
            sb.Append("  cameraBandwidthPercentageValue: ").Append(CameraBandwidthPercentageValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CameraBandwidthPercentageOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CameraBandwidthPercentageOptions input)
        {
            if (input == null) return false;
            if (this.CameraBandwidthPercentageValue != input.CameraBandwidthPercentageValue || (this.CameraBandwidthPercentageValue != null && !this.CameraBandwidthPercentageValue.Equals(input.CameraBandwidthPercentageValue))) return false;

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
                if (this.CameraBandwidthPercentageValue != null) hashCode = hashCode * 59 + this.CameraBandwidthPercentageValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
