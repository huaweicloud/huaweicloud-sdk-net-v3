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
    /// 
    /// </summary>
    public class VerifyCodeSendDTOV1 
    {

        /// <summary>
        /// 用户身份信息（手机号码或邮箱帐号或用户真实帐号）。 &gt; 必须和发送滑块验证码时带的用户身份信息相同。 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 验证码发送方式。 user类型是用户真实帐号时必选；如果没有选择的话，优先短信方式。 * sms：短信方式 * email：邮件方式 
        /// </summary>
        [JsonProperty("sendMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string SendMethod { get; set; }

        /// <summary>
        /// 访问Token字符串。通过[[校验滑块验证码](https://support.huaweicloud.com/api-meeting/meeting_21_0101.html)](tag:hws)[[校验滑块验证码](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0101.html)](tag:hk) 接口获取。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyCodeSendDTOV1 {\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  sendMethod: ").Append(SendMethod).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyCodeSendDTOV1);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyCodeSendDTOV1 input)
        {
            if (input == null) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.SendMethod != input.SendMethod || (this.SendMethod != null && !this.SendMethod.Equals(input.SendMethod))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;

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
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.SendMethod != null) hashCode = hashCode * 59 + this.SendMethod.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                return hashCode;
            }
        }
    }
}
