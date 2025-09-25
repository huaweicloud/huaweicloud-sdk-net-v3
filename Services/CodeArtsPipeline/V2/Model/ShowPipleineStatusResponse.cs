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
    /// Response Object
    /// </summary>
    public class ShowPipleineStatusResponse : SdkResponse
    {

        /// <summary>
        /// 流水线ID
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// 流水线名称
        /// </summary>
        [JsonProperty("pipeline_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineName { get; set; }

        /// <summary>
        /// 执行人
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }

        /// <summary>
        /// 流水线执行ID
        /// </summary>
        [JsonProperty("build_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildId { get; set; }

        /// <summary>
        /// 开始执行时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束执行时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 流水线参数
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineParameter> Parameters { get; set; }

        /// <summary>
        /// 流水线执行情况
        /// </summary>
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public List<PipelineStateStatus> States { get; set; }

        /// <summary>
        /// 执行耗时
        /// </summary>
        [JsonProperty("elapsed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ElapsedTime { get; set; }

        /// <summary>
        /// 流水线运行状态。取值及含义：waiting：等待；running：执行中；verifying：待审核；suspending：挂起；completed：完成。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 流水线执行结果。取值及含义：success：成功；error：失败；aborted：终止
        /// </summary>
        [JsonProperty("outcome", NullValueHandling = NullValueHandling.Ignore)]
        public string Outcome { get; set; }

        /// <summary>
        /// 流水线详情页地址
        /// </summary>
        [JsonProperty("detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipleineStatusResponse {\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineName: ").Append(PipelineName).Append("\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("  buildId: ").Append(BuildId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("  elapsedTime: ").Append(ElapsedTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  outcome: ").Append(Outcome).Append("\n");
            sb.Append("  detailUrl: ").Append(DetailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipleineStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipleineStatusResponse input)
        {
            if (input == null) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineName != input.PipelineName || (this.PipelineName != null && !this.PipelineName.Equals(input.PipelineName))) return false;
            if (this.Executor != input.Executor || (this.Executor != null && !this.Executor.Equals(input.Executor))) return false;
            if (this.BuildId != input.BuildId || (this.BuildId != null && !this.BuildId.Equals(input.BuildId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.States != input.States || (this.States != null && input.States != null && !this.States.SequenceEqual(input.States))) return false;
            if (this.ElapsedTime != input.ElapsedTime || (this.ElapsedTime != null && !this.ElapsedTime.Equals(input.ElapsedTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Outcome != input.Outcome || (this.Outcome != null && !this.Outcome.Equals(input.Outcome))) return false;
            if (this.DetailUrl != input.DetailUrl || (this.DetailUrl != null && !this.DetailUrl.Equals(input.DetailUrl))) return false;

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
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.PipelineName != null) hashCode = hashCode * 59 + this.PipelineName.GetHashCode();
                if (this.Executor != null) hashCode = hashCode * 59 + this.Executor.GetHashCode();
                if (this.BuildId != null) hashCode = hashCode * 59 + this.BuildId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.States != null) hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.ElapsedTime != null) hashCode = hashCode * 59 + this.ElapsedTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Outcome != null) hashCode = hashCode * 59 + this.Outcome.GetHashCode();
                if (this.DetailUrl != null) hashCode = hashCode * 59 + this.DetailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
