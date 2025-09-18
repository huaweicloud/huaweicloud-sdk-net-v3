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
    public class RuleItem 
    {

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
        /// 规则状态0：未启用，1：已启用
        /// </summary>
        [JsonProperty("checked", NullValueHandling = NullValueHandling.Ignore)]
        public string Checked { get; set; }

        /// <summary>
        /// 规则配置参数阈值相关信息
        /// </summary>
        [JsonProperty("rule_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleConfig> RuleConfigList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleItem {\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  ruleLanguage: ").Append(RuleLanguage).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  ruleSeverity: ").Append(RuleSeverity).Append("\n");
            sb.Append("  ruleTages: ").Append(RuleTages).Append("\n");
            sb.Append("  Checked: ").Append(Checked).Append("\n");
            sb.Append("  ruleConfigList: ").Append(RuleConfigList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleItem input)
        {
            if (input == null) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.RuleLanguage != input.RuleLanguage || (this.RuleLanguage != null && !this.RuleLanguage.Equals(input.RuleLanguage))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.RuleSeverity != input.RuleSeverity || (this.RuleSeverity != null && !this.RuleSeverity.Equals(input.RuleSeverity))) return false;
            if (this.RuleTages != input.RuleTages || (this.RuleTages != null && !this.RuleTages.Equals(input.RuleTages))) return false;
            if (this.Checked != input.Checked || (this.Checked != null && !this.Checked.Equals(input.Checked))) return false;
            if (this.RuleConfigList != input.RuleConfigList || (this.RuleConfigList != null && input.RuleConfigList != null && !this.RuleConfigList.SequenceEqual(input.RuleConfigList))) return false;

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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.RuleLanguage != null) hashCode = hashCode * 59 + this.RuleLanguage.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.RuleSeverity != null) hashCode = hashCode * 59 + this.RuleSeverity.GetHashCode();
                if (this.RuleTages != null) hashCode = hashCode * 59 + this.RuleTages.GetHashCode();
                if (this.Checked != null) hashCode = hashCode * 59 + this.Checked.GetHashCode();
                if (this.RuleConfigList != null) hashCode = hashCode * 59 + this.RuleConfigList.GetHashCode();
                return hashCode;
            }
        }
    }
}
