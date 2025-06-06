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
    /// 辅助认证配置信息。
    /// </summary>
    public class AssistAuthConfigInfo 
    {

        /// <summary>
        /// 当前激活的辅助认证类型。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("otp_config_info", NullValueHandling = NullValueHandling.Ignore)]
        public OtpConfigInfo OtpConfigInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistAuthConfigInfo {\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  otpConfigInfo: ").Append(OtpConfigInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssistAuthConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssistAuthConfigInfo input)
        {
            if (input == null) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.OtpConfigInfo != input.OtpConfigInfo || (this.OtpConfigInfo != null && !this.OtpConfigInfo.Equals(input.OtpConfigInfo))) return false;

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
                if (this.AuthType != null) hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.OtpConfigInfo != null) hashCode = hashCode * 59 + this.OtpConfigInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
