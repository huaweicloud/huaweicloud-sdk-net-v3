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
    /// 修改终端节点服务接口请求结构体
    /// </summary>
    public class UpdateEndpointServiceRequestBody 
    {
        /// <summary>
        /// 用于控制将哪些信息（如客户端的源IP、源端口、marker_id等）携带到服务端。 支持携带的客户端信息包括如下两种类型：  - TCP TOA：表示将客户端信息插入到tcp option字段中携带至服务端。 说明：仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。  - Proxy Protocol：表示将客户端信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 该参数的取值包括：  - close：表示关闭代理协议。  - toa_open：表示开启代理协议“tcp_toa”。  - proxy_open：表示开启代理协议“proxy_protocol”。  - open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。
        /// </summary>
        /// <value>用于控制将哪些信息（如客户端的源IP、源端口、marker_id等）携带到服务端。 支持携带的客户端信息包括如下两种类型：  - TCP TOA：表示将客户端信息插入到tcp option字段中携带至服务端。 说明：仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。  - Proxy Protocol：表示将客户端信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 该参数的取值包括：  - close：表示关闭代理协议。  - toa_open：表示开启代理协议“tcp_toa”。  - proxy_open：表示开启代理协议“proxy_protocol”。  - open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。</value>
        [JsonConverter(typeof(EnumClassConverter<TcpProxyEnum>))]
        public class TcpProxyEnum
        {
            /// <summary>
            /// Enum CLOSE for value: close
            /// </summary>
            public static readonly TcpProxyEnum CLOSE = new TcpProxyEnum("close");

            /// <summary>
            /// Enum TOA_OPEN for value: toa_open
            /// </summary>
            public static readonly TcpProxyEnum TOA_OPEN = new TcpProxyEnum("toa_open");

            /// <summary>
            /// Enum PROXY_OPEN for value: proxy_open
            /// </summary>
            public static readonly TcpProxyEnum PROXY_OPEN = new TcpProxyEnum("proxy_open");

            /// <summary>
            /// Enum OPEN for value: open
            /// </summary>
            public static readonly TcpProxyEnum OPEN = new TcpProxyEnum("open");

            /// <summary>
            /// Enum PROXY_VNI for value: proxy_vni
            /// </summary>
            public static readonly TcpProxyEnum PROXY_VNI = new TcpProxyEnum("proxy_vni");

            private static readonly Dictionary<string, TcpProxyEnum> StaticFields =
            new Dictionary<string, TcpProxyEnum>()
            {
                { "close", CLOSE },
                { "toa_open", TOA_OPEN },
                { "proxy_open", PROXY_OPEN },
                { "open", OPEN },
                { "proxy_vni", PROXY_VNI },
            };

            private string _value;

            public TcpProxyEnum()
            {

            }

            public TcpProxyEnum(string value)
            {
                _value = value;
            }

            public static TcpProxyEnum FromValue(string value)
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

                if (this.Equals(obj as TcpProxyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TcpProxyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TcpProxyEnum a, TcpProxyEnum b)
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

            public static bool operator !=(TcpProxyEnum a, TcpProxyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否需要审批。  - false：不需审批，创建的终端节点连接直接为accepted状态。  - true：需审批，创建的终端节点连接需要终端节点服务所属用户审核后方可使用。 默认为true，需要审批。
        /// </summary>
        [JsonProperty("approval_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalEnabled { get; set; }

        /// <summary>
        /// 终端节点服务的名称，长度不大于16，允许传入大小写字母、数字、下划线、中划线。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务开放的端口映射列表，同一个终端节点服务下，不允许重复的端口映射。 若多个终端节点服务共用一个port_id， 则终端节点之间服务的所有端口映射的server_port和protocol的组合不能重复， 单次最多添加200个。 该参数值将被全量更新。
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortList> Ports { get; set; }

        /// <summary>
        /// 标识终端节点服务后端资源的ID， 格式为通用唯一识别码（Universally UniqueIdentifier，下文简称UUID）。 取值为：  - LB类型：负载均衡器内网IP对应的端口ID。  - VM类型：弹性云服务器IP地址对应的网卡ID。  - VIP类型：虚拟资源所在物理服务器对应的网卡ID。（该字段已废弃，请优先使用LB类型） 说明： 当后端资源为“LB类型”时，仅支持修改为同类型后端资源。 例如，共享型负载均衡仅支持更换为共享型负载均衡，不支持更换为独享型负载均衡。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 用于控制将哪些信息（如客户端的源IP、源端口、marker_id等）携带到服务端。 支持携带的客户端信息包括如下两种类型：  - TCP TOA：表示将客户端信息插入到tcp option字段中携带至服务端。 说明：仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。  - Proxy Protocol：表示将客户端信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 该参数的取值包括：  - close：表示关闭代理协议。  - toa_open：表示开启代理协议“tcp_toa”。  - proxy_open：表示开启代理协议“proxy_protocol”。  - open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。
        /// </summary>
        [JsonProperty("tcp_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public TcpProxyEnum TcpProxy { get; set; }
        /// <summary>
        /// 描述字段，支持中英文字母、数字等字符，不支持“&lt;”或“&gt;”字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointServiceRequestBody {\n");
            sb.Append("  approvalEnabled: ").Append(ApprovalEnabled).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  tcpProxy: ").Append(TcpProxy).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointServiceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointServiceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovalEnabled == input.ApprovalEnabled ||
                    (this.ApprovalEnabled != null &&
                    this.ApprovalEnabled.Equals(input.ApprovalEnabled))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.TcpProxy == input.TcpProxy ||
                    (this.TcpProxy != null &&
                    this.TcpProxy.Equals(input.TcpProxy))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ApprovalEnabled != null)
                    hashCode = hashCode * 59 + this.ApprovalEnabled.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.TcpProxy != null)
                    hashCode = hashCode * 59 + this.TcpProxy.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
