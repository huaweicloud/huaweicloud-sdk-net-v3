using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释**：按标签统计训练作业资源数量的请求体。
    /// </summary>
    public class CountResourceInstancesReq 
    {

        /// <summary>
        /// **参数解释**：标签过滤条件，返回同时包含列表中所有标签的训练作业。 **约束限制**：标签个数不能超过系统允许的最大标签数。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<CountResourceInstancesReqTags> Tags { get; set; }

        /// <summary>
        /// **参数解释**：模糊匹配条件，支持按资源名称等字段进行模糊查询。 **约束限制**：最多1个匹配条件。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<CountResourceInstancesReqMatches> Matches { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：0。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：是否查询不带任何标签的训练作业。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：false。
        /// </summary>
        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountResourceInstancesReq {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountResourceInstancesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountResourceInstancesReq input)
        {
            if (input == null) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Matches != input.Matches || (this.Matches != null && input.Matches != null && !this.Matches.SequenceEqual(input.Matches))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.WithoutAnyTag != input.WithoutAnyTag || (this.WithoutAnyTag != null && !this.WithoutAnyTag.Equals(input.WithoutAnyTag))) return false;

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
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Matches != null) hashCode = hashCode * 59 + this.Matches.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.WithoutAnyTag != null) hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                return hashCode;
            }
        }
    }
}
