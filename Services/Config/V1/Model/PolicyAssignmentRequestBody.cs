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
    /// 规则请求体
    /// </summary>
    public class PolicyAssignmentRequestBody 
    {
        /// <summary>
        /// 规则类型，包括预定义合规规则(builtin)和用户自定义合规规则(custom)
        /// </summary>
        /// <value>规则类型，包括预定义合规规则(builtin)和用户自定义合规规则(custom)</value>
        [JsonConverter(typeof(EnumClassConverter<PolicyAssignmentTypeEnum>))]
        public class PolicyAssignmentTypeEnum
        {
            /// <summary>
            /// Enum BUILTIN for value: builtin
            /// </summary>
            public static readonly PolicyAssignmentTypeEnum BUILTIN = new PolicyAssignmentTypeEnum("builtin");

            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly PolicyAssignmentTypeEnum CUSTOM = new PolicyAssignmentTypeEnum("custom");

            private static readonly Dictionary<string, PolicyAssignmentTypeEnum> StaticFields =
            new Dictionary<string, PolicyAssignmentTypeEnum>()
            {
                { "builtin", BUILTIN },
                { "custom", CUSTOM },
            };

            private string _value;

            public PolicyAssignmentTypeEnum()
            {

            }

            public PolicyAssignmentTypeEnum(string value)
            {
                _value = value;
            }

            public static PolicyAssignmentTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PolicyAssignmentTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PolicyAssignmentTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PolicyAssignmentTypeEnum a, PolicyAssignmentTypeEnum b)
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

            public static bool operator !=(PolicyAssignmentTypeEnum a, PolicyAssignmentTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 触发周期值，可选值：One_Hour, Three_Hours, Six_Hours, Twelve_Hours, TwentyFour_Hours
        /// </summary>
        /// <value>触发周期值，可选值：One_Hour, Three_Hours, Six_Hours, Twelve_Hours, TwentyFour_Hours</value>
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
        /// 规则类型，包括预定义合规规则(builtin)和用户自定义合规规则(custom)
        /// </summary>
        [JsonProperty("policy_assignment_type", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyAssignmentTypeEnum PolicyAssignmentType { get; set; }
        /// <summary>
        /// 规则名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 触发周期值，可选值：One_Hour, Three_Hours, Six_Hours, Twelve_Hours, TwentyFour_Hours
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_filter", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyFilterDefinition PolicyFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_policy", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPolicy CustomPolicy { get; set; }

        /// <summary>
        /// 策略定义ID
        /// </summary>
        [JsonProperty("policy_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// 规则参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PolicyParameterValue> Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyAssignmentRequestBody {\n");
            sb.Append("  policyAssignmentType: ").Append(PolicyAssignmentType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  policyFilter: ").Append(PolicyFilter).Append("\n");
            sb.Append("  customPolicy: ").Append(CustomPolicy).Append("\n");
            sb.Append("  policyDefinitionId: ").Append(PolicyDefinitionId).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyAssignmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyAssignmentRequestBody input)
        {
            if (input == null) return false;
            if (this.PolicyAssignmentType != input.PolicyAssignmentType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Period != input.Period) return false;
            if (this.PolicyFilter != input.PolicyFilter || (this.PolicyFilter != null && !this.PolicyFilter.Equals(input.PolicyFilter))) return false;
            if (this.CustomPolicy != input.CustomPolicy || (this.CustomPolicy != null && !this.CustomPolicy.Equals(input.CustomPolicy))) return false;
            if (this.PolicyDefinitionId != input.PolicyDefinitionId || (this.PolicyDefinitionId != null && !this.PolicyDefinitionId.Equals(input.PolicyDefinitionId))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                hashCode = hashCode * 59 + this.PolicyAssignmentType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.PolicyFilter != null) hashCode = hashCode * 59 + this.PolicyFilter.GetHashCode();
                if (this.CustomPolicy != null) hashCode = hashCode * 59 + this.CustomPolicy.GetHashCode();
                if (this.PolicyDefinitionId != null) hashCode = hashCode * 59 + this.PolicyDefinitionId.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
