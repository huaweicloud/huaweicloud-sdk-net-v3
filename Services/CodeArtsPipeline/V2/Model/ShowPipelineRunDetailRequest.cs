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
    /// Request Object
    /// </summary>
    public class ShowPipelineRunDetailRequest 
    {

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 流水线ID
        /// </summary>
        [SDKProperty("pipeline_id", IsPath = true)]
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// 流水线运行实例ID
        /// </summary>
        [SDKProperty("pipeline_run_id", IsQuery = true)]
        [JsonProperty("pipeline_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineRunId { get; set; }

        /// <summary>
        /// 流水线运行编号
        /// </summary>
        [SDKProperty("pipeline_run_number", IsQuery = true)]
        [JsonProperty("pipeline_run_number", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineRunNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineRunDetailRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineRunId: ").Append(PipelineRunId).Append("\n");
            sb.Append("  pipelineRunNumber: ").Append(PipelineRunNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineRunDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineRunDetailRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineRunId != input.PipelineRunId || (this.PipelineRunId != null && !this.PipelineRunId.Equals(input.PipelineRunId))) return false;
            if (this.PipelineRunNumber != input.PipelineRunNumber || (this.PipelineRunNumber != null && !this.PipelineRunNumber.Equals(input.PipelineRunNumber))) return false;

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
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.PipelineRunId != null) hashCode = hashCode * 59 + this.PipelineRunId.GetHashCode();
                if (this.PipelineRunNumber != null) hashCode = hashCode * 59 + this.PipelineRunNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
