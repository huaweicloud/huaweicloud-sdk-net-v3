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
    /// 
    /// </summary>
    public class PipelineBasicInfo 
    {

        /// <summary>
        /// **参数解释**： 项目id。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 项目名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线id。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建人id。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线创建人名字。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线执行人id。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线执行人名字。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("executor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorName { get; set; }

        /// <summary>
        /// **参数解释**： 启动时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 用户是否关注流水线。 **取值范围**： - true：关注流水线。 - false：未关注流水线。 
        /// </summary>
        [JsonProperty("watched", NullValueHandling = NullValueHandling.Ignore)]
        public string Watched { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineBasicInfo {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineName: ").Append(PipelineName).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorName: ").Append(ExecutorName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  watched: ").Append(Watched).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineBasicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineBasicInfo input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineName != input.PipelineName || (this.PipelineName != null && !this.PipelineName.Equals(input.PipelineName))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorName != input.ExecutorName || (this.ExecutorName != null && !this.ExecutorName.Equals(input.ExecutorName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Watched != input.Watched || (this.Watched != null && !this.Watched.Equals(input.Watched))) return false;

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
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.PipelineName != null) hashCode = hashCode * 59 + this.PipelineName.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorName != null) hashCode = hashCode * 59 + this.ExecutorName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Watched != null) hashCode = hashCode * 59 + this.Watched.GetHashCode();
                return hashCode;
            }
        }
    }
}
