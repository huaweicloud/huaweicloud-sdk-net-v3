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
    /// 认证配置请求。
    /// </summary>
    public class AuthMethodConfigRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthTypeEnum? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("radius_gateway_config", NullValueHandling = NullValueHandling.Ignore)]
        public RadiusGatewayConfig RadiusGatewayConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("third_party_auth_config", NullValueHandling = NullValueHandling.Ignore)]
        public ThirdPartyAuthConfig ThirdPartyAuthConfig { get; set; }

        /// <summary>
        /// 应急登录模式。
        /// </summary>
        [JsonProperty("emergency_login_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string EmergencyLoginMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthMethodConfigRequest {\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  radiusGatewayConfig: ").Append(RadiusGatewayConfig).Append("\n");
            sb.Append("  thirdPartyAuthConfig: ").Append(ThirdPartyAuthConfig).Append("\n");
            sb.Append("  emergencyLoginMode: ").Append(EmergencyLoginMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthMethodConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthMethodConfigRequest input)
        {
            if (input == null) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.RadiusGatewayConfig != input.RadiusGatewayConfig || (this.RadiusGatewayConfig != null && !this.RadiusGatewayConfig.Equals(input.RadiusGatewayConfig))) return false;
            if (this.ThirdPartyAuthConfig != input.ThirdPartyAuthConfig || (this.ThirdPartyAuthConfig != null && !this.ThirdPartyAuthConfig.Equals(input.ThirdPartyAuthConfig))) return false;
            if (this.EmergencyLoginMode != input.EmergencyLoginMode || (this.EmergencyLoginMode != null && !this.EmergencyLoginMode.Equals(input.EmergencyLoginMode))) return false;

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
                if (this.RadiusGatewayConfig != null) hashCode = hashCode * 59 + this.RadiusGatewayConfig.GetHashCode();
                if (this.ThirdPartyAuthConfig != null) hashCode = hashCode * 59 + this.ThirdPartyAuthConfig.GetHashCode();
                if (this.EmergencyLoginMode != null) hashCode = hashCode * 59 + this.EmergencyLoginMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
