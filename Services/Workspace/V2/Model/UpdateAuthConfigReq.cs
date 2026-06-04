using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 增量更新认证配置请求。
    /// </summary>
    public class UpdateAuthConfigReq 
    {

        /// <summary>
        /// 是否开启短信登录。
        /// </summary>
        [JsonProperty("sms_login_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SmsLoginEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAuthConfigReq {\n");
            sb.Append("  smsLoginEnabled: ").Append(SmsLoginEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAuthConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAuthConfigReq input)
        {
            if (input == null) return false;
            if (this.SmsLoginEnabled != input.SmsLoginEnabled || (this.SmsLoginEnabled != null && !this.SmsLoginEnabled.Equals(input.SmsLoginEnabled))) return false;

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
                if (this.SmsLoginEnabled != null) hashCode = hashCode * 59 + this.SmsLoginEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
