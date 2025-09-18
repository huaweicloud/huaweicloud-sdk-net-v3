using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// oidc配置详细信息
    /// </summary>
    public class CreateOpenIdConnectConfig 
    {
        /// <summary>
        /// 授权请求返回的类型；id_token ；编程访问和管理控制台访问方式必选，编程访问方式不可选 
        /// </summary>
        /// <value>授权请求返回的类型；id_token ；编程访问和管理控制台访问方式必选，编程访问方式不可选 </value>
        [JsonConverter(typeof(EnumClassConverter<ResponseTypeEnum>))]
        public class ResponseTypeEnum
        {
            /// <summary>
            /// Enum ID_TOKEN for value: id_token
            /// </summary>
            public static readonly ResponseTypeEnum ID_TOKEN = new ResponseTypeEnum("id_token");

            private static readonly Dictionary<string, ResponseTypeEnum> StaticFields =
            new Dictionary<string, ResponseTypeEnum>()
            {
                { "id_token", ID_TOKEN },
            };

            private string _value;

            public ResponseTypeEnum()
            {

            }

            public ResponseTypeEnum(string value)
            {
                _value = value;
            }

            public static ResponseTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResponseTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResponseTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResponseTypeEnum a, ResponseTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ResponseTypeEnum a, ResponseTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 授权请求返回方式， form_post 或 fragment ；编程访问和管理控制台访问方式必选，编程访问方式不可选
        /// </summary>
        /// <value>授权请求返回方式， form_post 或 fragment ；编程访问和管理控制台访问方式必选，编程访问方式不可选</value>
        [JsonConverter(typeof(EnumClassConverter<ResponseModeEnum>))]
        public class ResponseModeEnum
        {
            /// <summary>
            /// Enum FRAGMENT for value: fragment
            /// </summary>
            public static readonly ResponseModeEnum FRAGMENT = new ResponseModeEnum("fragment");

            /// <summary>
            /// Enum FORM_POST for value: form_post
            /// </summary>
            public static readonly ResponseModeEnum FORM_POST = new ResponseModeEnum("form_post");

            private static readonly Dictionary<string, ResponseModeEnum> StaticFields =
            new Dictionary<string, ResponseModeEnum>()
            {
                { "fragment", FRAGMENT },
                { "form_post", FORM_POST },
            };

            private string _value;

            public ResponseModeEnum()
            {

            }

            public ResponseModeEnum(string value)
            {
                _value = value;
            }

            public static ResponseModeEnum FromValue(string value)
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

                if (this.Equals(obj as ResponseModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResponseModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResponseModeEnum a, ResponseModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ResponseModeEnum a, ResponseModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 访问方式: program_console: 支持编程访问和管理控制台访问方式; program: 支持编程访问方式
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMode { get; set; }

        /// <summary>
        /// OpenID Connect身份提供商标识, 对应ID token 中 iss
        /// </summary>
        [JsonProperty("idp_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IdpUrl { get; set; }

        /// <summary>
        /// 在OpenID Connect身份提供商注册的客户端ID
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// OpenID Connect身份提供商授权地址;编程访问和管理控制台访问方式必选，编程访问方式不可选
        /// </summary>
        [JsonProperty("authorization_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// 授权请求信息范围，编程访问和管理控制台访问方式必选，编程访问方式不可选，可选值：openid 、email、profile，IDP自定义scope，字符集a-zA-Z_0-9 ，1-10个可选值组合空格分割，至少包括openid，顺序无关，总长度最长255字符，例如：\&quot;openid\&quot;、\&quot;openid email\&quot;、\&quot;openid profile\&quot; 、\&quot;openid email profile\&quot;
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// 授权请求返回的类型；id_token ；编程访问和管理控制台访问方式必选，编程访问方式不可选 
        /// </summary>
        [JsonProperty("response_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseTypeEnum ResponseType { get; set; }
        /// <summary>
        /// 授权请求返回方式， form_post 或 fragment ；编程访问和管理控制台访问方式必选，编程访问方式不可选
        /// </summary>
        [JsonProperty("response_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseModeEnum ResponseMode { get; set; }
        /// <summary>
        /// OpenID Connect身份提供商ID Token签名的公钥
        /// </summary>
        [JsonProperty("signing_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SigningKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOpenIdConnectConfig {\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  idpUrl: ").Append(IdpUrl).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("  authorizationEndpoint: ").Append(AuthorizationEndpoint).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  responseType: ").Append(ResponseType).Append("\n");
            sb.Append("  responseMode: ").Append(ResponseMode).Append("\n");
            sb.Append("  signingKey: ").Append(SigningKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOpenIdConnectConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOpenIdConnectConfig input)
        {
            if (input == null) return false;
            if (this.AccessMode != input.AccessMode || (this.AccessMode != null && !this.AccessMode.Equals(input.AccessMode))) return false;
            if (this.IdpUrl != input.IdpUrl || (this.IdpUrl != null && !this.IdpUrl.Equals(input.IdpUrl))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;
            if (this.AuthorizationEndpoint != input.AuthorizationEndpoint || (this.AuthorizationEndpoint != null && !this.AuthorizationEndpoint.Equals(input.AuthorizationEndpoint))) return false;
            if (this.Scope != input.Scope || (this.Scope != null && !this.Scope.Equals(input.Scope))) return false;
            if (this.ResponseType != input.ResponseType) return false;
            if (this.ResponseMode != input.ResponseMode) return false;
            if (this.SigningKey != input.SigningKey || (this.SigningKey != null && !this.SigningKey.Equals(input.SigningKey))) return false;

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
                if (this.AccessMode != null) hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.IdpUrl != null) hashCode = hashCode * 59 + this.IdpUrl.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.AuthorizationEndpoint != null) hashCode = hashCode * 59 + this.AuthorizationEndpoint.GetHashCode();
                if (this.Scope != null) hashCode = hashCode * 59 + this.Scope.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseType.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseMode.GetHashCode();
                if (this.SigningKey != null) hashCode = hashCode * 59 + this.SigningKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
