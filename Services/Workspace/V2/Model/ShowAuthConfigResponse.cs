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
    public class ShowAuthConfigResponse : SdkResponse
    {

        /// <summary>
        /// 认证类型 LOCAL_PASSWORD：本地密码认证模式 KERBEROS：Windows AD认证模式 LDAP：第三方LDAP模式 CLIENT_TOKEN：金审UKEY客户端Token认证模式 OAUTH2：第三方单点登录模式
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// 当前状态。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("radius_gateway_config", NullValueHandling = NullValueHandling.Ignore)]
        public RadiusGatewayConfigInfo RadiusGatewayConfig { get; set; }

        /// <summary>
        /// 第三方认证接口配置信息。
        /// </summary>
        [JsonProperty("third_party_auth_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<ThirdPartyAuthConfig> ThirdPartyAuthConfig { get; set; }

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
            sb.Append("class ShowAuthConfigResponse {\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
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
            return this.Equals(input as ShowAuthConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuthConfigResponse input)
        {
            if (input == null) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.RadiusGatewayConfig != input.RadiusGatewayConfig || (this.RadiusGatewayConfig != null && !this.RadiusGatewayConfig.Equals(input.RadiusGatewayConfig))) return false;
            if (this.ThirdPartyAuthConfig != input.ThirdPartyAuthConfig || (this.ThirdPartyAuthConfig != null && input.ThirdPartyAuthConfig != null && !this.ThirdPartyAuthConfig.SequenceEqual(input.ThirdPartyAuthConfig))) return false;
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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.RadiusGatewayConfig != null) hashCode = hashCode * 59 + this.RadiusGatewayConfig.GetHashCode();
                if (this.ThirdPartyAuthConfig != null) hashCode = hashCode * 59 + this.ThirdPartyAuthConfig.GetHashCode();
                if (this.EmergencyLoginMode != null) hashCode = hashCode * 59 + this.EmergencyLoginMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
