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
    /// 创建主机组请求
    /// </summary>
    public class CreatePoolOption 
    {

        /// <summary>
        /// 后端云服务器组的管理状态，只支持更新为true。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端云服务器组的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 后端云服务器组的负载均衡算法。  取值： - ROUND_ROBIN：加权轮询算法。 - LEAST_CONNECTIONS：加权最少连接算法。 - SOURCE_IP：源IP算法。 - QUIC_CID：连接ID算法。  使用说明： - 当该字段的取值为SOURCE_IP时，后端云服务器组绑定的后端云服务器的weight字段无效。 - 只有pool的protocol为QUIC时，才支持QUIC_CID算法。  [不支持QUIC_CID算法。](tag:hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [JsonProperty("lb_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string LbAlgorithm { get; set; }

        /// <summary>
        /// 后端云服务器组关联的监听器的ID。  使用说明： - listener_id，loadbalancer_id，type至少指定一个。 [- 共享型实例的后端服务器组loadbalancer_id和listener_id至少指定一个。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 后端云服务器组关联的负载均衡器ID。  使用说明： - listener_id，loadbalancer_id，type至少指定一个。 [- 共享型实例的后端服务器组loadbalancer_id和listener_id至少指定一个。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// 后端云服务器组的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 后端云服务器组所属的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 后端云服务器组的后端协议。  取值：TCP、UDP、HTTP、HTTPS和QUIC。  使用说明： - listener的protocol为UDP时，pool的protocol必须为UDP或QUIC； - listener的protocol为TCP时pool的protocol必须为TCP； - listener的protocol为HTTP时，pool的protocol必须为HTTP。 - listener的protocol为HTTPS时，pool的protocol必须为HTTP或HTTPS。 - listener的protocol为TERMINATED_HTTPS时，pool的protocol必须为HTTP。 - 若pool的protocol为QUIC，则必须开启session_persistence且type为SOURCE_IP。  [不支持QUIC协议。](tag:hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC。](tag:dt)
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_persistence", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePoolSessionPersistenceOption SessionPersistence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("slow_start", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePoolSlowStartOption SlowStart { get; set; }

        /// <summary>
        /// 是否开启删除保护。  取值：false不开启，true开启，默认false。  &gt; 退场时需要先关闭所有资源的删除保护开关。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("member_deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MemberDeletionProtectionEnable { get; set; }

        /// <summary>
        /// 后端云服务器组关联的虚拟私有云的ID。  使用说明： - 只能挂载到该虚拟私有云下。 - 只能添加该虚拟私有云下的后端服务器或跨VPC的后端服务器。 - type必须指定为instance。  没有指定vpc_id的约束： - 后续添加后端服务器时，vpc_id由后端服务器所在的虚拟私有云确定。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 后端服务器组的类型。  取值： - instance：允许任意类型的后端，type指定为该类型时，vpc_id是必选字段。 - ip：只能添加跨VPC后端，type指定为该类型时，vpc_id不允许指定。  使用说明： - 不传表示允许任意类型的后端，并返回type为空字符串。 - listener_id，loadbalancer_id，type至少指定一个。 [- 共享型实例的后端服务器组loadbalancer_id和listener_id至少指定一个。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePoolOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  lbAlgorithm: ").Append(LbAlgorithm).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  sessionPersistence: ").Append(SessionPersistence).Append("\n");
            sb.Append("  slowStart: ").Append(SlowStart).Append("\n");
            sb.Append("  memberDeletionProtectionEnable: ").Append(MemberDeletionProtectionEnable).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePoolOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePoolOption input)
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
                    this.LbAlgorithm == input.LbAlgorithm ||
                    (this.LbAlgorithm != null &&
                    this.LbAlgorithm.Equals(input.LbAlgorithm))
                ) && 
                (
                    this.ListenerId == input.ListenerId ||
                    (this.ListenerId != null &&
                    this.ListenerId.Equals(input.ListenerId))
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    (this.LoadbalancerId != null &&
                    this.LoadbalancerId.Equals(input.LoadbalancerId))
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
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.LbAlgorithm != null)
                    hashCode = hashCode * 59 + this.LbAlgorithm.GetHashCode();
                if (this.ListenerId != null)
                    hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.SessionPersistence != null)
                    hashCode = hashCode * 59 + this.SessionPersistence.GetHashCode();
                if (this.SlowStart != null)
                    hashCode = hashCode * 59 + this.SlowStart.GetHashCode();
                if (this.MemberDeletionProtectionEnable != null)
                    hashCode = hashCode * 59 + this.MemberDeletionProtectionEnable.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
