using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateImmutableRuleBody 
    {

        /// <summary>
        /// 优先级，默认值为0
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 不可变策略是否生效，默认值为false
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 预留字段，支持填immutable
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 预留字段，支持填immutable_template
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }

        /// <summary>
        /// 制品版本选择器，目前只支持长度为1
        /// </summary>
        [JsonProperty("tag_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleSelector> TagSelectors { get; set; }

        /// <summary>
        /// 制品仓库选择器，目前只支持repository且长度为1
        /// </summary>
        [JsonProperty("scope_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<RuleSelector>> ScopeSelectors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateImmutableRuleBody {\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  tagSelectors: ").Append(TagSelectors).Append("\n");
            sb.Append("  scopeSelectors: ").Append(ScopeSelectors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateImmutableRuleBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateImmutableRuleBody input)
        {
            if (input == null) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Template != input.Template || (this.Template != null && !this.Template.Equals(input.Template))) return false;
            if (this.TagSelectors != input.TagSelectors || (this.TagSelectors != null && input.TagSelectors != null && !this.TagSelectors.SequenceEqual(input.TagSelectors))) return false;
            if (this.ScopeSelectors != input.ScopeSelectors || (this.ScopeSelectors != null && input.ScopeSelectors != null && !this.ScopeSelectors.SequenceEqual(input.ScopeSelectors))) return false;

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
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Template != null) hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TagSelectors != null) hashCode = hashCode * 59 + this.TagSelectors.GetHashCode();
                if (this.ScopeSelectors != null) hashCode = hashCode * 59 + this.ScopeSelectors.GetHashCode();
                return hashCode;
            }
        }
    }
}
