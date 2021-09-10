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
    /// 校验信息。仅在输入参数return_verification为true时返回该字段。
    /// </summary>
    public class IdcardVerificationResult 
    {

        /// <summary>
        /// 身份证号合法。校验规则为：将身份证号前17位数字分别乘以7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2，再求和，求和结果对11取模，取模结果作为数组[1,0,X,9,8,7,6,5,4,3,2]的下标，从里面取出一位结果，例如取模结果为0，则从数组里取出来的结果是1，最后判断从数组里面取出来的结果是否和身份证号最后一位是否一致。如果一致，代表身份证号合法，返回true，否则代表身份证号不合法，返回false。  当身份证图片是背面时，默认是false。 
        /// </summary>
        [JsonProperty("valid_number", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidNumber { get; set; }

        /// <summary>
        /// 身份证号与出生日期一致。出生日期和身份证号的第7位和第13位之间表示的出生日期是否一致。一致返回true，否则返回false。  当身份证图片是背面时，默认是false。 
        /// </summary>
        [JsonProperty("valid_birth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidBirth { get; set; }

        /// <summary>
        /// 身份证号与性别一致。性别和身份证号的第17位表示的性别信息是否一致。身份证号的第17位如果为奇数表示男性，偶数表示男性。一致返回true，否则返回false。  当身份证图片是背面时，默认是false。 
        /// </summary>
        [JsonProperty("valid_sex", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidSex { get; set; }

        /// <summary>
        /// 当前日期在有效期内。当前日期在身份证有效期内返回true，否则返回false。  当身份证图片是正面时，默认是false。 
        /// </summary>
        [JsonProperty("valid_date", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidDate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdcardVerificationResult {\n");
            sb.Append("  validNumber: ").Append(ValidNumber).Append("\n");
            sb.Append("  validBirth: ").Append(ValidBirth).Append("\n");
            sb.Append("  validSex: ").Append(ValidSex).Append("\n");
            sb.Append("  validDate: ").Append(ValidDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdcardVerificationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdcardVerificationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidNumber == input.ValidNumber ||
                    (this.ValidNumber != null &&
                    this.ValidNumber.Equals(input.ValidNumber))
                ) && 
                (
                    this.ValidBirth == input.ValidBirth ||
                    (this.ValidBirth != null &&
                    this.ValidBirth.Equals(input.ValidBirth))
                ) && 
                (
                    this.ValidSex == input.ValidSex ||
                    (this.ValidSex != null &&
                    this.ValidSex.Equals(input.ValidSex))
                ) && 
                (
                    this.ValidDate == input.ValidDate ||
                    (this.ValidDate != null &&
                    this.ValidDate.Equals(input.ValidDate))
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
                if (this.ValidNumber != null)
                    hashCode = hashCode * 59 + this.ValidNumber.GetHashCode();
                if (this.ValidBirth != null)
                    hashCode = hashCode * 59 + this.ValidBirth.GetHashCode();
                if (this.ValidSex != null)
                    hashCode = hashCode * 59 + this.ValidSex.GetHashCode();
                if (this.ValidDate != null)
                    hashCode = hashCode * 59 + this.ValidDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
