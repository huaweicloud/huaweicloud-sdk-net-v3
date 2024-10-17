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
    public class VietnamIdCardResult 
    {

        /// <summary>
        /// 返回证件正反面。字段值为“front”或“back” 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 卡证编号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 姓名。 
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

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
        /// 国籍。 
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// 籍贯。 
        /// </summary>
        [JsonProperty("origin_place", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginPlace { get; set; }

        /// <summary>
        /// 居住地。 
        /// </summary>
        [JsonProperty("residence_place", NullValueHandling = NullValueHandling.Ignore)]
        public string ResidencePlace { get; set; }

        /// <summary>
        /// 有效日期。 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 个人识别。当参数“side”为back时，返回此字段。 
        /// </summary>
        [JsonProperty("personal_identification", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalIdentification { get; set; }

        /// <summary>
        /// 签发日期。当参数“side”为back时，返回此字段。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 身份证背面第一行机器码。当参数“side”为back时，返回此字段。 
        /// </summary>
        [JsonProperty("machine_code1", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode1 { get; set; }

        /// <summary>
        /// 身份证背面第二行机器码。当参数“side”为back时，返回此字段。 
        /// </summary>
        [JsonProperty("machine_code2", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode2 { get; set; }

        /// <summary>
        /// 身份证背面第三行机器码。当参数“side”为back时，返回此字段。 
        /// </summary>
        [JsonProperty("machine_code3", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineCode3 { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。注：置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

        /// <summary>
        /// 当参数return_portrait_image为true时，返回头像的base64编码。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 当参数return_portrait_location为true时，返回头像在原图上的位置，以列表形式表示，包含头像区域四个顶点的二维坐标（x,y）；坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 输入参数return_idcard_type为true时，返回身份证的类型：normal是身份证原件，copy是复印的身份证，screen是屏幕翻拍。 
        /// </summary>
        [JsonProperty("idcard_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardType { get; set; }

        /// <summary>
        /// 对应所有在原图上识别到的字段位置信息，包含所有文字区域四个顶点的二维坐标（x,y）。采用图像坐标系，坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VietnamIdCardResult {\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  fullName: ").Append(FullName).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  originPlace: ").Append(OriginPlace).Append("\n");
            sb.Append("  residencePlace: ").Append(ResidencePlace).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  personalIdentification: ").Append(PersonalIdentification).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  machineCode1: ").Append(MachineCode1).Append("\n");
            sb.Append("  machineCode2: ").Append(MachineCode2).Append("\n");
            sb.Append("  machineCode3: ").Append(MachineCode3).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  idcardType: ").Append(IdcardType).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VietnamIdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VietnamIdCardResult input)
        {
            if (input == null) return false;
            if (this.Side != input.Side || (this.Side != null && !this.Side.Equals(input.Side))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.FullName != input.FullName || (this.FullName != null && !this.FullName.Equals(input.FullName))) return false;
            if (this.BirthDate != input.BirthDate || (this.BirthDate != null && !this.BirthDate.Equals(input.BirthDate))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Nationality != input.Nationality || (this.Nationality != null && !this.Nationality.Equals(input.Nationality))) return false;
            if (this.OriginPlace != input.OriginPlace || (this.OriginPlace != null && !this.OriginPlace.Equals(input.OriginPlace))) return false;
            if (this.ResidencePlace != input.ResidencePlace || (this.ResidencePlace != null && !this.ResidencePlace.Equals(input.ResidencePlace))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;
            if (this.PersonalIdentification != input.PersonalIdentification || (this.PersonalIdentification != null && !this.PersonalIdentification.Equals(input.PersonalIdentification))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.MachineCode1 != input.MachineCode1 || (this.MachineCode1 != null && !this.MachineCode1.Equals(input.MachineCode1))) return false;
            if (this.MachineCode2 != input.MachineCode2 || (this.MachineCode2 != null && !this.MachineCode2.Equals(input.MachineCode2))) return false;
            if (this.MachineCode3 != input.MachineCode3 || (this.MachineCode3 != null && !this.MachineCode3.Equals(input.MachineCode3))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
            if (this.PortraitLocation != input.PortraitLocation || (this.PortraitLocation != null && input.PortraitLocation != null && !this.PortraitLocation.SequenceEqual(input.PortraitLocation))) return false;
            if (this.IdcardType != input.IdcardType || (this.IdcardType != null && !this.IdcardType.Equals(input.IdcardType))) return false;
            if (this.TextLocation != input.TextLocation || (this.TextLocation != null && !this.TextLocation.Equals(input.TextLocation))) return false;

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
                if (this.Side != null) hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.FullName != null) hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.BirthDate != null) hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Nationality != null) hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.OriginPlace != null) hashCode = hashCode * 59 + this.OriginPlace.GetHashCode();
                if (this.ResidencePlace != null) hashCode = hashCode * 59 + this.ResidencePlace.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.PersonalIdentification != null) hashCode = hashCode * 59 + this.PersonalIdentification.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.MachineCode1 != null) hashCode = hashCode * 59 + this.MachineCode1.GetHashCode();
                if (this.MachineCode2 != null) hashCode = hashCode * 59 + this.MachineCode2.GetHashCode();
                if (this.MachineCode3 != null) hashCode = hashCode * 59 + this.MachineCode3.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.PortraitLocation != null) hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.IdcardType != null) hashCode = hashCode * 59 + this.IdcardType.GetHashCode();
                if (this.TextLocation != null) hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
