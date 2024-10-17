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
    /// 结果
    /// </summary>
    public class RecordInfoResult 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 构建工程ID,唯一对应codeci_job_id
        /// </summary>
        [JsonProperty("build_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildProjectId { get; set; }

        /// <summary>
        /// 构建记录ID
        /// </summary>
        [JsonProperty("build_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildRecordId { get; set; }

        /// <summary>
        /// 父构建记录ID
        /// </summary>
        [JsonProperty("parent_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentRecordId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("devcloud_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DevcloudProjectId { get; set; }

        /// <summary>
        /// codeci任务ID,唯一对应build_project_id
        /// </summary>
        [JsonProperty("codeci_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeciJobId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("build_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNo { get; set; }

        /// <summary>
        /// 每日构建编号，每日从1开始
        /// </summary>
        [JsonProperty("daily_build_num", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNum { get; set; }

        /// <summary>
        /// 八爪鱼任务ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// 仓库分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 仓库tag
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 仓库commit ID
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public string Commit { get; set; }

        /// <summary>
        /// 仓库commit提交信息
        /// </summary>
        [JsonProperty("commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// commit创建时间
        /// </summary>
        [JsonProperty("commit_create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitCreateTime { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 构建类型
        /// </summary>
        [JsonProperty("build_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildType { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 构建下发耗时
        /// </summary>
        [JsonProperty("schedule_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 构建排队耗时
        /// </summary>
        [JsonProperty("queued_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueuedTime { get; set; }

        /// <summary>
        /// 开始构建时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 八爪鱼真正开始构建时间
        /// </summary>
        [JsonProperty("runnable_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RunnableTime { get; set; }

        /// <summary>
        /// 构建结束时间
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 构建时长
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// record状态
        /// </summary>
        [JsonProperty("record_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordStatus { get; set; }

        /// <summary>
        /// 是否使用自定义执行机
        /// </summary>
        [JsonProperty("use_private_slave", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsePrivateSlave { get; set; }

        /// <summary>
        /// 租户所在region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("err_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 构建配置类型，YAML或ACTION
        /// </summary>
        [JsonProperty("build_config_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildConfigType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordInfoResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  buildProjectId: ").Append(BuildProjectId).Append("\n");
            sb.Append("  buildRecordId: ").Append(BuildRecordId).Append("\n");
            sb.Append("  parentRecordId: ").Append(ParentRecordId).Append("\n");
            sb.Append("  devcloudProjectId: ").Append(DevcloudProjectId).Append("\n");
            sb.Append("  codeciJobId: ").Append(CodeciJobId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  buildNo: ").Append(BuildNo).Append("\n");
            sb.Append("  dailyBuildNum: ").Append(DailyBuildNum).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  commitMessage: ").Append(CommitMessage).Append("\n");
            sb.Append("  commitCreateTime: ").Append(CommitCreateTime).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  buildType: ").Append(BuildType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  scheduleTime: ").Append(ScheduleTime).Append("\n");
            sb.Append("  queuedTime: ").Append(QueuedTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  runnableTime: ").Append(RunnableTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  recordStatus: ").Append(RecordStatus).Append("\n");
            sb.Append("  usePrivateSlave: ").Append(UsePrivateSlave).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  errMsg: ").Append(ErrMsg).Append("\n");
            sb.Append("  buildConfigType: ").Append(BuildConfigType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordInfoResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.BuildProjectId != input.BuildProjectId || (this.BuildProjectId != null && !this.BuildProjectId.Equals(input.BuildProjectId))) return false;
            if (this.BuildRecordId != input.BuildRecordId || (this.BuildRecordId != null && !this.BuildRecordId.Equals(input.BuildRecordId))) return false;
            if (this.ParentRecordId != input.ParentRecordId || (this.ParentRecordId != null && !this.ParentRecordId.Equals(input.ParentRecordId))) return false;
            if (this.DevcloudProjectId != input.DevcloudProjectId || (this.DevcloudProjectId != null && !this.DevcloudProjectId.Equals(input.DevcloudProjectId))) return false;
            if (this.CodeciJobId != input.CodeciJobId || (this.CodeciJobId != null && !this.CodeciJobId.Equals(input.CodeciJobId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.BuildNo != input.BuildNo || (this.BuildNo != null && !this.BuildNo.Equals(input.BuildNo))) return false;
            if (this.DailyBuildNum != input.DailyBuildNum || (this.DailyBuildNum != null && !this.DailyBuildNum.Equals(input.DailyBuildNum))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.CommitMessage != input.CommitMessage || (this.CommitMessage != null && !this.CommitMessage.Equals(input.CommitMessage))) return false;
            if (this.CommitCreateTime != input.CommitCreateTime || (this.CommitCreateTime != null && !this.CommitCreateTime.Equals(input.CommitCreateTime))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.BuildType != input.BuildType || (this.BuildType != null && !this.BuildType.Equals(input.BuildType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ScheduleTime != input.ScheduleTime || (this.ScheduleTime != null && !this.ScheduleTime.Equals(input.ScheduleTime))) return false;
            if (this.QueuedTime != input.QueuedTime || (this.QueuedTime != null && !this.QueuedTime.Equals(input.QueuedTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.RunnableTime != input.RunnableTime || (this.RunnableTime != null && !this.RunnableTime.Equals(input.RunnableTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.RecordStatus != input.RecordStatus || (this.RecordStatus != null && !this.RecordStatus.Equals(input.RecordStatus))) return false;
            if (this.UsePrivateSlave != input.UsePrivateSlave || (this.UsePrivateSlave != null && !this.UsePrivateSlave.Equals(input.UsePrivateSlave))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ErrMsg != input.ErrMsg || (this.ErrMsg != null && !this.ErrMsg.Equals(input.ErrMsg))) return false;
            if (this.BuildConfigType != input.BuildConfigType || (this.BuildConfigType != null && !this.BuildConfigType.Equals(input.BuildConfigType))) return false;

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
                if (this.BuildProjectId != null) hashCode = hashCode * 59 + this.BuildProjectId.GetHashCode();
                if (this.BuildRecordId != null) hashCode = hashCode * 59 + this.BuildRecordId.GetHashCode();
                if (this.ParentRecordId != null) hashCode = hashCode * 59 + this.ParentRecordId.GetHashCode();
                if (this.DevcloudProjectId != null) hashCode = hashCode * 59 + this.DevcloudProjectId.GetHashCode();
                if (this.CodeciJobId != null) hashCode = hashCode * 59 + this.CodeciJobId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.BuildNo != null) hashCode = hashCode * 59 + this.BuildNo.GetHashCode();
                if (this.DailyBuildNum != null) hashCode = hashCode * 59 + this.DailyBuildNum.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Commit != null) hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.CommitMessage != null) hashCode = hashCode * 59 + this.CommitMessage.GetHashCode();
                if (this.CommitCreateTime != null) hashCode = hashCode * 59 + this.CommitCreateTime.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.BuildType != null) hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ScheduleTime != null) hashCode = hashCode * 59 + this.ScheduleTime.GetHashCode();
                if (this.QueuedTime != null) hashCode = hashCode * 59 + this.QueuedTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.RunnableTime != null) hashCode = hashCode * 59 + this.RunnableTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.RecordStatus != null) hashCode = hashCode * 59 + this.RecordStatus.GetHashCode();
                if (this.UsePrivateSlave != null) hashCode = hashCode * 59 + this.UsePrivateSlave.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ErrMsg != null) hashCode = hashCode * 59 + this.ErrMsg.GetHashCode();
                if (this.BuildConfigType != null) hashCode = hashCode * 59 + this.BuildConfigType.GetHashCode();
                return hashCode;
            }
        }
    }
}
