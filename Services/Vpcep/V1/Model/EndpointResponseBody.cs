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
    /// 终端节接口响应结构体
    /// </summary>
    public class EndpointResponseBody 
    {

        /// <summary>
        /// 终端节点的ID，唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 终端节点连接的终端节点服务类型。  - gateway：由运维人员配置。用户无需创建，可直接使用。  - interface：包括运维人员配置的云服务和用户自己创建的私有服务。 其中，运维人员配置的云服务无需创建，用户可直接使用。 您可以通过查询公共终端节点服务列表， 查看由运维人员配置的所有用户可见且可连接的终端节点服务， 并通过创建终端节点服务创建Interface类型的终端节点服务。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 终端节点的连接状态。  - pendingAcceptance：待接受  - creating：创建中  - accepted：已接受  - rejected：已拒绝  - failed：失败  - deleting：删除中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 账号状态。  - frozen：冻结  - active：解冻
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
        /// 是否创建域名。  - true：创建域名  - false：不创建域名 说明 当创建gateway类型终端节点服务的终端节点时， “enable_dns”设置为true或者false，均不创建域名。
        /// </summary>
        [JsonProperty("enable_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDns { get; set; }

        /// <summary>
        /// 访问所连接的终端节点服务的域名。 当“enable_dns”为true时，该参数可见。
        /// </summary>
        [JsonProperty("dns_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsNames { get; set; }

        /// <summary>
        /// 访问所连接的终端节点服务的IP。 仅当同时满足如下条件时，返回该参数： 当查询连接interface类型终端节点服务的终端节点时。 终端节点服务启用“连接审批”功能，且已经“接受”连接审批。 “status”可以是“accepted”或者“rejected（仅支持“接受”连接审批后再“拒绝”的情况）”。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 终端节点所在的VPC的ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// vpc_id对应VPC下已创建的网络（network）的ID，UUID格式。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 终端节点的创建时间。 采用UTC时间格式，格式为：YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 终端节点的更新时间。 采用UTC时间格式，格式为：YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

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
        /// 错误信息。 当终端节点状态异常，即“status”的值为“failed”时，会返回该字段。
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryError> Error { get; set; }

        /// <summary>
        /// 控制访问终端节点的白名单。 若未创建，则返回空列表。 创建连接Interface类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Whitelist { get; set; }

        /// <summary>
        /// 是否开启网络ACL隔离。  - true：开启网络ACL隔离  - false：不开启网络ACL隔离 若未指定，则返回false。 创建连接Interface类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("enable_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWhitelist { get; set; }

        /// <summary>
        /// 路由表ID列表。 若未指定，返回默认VPC下路由表ID。 创建gateway类型终端节点服务的终端节点时，显示此参数。
        /// </summary>
        [JsonProperty("routetables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Routetables { get; set; }

        /// <summary>
        /// 描述字段，支持中英文字母、数字等字符，不支持“&lt;”或“&gt;”字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gateway类型终端节点策略信息，仅限OBS、SFS的终端节点服务的enable_policy值为true时支持该参数。
        /// </summary>
        [JsonProperty("policy_statement", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyStatement> PolicyStatement { get; set; }

        /// <summary>
        /// 终端节点策略信息，仅当终端节点服务的enable_policy值为true时支持该参数，默认值为完全访问权限。（OBS、SFS的终端节点服务暂不支持该参数）
        /// </summary>
        [JsonProperty("policy_document", NullValueHandling = NullValueHandling.Ignore)]
        public Object PolicyDocument { get; set; }

        /// <summary>
        /// 待废弃，实例相关联的集群ID
        /// </summary>
        [JsonProperty("endpoint_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointPoolId { get; set; }

        /// <summary>
        /// 终端节点关联的Public Border Group信息，只有当终端节点和边缘Pool相关联时才会返回该字段
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointResponseBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  activeStatus: ").Append(ActiveStatus).Append("\n");
            sb.Append("  endpointServiceName: ").Append(EndpointServiceName).Append("\n");
            sb.Append("  markerId: ").Append(MarkerId).Append("\n");
            sb.Append("  endpointServiceId: ").Append(EndpointServiceId).Append("\n");
            sb.Append("  enableDns: ").Append(EnableDns).Append("\n");
            sb.Append("  dnsNames: ").Append(DnsNames).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  error: ").Append(Error).Append("\n");
            sb.Append("  whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  enableWhitelist: ").Append(EnableWhitelist).Append("\n");
            sb.Append("  routetables: ").Append(Routetables).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  policyStatement: ").Append(PolicyStatement).Append("\n");
            sb.Append("  policyDocument: ").Append(PolicyDocument).Append("\n");
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
            return this.Equals(input as EndpointResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointResponseBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ActiveStatus != input.ActiveStatus || (this.ActiveStatus != null && input.ActiveStatus != null && !this.ActiveStatus.SequenceEqual(input.ActiveStatus))) return false;
            if (this.EndpointServiceName != input.EndpointServiceName || (this.EndpointServiceName != null && !this.EndpointServiceName.Equals(input.EndpointServiceName))) return false;
            if (this.MarkerId != input.MarkerId || (this.MarkerId != null && !this.MarkerId.Equals(input.MarkerId))) return false;
            if (this.EndpointServiceId != input.EndpointServiceId || (this.EndpointServiceId != null && !this.EndpointServiceId.Equals(input.EndpointServiceId))) return false;
            if (this.EnableDns != input.EnableDns || (this.EnableDns != null && !this.EnableDns.Equals(input.EnableDns))) return false;
            if (this.DnsNames != input.DnsNames || (this.DnsNames != null && input.DnsNames != null && !this.DnsNames.SequenceEqual(input.DnsNames))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Error != input.Error || (this.Error != null && input.Error != null && !this.Error.SequenceEqual(input.Error))) return false;
            if (this.Whitelist != input.Whitelist || (this.Whitelist != null && input.Whitelist != null && !this.Whitelist.SequenceEqual(input.Whitelist))) return false;
            if (this.EnableWhitelist != input.EnableWhitelist || (this.EnableWhitelist != null && !this.EnableWhitelist.Equals(input.EnableWhitelist))) return false;
            if (this.Routetables != input.Routetables || (this.Routetables != null && input.Routetables != null && !this.Routetables.SequenceEqual(input.Routetables))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PolicyStatement != input.PolicyStatement || (this.PolicyStatement != null && input.PolicyStatement != null && !this.PolicyStatement.SequenceEqual(input.PolicyStatement))) return false;
            if (this.PolicyDocument != input.PolicyDocument || (this.PolicyDocument != null && !this.PolicyDocument.Equals(input.PolicyDocument))) return false;
            if (this.EndpointPoolId != input.EndpointPoolId || (this.EndpointPoolId != null && !this.EndpointPoolId.Equals(input.EndpointPoolId))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ActiveStatus != null) hashCode = hashCode * 59 + this.ActiveStatus.GetHashCode();
                if (this.EndpointServiceName != null) hashCode = hashCode * 59 + this.EndpointServiceName.GetHashCode();
                if (this.MarkerId != null) hashCode = hashCode * 59 + this.MarkerId.GetHashCode();
                if (this.EndpointServiceId != null) hashCode = hashCode * 59 + this.EndpointServiceId.GetHashCode();
                if (this.EnableDns != null) hashCode = hashCode * 59 + this.EnableDns.GetHashCode();
                if (this.DnsNames != null) hashCode = hashCode * 59 + this.DnsNames.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Error != null) hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Whitelist != null) hashCode = hashCode * 59 + this.Whitelist.GetHashCode();
                if (this.EnableWhitelist != null) hashCode = hashCode * 59 + this.EnableWhitelist.GetHashCode();
                if (this.Routetables != null) hashCode = hashCode * 59 + this.Routetables.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PolicyStatement != null) hashCode = hashCode * 59 + this.PolicyStatement.GetHashCode();
                if (this.PolicyDocument != null) hashCode = hashCode * 59 + this.PolicyDocument.GetHashCode();
                if (this.EndpointPoolId != null) hashCode = hashCode * 59 + this.EndpointPoolId.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
