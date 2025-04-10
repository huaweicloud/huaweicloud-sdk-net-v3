using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterOIDC.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateTokenReqBody 
    {
        /// <summary>
        /// 请求的授权类型。支持授权码、设备代码、客户端凭证和刷新令牌等授权类型
        /// </summary>
        /// <value>请求的授权类型。支持授权码、设备代码、客户端凭证和刷新令牌等授权类型</value>
        [JsonConverter(typeof(EnumClassConverter<GrantTypeEnum>))]
        public class GrantTypeEnum
        {
            /// <summary>
            /// Enum AUTHORIZATION_CODE for value: authorization_code
            /// </summary>
            public static readonly GrantTypeEnum AUTHORIZATION_CODE = new GrantTypeEnum("authorization_code");

            /// <summary>
            /// Enum URN_IETF_PARAMS_OAUTH_GRANT_TYPE_DEVICE_CODE for value: urn:ietf:params:oauth:grant-type:device_code
            /// </summary>
            public static readonly GrantTypeEnum URN_IETF_PARAMS_OAUTH_GRANT_TYPE_DEVICE_CODE = new GrantTypeEnum("urn:ietf:params:oauth:grant-type:device_code");

            private static readonly Dictionary<string, GrantTypeEnum> StaticFields =
            new Dictionary<string, GrantTypeEnum>()
            {
                { "authorization_code", AUTHORIZATION_CODE },
                { "urn:ietf:params:oauth:grant-type:device_code", URN_IETF_PARAMS_OAUTH_GRANT_TYPE_DEVICE_CODE },
            };

            private string _value;

            public GrantTypeEnum()
            {

            }

            public GrantTypeEnum(string value)
            {
                _value = value;
            }

            public static GrantTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as GrantTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GrantTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GrantTypeEnum a, GrantTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(GrantTypeEnum a, GrantTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 客户端的唯一标识
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// 为客户端生成的秘密字符串。客户端将使用此字符串在后续调用中获得服务的身份验证
        /// </summary>
        [JsonProperty("client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 从授权服务接收的授权代码。执行授权授予请求以获取对令牌的访问权限时需要此参数
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 仅在为设备代码授权类型调用此API时使用
        /// </summary>
        [JsonProperty("device_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 请求的授权类型。支持授权码、设备代码、客户端凭证和刷新令牌等授权类型
        /// </summary>
        [JsonProperty("grant_type", NullValueHandling = NullValueHandling.Ignore)]
        public GrantTypeEnum GrantType { get; set; }
        /// <summary>
        /// 将接收授权代码的应用程序的位置。用户授权服务将请求发送到此位置
        /// </summary>
        [JsonProperty("redirect_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 刷新令牌，此令牌可在访问令牌过期后获取新的访问令牌
        /// </summary>
        [JsonProperty("refresh_token", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 客户端定义的作用域列表，表示客户端想要获取的权限。授权后，此列表用于在授予访问令牌时限制权限
        /// </summary>
        [JsonProperty("scopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Scopes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTokenReqBody {\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  clientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  deviceCode: ").Append(DeviceCode).Append("\n");
            sb.Append("  grantType: ").Append(GrantType).Append("\n");
            sb.Append("  redirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  refreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  scopes: ").Append(Scopes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTokenReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTokenReqBody input)
        {
            if (input == null) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.ClientSecret != input.ClientSecret || (this.ClientSecret != null && !this.ClientSecret.Equals(input.ClientSecret))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.DeviceCode != input.DeviceCode || (this.DeviceCode != null && !this.DeviceCode.Equals(input.DeviceCode))) return false;
            if (this.GrantType != input.GrantType) return false;
            if (this.RedirectUri != input.RedirectUri || (this.RedirectUri != null && !this.RedirectUri.Equals(input.RedirectUri))) return false;
            if (this.RefreshToken != input.RefreshToken || (this.RefreshToken != null && !this.RefreshToken.Equals(input.RefreshToken))) return false;
            if (this.Scopes != input.Scopes || (this.Scopes != null && input.Scopes != null && !this.Scopes.SequenceEqual(input.Scopes))) return false;

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
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null) hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DeviceCode != null) hashCode = hashCode * 59 + this.DeviceCode.GetHashCode();
                hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.RedirectUri != null) hashCode = hashCode * 59 + this.RedirectUri.GetHashCode();
                if (this.RefreshToken != null) hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.Scopes != null) hashCode = hashCode * 59 + this.Scopes.GetHashCode();
                return hashCode;
            }
        }
    }
}
