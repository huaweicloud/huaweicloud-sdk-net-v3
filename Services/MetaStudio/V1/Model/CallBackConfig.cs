using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CallBackConfig 
    {
        /// <summary>
        /// 认证类型。 * NONE。URL中自带认证。 * MSS_A。HMACSHA256签名模式，在URL中追加参数:secret,time_stamp。取值方式：secret&#x3D;hmac_sha256(key, URI（callback_url）+ time_stamp)&amp;time_stamp&#x3D;hex(timestamp)
        /// </summary>
        /// <value>认证类型。 * NONE。URL中自带认证。 * MSS_A。HMACSHA256签名模式，在URL中追加参数:secret,time_stamp。取值方式：secret&#x3D;hmac_sha256(key, URI（callback_url）+ time_stamp)&amp;time_stamp&#x3D;hex(timestamp)</value>
        [JsonConverter(typeof(EnumClassConverter<AuthTypeEnum>))]
        public class AuthTypeEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly AuthTypeEnum NONE = new AuthTypeEnum("NONE");

            /// <summary>
            /// Enum MSS_A for value: MSS_A
            /// </summary>
            public static readonly AuthTypeEnum MSS_A = new AuthTypeEnum("MSS_A");

            private static readonly Dictionary<string, AuthTypeEnum> StaticFields =
            new Dictionary<string, AuthTypeEnum>()
            {
                { "NONE", NONE },
                { "MSS_A", MSS_A },
            };

            private string _value;

            public AuthTypeEnum()
            {

            }

            public AuthTypeEnum(string value)
            {
                _value = value;
            }

            public static AuthTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AuthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthTypeEnum a, AuthTypeEnum b)
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

            public static bool operator !=(AuthTypeEnum a, AuthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 回调URL。  回调请求body为json格式，带参数如下：  result: SUCCEED或FAILED  asset_id: 资产ID  job_id: 任务
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 认证类型。 * NONE。URL中自带认证。 * MSS_A。HMACSHA256签名模式，在URL中追加参数:secret,time_stamp。取值方式：secret&#x3D;hmac_sha256(key, URI（callback_url）+ time_stamp)&amp;time_stamp&#x3D;hex(timestamp)
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// 密钥Key
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallBackConfig {\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CallBackConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CallBackConfig input)
        {
            if (input == null) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;

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
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                return hashCode;
            }
        }
    }
}
