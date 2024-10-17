using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 服务开放的端口映射列表
    /// </summary>
    public class PortList 
    {
        /// <summary>
        /// 端口映射协议，支持TCP。
        /// </summary>
        /// <value>端口映射协议，支持TCP。</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum TCP for value: TCP
            /// </summary>
            public static readonly ProtocolEnum TCP = new ProtocolEnum("TCP");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "TCP", TCP },
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
        /// 终端节点访问的端口。 终端节点提供给用户，作为访问终端节点服务的端口，范围1-65535。
        /// </summary>
        [JsonProperty("client_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientPort { get; set; }

        /// <summary>
        /// 终端节点服务的端口。 终端节点服务绑定了后端资源，作为提供服务的端口，范围1-65535。
        /// </summary>
        [JsonProperty("server_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServerPort { get; set; }

        /// <summary>
        /// 端口映射协议，支持TCP。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortList {\n");
            sb.Append("  clientPort: ").Append(ClientPort).Append("\n");
            sb.Append("  serverPort: ").Append(ServerPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortList input)
        {
            if (input == null) return false;
            if (this.ClientPort != input.ClientPort || (this.ClientPort != null && !this.ClientPort.Equals(input.ClientPort))) return false;
            if (this.ServerPort != input.ServerPort || (this.ServerPort != null && !this.ServerPort.Equals(input.ServerPort))) return false;
            if (this.Protocol != input.Protocol) return false;

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
                if (this.ClientPort != null) hashCode = hashCode * 59 + this.ClientPort.GetHashCode();
                if (this.ServerPort != null) hashCode = hashCode * 59 + this.ServerPort.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
