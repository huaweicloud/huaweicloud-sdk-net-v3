using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyChainInfo 
    {
        /// <summary>
        /// 计算鉴权串的方式： - d_sha256：鉴权方式D，采用HMAC-SHA256算法，建议优先选择此方式； - c_aes：鉴权方式C，采用对称加密算法； - b_md5：鉴权方式B，采用MD5信息摘要算法； - a_md5：鉴权方式A，采用MD5信息摘要算法。  &gt; 鉴权方式ABC存在安全风险，鉴权方式D拥有更高的安全性，建议您优先使用鉴权方式D。
        /// </summary>
        /// <value>计算鉴权串的方式： - d_sha256：鉴权方式D，采用HMAC-SHA256算法，建议优先选择此方式； - c_aes：鉴权方式C，采用对称加密算法； - b_md5：鉴权方式B，采用MD5信息摘要算法； - a_md5：鉴权方式A，采用MD5信息摘要算法。  &gt; 鉴权方式ABC存在安全风险，鉴权方式D拥有更高的安全性，建议您优先使用鉴权方式D。</value>
        [JsonConverter(typeof(EnumClassConverter<AuthTypeEnum>))]
        public class AuthTypeEnum
        {
            /// <summary>
            /// Enum D_SHA256 for value: d_sha256
            /// </summary>
            public static readonly AuthTypeEnum D_SHA256 = new AuthTypeEnum("d_sha256");

            /// <summary>
            /// Enum C_AES for value: c_aes
            /// </summary>
            public static readonly AuthTypeEnum C_AES = new AuthTypeEnum("c_aes");

            /// <summary>
            /// Enum B_MD5 for value: b_md5
            /// </summary>
            public static readonly AuthTypeEnum B_MD5 = new AuthTypeEnum("b_md5");

            /// <summary>
            /// Enum A_MD5 for value: a_md5
            /// </summary>
            public static readonly AuthTypeEnum A_MD5 = new AuthTypeEnum("a_md5");

            private static readonly Dictionary<string, AuthTypeEnum> StaticFields =
            new Dictionary<string, AuthTypeEnum>()
            {
                { "d_sha256", D_SHA256 },
                { "c_aes", C_AES },
                { "b_md5", B_MD5 },
                { "a_md5", A_MD5 },
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

            public static bool operator !=(AuthTypeEnum a, AuthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防盗链Key值，由32个字符组成，支持大写字母、小写字母、数字。不可为纯数字或纯字母。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 计算鉴权串的方式： - d_sha256：鉴权方式D，采用HMAC-SHA256算法，建议优先选择此方式； - c_aes：鉴权方式C，采用对称加密算法； - b_md5：鉴权方式B，采用MD5信息摘要算法； - a_md5：鉴权方式A，采用MD5信息摘要算法。  &gt; 鉴权方式ABC存在安全风险，鉴权方式D拥有更高的安全性，建议您优先使用鉴权方式D。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// URL鉴权信息的超时时长  取值范围：[60，2592000]，即1分钟-30天  单位：秒  鉴权信息中携带的请求时间与直播服务收到请求时的时间的最大差值，用于检查直播推流URL或者直播播放URL是否已过期
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyChainInfo {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeyChainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeyChainInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
