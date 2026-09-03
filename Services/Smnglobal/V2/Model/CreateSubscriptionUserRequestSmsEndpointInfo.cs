using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smnglobal.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSubscriptionUserRequestSmsEndpointInfo 
    {

        /// <summary>
        /// 终端地址。必须是一个电话号码。
        /// </summary>
        [JsonProperty("endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Endpoint { get; set; }

        /// <summary>
        /// 是否启用验证码，默认为false。当protocol值为sms或callnotify，且该字段值设置为true时，发送订阅确认短信为验证码格式；该字段为false或者不存在时，发送的订阅确认短信为超链接格式。当protocol值为其他协议时，该字段不生效
        /// </summary>
        [JsonProperty("verification_code_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VerificationCodeEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSubscriptionUserRequestSmsEndpointInfo {\n");
            sb.Append("  endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  verificationCodeEnabled: ").Append(VerificationCodeEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSubscriptionUserRequestSmsEndpointInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSubscriptionUserRequestSmsEndpointInfo input)
        {
            if (input == null) return false;
            if (this.Endpoint != input.Endpoint || (this.Endpoint != null && !this.Endpoint.Equals(input.Endpoint))) return false;
            if (this.VerificationCodeEnabled != input.VerificationCodeEnabled || (this.VerificationCodeEnabled != null && !this.VerificationCodeEnabled.Equals(input.VerificationCodeEnabled))) return false;

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
                if (this.Endpoint != null) hashCode = hashCode * 59 + this.Endpoint.GetHashCode();
                if (this.VerificationCodeEnabled != null) hashCode = hashCode * 59 + this.VerificationCodeEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
