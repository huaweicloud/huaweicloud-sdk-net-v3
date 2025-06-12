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
    public class AutoIdDocClassificationAlarmResult 
    {

        /// <summary>
        /// 证件图像模糊告警结果。 - true：表示证件图片较模糊。 - false：表示证件清晰。  
        /// </summary>
        [JsonProperty("detect_blur_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlurResult { get; set; }

        /// <summary>
        /// 证件图像反光告警结果。 - true：表示证件图片存在反光。 - false：表示证件图片不存在反光。 
        /// </summary>
        [JsonProperty("detect_glare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectGlareResult { get; set; }

        /// <summary>
        /// 证件图像框内遮挡告警结果。 - true：表示证件图片存在框内遮挡。 - false：表示证件图片不存在框内遮挡。 
        /// </summary>
        [JsonProperty("detect_blocking_within_border_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlockingWithinBorderResult { get; set; }

        /// <summary>
        /// 证件图像过暗告警结果。 - true：表示证件图片过暗。 - false：表示证件图片光线正常。 
        /// </summary>
        [JsonProperty("detect_insufficient_lighting_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectInsufficientLightingResult { get; set; }

        /// <summary>
        /// 证件图像是否黑白复印件告警结果。 - true：表示证件是复印件。 - false：表示证件是原件。  
        /// </summary>
        [JsonProperty("detect_copy_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectCopyResult { get; set; }

        /// <summary>
        /// 证件图像边框完整性告警结果。 - true：表示边框不完整。 - false：表示边框完整。  
        /// </summary>
        [JsonProperty("detect_border_integrity_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBorderIntegrityResult { get; set; }

        /// <summary>
        /// 证件图像是否翻拍告警结果。 - true：表示证件图片经过翻拍。 - false：表示证件图片未经过翻拍。  
        /// </summary>
        [JsonProperty("detect_reproduce_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectReproduceResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoIdDocClassificationAlarmResult {\n");
            sb.Append("  detectBlurResult: ").Append(DetectBlurResult).Append("\n");
            sb.Append("  detectGlareResult: ").Append(DetectGlareResult).Append("\n");
            sb.Append("  detectBlockingWithinBorderResult: ").Append(DetectBlockingWithinBorderResult).Append("\n");
            sb.Append("  detectInsufficientLightingResult: ").Append(DetectInsufficientLightingResult).Append("\n");
            sb.Append("  detectCopyResult: ").Append(DetectCopyResult).Append("\n");
            sb.Append("  detectBorderIntegrityResult: ").Append(DetectBorderIntegrityResult).Append("\n");
            sb.Append("  detectReproduceResult: ").Append(DetectReproduceResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoIdDocClassificationAlarmResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoIdDocClassificationAlarmResult input)
        {
            if (input == null) return false;
            if (this.DetectBlurResult != input.DetectBlurResult || (this.DetectBlurResult != null && !this.DetectBlurResult.Equals(input.DetectBlurResult))) return false;
            if (this.DetectGlareResult != input.DetectGlareResult || (this.DetectGlareResult != null && !this.DetectGlareResult.Equals(input.DetectGlareResult))) return false;
            if (this.DetectBlockingWithinBorderResult != input.DetectBlockingWithinBorderResult || (this.DetectBlockingWithinBorderResult != null && !this.DetectBlockingWithinBorderResult.Equals(input.DetectBlockingWithinBorderResult))) return false;
            if (this.DetectInsufficientLightingResult != input.DetectInsufficientLightingResult || (this.DetectInsufficientLightingResult != null && !this.DetectInsufficientLightingResult.Equals(input.DetectInsufficientLightingResult))) return false;
            if (this.DetectCopyResult != input.DetectCopyResult || (this.DetectCopyResult != null && !this.DetectCopyResult.Equals(input.DetectCopyResult))) return false;
            if (this.DetectBorderIntegrityResult != input.DetectBorderIntegrityResult || (this.DetectBorderIntegrityResult != null && !this.DetectBorderIntegrityResult.Equals(input.DetectBorderIntegrityResult))) return false;
            if (this.DetectReproduceResult != input.DetectReproduceResult || (this.DetectReproduceResult != null && !this.DetectReproduceResult.Equals(input.DetectReproduceResult))) return false;

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
                if (this.DetectBlurResult != null) hashCode = hashCode * 59 + this.DetectBlurResult.GetHashCode();
                if (this.DetectGlareResult != null) hashCode = hashCode * 59 + this.DetectGlareResult.GetHashCode();
                if (this.DetectBlockingWithinBorderResult != null) hashCode = hashCode * 59 + this.DetectBlockingWithinBorderResult.GetHashCode();
                if (this.DetectInsufficientLightingResult != null) hashCode = hashCode * 59 + this.DetectInsufficientLightingResult.GetHashCode();
                if (this.DetectCopyResult != null) hashCode = hashCode * 59 + this.DetectCopyResult.GetHashCode();
                if (this.DetectBorderIntegrityResult != null) hashCode = hashCode * 59 + this.DetectBorderIntegrityResult.GetHashCode();
                if (this.DetectReproduceResult != null) hashCode = hashCode * 59 + this.DetectReproduceResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
