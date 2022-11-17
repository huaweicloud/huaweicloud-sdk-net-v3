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
    public class PassportResult 
    {

        /// <summary>
        /// 护照类型（P:普通因私护照、W:外交护照、G:公务护照）（英文）。 
        /// </summary>
        [JsonProperty("passport_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PassportType { get; set; }

        /// <summary>
        /// 护照签发国的国家码（英文）。 
        /// </summary>
        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        /// <summary>
        /// 护照号码（英文）。 
        /// </summary>
        [JsonProperty("passport_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PassportNumber { get; set; }

        /// <summary>
        /// 护照持有人国籍（英文）。 
        /// </summary>
        [JsonProperty("nationality", NullValueHandling = NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        /// <summary>
        /// 姓（英文）。 
        /// </summary>
        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        public string Surname { get; set; }

        /// <summary>
        /// 名字（英文）。 
        /// </summary>
        [JsonProperty("given_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GivenName { get; set; }

        /// <summary>
        /// 性别（英文）。 
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 出生日期（英文）。 
        /// </summary>
        [JsonProperty("date_of_birth", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// 护照有效期（英文）。 
        /// </summary>
        [JsonProperty("date_of_expiry", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfExpiry { get; set; }

        /// <summary>
        /// 护照签发日期（英文）。 
        /// </summary>
        [JsonProperty("date_of_issue", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOfIssue { get; set; }

        /// <summary>
        /// 出生地（英文）。 
        /// </summary>
        [JsonProperty("place_of_birth", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// 签发地（英文）。 
        /// </summary>
        [JsonProperty("place_of_issue", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaceOfIssue { get; set; }

        /// <summary>
        /// 签发机构（英文），其中对中国的英文简写统一输出为P.R.China。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }

        /// <summary>
        /// 默认为空。对于部分常见国家的护照OCR服务，extra_info内会包含护照上由本地官方语言描述的字段信息及其他信息。 如中国护照，里面会包含汉字表达的姓名、出生地等信息。 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExtraInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PassportResult {\n");
            sb.Append("  passportType: ").Append(PassportType).Append("\n");
            sb.Append("  countryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  passportNumber: ").Append(PassportNumber).Append("\n");
            sb.Append("  nationality: ").Append(Nationality).Append("\n");
            sb.Append("  surname: ").Append(Surname).Append("\n");
            sb.Append("  givenName: ").Append(GivenName).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  dateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  dateOfExpiry: ").Append(DateOfExpiry).Append("\n");
            sb.Append("  dateOfIssue: ").Append(DateOfIssue).Append("\n");
            sb.Append("  placeOfBirth: ").Append(PlaceOfBirth).Append("\n");
            sb.Append("  placeOfIssue: ").Append(PlaceOfIssue).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PassportResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PassportResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassportType == input.PassportType ||
                    (this.PassportType != null &&
                    this.PassportType.Equals(input.PassportType))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.PassportNumber == input.PassportNumber ||
                    (this.PassportNumber != null &&
                    this.PassportNumber.Equals(input.PassportNumber))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.Sex == input.Sex ||
                    (this.Sex != null &&
                    this.Sex.Equals(input.Sex))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.DateOfExpiry == input.DateOfExpiry ||
                    (this.DateOfExpiry != null &&
                    this.DateOfExpiry.Equals(input.DateOfExpiry))
                ) && 
                (
                    this.DateOfIssue == input.DateOfIssue ||
                    (this.DateOfIssue != null &&
                    this.DateOfIssue.Equals(input.DateOfIssue))
                ) && 
                (
                    this.PlaceOfBirth == input.PlaceOfBirth ||
                    (this.PlaceOfBirth != null &&
                    this.PlaceOfBirth.Equals(input.PlaceOfBirth))
                ) && 
                (
                    this.PlaceOfIssue == input.PlaceOfIssue ||
                    (this.PlaceOfIssue != null &&
                    this.PlaceOfIssue.Equals(input.PlaceOfIssue))
                ) && 
                (
                    this.IssuingAuthority == input.IssuingAuthority ||
                    (this.IssuingAuthority != null &&
                    this.IssuingAuthority.Equals(input.IssuingAuthority))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.ExtraInfo == input.ExtraInfo ||
                    (this.ExtraInfo != null &&
                    this.ExtraInfo.Equals(input.ExtraInfo))
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
                if (this.PassportType != null)
                    hashCode = hashCode * 59 + this.PassportType.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PassportNumber != null)
                    hashCode = hashCode * 59 + this.PassportNumber.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.Sex != null)
                    hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.DateOfExpiry != null)
                    hashCode = hashCode * 59 + this.DateOfExpiry.GetHashCode();
                if (this.DateOfIssue != null)
                    hashCode = hashCode * 59 + this.DateOfIssue.GetHashCode();
                if (this.PlaceOfBirth != null)
                    hashCode = hashCode * 59 + this.PlaceOfBirth.GetHashCode();
                if (this.PlaceOfIssue != null)
                    hashCode = hashCode * 59 + this.PlaceOfIssue.GetHashCode();
                if (this.IssuingAuthority != null)
                    hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.ExtraInfo != null)
                    hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
