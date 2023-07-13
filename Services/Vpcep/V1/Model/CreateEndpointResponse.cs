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
    /// Response Object
    /// </summary>
    public class CreateEndpointResponse : SdkResponse
    {
        /// <summary>
        /// 终端节点连接的终端节点服务类型。 ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过查询公共终端节点服务列表， 查看由运维人员配置的所有用户可见且可连接的终端节点服务， 并通过创建终端节点服务创建Interface类型的终端节点服务。
        /// </summary>
        /// <value>终端节点连接的终端节点服务类型。 ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过查询公共终端节点服务列表， 查看由运维人员配置的所有用户可见且可连接的终端节点服务， 并通过创建终端节点服务创建Interface类型的终端节点服务。</value>
        [JsonConverter(typeof(EnumClassConverter<ServiceTypeEnum>))]
        public class ServiceTypeEnum
        {
            /// <summary>
            /// Enum INTERFACE for value: interface
            /// </summary>
            public static readonly ServiceTypeEnum INTERFACE = new ServiceTypeEnum("interface");

            /// <summary>
            /// Enum GATEWAY for value: gateway
            /// </summary>
            public static readonly ServiceTypeEnum GATEWAY = new ServiceTypeEnum("gateway");

            private static readonly Dictionary<string, ServiceTypeEnum> StaticFields =
            new Dictionary<string, ServiceTypeEnum>()
            {
                { "interface", INTERFACE },
                { "gateway", GATEWAY },
            };

            private string _value;

            public ServiceTypeEnum()
            {

            }

            public ServiceTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 终端节点的状态。 ● pendingAcceptance：待接受 ● creating：创建中 ● accepted：已接受 ● rejected：已拒绝 ● failed：失败 ● deleting：删除中
        /// </summary>
        /// <value>终端节点的状态。 ● pendingAcceptance：待接受 ● creating：创建中 ● accepted：已接受 ● rejected：已拒绝 ● failed：失败 ● deleting：删除中</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum PENDINGACCEPTANCE for value: pendingAcceptance
            /// </summary>
            public static readonly StatusEnum PENDINGACCEPTANCE = new StatusEnum("pendingAcceptance");

            /// <summary>
            /// Enum CREATING for value: creating
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("creating");

            /// <summary>
            /// Enum ACCEPTED for value: accepted
            /// </summary>
            public static readonly StatusEnum ACCEPTED = new StatusEnum("accepted");

            /// <summary>
            /// Enum REJECTED for value: rejected
            /// </summary>
            public static readonly StatusEnum REJECTED = new StatusEnum("rejected");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("failed");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "pendingAcceptance", PENDINGACCEPTANCE },
                { "creating", CREATING },
                { "accepted", ACCEPTED },
                { "rejected", REJECTED },
                { "failed", FAILED },
                { "deleting", DELETING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 终端节点的ID，唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 终端节点连接的终端节点服务类型。 ● gataway：由运维人员配置。用户无需创建，可直接使用。 ● interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过查询公共终端节点服务列表， 查看由运维人员配置的所有用户可见且可连接的终端节点服务， 并通过创建终端节点服务创建Interface类型的终端节点服务。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceTypeEnum ServiceType { get; set; }
        /// <summary>
        /// 终端节点的状态。 ● pendingAcceptance：待接受 ● creating：创建中 ● accepted：已接受 ● rejected：已拒绝 ● failed：失败 ● deleting：删除中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 终端节点ip
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 帐号状态。 ● frozen：冻结 ● active：解冻
        /// </summary>
        [JsonProperty("active_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ActiveStatus { get; set; }

        /// <summary>
        /// 终端节点服务的名称。
        /// </summary>
        [JsonProperty("endpoint_service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointServiceName { get; set; }

        /// <summary>
        /// 终端节点的报文标识。
        /// </summary>
        [JsonProperty("marker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MarkerId { get; set; }

        /// <summary>
        /// 终端节点服务的ID。
        /// </summary>
        [JsonProperty("endpoint_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointServiceId { get; set; }

        /// <summary>
        /// 是否创建域名。 ● true：创建域名 ● false：不创建域名 说明 当创建连接gateway类型终端节点服务的终端节点时， “enable_dns”设置为true或者false，均不创建域名。
        /// </summary>
        [JsonProperty("enable_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDns { get; set; }

        /// <summary>
        /// 访问所连接的终端节点服务的域名。 当“enable_dns”为true时，该参数可见。
        /// </summary>
        [JsonProperty("dns_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsNames { get; set; }

        /// <summary>
        /// vpc_id对应VPC下已创建的网络（network）的ID，UUID格式。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 终端节点所在的VPC的ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 终端节点的创建时间。 采用UTC时间格式，格式为：YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 终端节点的更新时间。 采用UTC时间格式，格式为：YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 项目ID，获取方法请参见获取项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 标签列表，没有标签默认为空数组。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagList> Tags { get; set; }

        /// <summary>
        /// 控制访问终端节点的白名单。 若未创建，则返回空列表。 创建连接Interface类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Whitelist { get; set; }

        /// <summary>
        /// 是否开启网络ACL隔离。 ● true：开启网络ACL隔离 ● false：不开启网络ACL隔离 若未指定，则返回false。 创建连接Interface类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("enable_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWhitelist { get; set; }

        /// <summary>
        /// 路由表ID列表。 若未指定，返回默认VPC下路由表ID。 创建连接Gateway类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("routetables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Routetables { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("specification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 只涉及开启双端固定的网关型终端节点，响应体展示此字段
        /// </summary>
        [JsonProperty("policy_statement", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PolicyStatement { get; set; }

        /// <summary>
        /// 终端节点是否已停用，取值【enable/disable】
        /// </summary>
        [JsonProperty("enable_status", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// 待废弃，实例相关联的集群ID
        /// </summary>
        [JsonProperty("endpoint_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointPoolId { get; set; }

        /// <summary>
        /// 终端节点对应Pool的Public Border Group信息
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEndpointResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  activeStatus: ").Append(ActiveStatus).Append("\n");
            sb.Append("  endpointServiceName: ").Append(EndpointServiceName).Append("\n");
            sb.Append("  markerId: ").Append(MarkerId).Append("\n");
            sb.Append("  endpointServiceId: ").Append(EndpointServiceId).Append("\n");
            sb.Append("  enableDns: ").Append(EnableDns).Append("\n");
            sb.Append("  dnsNames: ").Append(DnsNames).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  enableWhitelist: ").Append(EnableWhitelist).Append("\n");
            sb.Append("  routetables: ").Append(Routetables).Append("\n");
            sb.Append("  specificationName: ").Append(SpecificationName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  policyStatement: ").Append(PolicyStatement).Append("\n");
            sb.Append("  enableStatus: ").Append(EnableStatus).Append("\n");
            sb.Append("  endpointPoolId: ").Append(EndpointPoolId).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEndpointResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEndpointResponse input)
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
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.ActiveStatus == input.ActiveStatus ||
                    this.ActiveStatus != null &&
                    input.ActiveStatus != null &&
                    this.ActiveStatus.SequenceEqual(input.ActiveStatus)
                ) && 
                (
                    this.EndpointServiceName == input.EndpointServiceName ||
                    (this.EndpointServiceName != null &&
                    this.EndpointServiceName.Equals(input.EndpointServiceName))
                ) && 
                (
                    this.MarkerId == input.MarkerId ||
                    (this.MarkerId != null &&
                    this.MarkerId.Equals(input.MarkerId))
                ) && 
                (
                    this.EndpointServiceId == input.EndpointServiceId ||
                    (this.EndpointServiceId != null &&
                    this.EndpointServiceId.Equals(input.EndpointServiceId))
                ) && 
                (
                    this.EnableDns == input.EnableDns ||
                    (this.EnableDns != null &&
                    this.EnableDns.Equals(input.EnableDns))
                ) && 
                (
                    this.DnsNames == input.DnsNames ||
                    this.DnsNames != null &&
                    input.DnsNames != null &&
                    this.DnsNames.SequenceEqual(input.DnsNames)
                ) && 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Whitelist == input.Whitelist ||
                    this.Whitelist != null &&
                    input.Whitelist != null &&
                    this.Whitelist.SequenceEqual(input.Whitelist)
                ) && 
                (
                    this.EnableWhitelist == input.EnableWhitelist ||
                    (this.EnableWhitelist != null &&
                    this.EnableWhitelist.Equals(input.EnableWhitelist))
                ) && 
                (
                    this.Routetables == input.Routetables ||
                    this.Routetables != null &&
                    input.Routetables != null &&
                    this.Routetables.SequenceEqual(input.Routetables)
                ) && 
                (
                    this.SpecificationName == input.SpecificationName ||
                    (this.SpecificationName != null &&
                    this.SpecificationName.Equals(input.SpecificationName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PolicyStatement == input.PolicyStatement ||
                    this.PolicyStatement != null &&
                    input.PolicyStatement != null &&
                    this.PolicyStatement.SequenceEqual(input.PolicyStatement)
                ) && 
                (
                    this.EnableStatus == input.EnableStatus ||
                    (this.EnableStatus != null &&
                    this.EnableStatus.Equals(input.EnableStatus))
                ) && 
                (
                    this.EndpointPoolId == input.EndpointPoolId ||
                    (this.EndpointPoolId != null &&
                    this.EndpointPoolId.Equals(input.EndpointPoolId))
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
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.ActiveStatus != null)
                    hashCode = hashCode * 59 + this.ActiveStatus.GetHashCode();
                if (this.EndpointServiceName != null)
                    hashCode = hashCode * 59 + this.EndpointServiceName.GetHashCode();
                if (this.MarkerId != null)
                    hashCode = hashCode * 59 + this.MarkerId.GetHashCode();
                if (this.EndpointServiceId != null)
                    hashCode = hashCode * 59 + this.EndpointServiceId.GetHashCode();
                if (this.EnableDns != null)
                    hashCode = hashCode * 59 + this.EnableDns.GetHashCode();
                if (this.DnsNames != null)
                    hashCode = hashCode * 59 + this.DnsNames.GetHashCode();
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Whitelist != null)
                    hashCode = hashCode * 59 + this.Whitelist.GetHashCode();
                if (this.EnableWhitelist != null)
                    hashCode = hashCode * 59 + this.EnableWhitelist.GetHashCode();
                if (this.Routetables != null)
                    hashCode = hashCode * 59 + this.Routetables.GetHashCode();
                if (this.SpecificationName != null)
                    hashCode = hashCode * 59 + this.SpecificationName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PolicyStatement != null)
                    hashCode = hashCode * 59 + this.PolicyStatement.GetHashCode();
                if (this.EnableStatus != null)
                    hashCode = hashCode * 59 + this.EnableStatus.GetHashCode();
                if (this.EndpointPoolId != null)
                    hashCode = hashCode * 59 + this.EndpointPoolId.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
