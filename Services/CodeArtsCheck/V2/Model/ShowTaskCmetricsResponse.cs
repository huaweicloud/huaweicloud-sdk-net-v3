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
    /// Response Object
    /// </summary>
    public class ShowTaskCmetricsResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 旧版任务ID。即新建检查任务接口的返回值，每个代码检查任务及其下的分支任务、通过API创建的增量任务都有唯一的任务ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释：** 任务名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// **参数解释：** 任务创建者用户ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓分支。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("git_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitBranch { get; set; }

        /// <summary>
        /// **参数解释：** 上一次检查时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckTime { get; set; }

        /// <summary>
        /// **参数解释：** 上一次执行时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastExecTime { get; set; }

        /// <summary>
        /// **参数解释：** 上次执行结束时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_check_finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastCheckFinishTime { get; set; }

        /// <summary>
        /// **参数解释：** 废弃字段。 **约束限制：** 不涉及。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("check_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckType { get; set; }

        /// <summary>
        /// **参数解释：** 任务创建时间。使用UTC时间，格式为yyyy-MM-ddTHH:mm:ssZ。例如：2020-09-25T12:05:00Z。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric_info", NullValueHandling = NullValueHandling.Ignore)]
        public MetricInfo MetricInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaskCmetricsResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitBranch: ").Append(GitBranch).Append("\n");
            sb.Append("  lastCheckTime: ").Append(LastCheckTime).Append("\n");
            sb.Append("  lastExecTime: ").Append(LastExecTime).Append("\n");
            sb.Append("  lastCheckFinishTime: ").Append(LastCheckFinishTime).Append("\n");
            sb.Append("  checkType: ").Append(CheckType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  metricInfo: ").Append(MetricInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaskCmetricsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaskCmetricsResponse input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitBranch != input.GitBranch || (this.GitBranch != null && !this.GitBranch.Equals(input.GitBranch))) return false;
            if (this.LastCheckTime != input.LastCheckTime || (this.LastCheckTime != null && !this.LastCheckTime.Equals(input.LastCheckTime))) return false;
            if (this.LastExecTime != input.LastExecTime || (this.LastExecTime != null && !this.LastExecTime.Equals(input.LastExecTime))) return false;
            if (this.LastCheckFinishTime != input.LastCheckFinishTime || (this.LastCheckFinishTime != null && !this.LastCheckFinishTime.Equals(input.LastCheckFinishTime))) return false;
            if (this.CheckType != input.CheckType || (this.CheckType != null && !this.CheckType.Equals(input.CheckType))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.MetricInfo != input.MetricInfo || (this.MetricInfo != null && !this.MetricInfo.Equals(input.MetricInfo))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitBranch != null) hashCode = hashCode * 59 + this.GitBranch.GetHashCode();
                if (this.LastCheckTime != null) hashCode = hashCode * 59 + this.LastCheckTime.GetHashCode();
                if (this.LastExecTime != null) hashCode = hashCode * 59 + this.LastExecTime.GetHashCode();
                if (this.LastCheckFinishTime != null) hashCode = hashCode * 59 + this.LastCheckFinishTime.GetHashCode();
                if (this.CheckType != null) hashCode = hashCode * 59 + this.CheckType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.MetricInfo != null) hashCode = hashCode * 59 + this.MetricInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
