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
    /// 增强型负载均衡器信息
    /// </summary>
    public class LbaasListenersResult 
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

            public static bool operator !=(ProtocolVersionEnum a, ProtocolVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 监听器ID
        /// </summary>
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

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
        /// 权重，指后端云服务器经分发得到的请求数量比例，取值范围[0,1]，默认为1。
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
            sb.Append("class LbaasListenersResult {\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
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
            return this.Equals(input as LbaasListenersResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LbaasListenersResult input)
        {
            if (input == null) return false;
            if (this.ListenerId != input.ListenerId || (this.ListenerId != null && !this.ListenerId.Equals(input.ListenerId))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.ProtocolPort != input.ProtocolPort || (this.ProtocolPort != null && !this.ProtocolPort.Equals(input.ProtocolPort))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.ProtocolVersion != input.ProtocolVersion) return false;

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
                if (this.ListenerId != null) hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.ProtocolPort != null) hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                hashCode = hashCode * 59 + this.ProtocolVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
