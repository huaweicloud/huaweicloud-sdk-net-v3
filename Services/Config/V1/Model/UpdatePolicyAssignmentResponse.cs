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
    /// Response Object
    /// </summary>
    public class UpdatePolicyAssignmentResponse : SdkResponse
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

            public static bool operator !=(PolicyAssignmentTypeEnum a, PolicyAssignmentTypeEnum b)
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
        /// 规则ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("policy_filter", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyFilterDefinition PolicyFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_filter_v2", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyFilterDefinitionV2 PolicyFilterV2 { get; set; }

        /// <summary>
        /// 触发周期值，可选值：One_Hour, Three_Hours, Six_Hours, Twelve_Hours, TwentyFour_Hours
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 规则状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 规则创建时间
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 规则更新时间
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 规则的策略ID
        /// </summary>
        [JsonProperty("policy_definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_policy", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPolicy CustomPolicy { get; set; }

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
        /// 规则的创建者
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 合规规则修正方式。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 修正执行的目标id。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePolicyAssignmentResponse {\n");
            sb.Append("  policyAssignmentType: ").Append(PolicyAssignmentType).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  policyFilter: ").Append(PolicyFilter).Append("\n");
            sb.Append("  policyFilterV2: ").Append(PolicyFilterV2).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  policyDefinitionId: ").Append(PolicyDefinitionId).Append("\n");
            sb.Append("  customPolicy: ").Append(CustomPolicy).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePolicyAssignmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePolicyAssignmentResponse input)
        {
            if (input == null) return false;
            if (this.PolicyAssignmentType != input.PolicyAssignmentType) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PolicyFilter != input.PolicyFilter || (this.PolicyFilter != null && !this.PolicyFilter.Equals(input.PolicyFilter))) return false;
            if (this.PolicyFilterV2 != input.PolicyFilterV2 || (this.PolicyFilterV2 != null && !this.PolicyFilterV2.Equals(input.PolicyFilterV2))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.PolicyDefinitionId != input.PolicyDefinitionId || (this.PolicyDefinitionId != null && !this.PolicyDefinitionId.Equals(input.PolicyDefinitionId))) return false;
            if (this.CustomPolicy != input.CustomPolicy || (this.CustomPolicy != null && !this.CustomPolicy.Equals(input.CustomPolicy))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PolicyFilter != null) hashCode = hashCode * 59 + this.PolicyFilter.GetHashCode();
                if (this.PolicyFilterV2 != null) hashCode = hashCode * 59 + this.PolicyFilterV2.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.PolicyDefinitionId != null) hashCode = hashCode * 59 + this.PolicyDefinitionId.GetHashCode();
                if (this.CustomPolicy != null) hashCode = hashCode * 59 + this.CustomPolicy.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
