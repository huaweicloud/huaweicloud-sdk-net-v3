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
    /// 查询训练作业资源列表的请求体。
    /// </summary>
    public class ResourceInstancesFilterReq 
    {

        /// <summary>
        /// **参数解释**：工作空间ID。未创建工作空间时默认值为\&quot;0\&quot;，存在创建并使用的工作空间，以实际取值为准。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：0。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：标签筛选条件，按标签key-value对筛选作业。同一key下多个value为OR关系，不同key之间为AND关系。 **约束限制**：同一key的values不能重复，不同key不能重复。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<MutiValueTag> Tags { get; set; }

        /// <summary>
        /// **参数解释**：是否查询没有任何标签的作业。 **约束限制**：设为true时忽略tags筛选条件。 **取值范围**： - true：仅查询无标签的作业 - false：按tags条件筛选 **默认取值**：false。
        /// </summary>
        [JsonProperty("without_any_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithoutAnyTag { get; set; }

        /// <summary>
        /// **参数解释**：资源名称搜索条件。 **约束限制**：最多支持1个匹配项，且key必须为resource_name。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<Match> Matches { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceInstancesFilterReq {\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  withoutAnyTag: ").Append(WithoutAnyTag).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceInstancesFilterReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceInstancesFilterReq input)
        {
            if (input == null) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.WithoutAnyTag != input.WithoutAnyTag || (this.WithoutAnyTag != null && !this.WithoutAnyTag.Equals(input.WithoutAnyTag))) return false;
            if (this.Matches != input.Matches || (this.Matches != null && input.Matches != null && !this.Matches.SequenceEqual(input.Matches))) return false;

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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.WithoutAnyTag != null) hashCode = hashCode * 59 + this.WithoutAnyTag.GetHashCode();
                if (this.Matches != null) hashCode = hashCode * 59 + this.Matches.GetHashCode();
                return hashCode;
            }
        }
    }
}
