using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 合规评估结果
    /// </summary>
    public class PolicyStateRequestBody 
    {
        /// <summary>
        /// 触发器类型
        /// </summary>
        /// <value>触发器类型</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerTypeEnum>))]
        public class TriggerTypeEnum
        {
            /// <summary>
            /// Enum RESOURCE for value: resource
            /// </summary>
            public static readonly TriggerTypeEnum RESOURCE = new TriggerTypeEnum("resource");

            /// <summary>
            /// Enum PERIOD for value: period
            /// </summary>
            public static readonly TriggerTypeEnum PERIOD = new TriggerTypeEnum("period");

            private static readonly Dictionary<string, TriggerTypeEnum> StaticFields =
            new Dictionary<string, TriggerTypeEnum>()
            {
                { "resource", RESOURCE },
                { "period", PERIOD },
            };

            private string _value;

            public TriggerTypeEnum()
            {

            }

            public TriggerTypeEnum(string value)
            {
                _value = value;
            }

            public static TriggerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerTypeEnum a, TriggerTypeEnum b)
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

            public static bool operator !=(TriggerTypeEnum a, TriggerTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 合规状态
        /// </summary>
        /// <value>合规状态</value>
        [JsonConverter(typeof(EnumClassConverter<ComplianceStateEnum>))]
        public class ComplianceStateEnum
        {
            /// <summary>
            /// Enum NONCOMPLIANT for value: NonCompliant
            /// </summary>
            public static readonly ComplianceStateEnum NONCOMPLIANT = new ComplianceStateEnum("NonCompliant");

            /// <summary>
            /// Enum COMPLIANT for value: Compliant
            /// </summary>
            public static readonly ComplianceStateEnum COMPLIANT = new ComplianceStateEnum("Compliant");

            private static readonly Dictionary<string, ComplianceStateEnum> StaticFields =
            new Dictionary<string, ComplianceStateEnum>()
            {
                { "NonCompliant", NONCOMPLIANT },
                { "Compliant", COMPLIANT },
            };

            private string _value;

            public ComplianceStateEnum()
            {

            }

            public ComplianceStateEnum(string value)
            {
                _value = value;
            }

            public static ComplianceStateEnum FromValue(string value)
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

                if (this.Equals(obj as ComplianceStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ComplianceStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ComplianceStateEnum a, ComplianceStateEnum b)
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

            public static bool operator !=(ComplianceStateEnum a, ComplianceStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_resource", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyResource PolicyResource { get; set; }

        /// <summary>
        /// 触发器类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeEnum TriggerType { get; set; }
        /// <summary>
        /// 合规状态
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public ComplianceStateEnum ComplianceState { get; set; }
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentName { get; set; }

        /// <summary>
        /// 合规状态评估时间
        /// </summary>
        [JsonProperty("evaluation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EvaluationTime { get; set; }

        /// <summary>
        /// 评估校验码
        /// </summary>
        [JsonProperty("evaluation_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string EvaluationHash { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyStateRequestBody {\n");
            sb.Append("  policyResource: ").Append(PolicyResource).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  policyAssignmentId: ").Append(PolicyAssignmentId).Append("\n");
            sb.Append("  policyAssignmentName: ").Append(PolicyAssignmentName).Append("\n");
            sb.Append("  evaluationTime: ").Append(EvaluationTime).Append("\n");
            sb.Append("  evaluationHash: ").Append(EvaluationHash).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyStateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyStateRequestBody input)
        {
            if (input == null) return false;
            if (this.PolicyResource != input.PolicyResource || (this.PolicyResource != null && !this.PolicyResource.Equals(input.PolicyResource))) return false;
            if (this.TriggerType != input.TriggerType) return false;
            if (this.ComplianceState != input.ComplianceState) return false;
            if (this.PolicyAssignmentId != input.PolicyAssignmentId || (this.PolicyAssignmentId != null && !this.PolicyAssignmentId.Equals(input.PolicyAssignmentId))) return false;
            if (this.PolicyAssignmentName != input.PolicyAssignmentName || (this.PolicyAssignmentName != null && !this.PolicyAssignmentName.Equals(input.PolicyAssignmentName))) return false;
            if (this.EvaluationTime != input.EvaluationTime || (this.EvaluationTime != null && !this.EvaluationTime.Equals(input.EvaluationTime))) return false;
            if (this.EvaluationHash != input.EvaluationHash || (this.EvaluationHash != null && !this.EvaluationHash.Equals(input.EvaluationHash))) return false;

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
                if (this.PolicyResource != null) hashCode = hashCode * 59 + this.PolicyResource.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                hashCode = hashCode * 59 + this.ComplianceState.GetHashCode();
                if (this.PolicyAssignmentId != null) hashCode = hashCode * 59 + this.PolicyAssignmentId.GetHashCode();
                if (this.PolicyAssignmentName != null) hashCode = hashCode * 59 + this.PolicyAssignmentName.GetHashCode();
                if (this.EvaluationTime != null) hashCode = hashCode * 59 + this.EvaluationTime.GetHashCode();
                if (this.EvaluationHash != null) hashCode = hashCode * 59 + this.EvaluationHash.GetHashCode();
                return hashCode;
            }
        }
    }
}
