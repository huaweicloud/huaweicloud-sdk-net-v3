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
    public class IdcardFrontVerificationResult 
    {

        /// <summary>
        /// 身份证号规则校验是否通过。 - true：表示身份证号规则校验通过。 - false：表示身份证号规则校验不通过。 当识别结果为单页，身份证图片是国徽面时，默认是false。输入参数side为double_side时，该字典仅在front字段中存在。 仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_number", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidNumber { get; set; }

        /// <summary>
        /// 出生日期与身份证号所表示的出生日期是否一致。 - true：出生日期与身份证号所表示的出生日期一致。 - false：出生日期与身份证号所表示的出生日期不一致。 当识别结果为单页，身份证图片是国徽面，或者身份证号规则校验不通过时，默认是false。输入参数side为double_side时，该字段仅在front字典中存在。 仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_birth", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidBirth { get; set; }

        /// <summary>
        /// 性别与身份证号所表示的性别信息是否一致。 -true：性别与身份证号所表示的性别信息一致 -false：性别与身份证号所表示的性别信息不一致。 当识别结果为单页，身份证图片是国徽面，或者身份证号规则校验不通过时，默认是false。输入参数side为double_side时，该字段仅在front字典中存在。 仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_sex", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidSex { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdcardFrontVerificationResult {\n");
            sb.Append("  validNumber: ").Append(ValidNumber).Append("\n");
            sb.Append("  validBirth: ").Append(ValidBirth).Append("\n");
            sb.Append("  validSex: ").Append(ValidSex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdcardFrontVerificationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdcardFrontVerificationResult input)
        {
            if (input == null) return false;
            if (this.ValidNumber != input.ValidNumber || (this.ValidNumber != null && !this.ValidNumber.Equals(input.ValidNumber))) return false;
            if (this.ValidBirth != input.ValidBirth || (this.ValidBirth != null && !this.ValidBirth.Equals(input.ValidBirth))) return false;
            if (this.ValidSex != input.ValidSex || (this.ValidSex != null && !this.ValidSex.Equals(input.ValidSex))) return false;

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
                if (this.ValidNumber != null) hashCode = hashCode * 59 + this.ValidNumber.GetHashCode();
                if (this.ValidBirth != null) hashCode = hashCode * 59 + this.ValidBirth.GetHashCode();
                if (this.ValidSex != null) hashCode = hashCode * 59 + this.ValidSex.GetHashCode();
                return hashCode;
            }
        }
    }
}
