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
    public class ShowBuiltInPolicyDefinitionResponse : SdkResponse
    {

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 策略名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 策略展示名
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 策略类型
        /// </summary>
        [JsonProperty("policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyType { get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 策略语法类型
        /// </summary>
        [JsonProperty("policy_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyRuleType { get; set; }

        /// <summary>
        /// 策略规则
        /// </summary>
        [JsonProperty("policy_rule", NullValueHandling = NullValueHandling.Ignore)]
        public Object PolicyRule { get; set; }

        /// <summary>
        /// 触发器类型，可选值：resource, period
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 关键词列表
        /// </summary>
        [JsonProperty("keywords", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 默认资源类型列表
        /// </summary>
        [JsonProperty("default_resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyDefinitionDefaultResourceTypes> DefaultResourceTypes { get; set; }

        /// <summary>
        /// 策略参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PolicyParameterDefinition> Parameters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBuiltInPolicyDefinitionResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  policyRuleType: ").Append(PolicyRuleType).Append("\n");
            sb.Append("  policyRule: ").Append(PolicyRule).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  keywords: ").Append(Keywords).Append("\n");
            sb.Append("  defaultResourceTypes: ").Append(DefaultResourceTypes).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBuiltInPolicyDefinitionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBuiltInPolicyDefinitionResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.PolicyType != input.PolicyType || (this.PolicyType != null && !this.PolicyType.Equals(input.PolicyType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PolicyRuleType != input.PolicyRuleType || (this.PolicyRuleType != null && !this.PolicyRuleType.Equals(input.PolicyRuleType))) return false;
            if (this.PolicyRule != input.PolicyRule || (this.PolicyRule != null && !this.PolicyRule.Equals(input.PolicyRule))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.Keywords != input.Keywords || (this.Keywords != null && input.Keywords != null && !this.Keywords.SequenceEqual(input.Keywords))) return false;
            if (this.DefaultResourceTypes != input.DefaultResourceTypes || (this.DefaultResourceTypes != null && input.DefaultResourceTypes != null && !this.DefaultResourceTypes.SequenceEqual(input.DefaultResourceTypes))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.PolicyType != null) hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PolicyRuleType != null) hashCode = hashCode * 59 + this.PolicyRuleType.GetHashCode();
                if (this.PolicyRule != null) hashCode = hashCode * 59 + this.PolicyRule.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.Keywords != null) hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.DefaultResourceTypes != null) hashCode = hashCode * 59 + this.DefaultResourceTypes.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }
    }
}
