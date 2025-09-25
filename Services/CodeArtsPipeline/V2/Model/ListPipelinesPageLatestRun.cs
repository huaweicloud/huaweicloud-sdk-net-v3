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
    /// **参数解释**： 最近一次运行信息。 **取值范围**： 不涉及。 
    /// </summary>
    public class ListPipelinesPageLatestRun 
    {

        /// <summary>
        /// **参数解释**： 流水线ID，可以通过[查询流水线列表](ListPipelines.xml)接口，其中pipelines.pipelineId即为流水线ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行实例ID，[启动流水线](RunPipeline.xml)接口的返回值即为流水线运行实例ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_run_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineRunId { get; set; }

        /// <summary>
        /// **参数解释**： 执行人ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// **参数解释**： 执行人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("executor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorName { get; set; }

        /// <summary>
        /// **参数解释**： 阶段信息列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("stage_status_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListPipelinesPageLatestRunStageStatusList> StageStatusList { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行实例状态。 **取值范围**： - COMPLETED：已完成。 - RUNNING：运行中。 - FAILED：失败。 - CANCELED：取消。 - PAUSED：暂停。 - SUSPEND：挂起。 - IGNORED：忽略。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行序号。 **取值范围**： 大于等于 1。 
        /// </summary>
        [JsonProperty("run_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunNumber { get; set; }

        /// <summary>
        /// **参数解释**： 触发类型 **取值范围**： - Manual：手动触发。 - Scheduler：定时任务。 - MR：MR触发。 - Push：Push事件触发。 - CreateTag：Tag事件触发。 - Issue：Issue触发。 - Note：评论触发。 
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("build_params", NullValueHandling = NullValueHandling.Ignore)]
        public ListPipelinesPageLatestRunBuildParams BuildParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("artifact_params", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineLatestRunArtifactParams ArtifactParams { get; set; }

        /// <summary>
        /// **参数解释**： 流水线开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 流水线结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 修改页地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("modify_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifyUrl { get; set; }

        /// <summary>
        /// **参数解释**： 详情页地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelinesPageLatestRun {\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  pipelineRunId: ").Append(PipelineRunId).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorName: ").Append(ExecutorName).Append("\n");
            sb.Append("  stageStatusList: ").Append(StageStatusList).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  runNumber: ").Append(RunNumber).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  buildParams: ").Append(BuildParams).Append("\n");
            sb.Append("  artifactParams: ").Append(ArtifactParams).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  modifyUrl: ").Append(ModifyUrl).Append("\n");
            sb.Append("  detailUrl: ").Append(DetailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPipelinesPageLatestRun);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelinesPageLatestRun input)
        {
            if (input == null) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.PipelineRunId != input.PipelineRunId || (this.PipelineRunId != null && !this.PipelineRunId.Equals(input.PipelineRunId))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorName != input.ExecutorName || (this.ExecutorName != null && !this.ExecutorName.Equals(input.ExecutorName))) return false;
            if (this.StageStatusList != input.StageStatusList || (this.StageStatusList != null && input.StageStatusList != null && !this.StageStatusList.SequenceEqual(input.StageStatusList))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RunNumber != input.RunNumber || (this.RunNumber != null && !this.RunNumber.Equals(input.RunNumber))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.BuildParams != input.BuildParams || (this.BuildParams != null && !this.BuildParams.Equals(input.BuildParams))) return false;
            if (this.ArtifactParams != input.ArtifactParams || (this.ArtifactParams != null && !this.ArtifactParams.Equals(input.ArtifactParams))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ModifyUrl != input.ModifyUrl || (this.ModifyUrl != null && !this.ModifyUrl.Equals(input.ModifyUrl))) return false;
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
                if (this.PipelineRunId != null) hashCode = hashCode * 59 + this.PipelineRunId.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorName != null) hashCode = hashCode * 59 + this.ExecutorName.GetHashCode();
                if (this.StageStatusList != null) hashCode = hashCode * 59 + this.StageStatusList.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RunNumber != null) hashCode = hashCode * 59 + this.RunNumber.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.BuildParams != null) hashCode = hashCode * 59 + this.BuildParams.GetHashCode();
                if (this.ArtifactParams != null) hashCode = hashCode * 59 + this.ArtifactParams.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ModifyUrl != null) hashCode = hashCode * 59 + this.ModifyUrl.GetHashCode();
                if (this.DetailUrl != null) hashCode = hashCode * 59 + this.DetailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
