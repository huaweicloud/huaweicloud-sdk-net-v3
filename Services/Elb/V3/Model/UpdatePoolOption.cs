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
        /// 修改保护状态, 取值： - nonProtection: 不保护 - consoleProtection: 控制台修改保护
        /// </summary>
        /// <value>修改保护状态, 取值： - nonProtection: 不保护 - consoleProtection: 控制台修改保护</value>
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
        /// 后端服务器组的管理状态，只支持更新为true。  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端服务器组的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 后端服务器组的负载均衡算法。  取值： - ROUND_ROBIN：加权轮询算法。 - LEAST_CONNECTIONS：加权最少连接算法。 - SOURCE_IP：源IP算法。 - QUIC_CID：连接ID算法。 [- 2_TUPLE_HASH：二元组hash算法，仅IP类型的pool支持。 - 3_TUPLE_HASH：三元组hash算法，仅IP类型的pool支持。 - 5_TUPLE_HASH：五元组hash算法，仅IP类型的pool支持。 - IP型pool不指定该字段时，默认设置为5_TUPLE_HASH。](tag:hws_eu)  使用说明： - 当该字段的取值为SOURCE_IP或QUIC_CID时，后端服务器组绑定的后端服务器的weight字段无效。 - 只有pool的protocol为QUIC时，才支持QUIC_CID算法。  [不支持QUIC_CID。](tag:tm,hws_eu,g42,hk_g42,hcso_dt)  [荷兰region不支持QUIC_CID。](tag:dt)
        /// </summary>
        [JsonProperty("lb_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string LbAlgorithm { get; set; }

        /// <summary>
        /// 后端服务器组的名称。
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
        /// 是否开启删除保护。  取值：false不开启，true开启。  &gt; 退场时需要先关闭所有资源的删除保护开关。  [不支持该字段，请勿使用。](tag:hws_eu,g42,hk_g42)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("member_deletion_protection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MemberDeletionProtectionEnable { get; set; }

        /// <summary>
        /// 后端服务器组关联的虚拟私有云的ID。 [- pool的protocol为IP时，必须指定vpc_id，且与LB的vpc_id相同。](tag:hws_eu)  只有vpc_id为空时允许更新。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 后端服务器组的类型。  取值： - instance：允许任意类型的后端，type指定为该类型时，vpc_id是必选字段。 - ip：只能添加跨VPC后端，type指定为该类型时，vpc_id不允许指定。[pool的protocol为IP时，type不允许设置为ip。](tag:hws_eu)] - 空字符串（\&quot;\&quot;）：允许任意类型的后端  使用说明： - 只有type为空时允许更新，不允许从非空更新为空。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护 - consoleProtection: 控制台修改保护
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// 参数解释：设置保护的原因。作为protection_status的转态设置的原因。  约束限制：仅当protection_status为consoleProtection时有效。  取值范围：除&#39;&lt;&#39;和&#39;&gt;&#39;外通用Unicode字符集字符，最大255个字符。
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
        /// 
        /// </summary>
        [JsonProperty("pool_health", NullValueHandling = NullValueHandling.Ignore)]
        public PoolHealth PoolHealth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quic_cid_hash_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public QuicCidHashStrategy QuicCidHashStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("az_affinity", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateAzAffinity AzAffinity { get; set; }



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
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("  anyPortEnable: ").Append(AnyPortEnable).Append("\n");
            sb.Append("  connectionDrain: ").Append(ConnectionDrain).Append("\n");
            sb.Append("  poolHealth: ").Append(PoolHealth).Append("\n");
            sb.Append("  quicCidHashStrategy: ").Append(QuicCidHashStrategy).Append("\n");
            sb.Append("  azAffinity: ").Append(AzAffinity).Append("\n");
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
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LbAlgorithm != input.LbAlgorithm || (this.LbAlgorithm != null && !this.LbAlgorithm.Equals(input.LbAlgorithm))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SessionPersistence != input.SessionPersistence || (this.SessionPersistence != null && !this.SessionPersistence.Equals(input.SessionPersistence))) return false;
            if (this.SlowStart != input.SlowStart || (this.SlowStart != null && !this.SlowStart.Equals(input.SlowStart))) return false;
            if (this.MemberDeletionProtectionEnable != input.MemberDeletionProtectionEnable || (this.MemberDeletionProtectionEnable != null && !this.MemberDeletionProtectionEnable.Equals(input.MemberDeletionProtectionEnable))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ProtectionStatus != input.ProtectionStatus) return false;
            if (this.ProtectionReason != input.ProtectionReason || (this.ProtectionReason != null && !this.ProtectionReason.Equals(input.ProtectionReason))) return false;
            if (this.AnyPortEnable != input.AnyPortEnable || (this.AnyPortEnable != null && !this.AnyPortEnable.Equals(input.AnyPortEnable))) return false;
            if (this.ConnectionDrain != input.ConnectionDrain || (this.ConnectionDrain != null && !this.ConnectionDrain.Equals(input.ConnectionDrain))) return false;
            if (this.PoolHealth != input.PoolHealth || (this.PoolHealth != null && !this.PoolHealth.Equals(input.PoolHealth))) return false;
            if (this.QuicCidHashStrategy != input.QuicCidHashStrategy || (this.QuicCidHashStrategy != null && !this.QuicCidHashStrategy.Equals(input.QuicCidHashStrategy))) return false;
            if (this.AzAffinity != input.AzAffinity || (this.AzAffinity != null && !this.AzAffinity.Equals(input.AzAffinity))) return false;

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
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LbAlgorithm != null) hashCode = hashCode * 59 + this.LbAlgorithm.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SessionPersistence != null) hashCode = hashCode * 59 + this.SessionPersistence.GetHashCode();
                if (this.SlowStart != null) hashCode = hashCode * 59 + this.SlowStart.GetHashCode();
                if (this.MemberDeletionProtectionEnable != null) hashCode = hashCode * 59 + this.MemberDeletionProtectionEnable.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                if (this.AnyPortEnable != null) hashCode = hashCode * 59 + this.AnyPortEnable.GetHashCode();
                if (this.ConnectionDrain != null) hashCode = hashCode * 59 + this.ConnectionDrain.GetHashCode();
                if (this.PoolHealth != null) hashCode = hashCode * 59 + this.PoolHealth.GetHashCode();
                if (this.QuicCidHashStrategy != null) hashCode = hashCode * 59 + this.QuicCidHashStrategy.GetHashCode();
                if (this.AzAffinity != null) hashCode = hashCode * 59 + this.AzAffinity.GetHashCode();
                return hashCode;
            }
        }
    }
}
