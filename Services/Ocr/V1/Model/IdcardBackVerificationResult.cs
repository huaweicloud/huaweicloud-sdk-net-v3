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
    public class IdcardBackVerificationResult 
    {

        /// <summary>
        /// 当前日期是否在有效期内。 - true：表示当前日期在有效期内。 - false：表示当前日期不在有效期内。 当识别结果为单页，身份证图片是人像面时，默认是false。输入参数side为double_side时，该字段仅在back字典中存在。 仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_date", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidDate { get; set; }

        /// <summary>
        /// 身份证有效日期是否合法。 - true：表示身份证的有效日期合法 - false：表示身份证有效日期非法 当识别结果为单页，身份证图片是人像面时，默认是false。输入参数side为double_side时，该字段仅在back字典中存在。 仅在输入参数return_verification为true时，返回该字段。 
        /// </summary>
        [JsonProperty("valid_validity_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidValidityPeriod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdcardBackVerificationResult {\n");
            sb.Append("  validDate: ").Append(ValidDate).Append("\n");
            sb.Append("  validValidityPeriod: ").Append(ValidValidityPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IdcardBackVerificationResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IdcardBackVerificationResult input)
        {
            if (input == null) return false;
            if (this.ValidDate != input.ValidDate || (this.ValidDate != null && !this.ValidDate.Equals(input.ValidDate))) return false;
            if (this.ValidValidityPeriod != input.ValidValidityPeriod || (this.ValidValidityPeriod != null && !this.ValidValidityPeriod.Equals(input.ValidValidityPeriod))) return false;

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
                if (this.ValidDate != null) hashCode = hashCode * 59 + this.ValidDate.GetHashCode();
                if (this.ValidValidityPeriod != null) hashCode = hashCode * 59 + this.ValidValidityPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
