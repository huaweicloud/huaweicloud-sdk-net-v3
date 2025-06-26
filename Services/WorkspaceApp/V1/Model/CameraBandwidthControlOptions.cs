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
    public class CameraBandwidthControlOptions 
    {

        /// <summary>
        /// 摄像头带宽控制量（Kbps）。取值范围为[0-10000]。默认：10000。
        /// </summary>
        [JsonProperty("camera_bandwidth_control_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? CameraBandwidthControlValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CameraBandwidthControlOptions {\n");
            sb.Append("  cameraBandwidthControlValue: ").Append(CameraBandwidthControlValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CameraBandwidthControlOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CameraBandwidthControlOptions input)
        {
            if (input == null) return false;
            if (this.CameraBandwidthControlValue != input.CameraBandwidthControlValue || (this.CameraBandwidthControlValue != null && !this.CameraBandwidthControlValue.Equals(input.CameraBandwidthControlValue))) return false;

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
                if (this.CameraBandwidthControlValue != null) hashCode = hashCode * 59 + this.CameraBandwidthControlValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
