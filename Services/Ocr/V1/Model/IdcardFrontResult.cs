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
    public class IdcardFrontResult 
    {

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 性别。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth", NullValueHandling = NullValueHandling.Ignore)]
        public string Birth { get; set; }

        /// <summary>
        /// 民族。 
        /// </summary>
        [JsonProperty("ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public string Ethnicity { get; set; }

        /// <summary>
        /// 地址。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 身份证号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 身份证头像图片信息的base64码结果。  &gt; 说明： - 仅在输入参数return_portrait_image为true时，返回该字段。 - 当输入为身份证背面时返回为空字符串。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 身份证卡面图片信息的base64码结果。  &gt; 说明： - 仅在输入参数return_adjusted_image为true时，返回该字段。 
        /// </summary>
        [JsonProperty("adjusted_image", NullValueHandling = NullValueHandling.Ignore)]
        public string AdjustedImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("verification_result", NullValueHandling = NullValueHandling.Ignore)]
        public IdcardFrontVerificationResult VerificationResult { get; set; }

        /// <summary>
        /// 文本框在原图位置。输出左上、右上、右下、左下四个点坐标。 仅return_text_location设置为true时才返回。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }

        /// <summary>
        /// 身份证头像位置信息的结果。 仅在输入参数return_portrait_location为true时，返回该字段。 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 身份证图像是否翻拍告警结果。 - true：表示身份证图片经过翻拍。 - false：表示身份证图片未经过翻拍。 仅在输入参数detect_reproduce为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_reproduce_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectReproduceResult { get; set; }

        /// <summary>
        /// 身份证图像是否黑白复印件告警结果。 - true：表示身份证图片是复印件。 - false”表示身份证图片是原件。 仅在输入参数detect_copy为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_copy_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectCopyResult { get; set; }

        /// <summary>
        /// 身份证图片是否PS告警结果。 - true：表示身份证经过PS。 - false：表示未经过PS。 仅在传入参数detect_tampering为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_tampering_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectTamperingResult { get; set; }

        /// <summary>
        /// 身份证图片边框完整性告警结果。 - true：表示边框不完整 - false：表示边框完整。 仅在输入参数detect_border_integrity为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_border_integrity_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBorderIntegrityResult { get; set; }

        /// <summary>
        /// 身份证图像框内是否存在遮挡的告警结果。 - true：表示边框内部存在遮挡。 - false：表示边框内部不存在遮挡。 仅在输入参数detect_blocking_within_border为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_blocking_within_border_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlockingWithinBorderResult { get; set; }

        /// <summary>
        /// 身份证模糊告警结果。 - true：表示身份证图片较模糊。 - false：表示身份证清晰。 仅在输入参数detect_blur为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_blur_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlurResult { get; set; }

        /// <summary>
        /// 临时身份证告警结果。 - true：表示是临时身份证。 - false：表示非临时身份证。 仅在输入参数detect_interim为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_interim_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectInterimResult { get; set; }

        /// <summary>
        /// 身份证反光告警结果。 - true：表示身份证图片存在反光。 - false：表示是身份证不存在反光。 仅在输入参数detect_glare为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_glare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectGlareResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("score_info", NullValueHandling = NullValueHandling.Ignore)]
        public IdcardScoreInfoResult ScoreInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdcardFrontResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birth: ").Append(Birth).Append("\n");
            sb.Append("  ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  adjustedImage: ").Append(AdjustedImage).Append("\n");
            sb.Append("  verificationResult: ").Append(VerificationResult).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  detectReproduceResult: ").Append(DetectReproduceResult).Append("\n");
            sb.Append("  detectCopyResult: ").Append(DetectCopyResult).Append("\n");
            sb.Append("  detectTamperingResult: ").Append(DetectTamperingResult).Append("\n");
            sb.Append("  detectBorderIntegrityResult: ").Append(DetectBorderIntegrityResult).Append("\n");
            sb.Append("  detectBlockingWithinBorderResult: ").Append(DetectBlockingWithinBorderResult).Append("\n");
            sb.Append("  detectBlurResult: ").Append(DetectBlurResult).Append("\n");
            sb.Append("  detectInterimResult: ").Append(DetectInterimResult).Append("\n");
            sb.Append("  detectGlareResult: ").Append(DetectGlareResult).Append("\n");
            sb.Append("  scoreInfo: ").Append(ScoreInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdcardFrontResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdcardFrontResult input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Birth != input.Birth || (this.Birth != null && !this.Birth.Equals(input.Birth))) return false;
            if (this.Ethnicity != input.Ethnicity || (this.Ethnicity != null && !this.Ethnicity.Equals(input.Ethnicity))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
            if (this.AdjustedImage != input.AdjustedImage || (this.AdjustedImage != null && !this.AdjustedImage.Equals(input.AdjustedImage))) return false;
            if (this.VerificationResult != input.VerificationResult || (this.VerificationResult != null && !this.VerificationResult.Equals(input.VerificationResult))) return false;
            if (this.TextLocation != input.TextLocation || (this.TextLocation != null && !this.TextLocation.Equals(input.TextLocation))) return false;
            if (this.PortraitLocation != input.PortraitLocation || (this.PortraitLocation != null && input.PortraitLocation != null && !this.PortraitLocation.SequenceEqual(input.PortraitLocation))) return false;
            if (this.DetectReproduceResult != input.DetectReproduceResult || (this.DetectReproduceResult != null && !this.DetectReproduceResult.Equals(input.DetectReproduceResult))) return false;
            if (this.DetectCopyResult != input.DetectCopyResult || (this.DetectCopyResult != null && !this.DetectCopyResult.Equals(input.DetectCopyResult))) return false;
            if (this.DetectTamperingResult != input.DetectTamperingResult || (this.DetectTamperingResult != null && !this.DetectTamperingResult.Equals(input.DetectTamperingResult))) return false;
            if (this.DetectBorderIntegrityResult != input.DetectBorderIntegrityResult || (this.DetectBorderIntegrityResult != null && !this.DetectBorderIntegrityResult.Equals(input.DetectBorderIntegrityResult))) return false;
            if (this.DetectBlockingWithinBorderResult != input.DetectBlockingWithinBorderResult || (this.DetectBlockingWithinBorderResult != null && !this.DetectBlockingWithinBorderResult.Equals(input.DetectBlockingWithinBorderResult))) return false;
            if (this.DetectBlurResult != input.DetectBlurResult || (this.DetectBlurResult != null && !this.DetectBlurResult.Equals(input.DetectBlurResult))) return false;
            if (this.DetectInterimResult != input.DetectInterimResult || (this.DetectInterimResult != null && !this.DetectInterimResult.Equals(input.DetectInterimResult))) return false;
            if (this.DetectGlareResult != input.DetectGlareResult || (this.DetectGlareResult != null && !this.DetectGlareResult.Equals(input.DetectGlareResult))) return false;
            if (this.ScoreInfo != input.ScoreInfo || (this.ScoreInfo != null && !this.ScoreInfo.Equals(input.ScoreInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Birth != null) hashCode = hashCode * 59 + this.Birth.GetHashCode();
                if (this.Ethnicity != null) hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.AdjustedImage != null) hashCode = hashCode * 59 + this.AdjustedImage.GetHashCode();
                if (this.VerificationResult != null) hashCode = hashCode * 59 + this.VerificationResult.GetHashCode();
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                if (this.PortraitLocation != null) hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.DetectReproduceResult != null) hashCode = hashCode * 59 + this.DetectReproduceResult.GetHashCode();
                if (this.DetectCopyResult != null) hashCode = hashCode * 59 + this.DetectCopyResult.GetHashCode();
                if (this.DetectTamperingResult != null) hashCode = hashCode * 59 + this.DetectTamperingResult.GetHashCode();
                if (this.DetectBorderIntegrityResult != null) hashCode = hashCode * 59 + this.DetectBorderIntegrityResult.GetHashCode();
                if (this.DetectBlockingWithinBorderResult != null) hashCode = hashCode * 59 + this.DetectBlockingWithinBorderResult.GetHashCode();
                if (this.DetectBlurResult != null) hashCode = hashCode * 59 + this.DetectBlurResult.GetHashCode();
                if (this.DetectInterimResult != null) hashCode = hashCode * 59 + this.DetectInterimResult.GetHashCode();
                if (this.DetectGlareResult != null) hashCode = hashCode * 59 + this.DetectGlareResult.GetHashCode();
                if (this.ScoreInfo != null) hashCode = hashCode * 59 + this.ScoreInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
