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
        /// 安全协议，安全认证时必填，对应Kafka字段：security.protocol。 - PLAINTEXT：无安全认证方式，仅需输入IP和端口进行连接。 - SASL_PLAINTEXT：使用SASL机制连接Kafka，需要设置SASL相关配置。 - SSL：使用SSL加密方式连接Kafka，需要设置SSL相关配置。 - SASL_SSL：使用SASL及SSL加密认证方式，需要设置SSL及SASL相关参数配置信息。
        /// </summary>
        /// <value>安全协议，安全认证时必填，对应Kafka字段：security.protocol。 - PLAINTEXT：无安全认证方式，仅需输入IP和端口进行连接。 - SASL_PLAINTEXT：使用SASL机制连接Kafka，需要设置SASL相关配置。 - SSL：使用SSL加密方式连接Kafka，需要设置SSL相关配置。 - SASL_SSL：使用SASL及SSL加密认证方式，需要设置SSL及SASL相关参数配置信息。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum PLAINTEXT for value: PLAINTEXT
            /// </summary>
            public static readonly TypeEnum PLAINTEXT = new TypeEnum("PLAINTEXT");

            /// <summary>
            /// Enum SASL_PLAINTEXT for value: SASL_PLAINTEXT
            /// </summary>
            public static readonly TypeEnum SASL_PLAINTEXT = new TypeEnum("SASL_PLAINTEXT");

            /// <summary>
            /// Enum SASL_SSL for value: SASL_SSL
            /// </summary>
            public static readonly TypeEnum SASL_SSL = new TypeEnum("SASL_SSL");

            /// <summary>
            /// Enum SSL for value: SSL
            /// </summary>
            public static readonly TypeEnum SSL = new TypeEnum("SSL");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "PLAINTEXT", PLAINTEXT },
                { "SASL_PLAINTEXT", SASL_PLAINTEXT },
                { "SASL_SSL", SASL_SSL },
                { "SSL", SSL },
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
        /// 安全协议，安全认证时必填，对应Kafka字段：security.protocol。 - PLAINTEXT：无安全认证方式，仅需输入IP和端口进行连接。 - SASL_PLAINTEXT：使用SASL机制连接Kafka，需要设置SASL相关配置。 - SSL：使用SSL加密方式连接Kafka，需要设置SSL相关配置。 - SASL_SSL：使用SASL及SSL加密认证方式，需要设置SSL及SASL相关参数配置信息。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 证书名称，安全协议为SSL、SASL_SSL时必填。
        /// </summary>
        [JsonProperty("trust_store_key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustStoreKeyName { get; set; }

        /// <summary>
        /// 安全证书base64转码后的值，安全协议为SSL、SASL_SSL时必填。
        /// </summary>
        [JsonProperty("trust_store_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustStoreKey { get; set; }

        /// <summary>
        /// 证书密码，证书设置了密码时必填。
        /// </summary>
        [JsonProperty("trust_store_password", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustStorePassword { get; set; }

        /// <summary>
        /// 主机名端点识别算法，指定通过服务端证书验证服务端主机名的端点识别算法，不填表示禁用主机名验证。对应Kafka字段：ssl.endpoint.identification.algorithm。
        /// </summary>
        [JsonProperty("endpoint_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointAlgorithm { get; set; }

        /// <summary>
        /// SASL机制，用于客户端连接的SASL机制，对应Kafka字段：sasl.mechanism，支持以下四项，取值： - GSSAPI - PLAIN - SCRAM-SHA-256 - SCRAM-SHA-512
        /// </summary>
        [JsonProperty("sasl_mechanism", NullValueHandling = NullValueHandling.Ignore)]
        public string SaslMechanism { get; set; }

        /// <summary>
        /// 是否为委托令牌鉴权，安全协议为SASL_SSL和SASL_PLAINTEXT时，SASL机制选择“SCRAM-SHA-256”或者“SCRAM-SHA-512”时生效。
        /// </summary>
        [JsonProperty("delegation_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DelegationTokens { get; set; }

        /// <summary>
        /// 是否开启SSL双向认证。
        /// </summary>
        [JsonProperty("enable_key_store", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableKeyStore { get; set; }

        /// <summary>
        /// Keystore证书，开启SSL双向认证时需要。
        /// </summary>
        [JsonProperty("key_store_key", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyStoreKey { get; set; }

        /// <summary>
        /// Keystore证书名称，开启SSL双向认证时需要。
        /// </summary>
        [JsonProperty("key_store_key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyStoreKeyName { get; set; }

        /// <summary>
        /// Keystore证书密码，证书设置了密码时需要。对应Kafka字段：ssl.keystore.password。
        /// </summary>
        [JsonProperty("key_store_password", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyStorePassword { get; set; }

        /// <summary>
        /// 是否设置Keystore私钥密码，默认为false。
        /// </summary>
        [JsonProperty("set_private_key_password", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetPrivateKeyPassword { get; set; }

        /// <summary>
        /// Keystore私钥密码，开启SSL双向认证时，set_private_key_password为true时必填。对应Kafka字段：ssl.key.password。
        /// </summary>
        [JsonProperty("key_password", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KafkaSecurity {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  trustStoreKeyName: ").Append(TrustStoreKeyName).Append("\n");
            sb.Append("  trustStoreKey: ").Append(TrustStoreKey).Append("\n");
            sb.Append("  trustStorePassword: ").Append(TrustStorePassword).Append("\n");
            sb.Append("  endpointAlgorithm: ").Append(EndpointAlgorithm).Append("\n");
            sb.Append("  saslMechanism: ").Append(SaslMechanism).Append("\n");
            sb.Append("  delegationTokens: ").Append(DelegationTokens).Append("\n");
            sb.Append("  enableKeyStore: ").Append(EnableKeyStore).Append("\n");
            sb.Append("  keyStoreKey: ").Append(KeyStoreKey).Append("\n");
            sb.Append("  keyStoreKeyName: ").Append(KeyStoreKeyName).Append("\n");
            sb.Append("  keyStorePassword: ").Append(KeyStorePassword).Append("\n");
            sb.Append("  setPrivateKeyPassword: ").Append(SetPrivateKeyPassword).Append("\n");
            sb.Append("  keyPassword: ").Append(KeyPassword).Append("\n");
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
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
                    this.EndpointAlgorithm == input.EndpointAlgorithm ||
                    (this.EndpointAlgorithm != null &&
                    this.EndpointAlgorithm.Equals(input.EndpointAlgorithm))
                ) && 
                (
                    this.SaslMechanism == input.SaslMechanism ||
                    (this.SaslMechanism != null &&
                    this.SaslMechanism.Equals(input.SaslMechanism))
                ) && 
                (
                    this.DelegationTokens == input.DelegationTokens ||
                    (this.DelegationTokens != null &&
                    this.DelegationTokens.Equals(input.DelegationTokens))
                ) && 
                (
                    this.EnableKeyStore == input.EnableKeyStore ||
                    (this.EnableKeyStore != null &&
                    this.EnableKeyStore.Equals(input.EnableKeyStore))
                ) && 
                (
                    this.KeyStoreKey == input.KeyStoreKey ||
                    (this.KeyStoreKey != null &&
                    this.KeyStoreKey.Equals(input.KeyStoreKey))
                ) && 
                (
                    this.KeyStoreKeyName == input.KeyStoreKeyName ||
                    (this.KeyStoreKeyName != null &&
                    this.KeyStoreKeyName.Equals(input.KeyStoreKeyName))
                ) && 
                (
                    this.KeyStorePassword == input.KeyStorePassword ||
                    (this.KeyStorePassword != null &&
                    this.KeyStorePassword.Equals(input.KeyStorePassword))
                ) && 
                (
                    this.SetPrivateKeyPassword == input.SetPrivateKeyPassword ||
                    (this.SetPrivateKeyPassword != null &&
                    this.SetPrivateKeyPassword.Equals(input.SetPrivateKeyPassword))
                ) && 
                (
                    this.KeyPassword == input.KeyPassword ||
                    (this.KeyPassword != null &&
                    this.KeyPassword.Equals(input.KeyPassword))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TrustStoreKeyName != null)
                    hashCode = hashCode * 59 + this.TrustStoreKeyName.GetHashCode();
                if (this.TrustStoreKey != null)
                    hashCode = hashCode * 59 + this.TrustStoreKey.GetHashCode();
                if (this.TrustStorePassword != null)
                    hashCode = hashCode * 59 + this.TrustStorePassword.GetHashCode();
                if (this.EndpointAlgorithm != null)
                    hashCode = hashCode * 59 + this.EndpointAlgorithm.GetHashCode();
                if (this.SaslMechanism != null)
                    hashCode = hashCode * 59 + this.SaslMechanism.GetHashCode();
                if (this.DelegationTokens != null)
                    hashCode = hashCode * 59 + this.DelegationTokens.GetHashCode();
                if (this.EnableKeyStore != null)
                    hashCode = hashCode * 59 + this.EnableKeyStore.GetHashCode();
                if (this.KeyStoreKey != null)
                    hashCode = hashCode * 59 + this.KeyStoreKey.GetHashCode();
                if (this.KeyStoreKeyName != null)
                    hashCode = hashCode * 59 + this.KeyStoreKeyName.GetHashCode();
                if (this.KeyStorePassword != null)
                    hashCode = hashCode * 59 + this.KeyStorePassword.GetHashCode();
                if (this.SetPrivateKeyPassword != null)
                    hashCode = hashCode * 59 + this.SetPrivateKeyPassword.GetHashCode();
                if (this.KeyPassword != null)
                    hashCode = hashCode * 59 + this.KeyPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
