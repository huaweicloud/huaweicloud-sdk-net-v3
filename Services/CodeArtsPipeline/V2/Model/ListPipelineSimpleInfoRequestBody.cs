using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 查询流水线信息对象 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
    /// </summary>
    public class ListPipelineSimpleInfoRequestBody 
    {

        /// <summary>
        /// **参数解释**： 流水线名字。查询时进行模糊匹配。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineName { get; set; }

        /// <summary>
        /// **参数解释**： 项目id，有多个值时用逗号分隔，id个数取值[0,10]，非必选。如果该参数有值，则获取对应项目下的流水线列表；如果没有值，则获取用户有权限的所有项目的流水线列表 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("project_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectIds { get; set; }

        /// <summary>
        /// **参数解释**： 创建人id，有多个值时用逗号分隔，id个数取值[0,10]，非必选 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorIds { get; set; }

        /// <summary>
        /// **参数解释**： 执行人id。有多个值时用逗号分隔，id个数取值[0,10]，非必选。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("executor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorIds { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行状态。 **约束限制**： 不涉及。 **取值范围**： - waiting：等待中。 - running：运行中。 - verifying：待审核。 - suspending：挂起。 - completed：执行完成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 流水线执行结果。 **约束限制**： 不涉及。 **取值范围**： - success：成功。 - error：失败。 - aborted：终止。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("outcome", NullValueHandling = NullValueHandling.Ignore)]
        public string Outcome { get; set; }

        /// <summary>
        /// **参数解释**： 用于排序的字段，非必选。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// **参数解释**： 排序方式。 **约束限制**： 不涉及。 **取值范围**： - asc：按排序字段升序。 - desc：按排序字段降序。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓地址。仅支持codehub仓库，如：git@codehub.XXX.git **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释**： 偏移量。表示从此偏移量开始查询。 **约束限制**： 不涉及。 **取值范围**： offset大于等于0。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 每次查询的条目数量。 **约束限制**： 不涉及。 **取值范围**： 取值[10-50]。 **默认取值**： 10。 
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelineSimpleInfoRequestBody {\n");
            sb.Append("  pipelineName: ").Append(PipelineName).Append("\n");
            sb.Append("  projectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  creatorIds: ").Append(CreatorIds).Append("\n");
            sb.Append("  executorIds: ").Append(ExecutorIds).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  outcome: ").Append(Outcome).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
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
            return this.Equals(input as ListPipelineSimpleInfoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelineSimpleInfoRequestBody input)
        {
            if (input == null) return false;
            if (this.PipelineName != input.PipelineName || (this.PipelineName != null && !this.PipelineName.Equals(input.PipelineName))) return false;
            if (this.ProjectIds != input.ProjectIds || (this.ProjectIds != null && !this.ProjectIds.Equals(input.ProjectIds))) return false;
            if (this.CreatorIds != input.CreatorIds || (this.CreatorIds != null && !this.CreatorIds.Equals(input.CreatorIds))) return false;
            if (this.ExecutorIds != input.ExecutorIds || (this.ExecutorIds != null && !this.ExecutorIds.Equals(input.ExecutorIds))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Outcome != input.Outcome || (this.Outcome != null && !this.Outcome.Equals(input.Outcome))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
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
                if (this.PipelineName != null) hashCode = hashCode * 59 + this.PipelineName.GetHashCode();
                if (this.ProjectIds != null) hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.CreatorIds != null) hashCode = hashCode * 59 + this.CreatorIds.GetHashCode();
                if (this.ExecutorIds != null) hashCode = hashCode * 59 + this.ExecutorIds.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Outcome != null) hashCode = hashCode * 59 + this.Outcome.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
