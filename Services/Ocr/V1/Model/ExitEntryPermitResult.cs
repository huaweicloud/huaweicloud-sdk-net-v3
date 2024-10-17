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
    public class ExitEntryPermitResult 
    {

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 英文姓名。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 性别。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 证件号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 签发机关。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 签发地点。 
        /// </summary>
        [JsonProperty("issue_place", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuePlace { get; set; }

        /// <summary>
        /// 有效期限。 
        /// </summary>
        [JsonProperty("valid_period", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidPeriod { get; set; }

        /// <summary>
        /// 机器码。 
        /// </summary>
        [JsonProperty("machine_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode { get; set; }

        /// <summary>
        /// 头像的base64编码。当输入参数“return_portrait_image”为“true”时，才返回该参数。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 头像在原图上的位置。 当输入参数“return_portrait_location”为“true”时，才返回该参数。以列表形式显示，包含头像区域四个顶点的二维坐标（x,y），坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 证件类型。可选值包括： - \&quot;往来港澳通行证 \&quot; - \&quot;往来台湾通行证\&quot; 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 证件图片正反面信息。可选值包括： - \&quot;front\&quot;：证件图片为正面 - \&quot;back\&quot;：证件图片为反面 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endorsement_info_hk", NullValueHandling = NullValueHandling.Ignore)]
        public ExitEntryPermitEndorsementInfo EndorsementInfoHk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endorsement_info_mo", NullValueHandling = NullValueHandling.Ignore)]
        public ExitEntryPermitEndorsementInfo EndorsementInfoMo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("endorsement_info_tw", NullValueHandling = NullValueHandling.Ignore)]
        public ExitEntryPermitEndorsementInfo EndorsementInfoTw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public ExitEntryPermitConfidence Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExitEntryPermitResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  issuePlace: ").Append(IssuePlace).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("  machineCode: ").Append(MachineCode).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  endorsementInfoHk: ").Append(EndorsementInfoHk).Append("\n");
            sb.Append("  endorsementInfoMo: ").Append(EndorsementInfoMo).Append("\n");
            sb.Append("  endorsementInfoTw: ").Append(EndorsementInfoTw).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExitEntryPermitResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExitEntryPermitResult input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.BirthDate != input.BirthDate || (this.BirthDate != null && !this.BirthDate.Equals(input.BirthDate))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.IssuingAuthority != input.IssuingAuthority || (this.IssuingAuthority != null && !this.IssuingAuthority.Equals(input.IssuingAuthority))) return false;
            if (this.IssuePlace != input.IssuePlace || (this.IssuePlace != null && !this.IssuePlace.Equals(input.IssuePlace))) return false;
            if (this.ValidPeriod != input.ValidPeriod || (this.ValidPeriod != null && !this.ValidPeriod.Equals(input.ValidPeriod))) return false;
            if (this.MachineCode != input.MachineCode || (this.MachineCode != null && !this.MachineCode.Equals(input.MachineCode))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
            if (this.PortraitLocation != input.PortraitLocation || (this.PortraitLocation != null && input.PortraitLocation != null && !this.PortraitLocation.SequenceEqual(input.PortraitLocation))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Side != input.Side || (this.Side != null && !this.Side.Equals(input.Side))) return false;
            if (this.EndorsementInfoHk != input.EndorsementInfoHk || (this.EndorsementInfoHk != null && !this.EndorsementInfoHk.Equals(input.EndorsementInfoHk))) return false;
            if (this.EndorsementInfoMo != input.EndorsementInfoMo || (this.EndorsementInfoMo != null && !this.EndorsementInfoMo.Equals(input.EndorsementInfoMo))) return false;
            if (this.EndorsementInfoTw != input.EndorsementInfoTw || (this.EndorsementInfoTw != null && !this.EndorsementInfoTw.Equals(input.EndorsementInfoTw))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.BirthDate != null) hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.IssuingAuthority != null) hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.IssuePlace != null) hashCode = hashCode * 59 + this.IssuePlace.GetHashCode();
                if (this.ValidPeriod != null) hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                if (this.MachineCode != null) hashCode = hashCode * 59 + this.MachineCode.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.PortraitLocation != null) hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Side != null) hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.EndorsementInfoHk != null) hashCode = hashCode * 59 + this.EndorsementInfoHk.GetHashCode();
                if (this.EndorsementInfoMo != null) hashCode = hashCode * 59 + this.EndorsementInfoMo.GetHashCode();
                if (this.EndorsementInfoTw != null) hashCode = hashCode * 59 + this.EndorsementInfoTw.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
