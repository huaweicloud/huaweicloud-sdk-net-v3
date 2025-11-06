using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeRequestRelatedWorkItemDto 
    {

        /// <summary>
        /// 关联id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepoId { get; set; }

        /// <summary>
        /// 合并请求id
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// 目标分支
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// 合并请求标题
        /// </summary>
        [JsonProperty("merge_request_title", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestTitle { get; set; }

        /// <summary>
        /// 合并请求url
        /// </summary>
        [JsonProperty("merge_request_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestUrl { get; set; }

        /// <summary>
        /// 合并请求状态
        /// </summary>
        [JsonProperty("merge_request_state", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestState { get; set; }

        /// <summary>
        /// 关联单id
        /// </summary>
        [JsonProperty("related_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedId { get; set; }

        /// <summary>
        /// 关联单标题
        /// </summary>
        [JsonProperty("related_title", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedTitle { get; set; }

        /// <summary>
        /// 关联单url
        /// </summary>
        [JsonProperty("related_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedUrl { get; set; }

        /// <summary>
        /// 关联结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public int? Result { get; set; }

        /// <summary>
        /// 关联结果信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// 话题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 跟单人
        /// </summary>
        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public Object Tracker { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Object Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestRelatedWorkItemDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  mergeRequestTitle: ").Append(MergeRequestTitle).Append("\n");
            sb.Append("  mergeRequestUrl: ").Append(MergeRequestUrl).Append("\n");
            sb.Append("  mergeRequestState: ").Append(MergeRequestState).Append("\n");
            sb.Append("  relatedId: ").Append(RelatedId).Append("\n");
            sb.Append("  relatedTitle: ").Append(RelatedTitle).Append("\n");
            sb.Append("  relatedUrl: ").Append(RelatedUrl).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  tracker: ").Append(Tracker).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestRelatedWorkItemDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestRelatedWorkItemDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.MergeRequestTitle != input.MergeRequestTitle || (this.MergeRequestTitle != null && !this.MergeRequestTitle.Equals(input.MergeRequestTitle))) return false;
            if (this.MergeRequestUrl != input.MergeRequestUrl || (this.MergeRequestUrl != null && !this.MergeRequestUrl.Equals(input.MergeRequestUrl))) return false;
            if (this.MergeRequestState != input.MergeRequestState || (this.MergeRequestState != null && !this.MergeRequestState.Equals(input.MergeRequestState))) return false;
            if (this.RelatedId != input.RelatedId || (this.RelatedId != null && !this.RelatedId.Equals(input.RelatedId))) return false;
            if (this.RelatedTitle != input.RelatedTitle || (this.RelatedTitle != null && !this.RelatedTitle.Equals(input.RelatedTitle))) return false;
            if (this.RelatedUrl != input.RelatedUrl || (this.RelatedUrl != null && !this.RelatedUrl.Equals(input.RelatedUrl))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.Tracker != input.Tracker || (this.Tracker != null && !this.Tracker.Equals(input.Tracker))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.MergeRequestTitle != null) hashCode = hashCode * 59 + this.MergeRequestTitle.GetHashCode();
                if (this.MergeRequestUrl != null) hashCode = hashCode * 59 + this.MergeRequestUrl.GetHashCode();
                if (this.MergeRequestState != null) hashCode = hashCode * 59 + this.MergeRequestState.GetHashCode();
                if (this.RelatedId != null) hashCode = hashCode * 59 + this.RelatedId.GetHashCode();
                if (this.RelatedTitle != null) hashCode = hashCode * 59 + this.RelatedTitle.GetHashCode();
                if (this.RelatedUrl != null) hashCode = hashCode * 59 + this.RelatedUrl.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Tracker != null) hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
