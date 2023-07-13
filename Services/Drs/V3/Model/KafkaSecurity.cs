using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Kafka安全认证相关参数
    /// </summary>
    public class KafkaSecurity 
    {
        /// <summary>
        /// 认证类型，PLAINTEXT为无认证，，使用安全认证时必填。
        /// </summary>
        /// <value>认证类型，PLAINTEXT为无认证，，使用安全认证时必填。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum PLAINTEXT for value: PLAINTEXT
            /// </summary>
            public static readonly TypeEnum PLAINTEXT = new TypeEnum("PLAINTEXT");

            /// <summary>
            /// Enum SASL_SSL for value: SASL_SSL
            /// </summary>
            public static readonly TypeEnum SASL_SSL = new TypeEnum("SASL_SSL");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "PLAINTEXT", PLAINTEXT },
                { "SASL_SSL", SASL_SSL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 证书名称，使用安全认证时必填。
        /// </summary>
        [JsonProperty("trust_store_key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustStoreKeyName { get; set; }

        /// <summary>
        /// 安全证书base64转码后的值，使用安全认证时必填。
        /// </summary>
        [JsonProperty("trust_store_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustStoreKey { get; set; }

        /// <summary>
        /// 证书密码，使用安全认证时必填。
        /// </summary>
        [JsonProperty("trust_store_password", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustStorePassword { get; set; }

        /// <summary>
        /// 认证类型，PLAINTEXT为无认证，，使用安全认证时必填。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaSecurity {\n");
            sb.Append("  trustStoreKeyName: ").Append(TrustStoreKeyName).Append("\n");
            sb.Append("  trustStoreKey: ").Append(TrustStoreKey).Append("\n");
            sb.Append("  trustStorePassword: ").Append(TrustStorePassword).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KafkaSecurity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KafkaSecurity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrustStoreKeyName == input.TrustStoreKeyName ||
                    (this.TrustStoreKeyName != null &&
                    this.TrustStoreKeyName.Equals(input.TrustStoreKeyName))
                ) && 
                (
                    this.TrustStoreKey == input.TrustStoreKey ||
                    (this.TrustStoreKey != null &&
                    this.TrustStoreKey.Equals(input.TrustStoreKey))
                ) && 
                (
                    this.TrustStorePassword == input.TrustStorePassword ||
                    (this.TrustStorePassword != null &&
                    this.TrustStorePassword.Equals(input.TrustStorePassword))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.TrustStoreKeyName != null)
                    hashCode = hashCode * 59 + this.TrustStoreKeyName.GetHashCode();
                if (this.TrustStoreKey != null)
                    hashCode = hashCode * 59 + this.TrustStoreKey.GetHashCode();
                if (this.TrustStorePassword != null)
                    hashCode = hashCode * 59 + this.TrustStorePassword.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
