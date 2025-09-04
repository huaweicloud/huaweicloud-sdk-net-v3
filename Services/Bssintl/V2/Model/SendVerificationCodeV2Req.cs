using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SendVerificationCodeV2Req 
    {

        /// <summary>
        /// 发送验证码的类型： 2：发送邮件验证码
        /// </summary>
        [JsonProperty("receiver_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReceiverType { get; set; }

        /// <summary>
        /// 发送验证码的超时时间。 如果不填的话，采用系统默认超时时间5分钟。 单位：分钟
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 指定发送验证码的邮箱地址。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 根据该参数的取值选择发送邮件验证码的语言。 zh-cn：中文en-us：英文
        /// </summary>
        [JsonProperty("lang", NullValueHandling = NullValueHandling.Ignore)]
        public string Lang { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendVerificationCodeV2Req {\n");
            sb.Append("  receiverType: ").Append(ReceiverType).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  lang: ").Append(Lang).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendVerificationCodeV2Req);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendVerificationCodeV2Req input)
        {
            if (input == null) return false;
            if (this.ReceiverType != input.ReceiverType || (this.ReceiverType != null && !this.ReceiverType.Equals(input.ReceiverType))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Email != input.Email || (this.Email != null && !this.Email.Equals(input.Email))) return false;
            if (this.Lang != input.Lang || (this.Lang != null && !this.Lang.Equals(input.Lang))) return false;

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
                if (this.ReceiverType != null) hashCode = hashCode * 59 + this.ReceiverType.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Email != null) hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Lang != null) hashCode = hashCode * 59 + this.Lang.GetHashCode();
                return hashCode;
            }
        }
    }
}
