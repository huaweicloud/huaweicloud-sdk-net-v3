using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VehicleLicenseAlarmResult 
    {

        /// <summary>
        /// -| 证件图像框内遮挡告警结果。 true：表示证件图片内部有被遮挡。 false：表示证件图片内部未被遮挡。
        /// </summary>
        [JsonProperty("detect_blocking_within_border_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlockingWithinBorderResult { get; set; }

        /// <summary>
        /// -| 证件图像边框完整性告警结果。 true：表示边框不完整。 false：表示边框完整。
        /// </summary>
        [JsonProperty("detect_border_integrity_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBorderIntegrityResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleLicenseAlarmResult {\n");
            sb.Append("  detectBlockingWithinBorderResult: ").Append(DetectBlockingWithinBorderResult).Append("\n");
            sb.Append("  detectBorderIntegrityResult: ").Append(DetectBorderIntegrityResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleLicenseAlarmResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VehicleLicenseAlarmResult input)
        {
            if (input == null) return false;
            if (this.DetectBlockingWithinBorderResult != input.DetectBlockingWithinBorderResult || (this.DetectBlockingWithinBorderResult != null && !this.DetectBlockingWithinBorderResult.Equals(input.DetectBlockingWithinBorderResult))) return false;
            if (this.DetectBorderIntegrityResult != input.DetectBorderIntegrityResult || (this.DetectBorderIntegrityResult != null && !this.DetectBorderIntegrityResult.Equals(input.DetectBorderIntegrityResult))) return false;

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
                if (this.DetectBlockingWithinBorderResult != null) hashCode = hashCode * 59 + this.DetectBlockingWithinBorderResult.GetHashCode();
                if (this.DetectBorderIntegrityResult != null) hashCode = hashCode * 59 + this.DetectBorderIntegrityResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
