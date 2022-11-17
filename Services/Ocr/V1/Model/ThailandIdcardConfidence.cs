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
    public class ThailandIdcardConfidence 
    {

        /// <summary>
        /// 身份证号置信度。 
        /// </summary>
        [JsonProperty("id_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? IdNumber { get; set; }

        /// <summary>
        /// 泰文名字置信度。 
        /// </summary>
        [JsonProperty("name_th", NullValueHandling = NullValueHandling.Ignore)]
        public float? NameTh { get; set; }

        /// <summary>
        /// 英文名字置信度。 
        /// </summary>
        [JsonProperty("first_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? FirstNameEn { get; set; }

        /// <summary>
        /// 英文姓氏置信度。 
        /// </summary>
        [JsonProperty("last_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? LastNameEn { get; set; }

        /// <summary>
        /// 泰文出生日期置信度。 
        /// </summary>
        [JsonProperty("date_of_birth_th", NullValueHandling = NullValueHandling.Ignore)]
        public float? DateOfBirthTh { get; set; }

        /// <summary>
        /// 英文出生日期置信度。 
        /// </summary>
        [JsonProperty("date_of_birth_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? DateOfBirthEn { get; set; }

        /// <summary>
        /// 宗教置信度。 
        /// </summary>
        [JsonProperty("religion_th", NullValueHandling = NullValueHandling.Ignore)]
        public float? ReligionTh { get; set; }

        /// <summary>
        /// 地址置信度。 
        /// </summary>
        [JsonProperty("address_th", NullValueHandling = NullValueHandling.Ignore)]
        public float? AddressTh { get; set; }

        /// <summary>
        /// 泰文签发日期置信度。 
        /// </summary>
        [JsonProperty("date_of_issue_th", NullValueHandling = NullValueHandling.Ignore)]
        public float? DateOfIssueTh { get; set; }

        /// <summary>
        /// 英文签发日期置信度。 
        /// </summary>
        [JsonProperty("date_of_issue_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? DateOfIssueEn { get; set; }

        /// <summary>
        /// 泰文有效期置信度。 
        /// </summary>
        [JsonProperty("date_of_expiry_th", NullValueHandling = NullValueHandling.Ignore)]
        public float? DateOfExpiryTh { get; set; }

        /// <summary>
        /// 英文有效期置信度。 
        /// </summary>
        [JsonProperty("date_of_expiry_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? DateOfExpiryEn { get; set; }

        /// <summary>
        /// 序列号置信度。 
        /// </summary>
        [JsonProperty("serial_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? SerialNumber { get; set; }

        /// <summary>
        /// 身份证反面卡号置信度。 
        /// </summary>
        [JsonProperty("card_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? CardNumber { get; set; }

        /// <summary>
        /// 激光码置信度。 
        /// </summary>
        [JsonProperty("laser_number", NullValueHandling = NullValueHandling.Ignore)]
        public float? LaserNumber { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThailandIdcardConfidence {\n");
            sb.Append("  idNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  nameTh: ").Append(NameTh).Append("\n");
            sb.Append("  firstNameEn: ").Append(FirstNameEn).Append("\n");
            sb.Append("  lastNameEn: ").Append(LastNameEn).Append("\n");
            sb.Append("  dateOfBirthTh: ").Append(DateOfBirthTh).Append("\n");
            sb.Append("  dateOfBirthEn: ").Append(DateOfBirthEn).Append("\n");
            sb.Append("  religionTh: ").Append(ReligionTh).Append("\n");
            sb.Append("  addressTh: ").Append(AddressTh).Append("\n");
            sb.Append("  dateOfIssueTh: ").Append(DateOfIssueTh).Append("\n");
            sb.Append("  dateOfIssueEn: ").Append(DateOfIssueEn).Append("\n");
            sb.Append("  dateOfExpiryTh: ").Append(DateOfExpiryTh).Append("\n");
            sb.Append("  dateOfExpiryEn: ").Append(DateOfExpiryEn).Append("\n");
            sb.Append("  serialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  cardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  laserNumber: ").Append(LaserNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThailandIdcardConfidence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThailandIdcardConfidence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.NameTh == input.NameTh ||
                    (this.NameTh != null &&
                    this.NameTh.Equals(input.NameTh))
                ) && 
                (
                    this.FirstNameEn == input.FirstNameEn ||
                    (this.FirstNameEn != null &&
                    this.FirstNameEn.Equals(input.FirstNameEn))
                ) && 
                (
                    this.LastNameEn == input.LastNameEn ||
                    (this.LastNameEn != null &&
                    this.LastNameEn.Equals(input.LastNameEn))
                ) && 
                (
                    this.DateOfBirthTh == input.DateOfBirthTh ||
                    (this.DateOfBirthTh != null &&
                    this.DateOfBirthTh.Equals(input.DateOfBirthTh))
                ) && 
                (
                    this.DateOfBirthEn == input.DateOfBirthEn ||
                    (this.DateOfBirthEn != null &&
                    this.DateOfBirthEn.Equals(input.DateOfBirthEn))
                ) && 
                (
                    this.ReligionTh == input.ReligionTh ||
                    (this.ReligionTh != null &&
                    this.ReligionTh.Equals(input.ReligionTh))
                ) && 
                (
                    this.AddressTh == input.AddressTh ||
                    (this.AddressTh != null &&
                    this.AddressTh.Equals(input.AddressTh))
                ) && 
                (
                    this.DateOfIssueTh == input.DateOfIssueTh ||
                    (this.DateOfIssueTh != null &&
                    this.DateOfIssueTh.Equals(input.DateOfIssueTh))
                ) && 
                (
                    this.DateOfIssueEn == input.DateOfIssueEn ||
                    (this.DateOfIssueEn != null &&
                    this.DateOfIssueEn.Equals(input.DateOfIssueEn))
                ) && 
                (
                    this.DateOfExpiryTh == input.DateOfExpiryTh ||
                    (this.DateOfExpiryTh != null &&
                    this.DateOfExpiryTh.Equals(input.DateOfExpiryTh))
                ) && 
                (
                    this.DateOfExpiryEn == input.DateOfExpiryEn ||
                    (this.DateOfExpiryEn != null &&
                    this.DateOfExpiryEn.Equals(input.DateOfExpiryEn))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.LaserNumber == input.LaserNumber ||
                    (this.LaserNumber != null &&
                    this.LaserNumber.Equals(input.LaserNumber))
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
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.NameTh != null)
                    hashCode = hashCode * 59 + this.NameTh.GetHashCode();
                if (this.FirstNameEn != null)
                    hashCode = hashCode * 59 + this.FirstNameEn.GetHashCode();
                if (this.LastNameEn != null)
                    hashCode = hashCode * 59 + this.LastNameEn.GetHashCode();
                if (this.DateOfBirthTh != null)
                    hashCode = hashCode * 59 + this.DateOfBirthTh.GetHashCode();
                if (this.DateOfBirthEn != null)
                    hashCode = hashCode * 59 + this.DateOfBirthEn.GetHashCode();
                if (this.ReligionTh != null)
                    hashCode = hashCode * 59 + this.ReligionTh.GetHashCode();
                if (this.AddressTh != null)
                    hashCode = hashCode * 59 + this.AddressTh.GetHashCode();
                if (this.DateOfIssueTh != null)
                    hashCode = hashCode * 59 + this.DateOfIssueTh.GetHashCode();
                if (this.DateOfIssueEn != null)
                    hashCode = hashCode * 59 + this.DateOfIssueEn.GetHashCode();
                if (this.DateOfExpiryTh != null)
                    hashCode = hashCode * 59 + this.DateOfExpiryTh.GetHashCode();
                if (this.DateOfExpiryEn != null)
                    hashCode = hashCode * 59 + this.DateOfExpiryEn.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.CardNumber != null)
                    hashCode = hashCode * 59 + this.CardNumber.GetHashCode();
                if (this.LaserNumber != null)
                    hashCode = hashCode * 59 + this.LaserNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
