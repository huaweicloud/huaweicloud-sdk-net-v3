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
    /// 
    /// </summary>
    public class ServiceList 
    {
        /// <summary>
        /// 终端节点服务的状态。 ● creating：创建中 ● available：可连接 ● failed：失败 ● deleting：删除中
        /// </summary>
        /// <value>终端节点服务的状态。 ● creating：创建中 ● available：可连接 ● failed：失败 ● deleting：删除中</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("creating");

            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("available");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "creating", CREATING },
                { "available", AVAILABLE },
                { "failed", FAILED },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 终端节点服务类型。 终端节点服务类型包括“网关（gataway）型”和“接口（interface）型”： ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过创建终端节点创建访问Gateway和Interface类型终端节点服务的终端节点。
        /// </summary>
        /// <value>终端节点服务类型。 终端节点服务类型包括“网关（gataway）型”和“接口（interface）型”： ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过创建终端节点创建访问Gateway和Interface类型终端节点服务的终端节点。</value>
        [JsonConverter(typeof(EnumClassConverter<ServiceTypeEnum>))]
        public class ServiceTypeEnum
        {
            /// <summary>
            /// Enum VM for value: VM
            /// </summary>
            public static readonly ServiceTypeEnum VM = new ServiceTypeEnum("VM");

            /// <summary>
            /// Enum VIP for value: VIP
            /// </summary>
            public static readonly ServiceTypeEnum VIP = new ServiceTypeEnum("VIP");

            /// <summary>
            /// Enum LB for value: LB
            /// </summary>
            public static readonly ServiceTypeEnum LB = new ServiceTypeEnum("LB");

            private static readonly Dictionary<string, ServiceTypeEnum> StaticFields =
            new Dictionary<string, ServiceTypeEnum>()
            {
                { "VM", VM },
                { "VIP", VIP },
                { "LB", LB },
            };

            private string Value;

            public ServiceTypeEnum(string value)
            {
                Value = value;
            }

            public static ServiceTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ServiceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ServiceTypeEnum a, ServiceTypeEnum b)
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

            public static bool operator !=(ServiceTypeEnum a, ServiceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 用于控制是否将客户端的源IP、源端口、marker_id等信息携带到服务端。 信息携带支持两种方式： ● TCP TOA：表示将客户端信息插入到tcp，option字段中携带至服务端。 说明 仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。 ● Proxy Protocol：表示将客户端相关信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 参数的取值包括： ● close：表示关闭代理协议。 ● toa_open：表示开启代理协议“tcp_toa”。 ● proxy_open：表示开启代理协议“proxy_protocol”。 ● open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。
        /// </summary>
        /// <value>用于控制是否将客户端的源IP、源端口、marker_id等信息携带到服务端。 信息携带支持两种方式： ● TCP TOA：表示将客户端信息插入到tcp，option字段中携带至服务端。 说明 仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。 ● Proxy Protocol：表示将客户端相关信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 参数的取值包括： ● close：表示关闭代理协议。 ● toa_open：表示开启代理协议“tcp_toa”。 ● proxy_open：表示开启代理协议“proxy_protocol”。 ● open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。</value>
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

            private string Value;

            public TcpProxyEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 终端节点服务的ID，唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 标识终端节点服务后端资源的ID， 格式为通用唯一识别码（Universally Unique Identifier，下文简称UUID）。取值为： ● LB类型：增强型负载均衡器内网IP对应的端口ID。 ● VM类型：弹性云服务器IP地址对应的网卡ID。 ● VIP类型：虚拟资源所在物理服务器对应的网卡ID。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 虚拟IP的网卡ID。 仅当“port_id”为“VIP类型”时，返回该参数。
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 终端节点服务的名称。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 资源类型。 ● VM：云服务器。 ● VIP：虚拟IP。 ● LB：增强负载均衡型。
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerType { get; set; }

        /// <summary>
        /// 终端节点服务对应后端资源所在的VPC的ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 是否需要审批。 ● false：不需要审批，创建的终端节点连接直接为accepted状态。 ● true：需要审批，创建的终端节点连接为pendingAcceptance状态， 需要终端节点服务所属用户审核后方可使用。
        /// </summary>
        [JsonProperty("approval_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalEnabled { get; set; }

        /// <summary>
        /// 终端节点服务的状态。 ● creating：创建中 ● available：可连接 ● failed：失败 ● deleting：删除中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 终端节点服务类型。 终端节点服务类型包括“网关（gataway）型”和“接口（interface）型”： ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过创建终端节点创建访问Gateway和Interface类型终端节点服务的终端节点。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceTypeEnum ServiceType { get; set; }
        /// <summary>
        /// 终端节点服务的创建时间。 采用UTC时间格式，格式为：YYYY-MMDDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 终端节点服务的更新时间。 采用UTC时间格式，格式为：YYYY-MMDDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 项目ID，获取方法请参见获取项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Domain ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 服务开放的端口映射列表 同一个终端节点服务下，不允许重复的端口映射。 若多个终端节点服务共用一个port_id， 则终端节点服务之间的所有端口映射的server_port和protocol的组合不能重复。
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortList> Ports { get; set; }

        /// <summary>
        /// 资源标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagList> Tags { get; set; }

        /// <summary>
        /// 终端节点服务下连接的状态为“创建中”或“已接受”的终端节点的个数。
        /// </summary>
        [JsonProperty("connection_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectionCount { get; set; }

        /// <summary>
        /// 用于控制是否将客户端的源IP、源端口、marker_id等信息携带到服务端。 信息携带支持两种方式： ● TCP TOA：表示将客户端信息插入到tcp，option字段中携带至服务端。 说明 仅当后端资源为OBS时，支持TCP TOA类型信息携带方式。 ● Proxy Protocol：表示将客户端相关信息插入到tcp payload字段中携带至服务端。 仅当服务端支持解析上述字段时，该参数设置才有效。 参数的取值包括： ● close：表示关闭代理协议。 ● toa_open：表示开启代理协议“tcp_toa”。 ● proxy_open：表示开启代理协议“proxy_protocol”。 ● open：表示同时开启代理协议“tcp_toa”和“proxy_protocol”。 默认值为“close”。
        /// </summary>
        [JsonProperty("tcp_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public TcpProxyEnum TcpProxy { get; set; }
        /// <summary>
        /// 提交任务异常时返回的异常信息
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<Error> Error { get; set; }

        /// <summary>
        /// 描述字段，支持中英文字母、数字等字符，不支持“&lt;”或“&gt;”字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 终端节点服务对应Pool的Public Border Group信息
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  approvalEnabled: ").Append(ApprovalEnabled).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  connectionCount: ").Append(ConnectionCount).Append("\n");
            sb.Append("  tcpProxy: ").Append(TcpProxy).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
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
                    this.ServerType == input.ServerType ||
                    (this.ServerType != null &&
                    this.ServerType.Equals(input.ServerType))
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ConnectionCount == input.ConnectionCount ||
                    (this.ConnectionCount != null &&
                    this.ConnectionCount.Equals(input.ConnectionCount))
                ) && 
                (
                    this.TcpProxy == input.TcpProxy ||
                    (this.TcpProxy != null &&
                    this.TcpProxy.Equals(input.TcpProxy))
                ) && 
                (
                    this.Error == input.Error ||
                    this.Error != null &&
                    input.Error != null &&
                    this.Error.SequenceEqual(input.Error)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.ServerType != null)
                    hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.ApprovalEnabled != null)
                    hashCode = hashCode * 59 + this.ApprovalEnabled.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ConnectionCount != null)
                    hashCode = hashCode * 59 + this.ConnectionCount.GetHashCode();
                if (this.TcpProxy != null)
                    hashCode = hashCode * 59 + this.TcpProxy.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}