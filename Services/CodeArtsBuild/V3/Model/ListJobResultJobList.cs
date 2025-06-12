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
    /// 
    /// </summary>
    public class ListJobResultJobList 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务创建者
        /// </summary>
        [JsonProperty("job_creator", NullValueHandling = NullValueHandling.Ignore)]
        public string JobCreator { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 构建任务所在项目的ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 构建任务所在项目的名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 最新执行时间
        /// </summary>
        [JsonProperty("last_build_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LastBuildTime { get; set; }

        /// <summary>
        /// 健康分值
        /// </summary>
        [JsonProperty("health_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthScore { get; set; }

        /// <summary>
        /// 代码来源
        /// </summary>
        [JsonProperty("source_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCode { get; set; }

        /// <summary>
        /// 最新构建状态
        /// </summary>
        [JsonProperty("last_build_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildStatus { get; set; }

        /// <summary>
        /// 最新运行状态
        /// </summary>
        [JsonProperty("last_job_running_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastJobRunningStatus { get; set; }

        /// <summary>
        /// 执行用户
        /// </summary>
        [JsonProperty("last_build_user", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildUser { get; set; }

        /// <summary>
        /// 执行用户ID
        /// </summary>
        [JsonProperty("last_build_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildUserId { get; set; }

        /// <summary>
        /// 是否已结束
        /// </summary>
        [JsonProperty("is_finished", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFinished { get; set; }

        /// <summary>
        /// 是否已禁用
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 是否已收藏
        /// </summary>
        [JsonProperty("favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// 是否有修改任务权限
        /// </summary>
        [JsonProperty("is_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsModify { get; set; }

        /// <summary>
        /// 是否有删除任务权限
        /// </summary>
        [JsonProperty("is_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDelete { get; set; }

        /// <summary>
        /// 是否有查看任务权限
        /// </summary>
        [JsonProperty("is_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsView { get; set; }

        /// <summary>
        /// 是否有执行任务权限
        /// </summary>
        [JsonProperty("is_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExecute { get; set; }

        /// <summary>
        /// 是否有复制任务权限
        /// </summary>
        [JsonProperty("is_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCopy { get; set; }

        /// <summary>
        /// 是否有禁用任务权限
        /// </summary>
        [JsonProperty("is_forbidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForbidden { get; set; }

        /// <summary>
        /// 任务记录编号
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 代码分支
        /// </summary>
        [JsonProperty("code_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeBranch { get; set; }

        /// <summary>
        /// 代码提交ID
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("build_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BuildTime { get; set; }

        /// <summary>
        /// 代码源地址
        /// </summary>
        [JsonProperty("scm_web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmWebUrl { get; set; }

        /// <summary>
        /// 仓库类别，Repo、Github等
        /// </summary>
        [JsonProperty("scm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmType { get; set; }

        /// <summary>
        /// repo的id
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// 代码提交记录信息地址（代码源为Repo)
        /// </summary>
        [JsonProperty("commit_detail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitDetailUrl { get; set; }

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildNumber { get; set; }

        /// <summary>
        /// 禁用消息
        /// </summary>
        [JsonProperty("forbidden_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ForbiddenMsg { get; set; }

        /// <summary>
        /// 构建工程ID,唯一对应codeci_job_id
        /// </summary>
        [JsonProperty("build_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildProjectId { get; set; }

        /// <summary>
        /// 构建类别
        /// </summary>
        [JsonProperty("build_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildType { get; set; }

        /// <summary>
        /// 仓库tag
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 使用项目权限
        /// </summary>
        [JsonProperty("project_permission_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProjectPermissionSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListJobResultJobList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobCreator: ").Append(JobCreator).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  lastBuildTime: ").Append(LastBuildTime).Append("\n");
            sb.Append("  healthScore: ").Append(HealthScore).Append("\n");
            sb.Append("  sourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  lastBuildStatus: ").Append(LastBuildStatus).Append("\n");
            sb.Append("  lastJobRunningStatus: ").Append(LastJobRunningStatus).Append("\n");
            sb.Append("  lastBuildUser: ").Append(LastBuildUser).Append("\n");
            sb.Append("  lastBuildUserId: ").Append(LastBuildUserId).Append("\n");
            sb.Append("  isFinished: ").Append(IsFinished).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  favorite: ").Append(Favorite).Append("\n");
            sb.Append("  isModify: ").Append(IsModify).Append("\n");
            sb.Append("  isDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  isView: ").Append(IsView).Append("\n");
            sb.Append("  isExecute: ").Append(IsExecute).Append("\n");
            sb.Append("  isCopy: ").Append(IsCopy).Append("\n");
            sb.Append("  isForbidden: ").Append(IsForbidden).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  codeBranch: ").Append(CodeBranch).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  buildTime: ").Append(BuildTime).Append("\n");
            sb.Append("  scmWebUrl: ").Append(ScmWebUrl).Append("\n");
            sb.Append("  scmType: ").Append(ScmType).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  commitDetailUrl: ").Append(CommitDetailUrl).Append("\n");
            sb.Append("  buildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  forbiddenMsg: ").Append(ForbiddenMsg).Append("\n");
            sb.Append("  buildProjectId: ").Append(BuildProjectId).Append("\n");
            sb.Append("  buildType: ").Append(BuildType).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  projectPermissionSwitch: ").Append(ProjectPermissionSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListJobResultJobList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListJobResultJobList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.JobCreator != input.JobCreator || (this.JobCreator != null && !this.JobCreator.Equals(input.JobCreator))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.LastBuildTime != input.LastBuildTime || (this.LastBuildTime != null && !this.LastBuildTime.Equals(input.LastBuildTime))) return false;
            if (this.HealthScore != input.HealthScore || (this.HealthScore != null && !this.HealthScore.Equals(input.HealthScore))) return false;
            if (this.SourceCode != input.SourceCode || (this.SourceCode != null && !this.SourceCode.Equals(input.SourceCode))) return false;
            if (this.LastBuildStatus != input.LastBuildStatus || (this.LastBuildStatus != null && !this.LastBuildStatus.Equals(input.LastBuildStatus))) return false;
            if (this.LastJobRunningStatus != input.LastJobRunningStatus || (this.LastJobRunningStatus != null && !this.LastJobRunningStatus.Equals(input.LastJobRunningStatus))) return false;
            if (this.LastBuildUser != input.LastBuildUser || (this.LastBuildUser != null && !this.LastBuildUser.Equals(input.LastBuildUser))) return false;
            if (this.LastBuildUserId != input.LastBuildUserId || (this.LastBuildUserId != null && !this.LastBuildUserId.Equals(input.LastBuildUserId))) return false;
            if (this.IsFinished != input.IsFinished || (this.IsFinished != null && !this.IsFinished.Equals(input.IsFinished))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.Favorite != input.Favorite || (this.Favorite != null && !this.Favorite.Equals(input.Favorite))) return false;
            if (this.IsModify != input.IsModify || (this.IsModify != null && !this.IsModify.Equals(input.IsModify))) return false;
            if (this.IsDelete != input.IsDelete || (this.IsDelete != null && !this.IsDelete.Equals(input.IsDelete))) return false;
            if (this.IsView != input.IsView || (this.IsView != null && !this.IsView.Equals(input.IsView))) return false;
            if (this.IsExecute != input.IsExecute || (this.IsExecute != null && !this.IsExecute.Equals(input.IsExecute))) return false;
            if (this.IsCopy != input.IsCopy || (this.IsCopy != null && !this.IsCopy.Equals(input.IsCopy))) return false;
            if (this.IsForbidden != input.IsForbidden || (this.IsForbidden != null && !this.IsForbidden.Equals(input.IsForbidden))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.CodeBranch != input.CodeBranch || (this.CodeBranch != null && !this.CodeBranch.Equals(input.CodeBranch))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.TriggerType != input.TriggerType || (this.TriggerType != null && !this.TriggerType.Equals(input.TriggerType))) return false;
            if (this.BuildTime != input.BuildTime || (this.BuildTime != null && !this.BuildTime.Equals(input.BuildTime))) return false;
            if (this.ScmWebUrl != input.ScmWebUrl || (this.ScmWebUrl != null && !this.ScmWebUrl.Equals(input.ScmWebUrl))) return false;
            if (this.ScmType != input.ScmType || (this.ScmType != null && !this.ScmType.Equals(input.ScmType))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.CommitDetailUrl != input.CommitDetailUrl || (this.CommitDetailUrl != null && !this.CommitDetailUrl.Equals(input.CommitDetailUrl))) return false;
            if (this.BuildNumber != input.BuildNumber || (this.BuildNumber != null && !this.BuildNumber.Equals(input.BuildNumber))) return false;
            if (this.ForbiddenMsg != input.ForbiddenMsg || (this.ForbiddenMsg != null && !this.ForbiddenMsg.Equals(input.ForbiddenMsg))) return false;
            if (this.BuildProjectId != input.BuildProjectId || (this.BuildProjectId != null && !this.BuildProjectId.Equals(input.BuildProjectId))) return false;
            if (this.BuildType != input.BuildType || (this.BuildType != null && !this.BuildType.Equals(input.BuildType))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.ProjectPermissionSwitch != input.ProjectPermissionSwitch || (this.ProjectPermissionSwitch != null && !this.ProjectPermissionSwitch.Equals(input.ProjectPermissionSwitch))) return false;

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
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobCreator != null) hashCode = hashCode * 59 + this.JobCreator.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.LastBuildTime != null) hashCode = hashCode * 59 + this.LastBuildTime.GetHashCode();
                if (this.HealthScore != null) hashCode = hashCode * 59 + this.HealthScore.GetHashCode();
                if (this.SourceCode != null) hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                if (this.LastBuildStatus != null) hashCode = hashCode * 59 + this.LastBuildStatus.GetHashCode();
                if (this.LastJobRunningStatus != null) hashCode = hashCode * 59 + this.LastJobRunningStatus.GetHashCode();
                if (this.LastBuildUser != null) hashCode = hashCode * 59 + this.LastBuildUser.GetHashCode();
                if (this.LastBuildUserId != null) hashCode = hashCode * 59 + this.LastBuildUserId.GetHashCode();
                if (this.IsFinished != null) hashCode = hashCode * 59 + this.IsFinished.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Favorite != null) hashCode = hashCode * 59 + this.Favorite.GetHashCode();
                if (this.IsModify != null) hashCode = hashCode * 59 + this.IsModify.GetHashCode();
                if (this.IsDelete != null) hashCode = hashCode * 59 + this.IsDelete.GetHashCode();
                if (this.IsView != null) hashCode = hashCode * 59 + this.IsView.GetHashCode();
                if (this.IsExecute != null) hashCode = hashCode * 59 + this.IsExecute.GetHashCode();
                if (this.IsCopy != null) hashCode = hashCode * 59 + this.IsCopy.GetHashCode();
                if (this.IsForbidden != null) hashCode = hashCode * 59 + this.IsForbidden.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.CodeBranch != null) hashCode = hashCode * 59 + this.CodeBranch.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.TriggerType != null) hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.BuildTime != null) hashCode = hashCode * 59 + this.BuildTime.GetHashCode();
                if (this.ScmWebUrl != null) hashCode = hashCode * 59 + this.ScmWebUrl.GetHashCode();
                if (this.ScmType != null) hashCode = hashCode * 59 + this.ScmType.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.CommitDetailUrl != null) hashCode = hashCode * 59 + this.CommitDetailUrl.GetHashCode();
                if (this.BuildNumber != null) hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.ForbiddenMsg != null) hashCode = hashCode * 59 + this.ForbiddenMsg.GetHashCode();
                if (this.BuildProjectId != null) hashCode = hashCode * 59 + this.BuildProjectId.GetHashCode();
                if (this.BuildType != null) hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.ProjectPermissionSwitch != null) hashCode = hashCode * 59 + this.ProjectPermissionSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
