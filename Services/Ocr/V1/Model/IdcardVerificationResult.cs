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
    /// 校验信息。仅在输入参数return_verification为true时，返回该字段，该字段包含valid_number、valid_birth、valid_sex和valid_date的校验信息。
    /// </summary>
    public class IdcardVerificationResult 
    {

        /// <summary>
        /// 身份证号规则校验是否通过。“true”表示身份证号规则校验通过，“false”表示身份证号规则校验不通过。当身份证图片是国徽面时，默认是false。仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_number", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidNumber { get; set; }

        /// <summary>
        /// 出生日期与身份证号所表示的出生日期是否一致。“true”表示一致，“false”表示不一致。当身份证图片是国徽面，或者身份证号规则校验不通过时，默认是false。仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_birth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidBirth { get; set; }

        /// <summary>
        /// 性别与身份证号所表示的性别信息是否一致。“true”表示一致，“false”表示不一致。当身份证图片是国徽面，或者身份证号规则校验不通过时，默认是false。仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_sex", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidSex { get; set; }

        /// <summary>
        /// 当前日期是否在有效期内。“true”表示当前日期在有效期内，“false”表示当前日期不在有效期内。当身份证图片是人像面时，默认是false。仅在输入参数return_verification为true时，返回该字段。 
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
