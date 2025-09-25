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
    public class PipelineBuildResult 
    {

        /// <summary>
        /// **参数解释**： 流水线执行ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        /// <summary>
        /// **参数解释**： 运行耗时，单位为毫秒。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("elapse_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ElapseTime { get; set; }

        /// <summary>
        /// **参数解释**： 执行结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 运行结果。 **取值范围**： - success：成功。 - error：失败。 - aborted：终止。 
        /// </summary>
        [JsonProperty("outcome", NullValueHandling = NullValueHandling.Ignore)]
        public string Outcome { get; set; }

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
        /// **参数解释**： 执行开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 运行状态。 **取值范围**： - waiting：等待中。 - running：运行中。 - verifying：待审核。 - suspending：挂起。 - completed：执行完成。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineBuildResult {\n");
            sb.Append("  buildId: ").Append(BuildId).Append("\n");
            sb.Append("  elapseTime: ").Append(ElapseTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  outcome: ").Append(Outcome).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineName: ").Append(PipelineName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineBuildResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineBuildResult input)
        {
            if (input == null) return false;
            if (this.BuildId != input.BuildId || (this.BuildId != null && !this.BuildId.Equals(input.BuildId))) return false;
            if (this.ElapseTime != input.ElapseTime || (this.ElapseTime != null && !this.ElapseTime.Equals(input.ElapseTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Outcome != input.Outcome || (this.Outcome != null && !this.Outcome.Equals(input.Outcome))) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineName != input.PipelineName || (this.PipelineName != null && !this.PipelineName.Equals(input.PipelineName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.BuildId != null) hashCode = hashCode * 59 + this.BuildId.GetHashCode();
                if (this.ElapseTime != null) hashCode = hashCode * 59 + this.ElapseTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Outcome != null) hashCode = hashCode * 59 + this.Outcome.GetHashCode();
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.PipelineName != null) hashCode = hashCode * 59 + this.PipelineName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
