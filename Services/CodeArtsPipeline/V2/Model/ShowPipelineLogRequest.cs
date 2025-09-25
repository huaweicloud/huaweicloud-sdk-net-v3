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
    public class ShowPipelineLogRequest 
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
        [SDKProperty("pipeline_run_id", IsPath = true)]
        [JsonProperty("pipeline_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineRunId { get; set; }

        /// <summary>
        /// 流水线任务ID
        /// </summary>
        [SDKProperty("job_run_id", IsPath = true)]
        [JsonProperty("job_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobRunId { get; set; }

        /// <summary>
        /// 流水线步骤ID
        /// </summary>
        [SDKProperty("step_run_id", IsPath = true)]
        [JsonProperty("step_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StepRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public LogQuery Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineLogRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineRunId: ").Append(PipelineRunId).Append("\n");
            sb.Append("  jobRunId: ").Append(JobRunId).Append("\n");
            sb.Append("  stepRunId: ").Append(StepRunId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineLogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineLogRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineRunId != input.PipelineRunId || (this.PipelineRunId != null && !this.PipelineRunId.Equals(input.PipelineRunId))) return false;
            if (this.JobRunId != input.JobRunId || (this.JobRunId != null && !this.JobRunId.Equals(input.JobRunId))) return false;
            if (this.StepRunId != input.StepRunId || (this.StepRunId != null && !this.StepRunId.Equals(input.StepRunId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.JobRunId != null) hashCode = hashCode * 59 + this.JobRunId.GetHashCode();
                if (this.StepRunId != null) hashCode = hashCode * 59 + this.StepRunId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
