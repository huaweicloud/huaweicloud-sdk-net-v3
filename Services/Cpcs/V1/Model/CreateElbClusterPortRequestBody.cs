using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateElbClusterPortRequestBody 
    {
        /// <summary>
        /// 新增的端口的模式。除了VPN外，其他类型的服务只支持 PROXY
        /// </summary>
        /// <value>新增的端口的模式。除了VPN外，其他类型的服务只支持 PROXY</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum TUNNEL for value: TUNNEL
            /// </summary>
            public static readonly ModeEnum TUNNEL = new ModeEnum("TUNNEL");

            /// <summary>
            /// Enum PROXY for value: PROXY
            /// </summary>
            public static readonly ModeEnum PROXY = new ModeEnum("PROXY");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "TUNNEL", TUNNEL },
                { "PROXY", PROXY },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// elb id。端口映射将会在该elb中创建
        /// </summary>
        [JsonProperty("elb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbId { get; set; }

        /// <summary>
        /// 新增的端口的模式。除了VPN外，其他类型的服务只支持 PROXY
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 将在elb中为代理通道创建的监听器的端口
        /// </summary>
        [JsonProperty("lb_listener_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? LbListenerPort { get; set; }

        /// <summary>
        /// 将在elb中为代理通道创建的后端服务组中后端服务器的端口。无默认值。
        /// </summary>
        [JsonProperty("server_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServerPort { get; set; }

        /// <summary>
        /// 将在elb中给VPN隧道创建的监听器的端口。当mode&#x3D;TUNNEL时，必填
        /// </summary>
        [JsonProperty("tunnel_lb_listener_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? TunnelLbListenerPort { get; set; }

        /// <summary>
        /// 将在elb中给VPN隧道创建的后端服务组中后端服务器的端口。 当mode&#x3D;TUNNEL时，必填，有默认值:20706。
        /// </summary>
        [JsonProperty("tunnel_server_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? TunnelServerPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateElbClusterPortRequestBody {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  elbId: ").Append(ElbId).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  lbListenerPort: ").Append(LbListenerPort).Append("\n");
            sb.Append("  serverPort: ").Append(ServerPort).Append("\n");
            sb.Append("  tunnelLbListenerPort: ").Append(TunnelLbListenerPort).Append("\n");
            sb.Append("  tunnelServerPort: ").Append(TunnelServerPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateElbClusterPortRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateElbClusterPortRequestBody input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ElbId != input.ElbId || (this.ElbId != null && !this.ElbId.Equals(input.ElbId))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.LbListenerPort != input.LbListenerPort || (this.LbListenerPort != null && !this.LbListenerPort.Equals(input.LbListenerPort))) return false;
            if (this.ServerPort != input.ServerPort || (this.ServerPort != null && !this.ServerPort.Equals(input.ServerPort))) return false;
            if (this.TunnelLbListenerPort != input.TunnelLbListenerPort || (this.TunnelLbListenerPort != null && !this.TunnelLbListenerPort.Equals(input.TunnelLbListenerPort))) return false;
            if (this.TunnelServerPort != input.TunnelServerPort || (this.TunnelServerPort != null && !this.TunnelServerPort.Equals(input.TunnelServerPort))) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ElbId != null) hashCode = hashCode * 59 + this.ElbId.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.LbListenerPort != null) hashCode = hashCode * 59 + this.LbListenerPort.GetHashCode();
                if (this.ServerPort != null) hashCode = hashCode * 59 + this.ServerPort.GetHashCode();
                if (this.TunnelLbListenerPort != null) hashCode = hashCode * 59 + this.TunnelLbListenerPort.GetHashCode();
                if (this.TunnelServerPort != null) hashCode = hashCode * 59 + this.TunnelServerPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
