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
    public class ListPoolsRequest 
    {

        /// <summary>
        /// 后端云服务器组的管理状态；该字段为预留字段，暂未启用。只支持更新为true。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端云服务器组的描述信息。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 后端云服务器组关联的健康检查的ID。
        /// </summary>
        [SDKProperty("healthmonitor_id", IsQuery = true)]
        [JsonProperty("healthmonitor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HealthmonitorId { get; set; }

        /// <summary>
        /// 后端云服务器组的ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 后端云服务器组所在ip_version。 取值范围：dualstack,v4,v6。
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpVersion { get; set; }

        /// <summary>
        /// 后端云服务器组的负载均衡算法，取值：ROUND_ROBIN：加权轮询算法；LEAST_CONNECTIONS：加权最少连接算法；SOURCE_IP：源IP算法；当该字段的取值为SOURCE_IP时，后端云服务器组绑定的后端云服务器的weight字段无效。
        /// </summary>
        [SDKProperty("lb_algorithm", IsQuery = true)]
        [JsonProperty("lb_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LbAlgorithm { get; set; }

        /// <summary>
        /// 每页返回的个数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 后端云服务器组绑定的负载均衡器ID。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerId { get; set; }

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明：  - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 后端云服务器的IP地址。
        /// </summary>
        [SDKProperty("member_address", IsQuery = true)]
        [JsonProperty("member_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberAddress { get; set; }

        /// <summary>
        /// 是否开启删除保护，false不开启，默认为空查询全部
        /// </summary>
        [SDKProperty("member_deletion_protection_enable", IsQuery = true)]
        [JsonProperty("member_deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MemberDeletionProtectionEnable { get; set; }

        /// <summary>
        /// 后端云服务器对应的弹性云服务器的ID。
        /// </summary>
        [SDKProperty("member_device_id", IsQuery = true)]
        [JsonProperty("member_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberDeviceId { get; set; }

        /// <summary>
        /// 后端云服务器组的名称。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 分页的顺序，true表示从后往前分页，false表示从前往后分页，默认为false。使用说明：必须与limit一起使用。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 后端云服务器组的后端协议。
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Protocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoolsRequest {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  healthmonitorId: ").Append(HealthmonitorId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  lbAlgorithm: ").Append(LbAlgorithm).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  memberAddress: ").Append(MemberAddress).Append("\n");
            sb.Append("  memberDeletionProtectionEnable: ").Append(MemberDeletionProtectionEnable).Append("\n");
            sb.Append("  memberDeviceId: ").Append(MemberDeviceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPoolsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPoolsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.HealthmonitorId == input.HealthmonitorId ||
                    this.HealthmonitorId != null &&
                    input.HealthmonitorId != null &&
                    this.HealthmonitorId.SequenceEqual(input.HealthmonitorId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    this.IpVersion != null &&
                    input.IpVersion != null &&
                    this.IpVersion.SequenceEqual(input.IpVersion)
                ) && 
                (
                    this.LbAlgorithm == input.LbAlgorithm ||
                    this.LbAlgorithm != null &&
                    input.LbAlgorithm != null &&
                    this.LbAlgorithm.SequenceEqual(input.LbAlgorithm)
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    this.LoadbalancerId != null &&
                    input.LoadbalancerId != null &&
                    this.LoadbalancerId.SequenceEqual(input.LoadbalancerId)
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.MemberAddress == input.MemberAddress ||
                    this.MemberAddress != null &&
                    input.MemberAddress != null &&
                    this.MemberAddress.SequenceEqual(input.MemberAddress)
                ) && 
                (
                    this.MemberDeletionProtectionEnable == input.MemberDeletionProtectionEnable ||
                    (this.MemberDeletionProtectionEnable != null &&
                    this.MemberDeletionProtectionEnable.Equals(input.MemberDeletionProtectionEnable))
                ) && 
                (
                    this.MemberDeviceId == input.MemberDeviceId ||
                    this.MemberDeviceId != null &&
                    input.MemberDeviceId != null &&
                    this.MemberDeviceId.SequenceEqual(input.MemberDeviceId)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol != null &&
                    input.Protocol != null &&
                    this.Protocol.SequenceEqual(input.Protocol)
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.HealthmonitorId != null)
                    hashCode = hashCode * 59 + this.HealthmonitorId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.LbAlgorithm != null)
                    hashCode = hashCode * 59 + this.LbAlgorithm.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.MemberAddress != null)
                    hashCode = hashCode * 59 + this.MemberAddress.GetHashCode();
                if (this.MemberDeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.MemberDeletionProtectionEnable.GetHashCode();
                if (this.MemberDeviceId != null)
                    hashCode = hashCode * 59 + this.MemberDeviceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
