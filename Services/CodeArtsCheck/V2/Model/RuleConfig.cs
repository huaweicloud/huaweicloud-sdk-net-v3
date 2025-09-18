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
    public class RuleConfig 
    {

        /// <summary>
        /// 规则配置ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleId { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 当前
        /// </summary>
        [JsonProperty("option_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionValue { get; set; }

        /// <summary>
        /// 当前规则配置项key
        /// </summary>
        [JsonProperty("option_key", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionKey { get; set; }

        /// <summary>
        /// 当前规则配置项名称
        /// </summary>
        [JsonProperty("option_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OptionName { get; set; }

        /// <summary>
        /// 规则集id
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ruleId: ").Append(RuleId).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  optionValue: ").Append(OptionValue).Append("\n");
            sb.Append("  optionKey: ").Append(OptionKey).Append("\n");
            sb.Append("  optionName: ").Append(OptionName).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleConfig input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RuleId != input.RuleId || (this.RuleId != null && !this.RuleId.Equals(input.RuleId))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.OptionValue != input.OptionValue || (this.OptionValue != null && !this.OptionValue.Equals(input.OptionValue))) return false;
            if (this.OptionKey != input.OptionKey || (this.OptionKey != null && !this.OptionKey.Equals(input.OptionKey))) return false;
            if (this.OptionName != input.OptionName || (this.OptionName != null && !this.OptionName.Equals(input.OptionName))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.RuleId != null) hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.OptionValue != null) hashCode = hashCode * 59 + this.OptionValue.GetHashCode();
                if (this.OptionKey != null) hashCode = hashCode * 59 + this.OptionKey.GetHashCode();
                if (this.OptionName != null) hashCode = hashCode * 59 + this.OptionName.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
