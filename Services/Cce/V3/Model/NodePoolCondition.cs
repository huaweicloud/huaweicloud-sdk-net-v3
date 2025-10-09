using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点池/伸缩组详细状态。
    /// </summary>
    public class NodePoolCondition 
    {
        /// <summary>
        /// **参数解释**： 状态类型。 **约束限制**： 不涉及 **取值范围**： - \&quot;TaintSynchronizing\&quot;: 节点池正在同步节点K8s污点，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;LabelSynchronizing\&quot;: 节点池正在同步节点K8s标签，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;UserTagsSynchronizing\&quot;: 节点池正在同步节点资源标签，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;ConfigurationSynchronizing\&quot;: 节点池正在同步节点配置，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;Scalable\&quot;：节点池/伸缩组实际的可扩容状态，如果状态为\&quot;False\&quot;时则不会再次触发节点池扩容行为。 - \&quot;QuotaInsufficient\&quot;：节点池/伸缩组扩容依赖的配额不足，影响节点池可扩容状态。 - \&quot;ResourceInsufficient\&quot;：节点池/伸缩组扩容依赖的资源不足，影响节点池可扩容状态。 - \&quot;UnexpectedError\&quot;：节点池/伸缩组非预期扩容失败，影响节点池可扩容状态。 [- \&quot;LockedByOrder\&quot;：节点池/伸缩组被订单锁定，此时Reason为待支付订单ID。](tag:hws,hws_hk) - \&quot;Error\&quot;：节点池/伸缩组错误，通常由于删除失败触发。  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 状态类型。 **约束限制**： 不涉及 **取值范围**： - \&quot;TaintSynchronizing\&quot;: 节点池正在同步节点K8s污点，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;LabelSynchronizing\&quot;: 节点池正在同步节点K8s标签，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;UserTagsSynchronizing\&quot;: 节点池正在同步节点资源标签，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;ConfigurationSynchronizing\&quot;: 节点池正在同步节点配置，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;Scalable\&quot;：节点池/伸缩组实际的可扩容状态，如果状态为\&quot;False\&quot;时则不会再次触发节点池扩容行为。 - \&quot;QuotaInsufficient\&quot;：节点池/伸缩组扩容依赖的配额不足，影响节点池可扩容状态。 - \&quot;ResourceInsufficient\&quot;：节点池/伸缩组扩容依赖的资源不足，影响节点池可扩容状态。 - \&quot;UnexpectedError\&quot;：节点池/伸缩组非预期扩容失败，影响节点池可扩容状态。 [- \&quot;LockedByOrder\&quot;：节点池/伸缩组被订单锁定，此时Reason为待支付订单ID。](tag:hws,hws_hk) - \&quot;Error\&quot;：节点池/伸缩组错误，通常由于删除失败触发。  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum TAINTSYNCHRONIZING for value: TaintSynchronizing
            /// </summary>
            public static readonly TypeEnum TAINTSYNCHRONIZING = new TypeEnum("TaintSynchronizing");

            /// <summary>
            /// Enum LABELSYNCHRONIZING for value: LabelSynchronizing
            /// </summary>
            public static readonly TypeEnum LABELSYNCHRONIZING = new TypeEnum("LabelSynchronizing");

            /// <summary>
            /// Enum USERTAGSSYNCHRONIZING for value: UserTagsSynchronizing
            /// </summary>
            public static readonly TypeEnum USERTAGSSYNCHRONIZING = new TypeEnum("UserTagsSynchronizing");

            /// <summary>
            /// Enum CONFIGURATIONSYNCHRONIZING for value: ConfigurationSynchronizing
            /// </summary>
            public static readonly TypeEnum CONFIGURATIONSYNCHRONIZING = new TypeEnum("ConfigurationSynchronizing");

            /// <summary>
            /// Enum SCALABLE for value: Scalable
            /// </summary>
            public static readonly TypeEnum SCALABLE = new TypeEnum("Scalable");

            /// <summary>
            /// Enum QUOTAINSUFFICIENT for value: QuotaInsufficient
            /// </summary>
            public static readonly TypeEnum QUOTAINSUFFICIENT = new TypeEnum("QuotaInsufficient");

            /// <summary>
            /// Enum RESOURCEINSUFFICIENT for value: ResourceInsufficient
            /// </summary>
            public static readonly TypeEnum RESOURCEINSUFFICIENT = new TypeEnum("ResourceInsufficient");

            /// <summary>
            /// Enum UNEXPECTEDERROR for value: UnexpectedError
            /// </summary>
            public static readonly TypeEnum UNEXPECTEDERROR = new TypeEnum("UnexpectedError");

            /// <summary>
            /// Enum LOCKEDBYORDER for value: LockedByOrder
            /// </summary>
            public static readonly TypeEnum LOCKEDBYORDER = new TypeEnum("LockedByOrder");

            /// <summary>
            /// Enum ERROR for value: Error
            /// </summary>
            public static readonly TypeEnum ERROR = new TypeEnum("Error");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "TaintSynchronizing", TAINTSYNCHRONIZING },
                { "LabelSynchronizing", LABELSYNCHRONIZING },
                { "UserTagsSynchronizing", USERTAGSSYNCHRONIZING },
                { "ConfigurationSynchronizing", CONFIGURATIONSYNCHRONIZING },
                { "Scalable", SCALABLE },
                { "QuotaInsufficient", QUOTAINSUFFICIENT },
                { "ResourceInsufficient", RESOURCEINSUFFICIENT },
                { "UnexpectedError", UNEXPECTEDERROR },
                { "LockedByOrder", LOCKEDBYORDER },
                { "Error", ERROR },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 状态类型。 **约束限制**： 不涉及 **取值范围**： - \&quot;TaintSynchronizing\&quot;: 节点池正在同步节点K8s污点，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;LabelSynchronizing\&quot;: 节点池正在同步节点K8s标签，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;UserTagsSynchronizing\&quot;: 节点池正在同步节点资源标签，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;ConfigurationSynchronizing\&quot;: 节点池正在同步节点配置，不影响节点池可扩容状态（该状态类型为节点池级别，伸缩组中无该状态类型）。 - \&quot;Scalable\&quot;：节点池/伸缩组实际的可扩容状态，如果状态为\&quot;False\&quot;时则不会再次触发节点池扩容行为。 - \&quot;QuotaInsufficient\&quot;：节点池/伸缩组扩容依赖的配额不足，影响节点池可扩容状态。 - \&quot;ResourceInsufficient\&quot;：节点池/伸缩组扩容依赖的资源不足，影响节点池可扩容状态。 - \&quot;UnexpectedError\&quot;：节点池/伸缩组非预期扩容失败，影响节点池可扩容状态。 [- \&quot;LockedByOrder\&quot;：节点池/伸缩组被订单锁定，此时Reason为待支付订单ID。](tag:hws,hws_hk) - \&quot;Error\&quot;：节点池/伸缩组错误，通常由于删除失败触发。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Condition当前状态，取值如下 - \&quot;True\&quot; - \&quot;False\&quot; 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 上次状态检查时间。
        /// </summary>
        [JsonProperty("lastProbeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastProbeTime { get; set; }

        /// <summary>
        /// 上次状态变更时间。
        /// </summary>
        [JsonProperty("lastTransitTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastTransitTime { get; set; }

        /// <summary>
        /// 上次状态变更原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Condition详细描述。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolCondition {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastProbeTime: ").Append(LastProbeTime).Append("\n");
            sb.Append("  lastTransitTime: ").Append(LastTransitTime).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolCondition input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.LastProbeTime != input.LastProbeTime || (this.LastProbeTime != null && !this.LastProbeTime.Equals(input.LastProbeTime))) return false;
            if (this.LastTransitTime != input.LastTransitTime || (this.LastTransitTime != null && !this.LastTransitTime.Equals(input.LastTransitTime))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastProbeTime != null) hashCode = hashCode * 59 + this.LastProbeTime.GetHashCode();
                if (this.LastTransitTime != null) hashCode = hashCode * 59 + this.LastTransitTime.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
