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
    public class HkIdCardResult 
    {

        /// <summary>
        /// 中文姓名。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 英文姓名。 
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 性别。  男： value值为：M 女： value值为：F 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期。 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 身份证号。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 证件符号。 
        /// </summary>
        [JsonProperty("symbols", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbols { get; set; }

        /// <summary>
        /// 中文姓名对应电码。 
        /// </summary>
        [JsonProperty("name_telegraph_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NameTelegraphCode { get; set; }

        /// <summary>
        /// 是否永久性居民身份证。  永久：value值为true 非永久：value值为false 
        /// </summary>
        [JsonProperty("permanent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Permanent { get; set; }

        /// <summary>
        /// 首次领用日期。 
        /// </summary>
        [JsonProperty("initial_issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialIssueDate { get; set; }

        /// <summary>
        /// 签发日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 头像在原图上的位置。 当输入参数“return_portrait_location”为“true”时，才返回该参数。以列表形式显示，包含头像区域四个顶点的二维坐标（x,y），坐标原点为图片左上角，x轴沿水平方向，y轴沿竖直方向。 
        /// </summary>
        [JsonProperty("portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> PortraitLocation { get; set; }

        /// <summary>
        /// 头像的base64编码，默认返回尺寸较大的头像。 当输入参数“return_portrait_image”为true时，才返回该参数。 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 各个字段的置信度。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HkIdCardResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  symbols: ").Append(Symbols).Append("\n");
            sb.Append("  nameTelegraphCode: ").Append(NameTelegraphCode).Append("\n");
            sb.Append("  permanent: ").Append(Permanent).Append("\n");
            sb.Append("  initialIssueDate: ").Append(InitialIssueDate).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  portraitLocation: ").Append(PortraitLocation).Append("\n");
            sb.Append("  portraitImage: ").Append(PortraitImage).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HkIdCardResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HkIdCardResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameEn == input.NameEn ||
                    (this.NameEn != null &&
                    this.NameEn.Equals(input.NameEn))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Symbols == input.Symbols ||
                    (this.Symbols != null &&
                    this.Symbols.Equals(input.Symbols))
                ) && 
                (
                    this.NameTelegraphCode == input.NameTelegraphCode ||
                    (this.NameTelegraphCode != null &&
                    this.NameTelegraphCode.Equals(input.NameTelegraphCode))
                ) && 
                (
                    this.Permanent == input.Permanent ||
                    (this.Permanent != null &&
                    this.Permanent.Equals(input.Permanent))
                ) && 
                (
                    this.InitialIssueDate == input.InitialIssueDate ||
                    (this.InitialIssueDate != null &&
                    this.InitialIssueDate.Equals(input.InitialIssueDate))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.PortraitLocation == input.PortraitLocation ||
                    this.PortraitLocation != null &&
                    input.PortraitLocation != null &&
                    this.PortraitLocation.SequenceEqual(input.PortraitLocation)
                ) && 
                (
                    this.PortraitImage == input.PortraitImage ||
                    (this.PortraitImage != null &&
                    this.PortraitImage.Equals(input.PortraitImage))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameEn != null)
                    hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Symbols != null)
                    hashCode = hashCode * 59 + this.Symbols.GetHashCode();
                if (this.NameTelegraphCode != null)
                    hashCode = hashCode * 59 + this.NameTelegraphCode.GetHashCode();
                if (this.Permanent != null)
                    hashCode = hashCode * 59 + this.Permanent.GetHashCode();
                if (this.InitialIssueDate != null)
                    hashCode = hashCode * 59 + this.InitialIssueDate.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.PortraitLocation != null)
                    hashCode = hashCode * 59 + this.PortraitLocation.GetHashCode();
                if (this.PortraitImage != null)
                    hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
