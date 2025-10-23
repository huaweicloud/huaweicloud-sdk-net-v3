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
    public class VehicleLicenseAlarmConfidence 
    {

        /// <summary>
        /// 证件图像框内遮挡告警分数，分数越高，证件图像框内遮挡的可能性越高。
        /// </summary>
        [JsonProperty("blocking_within_border_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockingWithinBorderScore { get; set; }

        /// <summary>
        /// 证件图像边框完整性告警分数，分数越高，证件图像边框不完整的可能性越高。
        /// </summary>
        [JsonProperty("border_integrity_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderIntegrityScore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleLicenseAlarmConfidence {\n");
            sb.Append("  blockingWithinBorderScore: ").Append(BlockingWithinBorderScore).Append("\n");
            sb.Append("  borderIntegrityScore: ").Append(BorderIntegrityScore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VehicleLicenseAlarmConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VehicleLicenseAlarmConfidence input)
        {
            if (input == null) return false;
            if (this.BlockingWithinBorderScore != input.BlockingWithinBorderScore || (this.BlockingWithinBorderScore != null && !this.BlockingWithinBorderScore.Equals(input.BlockingWithinBorderScore))) return false;
            if (this.BorderIntegrityScore != input.BorderIntegrityScore || (this.BorderIntegrityScore != null && !this.BorderIntegrityScore.Equals(input.BorderIntegrityScore))) return false;

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
                if (this.BlockingWithinBorderScore != null) hashCode = hashCode * 59 + this.BlockingWithinBorderScore.GetHashCode();
                if (this.BorderIntegrityScore != null) hashCode = hashCode * 59 + this.BorderIntegrityScore.GetHashCode();
                return hashCode;
            }
        }
    }
}
