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
        /// 后端服务器组的描述信息。  支持多值查询，查询条件格式：*description&#x3D;xxx&amp;description&#x3D;xxx*。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 后端服务器组的管理状态。  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端服务器组关联的健康检查的ID。  支持多值查询，查询条件格式：*healthmonitor_id&#x3D;xxx&amp;healthmonitor_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("healthmonitor_id", IsQuery = true)]
        [JsonProperty("healthmonitor_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HealthmonitorId { get; set; }

        /// <summary>
        /// 后端服务器组的ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 后端服务器组的名称。  支持多值查询，查询条件格式：*name&#x3D;xxx&amp;name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 后端服务器组绑定的负载均衡器ID。  支持多值查询，查询条件格式：*loadbalancer_id&#x3D;xxx&amp;loadbalancer_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerId { get; set; }

        /// <summary>
        /// 后端服务器组的后端协议。  取值：TCP、UDP、[IP、](tag:hws_eu)TLS、HTTP、HTTPS、QUIC和GRPC。  支持多值查询，查询条件格式：*protocol&#x3D;xxx&amp;protocol&#x3D;xxx*。  [不支持QUIC协议。](tag:hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Protocol { get; set; }

        /// <summary>
        /// 后端服务器组的负载均衡算法。  取值： - ROUND_ROBIN：加权轮询算法。 - LEAST_CONNECTIONS：加权最少连接算法。 - SOURCE_IP：源IP算法。 - QUIC_CID：连接ID算法。 [- 2_TUPLE_HASH：二元组hash算法，仅IP类型的pool支持。 - 3_TUPLE_HASH：三元组hash算法，仅IP类型的pool支持。 - 5_TUPLE_HASH：五元组hash算法，仅IP类型的pool支持。 - IP型pool不指定该字段时，默认设置为5_TUPLE_HASH。](tag:hws_eu)  支持多值查询，查询条件格式：*lb_algorithm&#x3D;xxx&amp;lb_algorithm&#x3D;xxx*。  [不支持QUIC_CID。](tag:hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC_CID。](tag:dt)
        /// </summary>
        [SDKProperty("lb_algorithm", IsQuery = true)]
        [JsonProperty("lb_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LbAlgorithm { get; set; }

        /// <summary>
        /// 参数解释：所属的企业项目ID。 如果enterprise_project_id不传值，默认查询所有企业项目下的资源，鉴权按照细粒度权限鉴权，必须在用户组下分配elb:pools:list权限。 如果enterprise_project_id传值，鉴权按照企业项目权限鉴权，分为传入具体eps_id和all_granted_eps两种场景，前者查询指定eps_id的eps下的资源，后者查询的是所有有list权限的eps下的资源。  支持多值查询，查询条件格式： *enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 后端服务器组支持的IP版本。  支持多值查询，查询条件格式：*ip_version&#x3D;xxx&amp;ip_version&#x3D;xxx*。
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpVersion { get; set; }

        /// <summary>
        /// 后端服务器的IP地址。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_address&#x3D;xxx&amp;member_address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_address", IsQuery = true)]
        [JsonProperty("member_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberAddress { get; set; }

        /// <summary>
        /// 后端服务器对应的弹性云服务器的ID。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_device_id&#x3D;xxx&amp;member_device_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_device_id", IsQuery = true)]
        [JsonProperty("member_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberDeviceId { get; set; }

        /// <summary>
        /// 是否开启删除保护，false不开启，true开启，不传查询全部。 [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [SDKProperty("member_deletion_protection_enable", IsQuery = true)]
        [JsonProperty("member_deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MemberDeletionProtectionEnable { get; set; }

        /// <summary>
        /// 关联的监听器ID，包括通过l7policy关联的。  支持多值查询，查询条件格式：*listener_id&#x3D;xxx&amp;listener_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("listener_id", IsQuery = true)]
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ListenerId { get; set; }

        /// <summary>
        /// 后端服务器ID。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_instance_id&#x3D;xxx&amp;member_instance_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_instance_id", IsQuery = true)]
        [JsonProperty("member_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberInstanceId { get; set; }

        /// <summary>
        /// 后端服务器组关联的虚拟私有云的ID。
        /// </summary>
        [SDKProperty("vpc_id", IsQuery = true)]
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VpcId { get; set; }

        /// <summary>
        /// 后端服务器组的类型。  取值： - instance：允许任意类型的后端，type指定为该类型时，vpc_id是必选字段。 - ip：只能添加跨VPC后端，type指定为该类型时，vpc_id不允许指定。 - 空字符串（\&quot;\&quot;）：允许任意类型的后端
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }

        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护
        /// </summary>
        [SDKProperty("protection_status", IsQuery = true)]
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProtectionStatus { get; set; }

        /// <summary>
        /// 查询是否开启延迟注销的功能，查询条件格式：*connection_drain&#x3D;true或者*connection_drain&#x3D;false
        /// </summary>
        [SDKProperty("connection_drain", IsQuery = true)]
        [JsonProperty("connection_drain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectionDrain { get; set; }

        /// <summary>
        /// 查询是否开启后端全下线转发功能，查询条件格式：*pool_health&#x3D;minimum_healthy_member_count&#x3D;0或者*pool_health&#x3D;minimum_healthy_member_count&#x3D;1
        /// </summary>
        [SDKProperty("pool_health", IsQuery = true)]
        [JsonProperty("pool_health", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolHealth { get; set; }

        /// <summary>
        /// 后端是否开启端口透传。开启后，后端服务器端口与前端监听器端口保持一致。取值：false不开启，true开启。
        /// </summary>
        [SDKProperty("any_port_enable", IsQuery = true)]
        [JsonProperty("any_port_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnyPortEnable { get; set; }

        /// <summary>
        /// 网络公共边界组
        /// </summary>
        [SDKProperty("public_border_group", IsQuery = true)]
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 查询相同QUIC CID策略配置的后端服务器组，仅用于查询条件，不作为响应参数字段。 支持多值查询，查询条件格式：*quic_cid_len&#x3D;3&amp;quic_cid_len&#x3D;5*
        /// </summary>
        [SDKProperty("quic_cid_len", IsQuery = true)]
        [JsonProperty("quic_cid_len", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuicCidLen { get; set; }

        /// <summary>
        /// 查询相同QUIC CID策略配置的后端服务器组，仅用于查询条件，不作为响应参数字段。 支持多值查询，查询条件格式：*quic_cid_offset&#x3D;1&amp;quic_cid_offset&#x3D;3*
        /// </summary>
        [SDKProperty("quic_cid_offset", IsQuery = true)]
        [JsonProperty("quic_cid_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuicCidOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPoolsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  healthmonitorId: ").Append(HealthmonitorId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  lbAlgorithm: ").Append(LbAlgorithm).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  memberAddress: ").Append(MemberAddress).Append("\n");
            sb.Append("  memberDeviceId: ").Append(MemberDeviceId).Append("\n");
            sb.Append("  memberDeletionProtectionEnable: ").Append(MemberDeletionProtectionEnable).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  memberInstanceId: ").Append(MemberInstanceId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  connectionDrain: ").Append(ConnectionDrain).Append("\n");
            sb.Append("  poolHealth: ").Append(PoolHealth).Append("\n");
            sb.Append("  anyPortEnable: ").Append(AnyPortEnable).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  quicCidLen: ").Append(QuicCidLen).Append("\n");
            sb.Append("  quicCidOffset: ").Append(QuicCidOffset).Append("\n");
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
            if (input == null) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Description != input.Description || (this.Description != null && input.Description != null && !this.Description.SequenceEqual(input.Description))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.HealthmonitorId != input.HealthmonitorId || (this.HealthmonitorId != null && input.HealthmonitorId != null && !this.HealthmonitorId.SequenceEqual(input.HealthmonitorId))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && input.LoadbalancerId != null && !this.LoadbalancerId.SequenceEqual(input.LoadbalancerId))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && input.Protocol != null && !this.Protocol.SequenceEqual(input.Protocol))) return false;
            if (this.LbAlgorithm != input.LbAlgorithm || (this.LbAlgorithm != null && input.LbAlgorithm != null && !this.LbAlgorithm.SequenceEqual(input.LbAlgorithm))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && input.IpVersion != null && !this.IpVersion.SequenceEqual(input.IpVersion))) return false;
            if (this.MemberAddress != input.MemberAddress || (this.MemberAddress != null && input.MemberAddress != null && !this.MemberAddress.SequenceEqual(input.MemberAddress))) return false;
            if (this.MemberDeviceId != input.MemberDeviceId || (this.MemberDeviceId != null && input.MemberDeviceId != null && !this.MemberDeviceId.SequenceEqual(input.MemberDeviceId))) return false;
            if (this.MemberDeletionProtectionEnable != input.MemberDeletionProtectionEnable || (this.MemberDeletionProtectionEnable != null && !this.MemberDeletionProtectionEnable.Equals(input.MemberDeletionProtectionEnable))) return false;
            if (this.ListenerId != input.ListenerId || (this.ListenerId != null && input.ListenerId != null && !this.ListenerId.SequenceEqual(input.ListenerId))) return false;
            if (this.MemberInstanceId != input.MemberInstanceId || (this.MemberInstanceId != null && input.MemberInstanceId != null && !this.MemberInstanceId.SequenceEqual(input.MemberInstanceId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && input.VpcId != null && !this.VpcId.SequenceEqual(input.VpcId))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;
            if (this.ProtectionStatus != input.ProtectionStatus || (this.ProtectionStatus != null && input.ProtectionStatus != null && !this.ProtectionStatus.SequenceEqual(input.ProtectionStatus))) return false;
            if (this.ConnectionDrain != input.ConnectionDrain || (this.ConnectionDrain != null && !this.ConnectionDrain.Equals(input.ConnectionDrain))) return false;
            if (this.PoolHealth != input.PoolHealth || (this.PoolHealth != null && !this.PoolHealth.Equals(input.PoolHealth))) return false;
            if (this.AnyPortEnable != input.AnyPortEnable || (this.AnyPortEnable != null && !this.AnyPortEnable.Equals(input.AnyPortEnable))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;
            if (this.QuicCidLen != input.QuicCidLen || (this.QuicCidLen != null && !this.QuicCidLen.Equals(input.QuicCidLen))) return false;
            if (this.QuicCidOffset != input.QuicCidOffset || (this.QuicCidOffset != null && !this.QuicCidOffset.Equals(input.QuicCidOffset))) return false;

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
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.HealthmonitorId != null) hashCode = hashCode * 59 + this.HealthmonitorId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.LbAlgorithm != null) hashCode = hashCode * 59 + this.LbAlgorithm.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.MemberAddress != null) hashCode = hashCode * 59 + this.MemberAddress.GetHashCode();
                if (this.MemberDeviceId != null) hashCode = hashCode * 59 + this.MemberDeviceId.GetHashCode();
                if (this.MemberDeletionProtectionEnable != null) hashCode = hashCode * 59 + this.MemberDeletionProtectionEnable.GetHashCode();
                if (this.ListenerId != null) hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.MemberInstanceId != null) hashCode = hashCode * 59 + this.MemberInstanceId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProtectionStatus != null) hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ConnectionDrain != null) hashCode = hashCode * 59 + this.ConnectionDrain.GetHashCode();
                if (this.PoolHealth != null) hashCode = hashCode * 59 + this.PoolHealth.GetHashCode();
                if (this.AnyPortEnable != null) hashCode = hashCode * 59 + this.AnyPortEnable.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.QuicCidLen != null) hashCode = hashCode * 59 + this.QuicCidLen.GetHashCode();
                if (this.QuicCidOffset != null) hashCode = hashCode * 59 + this.QuicCidOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
