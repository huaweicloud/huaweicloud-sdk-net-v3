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
    /// 辅助认证策略请求
    /// </summary>
    public class AssistAuthMethodConfigRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthAssistEnum AuthType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("otp_config_info", NullValueHandling = NullValueHandling.Ignore)]
        public OtpConfigInfo OtpConfigInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("radius_auth_config", NullValueHandling = NullValueHandling.Ignore)]
        public RadiusAuthConfig RadiusAuthConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("radius_gateway_config", NullValueHandling = NullValueHandling.Ignore)]
        public RadiusGatewayConfig RadiusGatewayConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssistAuthMethodConfigRequest {\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  otpConfigInfo: ").Append(OtpConfigInfo).Append("\n");
            sb.Append("  radiusAuthConfig: ").Append(RadiusAuthConfig).Append("\n");
            sb.Append("  radiusGatewayConfig: ").Append(RadiusGatewayConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssistAuthMethodConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssistAuthMethodConfigRequest input)
        {
            if (input == null) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.OtpConfigInfo != input.OtpConfigInfo || (this.OtpConfigInfo != null && !this.OtpConfigInfo.Equals(input.OtpConfigInfo))) return false;
            if (this.RadiusAuthConfig != input.RadiusAuthConfig || (this.RadiusAuthConfig != null && !this.RadiusAuthConfig.Equals(input.RadiusAuthConfig))) return false;
            if (this.RadiusGatewayConfig != input.RadiusGatewayConfig || (this.RadiusGatewayConfig != null && !this.RadiusGatewayConfig.Equals(input.RadiusGatewayConfig))) return false;

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
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.OtpConfigInfo != null) hashCode = hashCode * 59 + this.OtpConfigInfo.GetHashCode();
                if (this.RadiusAuthConfig != null) hashCode = hashCode * 59 + this.RadiusAuthConfig.GetHashCode();
                if (this.RadiusGatewayConfig != null) hashCode = hashCode * 59 + this.RadiusGatewayConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
