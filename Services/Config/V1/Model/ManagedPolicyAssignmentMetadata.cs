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
    /// 托管规则元数据。
    /// </summary>
    public class ManagedPolicyAssignmentMetadata 
    {
        /// <summary>
        /// 触发周期。
        /// </summary>
        /// <value>触发周期。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum ONE_HOUR for value: One_Hour
            /// </summary>
            public static readonly PeriodEnum ONE_HOUR = new PeriodEnum("One_Hour");

            /// <summary>
            /// Enum THREE_HOURS for value: Three_Hours
            /// </summary>
            public static readonly PeriodEnum THREE_HOURS = new PeriodEnum("Three_Hours");

            /// <summary>
            /// Enum SIX_HOURS for value: Six_Hours
            /// </summary>
            public static readonly PeriodEnum SIX_HOURS = new PeriodEnum("Six_Hours");

            /// <summary>
            /// Enum TWELVE_HOURS for value: Twelve_Hours
            /// </summary>
            public static readonly PeriodEnum TWELVE_HOURS = new PeriodEnum("Twelve_Hours");

            /// <summary>
            /// Enum TWENTYFOUR_HOURS for value: TwentyFour_Hours
            /// </summary>
            public static readonly PeriodEnum TWENTYFOUR_HOURS = new PeriodEnum("TwentyFour_Hours");

            private static readonly Dictionary<string, PeriodEnum> StaticFields =
            new Dictionary<string, PeriodEnum>()
            {
                { "One_Hour", ONE_HOUR },
                { "Three_Hours", THREE_HOURS },
                { "Six_Hours", SIX_HOURS },
                { "Twelve_Hours", TWELVE_HOURS },
                { "TwentyFour_Hours", TWENTYFOUR_HOURS },
            };

            private string _value;

            public PeriodEnum()
            {

            }

            public PeriodEnum(string value)
            {
                _value = value;
            }

            public static PeriodEnum FromValue(string value)
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

                if (this.Equals(obj as PeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodEnum a, PeriodEnum b)
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

            public static bool operator !=(PeriodEnum a, PeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 规则描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 触发周期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }
        /// <summary>
        /// 输入参数。
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PolicyParameterValue> Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_filter", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyFilterDefinition PolicyFilter { get; set; }

        /// <summary>
        /// 预定义策略标识符。
        /// </summary>
        [JsonProperty("policy_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyDefinitionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedPolicyAssignmentMetadata {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  policyFilter: ").Append(PolicyFilter).Append("\n");
            sb.Append("  policyDefinitionId: ").Append(PolicyDefinitionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagedPolicyAssignmentMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagedPolicyAssignmentMetadata input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Period != input.Period) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.PolicyFilter != input.PolicyFilter || (this.PolicyFilter != null && !this.PolicyFilter.Equals(input.PolicyFilter))) return false;
            if (this.PolicyDefinitionId != input.PolicyDefinitionId || (this.PolicyDefinitionId != null && !this.PolicyDefinitionId.Equals(input.PolicyDefinitionId))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.PolicyFilter != null) hashCode = hashCode * 59 + this.PolicyFilter.GetHashCode();
                if (this.PolicyDefinitionId != null) hashCode = hashCode * 59 + this.PolicyDefinitionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
