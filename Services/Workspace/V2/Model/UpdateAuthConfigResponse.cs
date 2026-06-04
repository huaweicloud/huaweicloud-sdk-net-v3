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
    /// Response Object
    /// </summary>
    public class UpdateAuthConfigResponse : SdkResponse
    {

        /// <summary>
        /// 认证配置ID。
        /// </summary>
        [JsonProperty("auth_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthConfigId { get; set; }

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
            sb.Append("class UpdateAuthConfigResponse {\n");
            sb.Append("  authConfigId: ").Append(AuthConfigId).Append("\n");
            sb.Append("  smsLoginEnabled: ").Append(SmsLoginEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAuthConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAuthConfigResponse input)
        {
            if (input == null) return false;
            if (this.AuthConfigId != input.AuthConfigId || (this.AuthConfigId != null && !this.AuthConfigId.Equals(input.AuthConfigId))) return false;
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
                if (this.AuthConfigId != null) hashCode = hashCode * 59 + this.AuthConfigId.GetHashCode();
                if (this.SmsLoginEnabled != null) hashCode = hashCode * 59 + this.SmsLoginEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
