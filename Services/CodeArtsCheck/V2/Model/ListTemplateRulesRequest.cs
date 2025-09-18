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
    /// Request Object
    /// </summary>
    public class ListTemplateRulesRequest 
    {

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 规则集ID
        /// </summary>
        [SDKProperty("ruleset_id", IsPath = true)]
        [JsonProperty("ruleset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RulesetId { get; set; }

        /// <summary>
        /// 规则状态  &#39;1查询全部，2已启动，3未启用&#39;
        /// </summary>
        [SDKProperty("types", IsQuery = true)]
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public string Types { get; set; }

        /// <summary>
        /// 规则语言
        /// </summary>
        [SDKProperty("languages", IsQuery = true)]
        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public string Languages { get; set; }

        /// <summary>
        /// 规则所属标签
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 分页索引，偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTemplateRulesRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  rulesetId: ").Append(RulesetId).Append("\n");
            sb.Append("  types: ").Append(Types).Append("\n");
            sb.Append("  languages: ").Append(Languages).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTemplateRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTemplateRulesRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.RulesetId != input.RulesetId || (this.RulesetId != null && !this.RulesetId.Equals(input.RulesetId))) return false;
            if (this.Types != input.Types || (this.Types != null && !this.Types.Equals(input.Types))) return false;
            if (this.Languages != input.Languages || (this.Languages != null && !this.Languages.Equals(input.Languages))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RulesetId != null) hashCode = hashCode * 59 + this.RulesetId.GetHashCode();
                if (this.Types != null) hashCode = hashCode * 59 + this.Types.GetHashCode();
                if (this.Languages != null) hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
