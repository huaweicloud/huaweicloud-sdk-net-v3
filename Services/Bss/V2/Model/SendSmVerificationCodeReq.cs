using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SendSmVerificationCodeReq 
    {

        /// <summary>
        /// 接受短信验证码的手机号码。
        /// </summary>
        [JsonProperty("mobile_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 超时时间，默认值为10分钟。 单位：分钟
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 发送的短信的语言。 zh-cn: 中文en-us: 英语 默认为偏好设置的默认语言。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 短信发送模板中的变量，具体参见表1。
        /// </summary>
        [JsonProperty("sm_template_args", NullValueHandling = NullValueHandling.Ignore)]
        public List<TemplateArgs> SmTemplateArgs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendSmVerificationCodeReq {\n");
            sb.Append("  mobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  smTemplateArgs: ").Append(SmTemplateArgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendSmVerificationCodeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SendSmVerificationCodeReq input)
        {
            if (input == null) return false;
            if (this.MobilePhone != input.MobilePhone || (this.MobilePhone != null && !this.MobilePhone.Equals(input.MobilePhone))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.SmTemplateArgs != input.SmTemplateArgs || (this.SmTemplateArgs != null && input.SmTemplateArgs != null && !this.SmTemplateArgs.SequenceEqual(input.SmTemplateArgs))) return false;

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
                if (this.MobilePhone != null) hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SmTemplateArgs != null) hashCode = hashCode * 59 + this.SmTemplateArgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
