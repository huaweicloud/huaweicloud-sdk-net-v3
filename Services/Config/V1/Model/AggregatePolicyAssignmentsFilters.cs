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
    /// 聚合合规规则过滤器。
    /// </summary>
    public class AggregatePolicyAssignmentsFilters 
    {
        /// <summary>
        /// 合规结果。
        /// </summary>
        /// <value>合规结果。</value>
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

            /// <summary>
            /// Enum NOTSTARTED for value: NotStarted
            /// </summary>
            public static readonly ComplianceStateEnum NOTSTARTED = new ComplianceStateEnum("NotStarted");

            private static readonly Dictionary<string, ComplianceStateEnum> StaticFields =
            new Dictionary<string, ComplianceStateEnum>()
            {
                { "NonCompliant", NONCOMPLIANT },
                { "Compliant", COMPLIANT },
                { "NotStarted", NOTSTARTED },
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
        /// 源帐号ID。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 合规结果。
        /// </summary>
        [JsonProperty("compliance_state", NullValueHandling = NullValueHandling.Ignore)]
        public ComplianceStateEnum ComplianceState { get; set; }
        /// <summary>
        /// 合规规则名称
        /// </summary>
        [JsonProperty("policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatePolicyAssignmentsFilters {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  complianceState: ").Append(ComplianceState).Append("\n");
            sb.Append("  policyAssignmentName: ").Append(PolicyAssignmentName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AggregatePolicyAssignmentsFilters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AggregatePolicyAssignmentsFilters input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.ComplianceState != input.ComplianceState) return false;
            if (this.PolicyAssignmentName != input.PolicyAssignmentName || (this.PolicyAssignmentName != null && !this.PolicyAssignmentName.Equals(input.PolicyAssignmentName))) return false;

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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                hashCode = hashCode * 59 + this.ComplianceState.GetHashCode();
                if (this.PolicyAssignmentName != null) hashCode = hashCode * 59 + this.PolicyAssignmentName.GetHashCode();
                return hashCode;
            }
        }
    }
}
