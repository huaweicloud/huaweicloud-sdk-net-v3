using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RuleListItem 
    {

        /// <summary>
        /// 规则集规范分类
        /// </summary>
        [JsonProperty("rule_set", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSet { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则所属语言
        /// </summary>
        [JsonProperty("rule_language", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleLanguage { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则问题级别
        /// </summary>
        [JsonProperty("rule_severity", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSeverity { get; set; }

        /// <summary>
        /// 规则标签
        /// </summary>
        [JsonProperty("rule_tages", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleTages { get; set; }

        /// <summary>
        /// 正确示例
        /// </summary>
        [JsonProperty("right_example", NullValueHandling = NullValueHandling.Ignore)]
        public string RightExample { get; set; }

        /// <summary>
        /// 错误示例
        /// </summary>
        [JsonProperty("error_example", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorExample { get; set; }

        /// <summary>
        /// 修改建议
        /// </summary>
        [JsonProperty("revise_opinion", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviseOpinion { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("rule_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleListItem {\n");
            sb.Append("  ruleSet: ").Append(RuleSet).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleLanguage: ").Append(RuleLanguage).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  ruleSeverity: ").Append(RuleSeverity).Append("\n");
            sb.Append("  ruleTages: ").Append(RuleTages).Append("\n");
            sb.Append("  rightExample: ").Append(RightExample).Append("\n");
            sb.Append("  errorExample: ").Append(ErrorExample).Append("\n");
            sb.Append("  reviseOpinion: ").Append(ReviseOpinion).Append("\n");
            sb.Append("  ruleDesc: ").Append(RuleDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleListItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleListItem input)
        {
            if (input == null) return false;
            if (this.RuleSet != input.RuleSet || (this.RuleSet != null && !this.RuleSet.Equals(input.RuleSet))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleLanguage != input.RuleLanguage || (this.RuleLanguage != null && !this.RuleLanguage.Equals(input.RuleLanguage))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.RuleSeverity != input.RuleSeverity || (this.RuleSeverity != null && !this.RuleSeverity.Equals(input.RuleSeverity))) return false;
            if (this.RuleTages != input.RuleTages || (this.RuleTages != null && !this.RuleTages.Equals(input.RuleTages))) return false;
            if (this.RightExample != input.RightExample || (this.RightExample != null && !this.RightExample.Equals(input.RightExample))) return false;
            if (this.ErrorExample != input.ErrorExample || (this.ErrorExample != null && !this.ErrorExample.Equals(input.ErrorExample))) return false;
            if (this.ReviseOpinion != input.ReviseOpinion || (this.ReviseOpinion != null && !this.ReviseOpinion.Equals(input.ReviseOpinion))) return false;
            if (this.RuleDesc != input.RuleDesc || (this.RuleDesc != null && !this.RuleDesc.Equals(input.RuleDesc))) return false;

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
                if (this.RuleSet != null) hashCode = hashCode * 59 + this.RuleSet.GetHashCode();
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleLanguage != null) hashCode = hashCode * 59 + this.RuleLanguage.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.RuleSeverity != null) hashCode = hashCode * 59 + this.RuleSeverity.GetHashCode();
                if (this.RuleTages != null) hashCode = hashCode * 59 + this.RuleTages.GetHashCode();
                if (this.RightExample != null) hashCode = hashCode * 59 + this.RightExample.GetHashCode();
                if (this.ErrorExample != null) hashCode = hashCode * 59 + this.ErrorExample.GetHashCode();
                if (this.ReviseOpinion != null) hashCode = hashCode * 59 + this.ReviseOpinion.GetHashCode();
                if (this.RuleDesc != null) hashCode = hashCode * 59 + this.RuleDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
