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
    public class IdcardScoreInfoResult 
    {

        /// <summary>
        /// 身份证PS告警分数，分数越高，PS的可能性越高。 仅在传入参数detect_tampering为true时，返回该字段。 
        /// </summary>
        [JsonProperty("tampering_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? TamperingScore { get; set; }

        /// <summary>
        /// 临时身份证告警分数，分数越高，临时身份证的可能性越高。 仅在传入参数detect_interim为true时，返回该字段。 
        /// </summary>
        [JsonProperty("interim_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? InterimScore { get; set; }

        /// <summary>
        /// 身份证翻拍告警分数，分数越高，身份证图像经过翻拍的可能性越高。 仅在传入参数detect_reproduce为true时，返回该字段。 
        /// </summary>
        [JsonProperty("reproduce_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReproduceScore { get; set; }

        /// <summary>
        /// 身份证复印告警分数, 分数越高，身份证图像是复印件的可能性越高。 仅在传入参数detect_copy为true时，返回该字段。 
        /// </summary>
        [JsonProperty("copy_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? CopyScore { get; set; }

        /// <summary>
        /// 身份证边缘完整性告警的分数，分数越高，身份证图像边缘不完整的可能性越高。 仅在传入参数detect_border_integrity为true时，返回该字段。 
        /// </summary>
        [JsonProperty("border_integrity_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderIntegrityScore { get; set; }

        /// <summary>
        /// 身份证模糊告警分数，分数越高，身份证图像模糊的可能性越高。 仅在传入参数detect_blur为true时，返回该字段。 
        /// </summary>
        [JsonProperty("blur_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlurScore { get; set; }

        /// <summary>
        /// 身份证反光告警分数，分数越高，身份证图像存在反光的可能性越高。 仅在传入参数detect_glare为true时，返回该字段。 
        /// </summary>
        [JsonProperty("glare_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? GlareScore { get; set; }

        /// <summary>
        /// 身份证图像框内是否有遮挡的告警分数，分数越高，身份证图像框内存在异物遮挡的可能性越高。 仅在传入参数detect_blocking_within_border为true时，返回该字段。 
        /// </summary>
        [JsonProperty("blocking_within_border_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockingWithinBorderScore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdcardScoreInfoResult {\n");
            sb.Append("  tamperingScore: ").Append(TamperingScore).Append("\n");
            sb.Append("  interimScore: ").Append(InterimScore).Append("\n");
            sb.Append("  reproduceScore: ").Append(ReproduceScore).Append("\n");
            sb.Append("  copyScore: ").Append(CopyScore).Append("\n");
            sb.Append("  borderIntegrityScore: ").Append(BorderIntegrityScore).Append("\n");
            sb.Append("  blurScore: ").Append(BlurScore).Append("\n");
            sb.Append("  glareScore: ").Append(GlareScore).Append("\n");
            sb.Append("  blockingWithinBorderScore: ").Append(BlockingWithinBorderScore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdcardScoreInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdcardScoreInfoResult input)
        {
            if (input == null) return false;
            if (this.TamperingScore != input.TamperingScore || (this.TamperingScore != null && !this.TamperingScore.Equals(input.TamperingScore))) return false;
            if (this.InterimScore != input.InterimScore || (this.InterimScore != null && !this.InterimScore.Equals(input.InterimScore))) return false;
            if (this.ReproduceScore != input.ReproduceScore || (this.ReproduceScore != null && !this.ReproduceScore.Equals(input.ReproduceScore))) return false;
            if (this.CopyScore != input.CopyScore || (this.CopyScore != null && !this.CopyScore.Equals(input.CopyScore))) return false;
            if (this.BorderIntegrityScore != input.BorderIntegrityScore || (this.BorderIntegrityScore != null && !this.BorderIntegrityScore.Equals(input.BorderIntegrityScore))) return false;
            if (this.BlurScore != input.BlurScore || (this.BlurScore != null && !this.BlurScore.Equals(input.BlurScore))) return false;
            if (this.GlareScore != input.GlareScore || (this.GlareScore != null && !this.GlareScore.Equals(input.GlareScore))) return false;
            if (this.BlockingWithinBorderScore != input.BlockingWithinBorderScore || (this.BlockingWithinBorderScore != null && !this.BlockingWithinBorderScore.Equals(input.BlockingWithinBorderScore))) return false;

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
                if (this.TamperingScore != null) hashCode = hashCode * 59 + this.TamperingScore.GetHashCode();
                if (this.InterimScore != null) hashCode = hashCode * 59 + this.InterimScore.GetHashCode();
                if (this.ReproduceScore != null) hashCode = hashCode * 59 + this.ReproduceScore.GetHashCode();
                if (this.CopyScore != null) hashCode = hashCode * 59 + this.CopyScore.GetHashCode();
                if (this.BorderIntegrityScore != null) hashCode = hashCode * 59 + this.BorderIntegrityScore.GetHashCode();
                if (this.BlurScore != null) hashCode = hashCode * 59 + this.BlurScore.GetHashCode();
                if (this.GlareScore != null) hashCode = hashCode * 59 + this.GlareScore.GetHashCode();
                if (this.BlockingWithinBorderScore != null) hashCode = hashCode * 59 + this.BlockingWithinBorderScore.GetHashCode();
                return hashCode;
            }
        }
    }
}
