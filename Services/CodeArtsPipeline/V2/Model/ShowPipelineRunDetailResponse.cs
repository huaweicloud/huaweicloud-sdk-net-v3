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
    public class ShowPipelineRunDetailResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 流水线运行实例ID，[启动流水线](RunPipeline.xml)接口的返回值即为流水线运行实例ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 流水线ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 流水线版本。 **取值范围**： 默认3.0。 
        /// </summary>
        [JsonProperty("manifest_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ManifestVersion { get; set; }

        /// <summary>
        /// **参数解释**： 流水线名称。 **取值范围**： 仅包含中文、大小写英文字母、数字、&#39;-&#39;和&#39;_&#39;，且长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行描述。 **取值范围**： 最长1024字符。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 是否为变更流水线。 **取值范围**： - true：是变更流水线。 - false：不是变更流水线。 
        /// </summary>
        [JsonProperty("is_publish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// **参数解释**： 运行人ID，用户的userId。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// **参数解释**： 运行人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("executor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorName { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行实例状态。 **取值范围**： - COMPLETED：已完成。 - RUNNING：运行中。 - FAILED：失败。 - CANCELED：取消。 - PAUSED：暂停。 - SUSPEND：挂起。 - IGNORED：忽略。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**： 流水线触发类型。 - Manual：手动触发。 - Scheduler：定时任务。 - MR：MR触发。 - Push：Push事件触发。 - CreateTag：Tag事件触发。 - Issue：Issue触发。 - Note：评论触发。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行序号。 **取值范围**： 大于等于 1。 
        /// </summary>
        [JsonProperty("run_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunNumber { get; set; }

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
        /// **参数解释**： 阶段运行信息列表，包含各个阶段的详细运行信息。 **约束限制**： 不涉及。 
        /// </summary>
        [JsonProperty("stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<StageRun> Stages { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID，用户账号的domainId。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**： 项目ID。 **取值范围**： 32位字符，仅由数字和字母组成。 
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 局点。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**： 微服务ID。可以通过[查询微服务列表](ListMicroservice.xml)接口获取，其中data.id即为微服务ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// **参数解释**： 语言，暂时仅包含中英文。 **取值范围**： zh-cn, en-us。 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释**： 流水线执行源信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<RunPipelineSource> Sources { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行产物。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("artifacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageInfo> Artifacts { get; set; }

        /// <summary>
        /// **参数解释**： 流水线运行实例ID，[启动流水线](RunPipeline.xml)接口的返回值即为流水线运行实例ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("subject_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubjectId { get; set; }

        /// <summary>
        /// **参数解释**： 分组ID。 **取值范围**： 32位字符，由数字和字母组成。 
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数解释**： 分组名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 详情页地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DetailUrl { get; set; }

        /// <summary>
        /// **参数解释**： 当前系统时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("current_system_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentSystemTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPipelineRunDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  manifestVersion: ").Append(ManifestVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isPublish: ").Append(IsPublish).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorName: ").Append(ExecutorName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  runNumber: ").Append(RunNumber).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  stages: ").Append(Stages).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  subjectId: ").Append(SubjectId).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  detailUrl: ").Append(DetailUrl).Append("\n");
            sb.Append("  currentSystemTime: ").Append(CurrentSystemTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPipelineRunDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPipelineRunDetailResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.ManifestVersion != input.ManifestVersion || (this.ManifestVersion != null && !this.ManifestVersion.Equals(input.ManifestVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsPublish != input.IsPublish || (this.IsPublish != null && !this.IsPublish.Equals(input.IsPublish))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorName != input.ExecutorName || (this.ExecutorName != null && !this.ExecutorName.Equals(input.ExecutorName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.RunNumber != input.RunNumber || (this.RunNumber != null && !this.RunNumber.Equals(input.RunNumber))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Stages != input.Stages || (this.Stages != null && input.Stages != null && !this.Stages.SequenceEqual(input.Stages))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ComponentId != input.ComponentId || (this.ComponentId != null && !this.ComponentId.Equals(input.ComponentId))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.Artifacts != input.Artifacts || (this.Artifacts != null && input.Artifacts != null && !this.Artifacts.SequenceEqual(input.Artifacts))) return false;
            if (this.SubjectId != input.SubjectId || (this.SubjectId != null && !this.SubjectId.Equals(input.SubjectId))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.DetailUrl != input.DetailUrl || (this.DetailUrl != null && !this.DetailUrl.Equals(input.DetailUrl))) return false;
            if (this.CurrentSystemTime != input.CurrentSystemTime || (this.CurrentSystemTime != null && !this.CurrentSystemTime.Equals(input.CurrentSystemTime))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.ManifestVersion != null) hashCode = hashCode * 59 + this.ManifestVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsPublish != null) hashCode = hashCode * 59 + this.IsPublish.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorName != null) hashCode = hashCode * 59 + this.ExecutorName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.RunNumber != null) hashCode = hashCode * 59 + this.RunNumber.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Stages != null) hashCode = hashCode * 59 + this.Stages.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ComponentId != null) hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.Artifacts != null) hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
                if (this.SubjectId != null) hashCode = hashCode * 59 + this.SubjectId.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.DetailUrl != null) hashCode = hashCode * 59 + this.DetailUrl.GetHashCode();
                if (this.CurrentSystemTime != null) hashCode = hashCode * 59 + this.CurrentSystemTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
