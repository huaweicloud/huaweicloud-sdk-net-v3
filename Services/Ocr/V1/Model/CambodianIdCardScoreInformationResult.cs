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
    public class CambodianIdCardScoreInformationResult 
    {

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示复印件，小于等于50表示原件，值越靠近99，表示复印件的可能性越大，值越靠近0，表示原件的可能性越大。  仅在传入参数return_idcard_type为true时，返回该字段。 
        /// </summary>
        [JsonProperty("idcard_type_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? IdcardTypeScore { get; set; }

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示边框不完整，小于50表示边框完整，值越靠近99，表示边框不完整的可能性越大，值越靠近0，表示边框完整的可能性越大。 仅在传入参数detect_border_integrity为true时，返回该字段。 
        /// </summary>
        [JsonProperty("border_integrity_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BorderIntegrityScore { get; set; }

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示框内有遮挡，小于50表示框内无遮挡，值越靠近99，表示框内有遮挡的可能性越大，值越靠近0，表示框内无遮挡的可能性越大。 仅在传入参数detect_blocking_within_border为true时，返回该字段。 
        /// </summary>
        [JsonProperty("blocking_within_border_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockingWithinBorderScore { get; set; }

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示身份证模糊，小于50表示身份证清晰，值越靠近99，表示身份证模糊的可能性越大，值越靠近0，表示身份证清晰的可能性越大。 仅在传入参数detect_blur为true时，返回该字段。 
        /// </summary>
        [JsonProperty("blur_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlurScore { get; set; }

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示身份证反光，小于50表示身份证不反光，值越靠近99，表示身份证反光的可能性越大，值越靠近0，表示身份证不反光的可能性越大。 仅在传入参数detect_glare为true时，返回该字段。 
        /// </summary>
        [JsonProperty("glare_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? GlareScore { get; set; }

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示身份证人像被其他非身份证人像篡改过，小于50表示身份证人像未被篡改，值越靠近99，表示身份证人像被篡改的可能性越大，值越靠近0，表示身份证未人像被篡改的可能性越大。 仅在传入参数detect_tampering为true时，返回该字段。 
        /// </summary>
        [JsonProperty("tampering_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? TamperingScore { get; set; }

        /// <summary>
        /// 告警分数，字段取值范围[0, 99]值大于50表示身份证经过翻拍，小于50表示身份证未经过翻拍，值越靠近99，表示身份证图像被翻拍过的可能性越大，值越靠近0，表示身份证图像未被翻拍的可能性越大。 仅在传入参数detect_reproduce为true时，返回该字段。 
        /// </summary>
        [JsonProperty("reproduce_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReproduceScore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CambodianIdCardScoreInformationResult {\n");
            sb.Append("  idcardTypeScore: ").Append(IdcardTypeScore).Append("\n");
            sb.Append("  borderIntegrityScore: ").Append(BorderIntegrityScore).Append("\n");
            sb.Append("  blockingWithinBorderScore: ").Append(BlockingWithinBorderScore).Append("\n");
            sb.Append("  blurScore: ").Append(BlurScore).Append("\n");
            sb.Append("  glareScore: ").Append(GlareScore).Append("\n");
            sb.Append("  tamperingScore: ").Append(TamperingScore).Append("\n");
            sb.Append("  reproduceScore: ").Append(ReproduceScore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CambodianIdCardScoreInformationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CambodianIdCardScoreInformationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdcardTypeScore == input.IdcardTypeScore ||
                    (this.IdcardTypeScore != null &&
                    this.IdcardTypeScore.Equals(input.IdcardTypeScore))
                ) && 
                (
                    this.BorderIntegrityScore == input.BorderIntegrityScore ||
                    (this.BorderIntegrityScore != null &&
                    this.BorderIntegrityScore.Equals(input.BorderIntegrityScore))
                ) && 
                (
                    this.BlockingWithinBorderScore == input.BlockingWithinBorderScore ||
                    (this.BlockingWithinBorderScore != null &&
                    this.BlockingWithinBorderScore.Equals(input.BlockingWithinBorderScore))
                ) && 
                (
                    this.BlurScore == input.BlurScore ||
                    (this.BlurScore != null &&
                    this.BlurScore.Equals(input.BlurScore))
                ) && 
                (
                    this.GlareScore == input.GlareScore ||
                    (this.GlareScore != null &&
                    this.GlareScore.Equals(input.GlareScore))
                ) && 
                (
                    this.TamperingScore == input.TamperingScore ||
                    (this.TamperingScore != null &&
                    this.TamperingScore.Equals(input.TamperingScore))
                ) && 
                (
                    this.ReproduceScore == input.ReproduceScore ||
                    (this.ReproduceScore != null &&
                    this.ReproduceScore.Equals(input.ReproduceScore))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IdcardTypeScore != null)
                    hashCode = hashCode * 59 + this.IdcardTypeScore.GetHashCode();
                if (this.BorderIntegrityScore != null)
                    hashCode = hashCode * 59 + this.BorderIntegrityScore.GetHashCode();
                if (this.BlockingWithinBorderScore != null)
                    hashCode = hashCode * 59 + this.BlockingWithinBorderScore.GetHashCode();
                if (this.BlurScore != null)
                    hashCode = hashCode * 59 + this.BlurScore.GetHashCode();
                if (this.GlareScore != null)
                    hashCode = hashCode * 59 + this.GlareScore.GetHashCode();
                if (this.TamperingScore != null)
                    hashCode = hashCode * 59 + this.TamperingScore.GetHashCode();
                if (this.ReproduceScore != null)
                    hashCode = hashCode * 59 + this.ReproduceScore.GetHashCode();
                return hashCode;
            }
        }
    }
}
