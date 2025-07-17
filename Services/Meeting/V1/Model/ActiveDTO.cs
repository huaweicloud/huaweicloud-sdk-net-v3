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
    /// 设备联系人信息。
    /// </summary>
    public class ActiveDTO 
    {

        /// <summary>
        /// 手机号。 例如中国大陆手机+86xxxxxxxxxxx。当填写手机号时 “country”参数必填。 &gt; 号码和邮箱必须填一个，若企业未开启短信功能，则邮箱必填。 
        /// </summary>
        [JsonProperty("smsNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsNumber { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 邮件地址。 &gt; 号码和邮箱必须填一个，若企业未开启短信功能，则邮箱必填。 
        /// </summary>
        [JsonProperty("emailAddr", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiveDTO {\n");
            sb.Append("  smsNumber: ").Append(SmsNumber).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  emailAddr: ").Append(EmailAddr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActiveDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActiveDTO input)
        {
            if (input == null) return false;
            if (this.SmsNumber != input.SmsNumber || (this.SmsNumber != null && !this.SmsNumber.Equals(input.SmsNumber))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.EmailAddr != input.EmailAddr || (this.EmailAddr != null && !this.EmailAddr.Equals(input.EmailAddr))) return false;

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
                if (this.SmsNumber != null) hashCode = hashCode * 59 + this.SmsNumber.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.EmailAddr != null) hashCode = hashCode * 59 + this.EmailAddr.GetHashCode();
                return hashCode;
            }
        }
    }
}
