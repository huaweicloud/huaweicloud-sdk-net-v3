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
    /// Response Object
    /// </summary>
    public class UpdateKafkaPortProtocolResponse : SdkResponse
    {
        /// <summary>
        /// 开启或者关闭的Kafka接入方式。
        /// </summary>
        /// <value>开启或者关闭的Kafka接入方式。</value>
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 后台任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 开启或者关闭的Kafka接入方式。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 开启动作或者关闭动作。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateKafkaPortProtocolResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateKafkaPortProtocolResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateKafkaPortProtocolResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
