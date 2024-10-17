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
    public class CambodianIdCardResult 
    {

        /// <summary>
        /// 身份证号码。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 高棉语版姓名。 
        /// </summary>
        [JsonProperty("name_kh", NullValueHandling = NullValueHandling.Ignore)]
        public string NameKh { get; set; }

        /// <summary>
        /// 英文姓名。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 性别。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 身高。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public string Height { get; set; }

        /// <summary>
        /// 出生地。 
        /// </summary>
        [JsonProperty("birth_place", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthPlace { get; set; }

        /// <summary>
        /// 地址，以空格分隔。 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 签发起始日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 签发结束日期。 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 图片中的个人特征。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 机器码第一行。 
        /// </summary>
        [JsonProperty("machine_code1", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode1 { get; set; }

        /// <summary>
        /// 机器码第二行。 
        /// </summary>
        [JsonProperty("machine_code2", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode2 { get; set; }

        /// <summary>
        /// 机器码第三行。 
        /// </summary>
        [JsonProperty("machine_code3", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode3 { get; set; }

        /// <summary>
        /// 头像的base64编码。 当输入参数“return_portrait_image”为“true”时，才返回该参数。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 头像在原图上的位置。 当输入参数“return_portrait_location”为“true”时，才返回该参数。以列表形式显示，包含头像区域四个顶点的二维坐标（x,y），坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 身份证的类型。当输入参数\&quot;idcard_type \&quot;为\&quot;true\&quot;时，才返回该参数。取值如下所示： - normal：身份证原件 - copy：复印的身份证 
        /// </summary>
        [JsonProperty("idcard_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardType { get; set; }

        /// <summary>
        /// 身份证原图的base64编码。 当输入参数\&quot;return_adjusted_image\&quot;为\&quot;true\&quot;时，才返回该参数。 
        /// </summary>
        [JsonProperty("adjusted_image", NullValueHandling = NullValueHandling.Ignore)]
        public string AdjustedImage { get; set; }

        /// <summary>
        /// 身份证图片边框完整性告警结果，\&quot;true\&quot;表示边框不完整，\&quot;false\&quot;表示边框完整。仅在输入参数detect_border_integrity为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_border_integrity_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBorderIntegrityResult { get; set; }

        /// <summary>
        /// 身份证图像框内是否存在遮挡的告警结果，\&quot;true\&quot;表示边框内部存在遮挡，\&quot;false\&quot;表示边框内部完整。仅在输入参数detect_blocking_within_border为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_blocking_within_border_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlockingWithinBorderResult { get; set; }

        /// <summary>
        /// 身份证模糊告警结果，\&quot;true\&quot;表示图片模糊，\&quot;false\&quot;表示身份证清晰。仅在输入参数detect_blur为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_blur_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectBlurResult { get; set; }

        /// <summary>
        /// 身份证反光告警结果，\&quot;true\&quot;表示身份证反光，\&quot;false\&quot;表示是身份证无反光。仅在输入参数detect_glare为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_glare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectGlareResult { get; set; }

        /// <summary>
        /// 身份证人像被篡改的告警结果，\&quot;true\&quot;表示身份证人像被篡改，\&quot;false\&quot;表示是身份证人像未被篡改。仅在输入参数detect_tampering为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_tampering_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectTamperingResult { get; set; }

        /// <summary>
        /// 身份证是否经过翻拍的告警结果，“true”表示身份证经过翻拍，“false”表示身份证未经过翻拍。仅在输入参数detect_reproduce为true时，返回该字段。 
        /// </summary>
        [JsonProperty("detect_reproduce_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DetectReproduceResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("score_info", NullValueHandling = NullValueHandling.Ignore)]
        public CambodianIdCardScoreInformationResult ScoreInfo { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CambodianIdCardResult {\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  nameKh: ").Append(NameKh).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  birthPlace: ").Append(BirthPlace).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  machineCode1: ").Append(MachineCode1).Append("\n");
            sb.Append("  machineCode2: ").Append(MachineCode2).Append("\n");
            sb.Append("  machineCode3: ").Append(MachineCode3).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  idcardType: ").Append(IdcardType).Append("\n");
            sb.Append("  adjustedImage: ").Append(AdjustedImage).Append("\n");
            sb.Append("  detectBorderIntegrityResult: ").Append(DetectBorderIntegrityResult).Append("\n");
            sb.Append("  detectBlockingWithinBorderResult: ").Append(DetectBlockingWithinBorderResult).Append("\n");
            sb.Append("  detectBlurResult: ").Append(DetectBlurResult).Append("\n");
            sb.Append("  detectGlareResult: ").Append(DetectGlareResult).Append("\n");
            sb.Append("  detectTamperingResult: ").Append(DetectTamperingResult).Append("\n");
            sb.Append("  detectReproduceResult: ").Append(DetectReproduceResult).Append("\n");
            sb.Append("  scoreInfo: ").Append(ScoreInfo).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CambodianIdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CambodianIdCardResult input)
        {
            if (input == null) return false;
            if (this.IdNumber != input.IdNumber || (this.IdNumber != null && !this.IdNumber.Equals(input.IdNumber))) return false;
            if (this.NameKh != input.NameKh || (this.NameKh != null && !this.NameKh.Equals(input.NameKh))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.BirthDate != input.BirthDate || (this.BirthDate != null && !this.BirthDate.Equals(input.BirthDate))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.BirthPlace != input.BirthPlace || (this.BirthPlace != null && !this.BirthPlace.Equals(input.BirthPlace))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.MachineCode1 != input.MachineCode1 || (this.MachineCode1 != null && !this.MachineCode1.Equals(input.MachineCode1))) return false;
            if (this.MachineCode2 != input.MachineCode2 || (this.MachineCode2 != null && !this.MachineCode2.Equals(input.MachineCode2))) return false;
            if (this.MachineCode3 != input.MachineCode3 || (this.MachineCode3 != null && !this.MachineCode3.Equals(input.MachineCode3))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
            if (this.PortraitLocation != input.PortraitLocation || (this.PortraitLocation != null && input.PortraitLocation != null && !this.PortraitLocation.SequenceEqual(input.PortraitLocation))) return false;
            if (this.IdcardType != input.IdcardType || (this.IdcardType != null && !this.IdcardType.Equals(input.IdcardType))) return false;
            if (this.AdjustedImage != input.AdjustedImage || (this.AdjustedImage != null && !this.AdjustedImage.Equals(input.AdjustedImage))) return false;
            if (this.DetectBorderIntegrityResult != input.DetectBorderIntegrityResult || (this.DetectBorderIntegrityResult != null && !this.DetectBorderIntegrityResult.Equals(input.DetectBorderIntegrityResult))) return false;
            if (this.DetectBlockingWithinBorderResult != input.DetectBlockingWithinBorderResult || (this.DetectBlockingWithinBorderResult != null && !this.DetectBlockingWithinBorderResult.Equals(input.DetectBlockingWithinBorderResult))) return false;
            if (this.DetectBlurResult != input.DetectBlurResult || (this.DetectBlurResult != null && !this.DetectBlurResult.Equals(input.DetectBlurResult))) return false;
            if (this.DetectGlareResult != input.DetectGlareResult || (this.DetectGlareResult != null && !this.DetectGlareResult.Equals(input.DetectGlareResult))) return false;
            if (this.DetectTamperingResult != input.DetectTamperingResult || (this.DetectTamperingResult != null && !this.DetectTamperingResult.Equals(input.DetectTamperingResult))) return false;
            if (this.DetectReproduceResult != input.DetectReproduceResult || (this.DetectReproduceResult != null && !this.DetectReproduceResult.Equals(input.DetectReproduceResult))) return false;
            if (this.ScoreInfo != input.ScoreInfo || (this.ScoreInfo != null && !this.ScoreInfo.Equals(input.ScoreInfo))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;

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
                if (this.IdNumber != null) hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.NameKh != null) hashCode = hashCode * 59 + this.NameKh.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.BirthDate != null) hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BirthPlace != null) hashCode = hashCode * 59 + this.BirthPlace.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MachineCode1 != null) hashCode = hashCode * 59 + this.MachineCode1.GetHashCode();
                if (this.MachineCode2 != null) hashCode = hashCode * 59 + this.MachineCode2.GetHashCode();
                if (this.MachineCode3 != null) hashCode = hashCode * 59 + this.MachineCode3.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.PortraitLocation != null) hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.IdcardType != null) hashCode = hashCode * 59 + this.IdcardType.GetHashCode();
                if (this.AdjustedImage != null) hashCode = hashCode * 59 + this.AdjustedImage.GetHashCode();
                if (this.DetectBorderIntegrityResult != null) hashCode = hashCode * 59 + this.DetectBorderIntegrityResult.GetHashCode();
                if (this.DetectBlockingWithinBorderResult != null) hashCode = hashCode * 59 + this.DetectBlockingWithinBorderResult.GetHashCode();
                if (this.DetectBlurResult != null) hashCode = hashCode * 59 + this.DetectBlurResult.GetHashCode();
                if (this.DetectGlareResult != null) hashCode = hashCode * 59 + this.DetectGlareResult.GetHashCode();
                if (this.DetectTamperingResult != null) hashCode = hashCode * 59 + this.DetectTamperingResult.GetHashCode();
                if (this.DetectReproduceResult != null) hashCode = hashCode * 59 + this.DetectReproduceResult.GetHashCode();
                if (this.ScoreInfo != null) hashCode = hashCode * 59 + this.ScoreInfo.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
