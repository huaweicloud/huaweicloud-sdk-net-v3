using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 修改Kafka实例的接入方式。
    /// </summary>
    public class PlainSslEnableRequest 
    {
        /// <summary>
        /// 需要开启或者关闭的接入方式。
        /// </summary>
        /// <value>需要开启或者关闭的接入方式。</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum PRIVATE_PLAIN_ENABLE for value: private_plain_enable
            /// </summary>
            public static readonly ProtocolEnum PRIVATE_PLAIN_ENABLE = new ProtocolEnum("private_plain_enable");

            /// <summary>
            /// Enum PRIVATE_SASL_SSL_ENABLE for value: private_sasl_ssl_enable
            /// </summary>
            public static readonly ProtocolEnum PRIVATE_SASL_SSL_ENABLE = new ProtocolEnum("private_sasl_ssl_enable");

            /// <summary>
            /// Enum PRIVATE_SASL_PLAINTEXT_ENABLE for value: private_sasl_plaintext_enable
            /// </summary>
            public static readonly ProtocolEnum PRIVATE_SASL_PLAINTEXT_ENABLE = new ProtocolEnum("private_sasl_plaintext_enable");

            /// <summary>
            /// Enum PUBLIC_PLAIN_ENABLE for value: public_plain_enable
            /// </summary>
            public static readonly ProtocolEnum PUBLIC_PLAIN_ENABLE = new ProtocolEnum("public_plain_enable");

            /// <summary>
            /// Enum PUBLIC_SASL_SSL_ENABLE for value: public_sasl_ssl_enable
            /// </summary>
            public static readonly ProtocolEnum PUBLIC_SASL_SSL_ENABLE = new ProtocolEnum("public_sasl_ssl_enable");

            /// <summary>
            /// Enum PUBLIC_SASL_PLAINTEXT_ENABLE for value: public_sasl_plaintext_enable
            /// </summary>
            public static readonly ProtocolEnum PUBLIC_SASL_PLAINTEXT_ENABLE = new ProtocolEnum("public_sasl_plaintext_enable");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "private_plain_enable", PRIVATE_PLAIN_ENABLE },
                { "private_sasl_ssl_enable", PRIVATE_SASL_SSL_ENABLE },
                { "private_sasl_plaintext_enable", PRIVATE_SASL_PLAINTEXT_ENABLE },
                { "public_plain_enable", PUBLIC_PLAIN_ENABLE },
                { "public_sasl_ssl_enable", PUBLIC_SASL_SSL_ENABLE },
                { "public_sasl_plaintext_enable", PUBLIC_SASL_PLAINTEXT_ENABLE },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines saslEnabledMechanisms
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SaslEnabledMechanismsEnum>))]
        public class SaslEnabledMechanismsEnum
        {
            /// <summary>
            /// Enum SCRAM_SHA_512 for value: SCRAM-SHA-512
            /// </summary>
            public static readonly SaslEnabledMechanismsEnum SCRAM_SHA_512 = new SaslEnabledMechanismsEnum("SCRAM-SHA-512");

            /// <summary>
            /// Enum PLAIN for value: PLAIN
            /// </summary>
            public static readonly SaslEnabledMechanismsEnum PLAIN = new SaslEnabledMechanismsEnum("PLAIN");

            private static readonly Dictionary<string, SaslEnabledMechanismsEnum> StaticFields =
            new Dictionary<string, SaslEnabledMechanismsEnum>()
            {
                { "SCRAM-SHA-512", SCRAM_SHA_512 },
                { "PLAIN", PLAIN },
            };

            private string _value;

            public SaslEnabledMechanismsEnum()
            {

            }

            public SaslEnabledMechanismsEnum(string value)
            {
                _value = value;
            }

            public static SaslEnabledMechanismsEnum FromValue(string value)
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

                if (this.Equals(obj as SaslEnabledMechanismsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SaslEnabledMechanismsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SaslEnabledMechanismsEnum a, SaslEnabledMechanismsEnum b)
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

            public static bool operator !=(SaslEnabledMechanismsEnum a, SaslEnabledMechanismsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 需要开启或者关闭的接入方式。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// - true：开启指定的接入方式。 - false：关闭指定的接入方式。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 首次开启SASL时，需要输入用户名。 实例创建后，关闭SASL并不会删除已经创建的用户，再次开启SASL时无需传入用户名，传入的用户名将无效。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 首次开启SASL时，需要输入用户名的密码。
        /// </summary>
        [JsonProperty("pass_word", NullValueHandling = NullValueHandling.Ignore)]
        public string PassWord { get; set; }

        /// <summary>
        /// 开启SASL后使用的认证机制。仅在第一次开启SASL时传入生效。生效后再次传入无效。 - PLAIN：简单的用户名密码校验。 - SCRAM-SHA-512：用户凭证校验，安全性比PLAIN机制更高。
        /// </summary>
        [JsonProperty("sasl_enabled_mechanisms", NullValueHandling = NullValueHandling.Ignore)]
        public List<SaslEnabledMechanismsEnum> SaslEnabledMechanisms { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlainSslEnableRequest {\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  passWord: ").Append(PassWord).Append("\n");
            sb.Append("  saslEnabledMechanisms: ").Append(SaslEnabledMechanisms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PlainSslEnableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PlainSslEnableRequest input)
        {
            if (input == null) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.PassWord != input.PassWord || (this.PassWord != null && !this.PassWord.Equals(input.PassWord))) return false;
            if (this.SaslEnabledMechanisms != input.SaslEnabledMechanisms || (this.SaslEnabledMechanisms != null && input.SaslEnabledMechanisms != null && !this.SaslEnabledMechanisms.SequenceEqual(input.SaslEnabledMechanisms))) return false;

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
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.PassWord != null) hashCode = hashCode * 59 + this.PassWord.GetHashCode();
                hashCode = hashCode * 59 + this.SaslEnabledMechanisms.GetHashCode();
                return hashCode;
            }
        }
    }
}
