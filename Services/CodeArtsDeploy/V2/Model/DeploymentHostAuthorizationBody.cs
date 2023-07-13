using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 登录主机鉴权，使用密码登录则填写密码即可，使用密钥则填写密钥，二选一即可。
    /// </summary>
    public class DeploymentHostAuthorizationBody 
    {
        /// <summary>
        /// 认证类型，0表示使用密码认证，1表示使用密钥认证
        /// </summary>
        /// <value>认证类型，0表示使用密码认证，1表示使用密钥认证</value>
        [JsonConverter(typeof(EnumClassConverter<TrustedTypeEnum>))]
        public class TrustedTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly TrustedTypeEnum NUMBER_0 = new TrustedTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly TrustedTypeEnum NUMBER_1 = new TrustedTypeEnum(1);

            private static readonly Dictionary<int?, TrustedTypeEnum> StaticFields =
            new Dictionary<int?, TrustedTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public TrustedTypeEnum()
            {

            }

            public TrustedTypeEnum(int? value)
            {
                _value = value;
            }

            public static TrustedTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as TrustedTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TrustedTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TrustedTypeEnum a, TrustedTypeEnum b)
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

            public static bool operator !=(TrustedTypeEnum a, TrustedTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户名，可输入中英文，数字和符号(-_.)。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 密码，认证类型为0时，密码必填。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }

        /// <summary>
        /// 密钥，认证类型为1时，密钥必填
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 认证类型，0表示使用密码认证，1表示使用密钥认证
        /// </summary>
        [JsonProperty("trusted_type", NullValueHandling = NullValueHandling.Ignore)]
        public TrustedTypeEnum TrustedType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentHostAuthorizationBody {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  trustedType: ").Append(TrustedType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentHostAuthorizationBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentHostAuthorizationBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.TrustedType == input.TrustedType ||
                    (this.TrustedType != null &&
                    this.TrustedType.Equals(input.TrustedType))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.TrustedType != null)
                    hashCode = hashCode * 59 + this.TrustedType.GetHashCode();
                return hashCode;
            }
        }
    }
}
