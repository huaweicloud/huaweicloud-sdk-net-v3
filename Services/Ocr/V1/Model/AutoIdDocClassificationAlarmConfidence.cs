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
    public class AutoIdDocClassificationAlarmConfidence 
    {

        /// <summary>
        /// 证件图像模糊告警分数，分数越高，证件图像模糊的可能性越高。 
        /// </summary>
        [JsonProperty("blur_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlurScore { get; set; }

        /// <summary>
        /// 证件图像反光告警分数，分数越高，证件图像反光的可能性越高。 
        /// </summary>
        [JsonProperty("glare_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? GlareScore { get; set; }

        /// <summary>
        /// 证件图像框内遮挡告警分数，分数越高，证件图像框内遮挡的可能性越高。 
        /// </summary>
        [JsonProperty("blocking_within_border_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockingWithinBorderScore { get; set; }

        /// <summary>
        /// 证件图像过暗告警分数，分数越高，证件图像过暗的可能性越高。 
        /// </summary>
        [JsonProperty("insufficient_lighting_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? InsufficientLightingScore { get; set; }

        /// <summary>
        /// 证件图像复印件告警分数，分数越高，证件图像是复印件的可能性越高。 
        /// </summary>
        [JsonProperty("copy_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? CopyScore { get; set; }

        /// <summary>
        /// 证件图像边框完整性告警分数，分数越高，证件图像边框不完整的可能性越高。 
        /// </summary>
        [JsonProperty("border_integrity_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderIntegrityScore { get; set; }

        /// <summary>
        /// 证件图像翻拍告警分数，分数越高，证件图像经过翻拍的可能性越高。 
        /// </summary>
        [JsonProperty("reproduce_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReproduceScore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoIdDocClassificationAlarmConfidence {\n");
            sb.Append("  blurScore: ").Append(BlurScore).Append("\n");
            sb.Append("  glareScore: ").Append(GlareScore).Append("\n");
            sb.Append("  blockingWithinBorderScore: ").Append(BlockingWithinBorderScore).Append("\n");
            sb.Append("  insufficientLightingScore: ").Append(InsufficientLightingScore).Append("\n");
            sb.Append("  copyScore: ").Append(CopyScore).Append("\n");
            sb.Append("  borderIntegrityScore: ").Append(BorderIntegrityScore).Append("\n");
            sb.Append("  reproduceScore: ").Append(ReproduceScore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoIdDocClassificationAlarmConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoIdDocClassificationAlarmConfidence input)
        {
            if (input == null) return false;
            if (this.BlurScore != input.BlurScore || (this.BlurScore != null && !this.BlurScore.Equals(input.BlurScore))) return false;
            if (this.GlareScore != input.GlareScore || (this.GlareScore != null && !this.GlareScore.Equals(input.GlareScore))) return false;
            if (this.BlockingWithinBorderScore != input.BlockingWithinBorderScore || (this.BlockingWithinBorderScore != null && !this.BlockingWithinBorderScore.Equals(input.BlockingWithinBorderScore))) return false;
            if (this.InsufficientLightingScore != input.InsufficientLightingScore || (this.InsufficientLightingScore != null && !this.InsufficientLightingScore.Equals(input.InsufficientLightingScore))) return false;
            if (this.CopyScore != input.CopyScore || (this.CopyScore != null && !this.CopyScore.Equals(input.CopyScore))) return false;
            if (this.BorderIntegrityScore != input.BorderIntegrityScore || (this.BorderIntegrityScore != null && !this.BorderIntegrityScore.Equals(input.BorderIntegrityScore))) return false;
            if (this.ReproduceScore != input.ReproduceScore || (this.ReproduceScore != null && !this.ReproduceScore.Equals(input.ReproduceScore))) return false;

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
                if (this.BlurScore != null) hashCode = hashCode * 59 + this.BlurScore.GetHashCode();
                if (this.GlareScore != null) hashCode = hashCode * 59 + this.GlareScore.GetHashCode();
                if (this.BlockingWithinBorderScore != null) hashCode = hashCode * 59 + this.BlockingWithinBorderScore.GetHashCode();
                if (this.InsufficientLightingScore != null) hashCode = hashCode * 59 + this.InsufficientLightingScore.GetHashCode();
                if (this.CopyScore != null) hashCode = hashCode * 59 + this.CopyScore.GetHashCode();
                if (this.BorderIntegrityScore != null) hashCode = hashCode * 59 + this.BorderIntegrityScore.GetHashCode();
                if (this.ReproduceScore != null) hashCode = hashCode * 59 + this.ReproduceScore.GetHashCode();
                return hashCode;
            }
        }
    }
}
