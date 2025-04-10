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
    public class RegisterClientReqBody 
    {
        /// <summary>
        /// 客户端的类型。该服务仅支持public作为客户端类型
        /// </summary>
        /// <value>客户端的类型。该服务仅支持public作为客户端类型</value>
        [JsonConverter(typeof(EnumClassConverter<ClientTypeEnum>))]
        public class ClientTypeEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly ClientTypeEnum PUBLIC = new ClientTypeEnum("public");

            private static readonly Dictionary<string, ClientTypeEnum> StaticFields =
            new Dictionary<string, ClientTypeEnum>()
            {
                { "public", PUBLIC },
            };

            private string _value;

            public ClientTypeEnum()
            {

            }

            public ClientTypeEnum(string value)
            {
                _value = value;
            }

            public static ClientTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ClientTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClientTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClientTypeEnum a, ClientTypeEnum b)
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

            public static bool operator !=(ClientTypeEnum a, ClientTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 向令牌端点发送请求时所需的身份验证方法
        /// </summary>
        /// <value>向令牌端点发送请求时所需的身份验证方法</value>
        [JsonConverter(typeof(EnumClassConverter<TokenEndpointAuthMethodEnum>))]
        public class TokenEndpointAuthMethodEnum
        {
            /// <summary>
            /// Enum CLIENT_SECRET_POST for value: client_secret_post
            /// </summary>
            public static readonly TokenEndpointAuthMethodEnum CLIENT_SECRET_POST = new TokenEndpointAuthMethodEnum("client_secret_post");

            private static readonly Dictionary<string, TokenEndpointAuthMethodEnum> StaticFields =
            new Dictionary<string, TokenEndpointAuthMethodEnum>()
            {
                { "client_secret_post", CLIENT_SECRET_POST },
            };

            private string _value;

            public TokenEndpointAuthMethodEnum()
            {

            }

            public TokenEndpointAuthMethodEnum(string value)
            {
                _value = value;
            }

            public static TokenEndpointAuthMethodEnum FromValue(string value)
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

                if (this.Equals(obj as TokenEndpointAuthMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TokenEndpointAuthMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TokenEndpointAuthMethodEnum a, TokenEndpointAuthMethodEnum b)
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

            public static bool operator !=(TokenEndpointAuthMethodEnum a, TokenEndpointAuthMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines grantTypes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<GrantTypesEnum>))]
        public class GrantTypesEnum
        {
            /// <summary>
            /// Enum URN_IETF_PARAMS_OAUTH_GRANT_TYPE_DEVICE_CODE for value: urn:ietf:params:oauth:grant-type:device_code
            /// </summary>
            public static readonly GrantTypesEnum URN_IETF_PARAMS_OAUTH_GRANT_TYPE_DEVICE_CODE = new GrantTypesEnum("urn:ietf:params:oauth:grant-type:device_code");

            /// <summary>
            /// Enum AUTHORIZATION_CODE for value: authorization_code
            /// </summary>
            public static readonly GrantTypesEnum AUTHORIZATION_CODE = new GrantTypesEnum("authorization_code");

            private static readonly Dictionary<string, GrantTypesEnum> StaticFields =
            new Dictionary<string, GrantTypesEnum>()
            {
                { "urn:ietf:params:oauth:grant-type:device_code", URN_IETF_PARAMS_OAUTH_GRANT_TYPE_DEVICE_CODE },
                { "authorization_code", AUTHORIZATION_CODE },
            };

            private string _value;

            public GrantTypesEnum()
            {

            }

            public GrantTypesEnum(string value)
            {
                _value = value;
            }

            public static GrantTypesEnum FromValue(string value)
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

                if (this.Equals(obj as GrantTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GrantTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GrantTypesEnum a, GrantTypesEnum b)
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

            public static bool operator !=(GrantTypesEnum a, GrantTypesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines responseTypes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ResponseTypesEnum>))]
        public class ResponseTypesEnum
        {
            /// <summary>
            /// Enum CODE for value: code
            /// </summary>
            public static readonly ResponseTypesEnum CODE = new ResponseTypesEnum("code");

            private static readonly Dictionary<string, ResponseTypesEnum> StaticFields =
            new Dictionary<string, ResponseTypesEnum>()
            {
                { "code", CODE },
            };

            private string _value;

            public ResponseTypesEnum()
            {

            }

            public ResponseTypesEnum(string value)
            {
                _value = value;
            }

            public static ResponseTypesEnum FromValue(string value)
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

                if (this.Equals(obj as ResponseTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResponseTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResponseTypesEnum a, ResponseTypesEnum b)
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

            public static bool operator !=(ResponseTypesEnum a, ResponseTypesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 客户端名称
        /// </summary>
        [JsonProperty("client_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        /// <summary>
        /// 客户端的类型。该服务仅支持public作为客户端类型
        /// </summary>
        [JsonProperty("client_type", NullValueHandling = NullValueHandling.Ignore)]
        public ClientTypeEnum ClientType { get; set; }
        /// <summary>
        /// 向令牌端点发送请求时所需的身份验证方法
        /// </summary>
        [JsonProperty("token_endpoint_auth_method", NullValueHandling = NullValueHandling.Ignore)]
        public TokenEndpointAuthMethodEnum TokenEndpointAuthMethod { get; set; }
        /// <summary>
        /// 客户端定义的作用域列表。授权后，此列表用于在授予访问令牌时限制权限
        /// </summary>
        [JsonProperty("scopes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// 客户端可以在令牌端点使用的OAuth2.0授权类型数组
        /// </summary>
        [JsonProperty("grant_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<GrantTypesEnum> GrantTypes { get; set; }
        /// <summary>
        /// 客户端可以在授权端点使用的OAuth2.0授权类型数组
        /// </summary>
        [JsonProperty("response_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResponseTypesEnum> ResponseTypes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterClientReqBody {\n");
            sb.Append("  clientName: ").Append(ClientName).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  tokenEndpointAuthMethod: ").Append(TokenEndpointAuthMethod).Append("\n");
            sb.Append("  scopes: ").Append(Scopes).Append("\n");
            sb.Append("  grantTypes: ").Append(GrantTypes).Append("\n");
            sb.Append("  responseTypes: ").Append(ResponseTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterClientReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterClientReqBody input)
        {
            if (input == null) return false;
            if (this.ClientName != input.ClientName || (this.ClientName != null && !this.ClientName.Equals(input.ClientName))) return false;
            if (this.ClientType != input.ClientType) return false;
            if (this.TokenEndpointAuthMethod != input.TokenEndpointAuthMethod) return false;
            if (this.Scopes != input.Scopes || (this.Scopes != null && input.Scopes != null && !this.Scopes.SequenceEqual(input.Scopes))) return false;
            if (this.GrantTypes != input.GrantTypes || (this.GrantTypes != null && input.GrantTypes != null && !this.GrantTypes.SequenceEqual(input.GrantTypes))) return false;
            if (this.ResponseTypes != input.ResponseTypes || (this.ResponseTypes != null && input.ResponseTypes != null && !this.ResponseTypes.SequenceEqual(input.ResponseTypes))) return false;

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
                if (this.ClientName != null) hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                hashCode = hashCode * 59 + this.TokenEndpointAuthMethod.GetHashCode();
                if (this.Scopes != null) hashCode = hashCode * 59 + this.Scopes.GetHashCode();
                hashCode = hashCode * 59 + this.GrantTypes.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
