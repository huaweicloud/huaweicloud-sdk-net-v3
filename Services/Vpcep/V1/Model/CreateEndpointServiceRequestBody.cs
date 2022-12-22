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
    /// 创建终端节点服务接口请求结构体
    /// </summary>
    public class CreateEndpointServiceRequestBody 
    {
        /// <summary>
        /// 资源类型。 ● VM：云服务器，适用于作为服务器使用。 ● VIP：虚拟IP，适用于作为虚拟资源的物理服务器使用。 ● LB：增强型负载均衡，适用于高访问量业务和对可靠性和容灾性要求较高的业务。
        /// </summary>
        /// <value>资源类型。 ● VM：云服务器，适用于作为服务器使用。 ● VIP：虚拟IP，适用于作为虚拟资源的物理服务器使用。 ● LB：增强型负载均衡，适用于高访问量业务和对可靠性和容灾性要求较高的业务。</value>
        [JsonConverter(typeof(EnumClassConverter<ServerTypeEnum>))]
        public class ServerTypeEnum
        {
            /// <summary>
            /// Enum VM for value: VM
            /// </summary>
            public static readonly ServerTypeEnum VM = new ServerTypeEnum("VM");

            /// <summary>
            /// Enum VIP for value: VIP
            /// </summary>
            public static readonly ServerTypeEnum VIP = new ServerTypeEnum("VIP");

            /// <summary>
            /// Enum LB for value: LB
            /// </summary>
            public static readonly ServerTypeEnum LB = new ServerTypeEnum("LB");

            private static readonly Dictionary<string, ServerTypeEnum> StaticFields =
            new Dictionary<string, ServerTypeEnum>()
            {
                { "VM", VM },
                { "VIP", VIP },
                { "LB", LB },
            };

            private string _value;

            public ServerTypeEnum()
            {

            }

            public ServerTypeEnum(string value)
            {
                _value = value;
            }

            public static ServerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ServerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServerTypeEnum a, ServerTypeEnum b)
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

            public static bool operator !=(ServerTypeEnum a, ServerTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 用于控制是否将客户端的源IP、源端口、marker_id等信息携带到服务端。 信息携带支持两种方式： ● TCP TOA：表示将客户端信息插入到tcp option字段中携带至服务端。 说明 仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。 ● Proxy Protocol：表示将客户端相关信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 参数的取值包括： ● close：表示关闭代理协议。 ● toa_open：表示开启代理协议“tcp_toa”。 ● proxy_open：表示开启代理协议“proxy_protocol”。 ● open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。
        /// </summary>
        /// <value>用于控制是否将客户端的源IP、源端口、marker_id等信息携带到服务端。 信息携带支持两种方式： ● TCP TOA：表示将客户端信息插入到tcp option字段中携带至服务端。 说明 仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。 ● Proxy Protocol：表示将客户端相关信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 参数的取值包括： ● close：表示关闭代理协议。 ● toa_open：表示开启代理协议“tcp_toa”。 ● proxy_open：表示开启代理协议“proxy_protocol”。 ● open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。</value>
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

            private static readonly Dictionary<string, TcpProxyEnum> StaticFields =
            new Dictionary<string, TcpProxyEnum>()
            {
                { "close", CLOSE },
                { "toa_open", TOA_OPEN },
                { "proxy_open", PROXY_OPEN },
                { "open", OPEN },
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
        /// 标识终端节点服务后端资源的ID， 格式为通用唯一识别码（Universally Unique Identifier，下文简称UUID）。 取值为： ● LB类型：增强型负载均衡器内网IP对应的端口ID。 详细内容请参考《弹性负载均衡API参考》中的“查询负载均衡详情”， 详见响应消息中的“vip_port_id”字段。 ● VM类型：弹性云服务器IP地址对应的网卡ID。 详细内容请参考《弹性云服务器API参考》中的“查询云服务器网卡信息”， 详见响应消息中的“port_id”字段。 ● VIP类型：虚拟资源所在物理服务器对应的网卡ID。 说明 ● 创建终端节点服务时，VPC的子网网段不能与198.19.128.0/17重叠。 ● VPC路由表中自定义路由的目的地址不能与198.19.128.0/17重叠。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 虚拟IP的网卡ID。
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 终端节点服务的名称，长度不大于16，允许传入大小写字母、数字、下划线、中划线。 ● 传入为空，存入值为regionName+.+serviceId ● 传入不为空并校验通过，存入值为regionName+.+serviceName+.+serviceId
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 终端节点服务对应后端资源所在的VPC的ID。 详细内容请参考《虚拟私有云API参考》中的“查询VPC”，详见响应消息中的“id”字段。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 是否需要审批。 ● false：不需要审批，创建的终端节点连接直接为accepted状态。 ● true：需要审批，创建的终端节点连接为pendingAcceptance状态， 需要终端节点服务所属用户审核后方可使用。 默认为true，需要审批。
        /// </summary>
        [JsonProperty("approval_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalEnabled { get; set; }

        /// <summary>
        /// 终端节点服务类型。 仅支持将用户私有服务创建为interface类型的终端节点服务。 终端节点服务类型包括“网关（gataway）型”和“接口（interface）型”： ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建， 用户可直接使用。 您可以通过查询公共终端节点服务列表, 查看由运维人员配置的所有用户可见且可连接的终端节点服务， 并通过创建终端节点创建访问Gateway和Interface类型终端节点服务的终端节点。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 资源类型。 ● VM：云服务器，适用于作为服务器使用。 ● VIP：虚拟IP，适用于作为虚拟资源的物理服务器使用。 ● LB：增强型负载均衡，适用于高访问量业务和对可靠性和容灾性要求较高的业务。
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServerTypeEnum ServerType { get; set; }
        /// <summary>
        /// 服务开放的端口映射列表，详细内容请参见表4-10。 同一个终端节点服务下，不允许重复的端口映射。若多个终端节点服务共用一个port_id， 则终端节点服务之间的所有端口映射的server_port和protocol的组合不能重复， 单次最多添加200个。
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortList> Ports { get; set; }

        /// <summary>
        /// 用于控制是否将客户端的源IP、源端口、marker_id等信息携带到服务端。 信息携带支持两种方式： ● TCP TOA：表示将客户端信息插入到tcp option字段中携带至服务端。 说明 仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。 ● Proxy Protocol：表示将客户端相关信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 参数的取值包括： ● close：表示关闭代理协议。 ● toa_open：表示开启代理协议“tcp_toa”。 ● proxy_open：表示开启代理协议“proxy_protocol”。 ● open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。
        /// </summary>
        [JsonProperty("tcp_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public TcpProxyEnum TcpProxy { get; set; }
        /// <summary>
        /// 资源标签列表。同一个终端节点服务最多可添加10个标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagList> Tags { get; set; }

        /// <summary>
        /// 描述字段，支持中英文字母、数字等字符，不支持“&lt;”或“&gt;”字符。  描述字段，支持中英文字母、数字等字符，不支持“&lt;”或“&gt;”字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEndpointServiceRequestBody {\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  approvalEnabled: ").Append(ApprovalEnabled).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  tcpProxy: ").Append(TcpProxy).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEndpointServiceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEndpointServiceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.VipPortId == input.VipPortId ||
                    (this.VipPortId != null &&
                    this.VipPortId.Equals(input.VipPortId))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.ApprovalEnabled == input.ApprovalEnabled ||
                    (this.ApprovalEnabled != null &&
                    this.ApprovalEnabled.Equals(input.ApprovalEnabled))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.ServerType == input.ServerType ||
                    (this.ServerType != null &&
                    this.ServerType.Equals(input.ServerType))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.TcpProxy == input.TcpProxy ||
                    (this.TcpProxy != null &&
                    this.TcpProxy.Equals(input.TcpProxy))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.ApprovalEnabled != null)
                    hashCode = hashCode * 59 + this.ApprovalEnabled.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServerType != null)
                    hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.TcpProxy != null)
                    hashCode = hashCode * 59 + this.TcpProxy.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
