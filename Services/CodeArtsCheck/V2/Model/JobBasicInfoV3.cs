using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** 执行记录信息。
    /// </summary>
    public class JobBasicInfoV3 
    {

        /// <summary>
        /// **参数解释：** 执行人用户名。 **取值范围：** 长度为[1~255]个字符。
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }

        /// <summary>
        /// **参数解释：** 执行记录的检查完成时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("finishTime", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// **参数解释：** 执行ID，来自代码检查执行任务接口的返回值，每次执行代码检查任务都有唯一的执行ID。 **取值范围：** 长度为[1~32]个字符。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("jobResult", NullValueHandling = NullValueHandling.Ignore)]
        public JobResultInfo JobResult { get; set; }

        /// <summary>
        /// **参数解释:** 任务类型。 **取值范围:** - FULL：版本级任务。 - INC_GIT：门禁级任务。 [- INC_COMMIT：流水线指定commitId增量检查、代码检查任务设置-检查范围-版本级检查模式的最近一次提交检查。](tag:hws,hws_hk) [- INC_COMMIT：代码检查任务设置-检查范围-版本级检查模式的最近一次提交检查。](tag:hcs,hcs_sm,hcs_site,hcs_sitesm,fcs) [- INC_LAST_SUCCESS_COMMIT：流水线指定commitId以及最后一次门禁成功的commitId间的增量检查。](tag:hws,hws_hk)
        /// </summary>
        [JsonProperty("jobType", NullValueHandling = NullValueHandling.Ignore)]
        public string JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public ProcessInfo Process { get; set; }

        /// <summary>
        /// **参数解释：** 门禁结果。 **取值范围：** - success：门禁通过。 - error：门禁未通过。
        /// </summary>
        [JsonProperty("reviewResult", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewResult { get; set; }

        /// <summary>
        /// **参数解释：** 规则集配置列表。
        /// </summary>
        [JsonProperty("ruleSets", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigTemplateRuleSetInfo> RuleSets { get; set; }

        /// <summary>
        /// **参数解释：** 执行来源。 **取值范围：** - customer：来自页面点击。 - Scheduled：来自定时任务。 - CodeCheckEdge：来自Edge服务。 - CodeArtsPipeline：来自流水线。 - DevCloudWebhook：来自CodeArtsRepo的Webhook。 - GitCodeActionPipeline：来自流水线的GitCodeAction插件。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释：** 源分支的代码仓地址。 **取值范围：** 长度为[1~1024]个字符。
        /// </summary>
        [JsonProperty("sourceRepoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceRepoUrl { get; set; }

        /// <summary>
        /// **参数解释：**  执行记录的检查开始时间，使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ，例如\&quot;2025-11-28T06:55:41Z\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释:** 任务执行状态。 **取值范围:** - quering：初始状态。 - running：执行中。 - success：检查成功。 - failed：检查失败。 - aborted：任务中止。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 子任务ID，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("subJobIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubJobIds { get; set; }

        /// <summary>
        /// **参数解释：** 子任务状态，该字段一般返回空数组[]。
        /// </summary>
        [JsonProperty("subJobStatuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubJobStatuses { get; set; }

        /// <summary>
        /// **参数解释：** 目标分支的代码仓地址。 **取值范围：** 长度为[1~1024]个字符。
        /// </summary>
        [JsonProperty("targetRepoUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRepoUrl { get; set; }

        /// <summary>
        /// **参数解释：** 任务ID，即新建检查任务接口的返回值，每个代码检查任务及其下的分支任务、通过API创建的增量任务都有唯一的任务ID。即[[查询任务列表](https://support.huaweicloud.com/api-codecheck/ShowTasksList.html)](tag:hws)[[查询任务列表](https://support.huaweicloud.com/intl/zh-cn/api-codecheck/ShowTasksList.html)](tag:hws_hk)[查询任务列表](tag:hcs,hcs_sm)接口响应中的id字段。 **取值范围：** 长度为[1~32]个字符。
        /// </summary>
        [JsonProperty("taskId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释：** 任务总执行时长，格式为%dm%ds，例如\&quot;6m6s\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("totalExecuteTime", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalExecuteTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobBasicInfoV3 {\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobResult: ").Append(JobResult).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  reviewResult: ").Append(ReviewResult).Append("\n");
            sb.Append("  ruleSets: ").Append(RuleSets).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  sourceRepoUrl: ").Append(SourceRepoUrl).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  subJobIds: ").Append(SubJobIds).Append("\n");
            sb.Append("  subJobStatuses: ").Append(SubJobStatuses).Append("\n");
            sb.Append("  targetRepoUrl: ").Append(TargetRepoUrl).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  totalExecuteTime: ").Append(TotalExecuteTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobBasicInfoV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobBasicInfoV3 input)
        {
            if (input == null) return false;
            if (this.Executor != input.Executor || (this.Executor != null && !this.Executor.Equals(input.Executor))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.JobResult != input.JobResult || (this.JobResult != null && !this.JobResult.Equals(input.JobResult))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.Process != input.Process || (this.Process != null && !this.Process.Equals(input.Process))) return false;
            if (this.ReviewResult != input.ReviewResult || (this.ReviewResult != null && !this.ReviewResult.Equals(input.ReviewResult))) return false;
            if (this.RuleSets != input.RuleSets || (this.RuleSets != null && input.RuleSets != null && !this.RuleSets.SequenceEqual(input.RuleSets))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.SourceRepoUrl != input.SourceRepoUrl || (this.SourceRepoUrl != null && !this.SourceRepoUrl.Equals(input.SourceRepoUrl))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SubJobIds != input.SubJobIds || (this.SubJobIds != null && input.SubJobIds != null && !this.SubJobIds.SequenceEqual(input.SubJobIds))) return false;
            if (this.SubJobStatuses != input.SubJobStatuses || (this.SubJobStatuses != null && input.SubJobStatuses != null && !this.SubJobStatuses.SequenceEqual(input.SubJobStatuses))) return false;
            if (this.TargetRepoUrl != input.TargetRepoUrl || (this.TargetRepoUrl != null && !this.TargetRepoUrl.Equals(input.TargetRepoUrl))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TotalExecuteTime != input.TotalExecuteTime || (this.TotalExecuteTime != null && !this.TotalExecuteTime.Equals(input.TotalExecuteTime))) return false;

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
                if (this.Executor != null) hashCode = hashCode * 59 + this.Executor.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobResult != null) hashCode = hashCode * 59 + this.JobResult.GetHashCode();
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.Process != null) hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.ReviewResult != null) hashCode = hashCode * 59 + this.ReviewResult.GetHashCode();
                if (this.RuleSets != null) hashCode = hashCode * 59 + this.RuleSets.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceRepoUrl != null) hashCode = hashCode * 59 + this.SourceRepoUrl.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubJobIds != null) hashCode = hashCode * 59 + this.SubJobIds.GetHashCode();
                if (this.SubJobStatuses != null) hashCode = hashCode * 59 + this.SubJobStatuses.GetHashCode();
                if (this.TargetRepoUrl != null) hashCode = hashCode * 59 + this.TargetRepoUrl.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TotalExecuteTime != null) hashCode = hashCode * 59 + this.TotalExecuteTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
