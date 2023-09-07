using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 增强型负载均衡器
    /// </summary>
    public class LbaasListeners 
    {
        /// <summary>
        /// 指定ip协议版本
        /// </summary>
        /// <value>指定ip协议版本</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolVersionEnum>))]
        public class ProtocolVersionEnum
        {
            /// <summary>
            /// Enum IPV4 for value: IPV4
            /// </summary>
            public static readonly ProtocolVersionEnum IPV4 = new ProtocolVersionEnum("IPV4");

            /// <summary>
            /// Enum IPV6 for value: IPV6
            /// </summary>
            public static readonly ProtocolVersionEnum IPV6 = new ProtocolVersionEnum("IPV6");

            private static readonly Dictionary<string, ProtocolVersionEnum> StaticFields =
            new Dictionary<string, ProtocolVersionEnum>()
            {
                { "IPV4", IPV4 },
                { "IPV6", IPV6 },
            };

            private string _value;

            public ProtocolVersionEnum()
            {

            }

            public ProtocolVersionEnum(string value)
            {
                _value = value;
            }

            public static ProtocolVersionEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolVersionEnum a, ProtocolVersionEnum b)
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

            public static bool operator !=(ProtocolVersionEnum a, ProtocolVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 后端云服务器组ID
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 后端协议号，指后端云服务器监听的端口，取值范围[1,65535]
        /// </summary>
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// 权重，指后端云服务器经分发得到的请求数量的比例，取值范围[0, 100]。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 指定ip协议版本
        /// </summary>
        [JsonProperty("protocol_version", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolVersionEnum ProtocolVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LbaasListeners {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  protocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LbaasListeners);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LbaasListeners input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.ProtocolVersion == input.ProtocolVersion ||
                    (this.ProtocolVersion != null &&
                    this.ProtocolVersion.Equals(input.ProtocolVersion))
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
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.ProtocolVersion != null)
                    hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
