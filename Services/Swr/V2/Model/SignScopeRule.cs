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
    public class SignScopeRule 
    {

        /// <summary>
        /// 制品版本选择器，目前只支持长度为1
        /// </summary>
        [JsonProperty("tag_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<SignRuleSelector> TagSelectors { get; set; }

        /// <summary>
        /// 制品仓库选择器，目前只支持repository且长度为1
        /// </summary>
        [JsonProperty("scope_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<SignRuleSelector>> ScopeSelectors { get; set; }

        /// <summary>
        /// repository选择方式。可选regular、selection，前端显示需要，api调用时可选regular
        /// </summary>
        [JsonProperty("repo_scope_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoScopeMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignScopeRule {\n");
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
            return this.Equals(input as SignScopeRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SignScopeRule input)
        {
            if (input == null) return false;
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
                if (this.TagSelectors != null) hashCode = hashCode * 59 + this.TagSelectors.GetHashCode();
                if (this.ScopeSelectors != null) hashCode = hashCode * 59 + this.ScopeSelectors.GetHashCode();
                if (this.RepoScopeMode != null) hashCode = hashCode * 59 + this.RepoScopeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
