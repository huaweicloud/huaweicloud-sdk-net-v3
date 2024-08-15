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
    /// 创建云服务器组请求返回对象
    /// </summary>
    public class Pool 
    {
        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护
        /// </summary>
        /// <value>修改保护状态, 取值： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectionStatusEnum>))]
        public class ProtectionStatusEnum
        {
            /// <summary>
            /// Enum NONPROTECTION for value: nonProtection
            /// </summary>
            public static readonly ProtectionStatusEnum NONPROTECTION = new ProtectionStatusEnum("nonProtection");

            /// <summary>
            /// Enum CONSOLEPROTECTION for value: consoleProtection
            /// </summary>
            public static readonly ProtectionStatusEnum CONSOLEPROTECTION = new ProtectionStatusEnum("consoleProtection");

            private static readonly Dictionary<string, ProtectionStatusEnum> StaticFields =
            new Dictionary<string, ProtectionStatusEnum>()
            {
                { "nonProtection", NONPROTECTION },
                { "consoleProtection", CONSOLEPROTECTION },
            };

            private string _value;

            public ProtectionStatusEnum()
            {

            }

            public ProtectionStatusEnum(string value)
            {
                _value = value;
            }

            public static ProtectionStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectionStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectionStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectionStatusEnum a, ProtectionStatusEnum b)
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

            public static bool operator !=(ProtectionStatusEnum a, ProtectionStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 后端云服务器组的管理状态。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端云服务器组的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 后端云服务器组关联的健康检查的ID。
        /// </summary>
        [JsonProperty("healthmonitor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HealthmonitorId { get; set; }

        /// <summary>
        /// 后端云服务器组的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 后端云服务器组的负载均衡算法。  取值： - ROUND_ROBIN：加权轮询算法。 - LEAST_CONNECTIONS：加权最少连接算法。 - SOURCE_IP：源IP算法。 - QUIC_CID：连接ID算法。 [- 2_TUPLE_HASH：二元组hash算法，仅IP类型的pool支持。 - 3_TUPLE_HASH：三元组hash算法，仅IP类型的pool支持。 - 5_TUPLE_HASH：五元组hash算法，仅IP类型的pool支持。 - IP型pool不指定该字段时，默认设置为5_TUPLE_HASH。](tag:hws_eu)  使用说明： - 当该字段的取值为SOURCE_IP时，后端云服务器组绑定的后端云服务器的weight字段无效。 - 只有pool的protocol为QUIC时，才支持QUIC_CID算法。  [不支持QUIC_CID算法。](tag:hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC_CID。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("lb_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string LbAlgorithm { get; set; }

        /// <summary>
        /// 后端云服务器组关联的监听器ID列表。
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListenerRef> Listeners { get; set; }

        /// <summary>
        /// 后端云服务器组关联的负载均衡器ID列表。
        /// </summary>
        [JsonProperty("loadbalancers", NullValueHandling = NullValueHandling.Ignore)]
        public List<LoadBalancerRef> Loadbalancers { get; set; }

        /// <summary>
        /// 后端云服务器组中的后端云服务器ID列表。
        /// </summary>
        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public List<MemberRef> Members { get; set; }

        /// <summary>
        /// 后端云服务器组的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 后端云服务器组所在的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 后端云服务器组的后端协议。  取值：TCP、UDP、[IP、](tag:hws_eu)TLS、gRPC、HTTP、HTTPS和QUIC。  使用说明： - listener的protocol为UDP时，pool的protocol必须为UDP或QUIC。 - listener的protocol为TCP时pool的protocol必须为TCP。 [- listener的protocol为IP时，pool的protocol必须为IP。](tag:hws_eu) - listener的protocol为HTTP时，pool的protocol必须为HTTP。 - listener的protocol为HTTPS时，pool的protocol必须为HTTP、HTTPS或gRPC。 - listener的protocol为TERMINATED_HTTPS时，pool的protocol必须为HTTP。 - listener的protocol为QUIC时，pool的protocol必须为HTTP、HTTPS或gRPC。 - listener的protocol为TLS时，pool的protocol必须为TLS或TCP。 - 若pool的protocol为QUIC，则必须开启session_persistence且type为SOURCE_IP。 - 若pool的protocol为gRPC，关联监听器必须开启HTTP2。 - 若pool的protocol为TCP,则pool的ip_version字段取值必须是4。  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_persistence", NullValueHandling = NullValueHandling.Ignore)]
        public SessionPersistence SessionPersistence { get; set; }

        /// <summary>
        /// 后端云服务器组支持的IP版本。  [取值： - 共享型：固定为v4； -  独享型：取值dualstack、v4、v6。当协议为TCP/UDP时，ip_version为dualstack，表示双栈。  当协议为HTTP时，ip_version为v4。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs)  [取值：dualstack、v4、v6。当协议为TCP/UDP时，ip_version为dualstack，表示双栈。 当协议为HTTP时，ip_version为v4。](tag:hcso_dt)  [不支持IPv6，只会返回v4。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public string IpVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("slow_start", NullValueHandling = NullValueHandling.Ignore)]
        public SlowStart SlowStart { get; set; }

        /// <summary>
        /// 是否开启误删保护。  取值：false不开启，true开启。  &gt; 退场时需要先关闭所有资源的删除保护开关。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42)  [荷兰region不支持该字段，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("member_deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MemberDeletionProtectionEnable { get; set; }

        /// <summary>
        /// 创建时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，UTC时区。  [注意：独享型实例的历史数据以及共享型实例下的资源，不返回该字段。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间。格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，UTC时区。  [注意：独享型实例的历史数据以及共享型实例下的资源，不返回该字段。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 后端云服务器组关联的虚拟私有云的ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 后端服务器组的类型。  取值： - instance：允许任意类型的后端，type指定为该类型时，vpc_id是必选字段。 - ip：只能添加跨VPC后端，type指定为该类型时，vpc_id不允许指定。 - 空字符串（\&quot;\&quot;）：允许任意类型的后端
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// 设置保护的原因 &gt;仅当protection_status为consoleProtection时有效。
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }

        /// <summary>
        /// 后端是否开启端口透传。开启后，后端服务器端口与前端监听器端口保持一致。关闭后，请求会转发给后端服务器protocol_port字段指定端口。取值：false不开启，true开启。  使用说明： - 仅QUIC,TCP,UDP的pool支持。
        /// </summary>
        [JsonProperty("any_port_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnyPortEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connection_drain", NullValueHandling = NullValueHandling.Ignore)]
        public ConnectionDrain ConnectionDrain { get; set; }

        /// <summary>
        /// IP地址组所在的企业项目ID。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pool_health", NullValueHandling = NullValueHandling.Ignore)]
        public PoolHealth PoolHealth { get; set; }

        /// <summary>
        /// 可用区组，如：center
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pool {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  healthmonitorId: ").Append(HealthmonitorId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  lbAlgorithm: ").Append(LbAlgorithm).Append("\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("  loadbalancers: ").Append(Loadbalancers).Append("\n");
            sb.Append("  members: ").Append(Members).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  sessionPersistence: ").Append(SessionPersistence).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  slowStart: ").Append(SlowStart).Append("\n");
            sb.Append("  memberDeletionProtectionEnable: ").Append(MemberDeletionProtectionEnable).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("  anyPortEnable: ").Append(AnyPortEnable).Append("\n");
            sb.Append("  connectionDrain: ").Append(ConnectionDrain).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  poolHealth: ").Append(PoolHealth).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Pool);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Pool input)
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
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HealthmonitorId == input.HealthmonitorId ||
                    (this.HealthmonitorId != null &&
                    this.HealthmonitorId.Equals(input.HealthmonitorId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LbAlgorithm == input.LbAlgorithm ||
                    (this.LbAlgorithm != null &&
                    this.LbAlgorithm.Equals(input.LbAlgorithm))
                ) && 
                (
                    this.Listeners == input.Listeners ||
                    this.Listeners != null &&
                    input.Listeners != null &&
                    this.Listeners.SequenceEqual(input.Listeners)
                ) && 
                (
                    this.Loadbalancers == input.Loadbalancers ||
                    this.Loadbalancers != null &&
                    input.Loadbalancers != null &&
                    this.Loadbalancers.SequenceEqual(input.Loadbalancers)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.SessionPersistence == input.SessionPersistence ||
                    (this.SessionPersistence != null &&
                    this.SessionPersistence.Equals(input.SessionPersistence))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.SlowStart == input.SlowStart ||
                    (this.SlowStart != null &&
                    this.SlowStart.Equals(input.SlowStart))
                ) && 
                (
                    this.MemberDeletionProtectionEnable == input.MemberDeletionProtectionEnable ||
                    (this.MemberDeletionProtectionEnable != null &&
                    this.MemberDeletionProtectionEnable.Equals(input.MemberDeletionProtectionEnable))
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
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ProtectionStatus == input.ProtectionStatus ||
                    (this.ProtectionStatus != null &&
                    this.ProtectionStatus.Equals(input.ProtectionStatus))
                ) && 
                (
                    this.ProtectionReason == input.ProtectionReason ||
                    (this.ProtectionReason != null &&
                    this.ProtectionReason.Equals(input.ProtectionReason))
                ) && 
                (
                    this.AnyPortEnable == input.AnyPortEnable ||
                    (this.AnyPortEnable != null &&
                    this.AnyPortEnable.Equals(input.AnyPortEnable))
                ) && 
                (
                    this.ConnectionDrain == input.ConnectionDrain ||
                    (this.ConnectionDrain != null &&
                    this.ConnectionDrain.Equals(input.ConnectionDrain))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.PoolHealth == input.PoolHealth ||
                    (this.PoolHealth != null &&
                    this.PoolHealth.Equals(input.PoolHealth))
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HealthmonitorId != null)
                    hashCode = hashCode * 59 + this.HealthmonitorId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LbAlgorithm != null)
                    hashCode = hashCode * 59 + this.LbAlgorithm.GetHashCode();
                if (this.Listeners != null)
                    hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.Loadbalancers != null)
                    hashCode = hashCode * 59 + this.Loadbalancers.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SessionPersistence != null)
                    hashCode = hashCode * 59 + this.SessionPersistence.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.SlowStart != null)
                    hashCode = hashCode * 59 + this.SlowStart.GetHashCode();
                if (this.MemberDeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.MemberDeletionProtectionEnable.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ProtectionStatus != null)
                    hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null)
                    hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                if (this.AnyPortEnable != null)
                    hashCode = hashCode * 59 + this.AnyPortEnable.GetHashCode();
                if (this.ConnectionDrain != null)
                    hashCode = hashCode * 59 + this.ConnectionDrain.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PoolHealth != null)
                    hashCode = hashCode * 59 + this.PoolHealth.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
