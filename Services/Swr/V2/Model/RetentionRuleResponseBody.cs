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
    public class RetentionRuleResponseBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 预留字段，目前只支持0
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 是否关闭此条规则
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 预留字段，目前只支持retain
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 规则模板类型，值为：latestPulledN，latestPushedK，nDaysSinceLastPush，nDaysSinceLastPull
        /// </summary>
        [JsonProperty("template", NullValueHandling = NullValueHandling.Ignore)]
        public string Template { get; set; }

        /// <summary>
        /// 保留方式的参数，配套template使用，可参考请求示例
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Params { get; set; }

        /// <summary>
        /// 制品版本选择器，目前只支持长度为1
        /// </summary>
        [JsonProperty("tag_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<RetentionSelector> TagSelectors { get; set; }

        /// <summary>
        /// 制品仓库选择器，目前只支持repository且长度为1
        /// </summary>
        [JsonProperty("scope_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<RetentionSelector>> ScopeSelectors { get; set; }

        /// <summary>
        /// repo选择模式，前端使用，可选regular、selection
        /// </summary>
        [JsonProperty("repo_scope_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoScopeMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetentionRuleResponseBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  template: ").Append(Template).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  tagSelectors: ").Append(TagSelectors).Append("\n");
            sb.Append("  scopeSelectors: ").Append(ScopeSelectors).Append("\n");
            sb.Append("  repoScopeMode: ").Append(RepoScopeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetentionRuleResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetentionRuleResponseBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Template != input.Template || (this.Template != null && !this.Template.Equals(input.Template))) return false;
            if (this.Params != input.Params || (this.Params != null && input.Params != null && !this.Params.SequenceEqual(input.Params))) return false;
            if (this.TagSelectors != input.TagSelectors || (this.TagSelectors != null && input.TagSelectors != null && !this.TagSelectors.SequenceEqual(input.TagSelectors))) return false;
            if (this.ScopeSelectors != input.ScopeSelectors || (this.ScopeSelectors != null && input.ScopeSelectors != null && !this.ScopeSelectors.SequenceEqual(input.ScopeSelectors))) return false;
            if (this.RepoScopeMode != input.RepoScopeMode || (this.RepoScopeMode != null && !this.RepoScopeMode.Equals(input.RepoScopeMode))) return false;

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
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Template != null) hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.TagSelectors != null) hashCode = hashCode * 59 + this.TagSelectors.GetHashCode();
                if (this.ScopeSelectors != null) hashCode = hashCode * 59 + this.ScopeSelectors.GetHashCode();
                if (this.RepoScopeMode != null) hashCode = hashCode * 59 + this.RepoScopeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
