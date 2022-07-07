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
    /// 更新后端服务器组请求参数。
    /// </summary>
    public class UpdatePoolOption 
    {

        /// <summary>
        /// 后端云服务器组的管理状态，只支持更新为true。 [ 不支持该字段，请勿使用。](tag:dt,dt_test)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端云服务器组的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 后端云服务器组的负载均衡算法。  取值： - ROUND_ROBIN：加权轮询算法。 - LEAST_CONNECTIONS：加权最少连接算法。 - SOURCE_IP：源IP算法。 - QUIC_CID：连接ID算法。  使用说明： - 当该字段的取值为SOURCE_IP时，后端云服务器组绑定的后端云服务器的weight字段无效。 - 只有pool的protocol为QUIC时，才支持QUIC_CID算法。
        /// </summary>
        [JsonProperty("lb_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string LbAlgorithm { get; set; }

        /// <summary>
        /// 后端云服务器组的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_persistence", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatePoolSessionPersistenceOption SessionPersistence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("slow_start", NullValueHandling = NullValueHandling.Ignore)]
        public UpdatePoolSlowStartOption SlowStart { get; set; }

        /// <summary>
        /// 是否开启删除保护。取值：false不开启，true开启。 &gt; 退场时需要先关闭所有资源的删除保护开关。
        /// </summary>
        [JsonProperty("member_deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MemberDeletionProtectionEnable { get; set; }

        /// <summary>
        /// 后端云服务器组关联的虚拟私有云的ID。  只有vpc_id为空时允许更新。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 后端服务器组的类型。   取值：  - instance：允许任意类型的后端，type指定为该类型时，vpc_id是必选字段。  - ip：只能添加跨VPC后端，type指定为该类型时，vpc_id不允许指定。  - 空字符串（\&quot;\&quot;）：允许任意类型的后端   使用说明：  - 只有type为空时允许更新，不允许从非空更新为空。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePoolOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  lbAlgorithm: ").Append(LbAlgorithm).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
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
            return this.Equals(input as UpdatePoolOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePoolOption input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
