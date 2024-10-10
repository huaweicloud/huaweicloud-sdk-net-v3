using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAllMembersRequest 
    {

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 参数解释：每页返回的个数。  取值范围：0-2000  默认取值：2000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 后端服务器名称。  支持多值查询，查询条件格式：*name&#x3D;xxx&amp;name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 后端服务器的权重，请求按权重在同一后端服务器组下的后端服务器间分发。 权重为0的后端不再接受新的请求。 当后端服务器所在的后端服务器组的lb_algorithm的取值为SOURCE_IP时，该字段无效。  支持多值查询，查询条件格式：*weight&#x3D;xxx&amp;weight&#x3D;xxx*。
        /// </summary>
        [SDKProperty("weight", IsQuery = true)]
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Weight { get; set; }

        /// <summary>
        /// 后端服务器的管理状态；该字段虽然支持创建、更新，但实际取值决定于member对应的弹性云服务器是否存在。 若存在，该值为true，否则，该值为false。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端服务器所在的子网ID。该子网和后端服务器关联的负载均衡器的子网必须在同一VPC下。只支持指定IPv4的子网ID。  支持多值查询，查询条件格式：***subnet_cidr_id&#x3D;xxx&amp;subnet_cidr_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("subnet_cidr_id", IsQuery = true)]
        [JsonProperty("subnet_cidr_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetCidrId { get; set; }

        /// <summary>
        /// 后端服务器的对应的IP地址，这个IP必须在subnet_cidr_id字段的子网网段中。 例如：192.168.3.11。  支持多值查询，查询条件格式：*address&#x3D;xxx&amp;address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("address", IsQuery = true)]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Address { get; set; }

        /// <summary>
        /// 后端服务器端口号。  支持多值查询，查询条件格式：*protocol_port&#x3D;xxx&amp;protocol_port&#x3D;xxx*。
        /// </summary>
        [SDKProperty("protocol_port", IsQuery = true)]
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ProtocolPort { get; set; }

        /// <summary>
        /// 后端服务器ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 后端服务器的健康状态。  取值： - ONLINE，后端服务器正常运行。 - NO_MONITOR，后端服务器无健康检查。 - OFFLINE，已下线。  支持多值查询，查询条件格式：*operating_status&#x3D;xxx&amp;operating_status&#x3D;*。
        /// </summary>
        [SDKProperty("operating_status", IsQuery = true)]
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperatingStatus { get; set; }

        /// <summary>
        /// 企业项目ID。不传时查询default企业项目\&quot;0\&quot;下的资源，鉴权按照default企业项目鉴权； 如果传值，则传已存在的企业项目ID或all_granted_eps（表示查询所有企业项目）进行查询。  支持多值查询，查询条件格式： *enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// IP版本，取值v4、v6。  支持多值查询，查询条件格式：*ip_version&#x3D;xxx&amp;ip_version&#x3D;xxx*。
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpVersion { get; set; }

        /// <summary>
        /// member所属的服务器组ID  支持多值查询，查询条件格式：*pool_id&#x3D;xxx&amp;pool_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("pool_id", IsQuery = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PoolId { get; set; }

        /// <summary>
        /// member所属的负载均衡器ID。  支持多值查询，查询条件格式：*loadbalancer_id&#x3D;xxx&amp;loadbalancer_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllMembersRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  subnetCidrId: ").Append(SubnetCidrId).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllMembersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllMembersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight != null &&
                    input.Weight != null &&
                    this.Weight.SequenceEqual(input.Weight)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.SubnetCidrId == input.SubnetCidrId ||
                    this.SubnetCidrId != null &&
                    input.SubnetCidrId != null &&
                    this.SubnetCidrId.SequenceEqual(input.SubnetCidrId)
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address != null &&
                    input.Address != null &&
                    this.Address.SequenceEqual(input.Address)
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    this.ProtocolPort != null &&
                    input.ProtocolPort != null &&
                    this.ProtocolPort.SequenceEqual(input.ProtocolPort)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    this.OperatingStatus != null &&
                    input.OperatingStatus != null &&
                    this.OperatingStatus.SequenceEqual(input.OperatingStatus)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    this.IpVersion != null &&
                    input.IpVersion != null &&
                    this.IpVersion.SequenceEqual(input.IpVersion)
                ) && 
                (
                    this.PoolId == input.PoolId ||
                    this.PoolId != null &&
                    input.PoolId != null &&
                    this.PoolId.SequenceEqual(input.PoolId)
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    this.LoadbalancerId != null &&
                    input.LoadbalancerId != null &&
                    this.LoadbalancerId.SequenceEqual(input.LoadbalancerId)
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
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.SubnetCidrId != null)
                    hashCode = hashCode * 59 + this.SubnetCidrId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
