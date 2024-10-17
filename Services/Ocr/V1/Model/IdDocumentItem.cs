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
    public class IdDocumentItem 
    {

        /// <summary>
        /// 证件签发国家或地区代码，命名遵循ISO-3166 3位代码。当前支持国家列表见表1。 
        /// </summary>
        [JsonProperty("country_region", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryRegion { get; set; }

        /// <summary>
        /// 证件类型，可选值如下： - PP: passport，国际护照。 - DL: driving license，驾驶证。 - ID: identification card，各国颁发的身份证类型证件，比如身份证、选民卡、社保卡等。 
        /// </summary>
        [JsonProperty("id_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IdType { get; set; }

        /// <summary>
        /// 证件正面或反面,可选值： - front: 正面，一般是包含人像的那面 - back: 背面 对于只有一面的卡证，返回front 
        /// </summary>
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        /// <summary>
        /// 名 
        /// </summary>
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// 姓氏 
        /// </summary>
        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// 性别，可选值： M:男性 F:女性 X:中性 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 持有人国籍 
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// 生日，格式为yyyy-mm-dd 
        /// </summary>
        [JsonProperty("birth_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BirthDate { get; set; }

        /// <summary>
        /// 签发日期，yyyy-mm-dd 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 有效日期，yyyy-mm-dd 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 证件号码 
        /// </summary>
        [JsonProperty("document_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// 持有人通讯地址 
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 签发机关 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 可选返回，证件头像图像base64编码 
        /// </summary>
        [JsonProperty("portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public string PortraitImage { get; set; }

        /// <summary>
        /// 字段置信度，为0~1之间的小数，值越大，表明识别结果越可靠 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdDocumentItem {\n");
            sb.Append("  countryRegion: ").Append(CountryRegion).Append("\n");
            sb.Append("  idType: ").Append(IdType).Append("\n");
            sb.Append("  side: ").Append(Side).Append("\n");
            sb.Append("  firstName: ").Append(FirstName).Append("\n");
            sb.Append("  lastName: ").Append(LastName).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  birthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  documentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
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
            return this.Equals(input as IdDocumentItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdDocumentItem input)
        {
            if (input == null) return false;
            if (this.CountryRegion != input.CountryRegion || (this.CountryRegion != null && !this.CountryRegion.Equals(input.CountryRegion))) return false;
            if (this.IdType != input.IdType || (this.IdType != null && !this.IdType.Equals(input.IdType))) return false;
            if (this.Side != input.Side || (this.Side != null && !this.Side.Equals(input.Side))) return false;
            if (this.FirstName != input.FirstName || (this.FirstName != null && !this.FirstName.Equals(input.FirstName))) return false;
            if (this.LastName != input.LastName || (this.LastName != null && !this.LastName.Equals(input.LastName))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Nationality != input.Nationality || (this.Nationality != null && !this.Nationality.Equals(input.Nationality))) return false;
            if (this.BirthDate != input.BirthDate || (this.BirthDate != null && !this.BirthDate.Equals(input.BirthDate))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;
            if (this.DocumentNumber != input.DocumentNumber || (this.DocumentNumber != null && !this.DocumentNumber.Equals(input.DocumentNumber))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.IssuingAuthority != input.IssuingAuthority || (this.IssuingAuthority != null && !this.IssuingAuthority.Equals(input.IssuingAuthority))) return false;
            if (this.PortraitImage != input.PortraitImage || (this.PortraitImage != null && !this.PortraitImage.Equals(input.PortraitImage))) return false;
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
                if (this.CountryRegion != null) hashCode = hashCode * 59 + this.CountryRegion.GetHashCode();
                if (this.IdType != null) hashCode = hashCode * 59 + this.IdType.GetHashCode();
                if (this.Side != null) hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.FirstName != null) hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null) hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Nationality != null) hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.BirthDate != null) hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.DocumentNumber != null) hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.IssuingAuthority != null) hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.PortraitImage != null) hashCode = hashCode * 59 + this.PortraitImage.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
