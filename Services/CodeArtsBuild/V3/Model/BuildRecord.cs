using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 项目列表
    /// </summary>
    public class BuildRecord 
    {

        /// <summary>
        /// 唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 等待时间
        /// </summary>
        [JsonProperty("schedule_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 排队时间
        /// </summary>
        [JsonProperty("queued_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueuedTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 持续时间
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 构建时间
        /// </summary>
        [JsonProperty("build_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildDuration { get; set; }

        /// <summary>
        /// 等待时间
        /// </summary>
        [JsonProperty("pending_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingDuration { get; set; }

        /// <summary>
        /// 工程ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 子任务名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 触发者名称
        /// </summary>
        [JsonProperty("trigger_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// 分组名
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 八爪鱼任务ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 构建执行参数列表
        /// </summary>
        [JsonProperty("parameters", NullValueHandling = NullValueHandling.Ignore)]
        public List<BuildRecordParameters> Parameters { get; set; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public string Repository { get; set; }

        /// <summary>
        /// 分支名
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// commitId
        /// </summary>
        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public string Revision { get; set; }

        /// <summary>
        /// yaml路径
        /// </summary>
        [JsonProperty("build_yml_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildYmlPath { get; set; }

        /// <summary>
        /// yaml地址
        /// </summary>
        [JsonProperty("build_yml_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildYmlUrl { get; set; }

        /// <summary>
        /// 构建每日编号
        /// </summary>
        [JsonProperty("daily_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("build_record_type", NullValueHandling = NullValueHandling.Ignore)]
        public BuildRecordBuildRecordType BuildRecordType { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 代码源类型
        /// </summary>
        [JsonProperty("scm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmType { get; set; }

        /// <summary>
        /// 代码源地址
        /// </summary>
        [JsonProperty("scm_web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmWebUrl { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 构建编码
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildNo { get; set; }

        /// <summary>
        /// 构建每日编号
        /// </summary>
        [JsonProperty("daily_build_no", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNo { get; set; }

        /// <summary>
        /// 构建类型
        /// </summary>
        [JsonProperty("dev_cloud_build_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DevCloudBuildType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildRecord {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  scheduleTime: ").Append(ScheduleTime).Append("\n");
            sb.Append("  queuedTime: ").Append(QueuedTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  buildDuration: ").Append(BuildDuration).Append("\n");
            sb.Append("  pendingDuration: ").Append(PendingDuration).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  triggerName: ").Append(TriggerName).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  parameters: ").Append(Parameters).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  revision: ").Append(Revision).Append("\n");
            sb.Append("  buildYmlPath: ").Append(BuildYmlPath).Append("\n");
            sb.Append("  buildYmlUrl: ").Append(BuildYmlUrl).Append("\n");
            sb.Append("  dailyBuildNumber: ").Append(DailyBuildNumber).Append("\n");
            sb.Append("  buildRecordType: ").Append(BuildRecordType).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  scmType: ").Append(ScmType).Append("\n");
            sb.Append("  scmWebUrl: ").Append(ScmWebUrl).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  dailyBuildNo: ").Append(DailyBuildNo).Append("\n");
            sb.Append("  devCloudBuildType: ").Append(DevCloudBuildType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BuildRecord input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ScheduleTime != input.ScheduleTime || (this.ScheduleTime != null && !this.ScheduleTime.Equals(input.ScheduleTime))) return false;
            if (this.QueuedTime != input.QueuedTime || (this.QueuedTime != null && !this.QueuedTime.Equals(input.QueuedTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.BuildDuration != input.BuildDuration || (this.BuildDuration != null && !this.BuildDuration.Equals(input.BuildDuration))) return false;
            if (this.PendingDuration != input.PendingDuration || (this.PendingDuration != null && !this.PendingDuration.Equals(input.PendingDuration))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.TriggerName != input.TriggerName || (this.TriggerName != null && !this.TriggerName.Equals(input.TriggerName))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.Parameters != input.Parameters || (this.Parameters != null && input.Parameters != null && !this.Parameters.SequenceEqual(input.Parameters))) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Revision != input.Revision || (this.Revision != null && !this.Revision.Equals(input.Revision))) return false;
            if (this.BuildYmlPath != input.BuildYmlPath || (this.BuildYmlPath != null && !this.BuildYmlPath.Equals(input.BuildYmlPath))) return false;
            if (this.BuildYmlUrl != input.BuildYmlUrl || (this.BuildYmlUrl != null && !this.BuildYmlUrl.Equals(input.BuildYmlUrl))) return false;
            if (this.DailyBuildNumber != input.DailyBuildNumber || (this.DailyBuildNumber != null && !this.DailyBuildNumber.Equals(input.DailyBuildNumber))) return false;
            if (this.BuildRecordType != input.BuildRecordType || (this.BuildRecordType != null && !this.BuildRecordType.Equals(input.BuildRecordType))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.ScmType != input.ScmType || (this.ScmType != null && !this.ScmType.Equals(input.ScmType))) return false;
            if (this.ScmWebUrl != input.ScmWebUrl || (this.ScmWebUrl != null && !this.ScmWebUrl.Equals(input.ScmWebUrl))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.DailyBuildNo != input.DailyBuildNo || (this.DailyBuildNo != null && !this.DailyBuildNo.Equals(input.DailyBuildNo))) return false;
            if (this.DevCloudBuildType != input.DevCloudBuildType || (this.DevCloudBuildType != null && !this.DevCloudBuildType.Equals(input.DevCloudBuildType))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ScheduleTime != null) hashCode = hashCode * 59 + this.ScheduleTime.GetHashCode();
                if (this.QueuedTime != null) hashCode = hashCode * 59 + this.QueuedTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.BuildDuration != null) hashCode = hashCode * 59 + this.BuildDuration.GetHashCode();
                if (this.PendingDuration != null) hashCode = hashCode * 59 + this.PendingDuration.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.TriggerName != null) hashCode = hashCode * 59 + this.TriggerName.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.Parameters != null) hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Revision != null) hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.BuildYmlPath != null) hashCode = hashCode * 59 + this.BuildYmlPath.GetHashCode();
                if (this.BuildYmlUrl != null) hashCode = hashCode * 59 + this.BuildYmlUrl.GetHashCode();
                if (this.DailyBuildNumber != null) hashCode = hashCode * 59 + this.DailyBuildNumber.GetHashCode();
                if (this.BuildRecordType != null) hashCode = hashCode * 59 + this.BuildRecordType.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.ScmType != null) hashCode = hashCode * 59 + this.ScmType.GetHashCode();
                if (this.ScmWebUrl != null) hashCode = hashCode * 59 + this.ScmWebUrl.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.DailyBuildNo != null) hashCode = hashCode * 59 + this.DailyBuildNo.GetHashCode();
                if (this.DevCloudBuildType != null) hashCode = hashCode * 59 + this.DevCloudBuildType.GetHashCode();
                return hashCode;
            }
        }
    }
}
