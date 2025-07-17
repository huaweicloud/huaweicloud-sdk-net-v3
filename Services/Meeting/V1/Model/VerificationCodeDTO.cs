using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 验证码信息。
    /// </summary>
    public class VerificationCodeDTO 
    {

        /// <summary>
        /// 后台自动识别是手机号还是邮箱。 如果为手机号，必须加上国家码，例如中国大陆手机为“+86xxxxxxxxxxx”，当填写手机号时 “country”参数必填。 
        /// </summary>
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        /// <summary>
        /// 验证码，在校验的场景时需要携带。
        /// </summary>
        [JsonProperty("verificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationCode { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerificationCodeDTO {\n");
            sb.Append("  contact: ").Append(Contact).Append("\n");
            sb.Append("  verificationCode: ").Append(VerificationCode).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerificationCodeDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerificationCodeDTO input)
        {
            if (input == null) return false;
            if (this.Contact != input.Contact || (this.Contact != null && !this.Contact.Equals(input.Contact))) return false;
            if (this.VerificationCode != input.VerificationCode || (this.VerificationCode != null && !this.VerificationCode.Equals(input.VerificationCode))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;

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
                if (this.Contact != null) hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.VerificationCode != null) hashCode = hashCode * 59 + this.VerificationCode.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                return hashCode;
            }
        }
    }
}
