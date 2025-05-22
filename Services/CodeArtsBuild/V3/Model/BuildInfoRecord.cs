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
    /// 构建历史详情
    /// </summary>
    public class BuildInfoRecord 
    {

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("build_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildTime { get; set; }

        /// <summary>
        /// 开始时间，时间戳
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("job_running_status", NullValueHandling = NullValueHandling.Ignore)]
        public string JobRunningStatus { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// IAM用户ID
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 触发构建用户
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>
        /// 构建编号，每日从1开始
        /// </summary>
        [JsonProperty("daily_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNumber { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CostTime { get; set; }

        /// <summary>
        /// 代码提交的commit id
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("commit_info", NullValueHandling = NullValueHandling.Ignore)]
        public BuildInfoRecordCommitInfo CommitInfo { get; set; }

        /// <summary>
        /// 构建类型
        /// </summary>
        [JsonProperty("build_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildType { get; set; }

        /// <summary>
        /// 代码仓分支
        /// </summary>
        [JsonProperty("code_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeBranch { get; set; }

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
        /// 代码提交记录信息地址（代码源为Repo)
        /// </summary>
        [JsonProperty("commit_detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitDetailUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildInfoRecord {\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  buildTime: ").Append(BuildTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  jobRunningStatus: ").Append(JobRunningStatus).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("  nickname: ").Append(Nickname).Append("\n");
            sb.Append("  dailyBuildNumber: ").Append(DailyBuildNumber).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  costTime: ").Append(CostTime).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  commitInfo: ").Append(CommitInfo).Append("\n");
            sb.Append("  buildType: ").Append(BuildType).Append("\n");
            sb.Append("  codeBranch: ").Append(CodeBranch).Append("\n");
            sb.Append("  scmType: ").Append(ScmType).Append("\n");
            sb.Append("  scmWebUrl: ").Append(ScmWebUrl).Append("\n");
            sb.Append("  commitDetailUrl: ").Append(CommitDetailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildInfoRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BuildInfoRecord input)
        {
            if (input == null) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.BuildTime != input.BuildTime || (this.BuildTime != null && !this.BuildTime.Equals(input.BuildTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.JobRunningStatus != input.JobRunningStatus || (this.JobRunningStatus != null && !this.JobRunningStatus.Equals(input.JobRunningStatus))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Executor != input.Executor || (this.Executor != null && !this.Executor.Equals(input.Executor))) return false;
            if (this.Nickname != input.Nickname || (this.Nickname != null && !this.Nickname.Equals(input.Nickname))) return false;
            if (this.DailyBuildNumber != input.DailyBuildNumber || (this.DailyBuildNumber != null && !this.DailyBuildNumber.Equals(input.DailyBuildNumber))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.CostTime != input.CostTime || (this.CostTime != null && !this.CostTime.Equals(input.CostTime))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.CommitInfo != input.CommitInfo || (this.CommitInfo != null && !this.CommitInfo.Equals(input.CommitInfo))) return false;
            if (this.BuildType != input.BuildType || (this.BuildType != null && !this.BuildType.Equals(input.BuildType))) return false;
            if (this.CodeBranch != input.CodeBranch || (this.CodeBranch != null && !this.CodeBranch.Equals(input.CodeBranch))) return false;
            if (this.ScmType != input.ScmType || (this.ScmType != null && !this.ScmType.Equals(input.ScmType))) return false;
            if (this.ScmWebUrl != input.ScmWebUrl || (this.ScmWebUrl != null && !this.ScmWebUrl.Equals(input.ScmWebUrl))) return false;
            if (this.CommitDetailUrl != input.CommitDetailUrl || (this.CommitDetailUrl != null && !this.CommitDetailUrl.Equals(input.CommitDetailUrl))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.BuildTime != null) hashCode = hashCode * 59 + this.BuildTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.JobRunningStatus != null) hashCode = hashCode * 59 + this.JobRunningStatus.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Executor != null) hashCode = hashCode * 59 + this.Executor.GetHashCode();
                if (this.Nickname != null) hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.DailyBuildNumber != null) hashCode = hashCode * 59 + this.DailyBuildNumber.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.CostTime != null) hashCode = hashCode * 59 + this.CostTime.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.CommitInfo != null) hashCode = hashCode * 59 + this.CommitInfo.GetHashCode();
                if (this.BuildType != null) hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.CodeBranch != null) hashCode = hashCode * 59 + this.CodeBranch.GetHashCode();
                if (this.ScmType != null) hashCode = hashCode * 59 + this.ScmType.GetHashCode();
                if (this.ScmWebUrl != null) hashCode = hashCode * 59 + this.ScmWebUrl.GetHashCode();
                if (this.CommitDetailUrl != null) hashCode = hashCode * 59 + this.CommitDetailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
