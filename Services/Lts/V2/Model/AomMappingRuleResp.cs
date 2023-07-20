using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AomMappingRuleResp 
    {

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 接入规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 接入规则id
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rule_info", NullValueHandling = NullValueHandling.Ignore)]
        public AomMappingRuleInfo RuleInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AomMappingRuleResp {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleInfo: ").Append(RuleInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AomMappingRuleResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AomMappingRuleResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.RuleInfo == input.RuleInfo ||
                    (this.RuleInfo != null &&
                    this.RuleInfo.Equals(input.RuleInfo))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleInfo != null)
                    hashCode = hashCode * 59 + this.RuleInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
