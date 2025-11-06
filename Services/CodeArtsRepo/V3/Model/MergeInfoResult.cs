using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeInfoResult 
    {

        /// <summary>
        /// 评审人
        /// </summary>
        [JsonProperty("approval_merge_request_approvers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApprovalMergeRequestApproversItem> ApprovalMergeRequestApprovers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public Author Author { get; set; }

        /// <summary>
        /// 关闭时间
        /// </summary>
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedAt { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 合并请求描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("devcloud_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DevcloudSourceBranch { get; set; }

        /// <summary>
        /// 合并请求id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public double? Id { get; set; }

        /// <summary>
        /// 当前仓库内合并请求序号
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public double? Iid { get; set; }

        /// <summary>
        /// 源分支是否存在
        /// </summary>
        [JsonProperty("is_source_branch_exist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSourceBranchExist { get; set; }

        /// <summary>
        /// 检视人
        /// </summary>
        [JsonProperty("merge_request_assignee_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MergeRequestAssigneeListItem> MergeRequestAssigneeList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merge_request_diff", NullValueHandling = NullValueHandling.Ignore)]
        public MergeRequestDiff MergeRequestDiff { get; set; }

        /// <summary>
        /// 是否可以被合并
        /// </summary>
        [JsonProperty("merge_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeStatus { get; set; }

        /// <summary>
        /// 源分支
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// 合并请求状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 目标分支
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeInfoResult {\n");
            sb.Append("  approvalMergeRequestApprovers: ").Append(ApprovalMergeRequestApprovers).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  closedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  devcloudSourceBranch: ").Append(DevcloudSourceBranch).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  isSourceBranchExist: ").Append(IsSourceBranchExist).Append("\n");
            sb.Append("  mergeRequestAssigneeList: ").Append(MergeRequestAssigneeList).Append("\n");
            sb.Append("  mergeRequestDiff: ").Append(MergeRequestDiff).Append("\n");
            sb.Append("  mergeStatus: ").Append(MergeStatus).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeInfoResult input)
        {
            if (input == null) return false;
            if (this.ApprovalMergeRequestApprovers != input.ApprovalMergeRequestApprovers || (this.ApprovalMergeRequestApprovers != null && input.ApprovalMergeRequestApprovers != null && !this.ApprovalMergeRequestApprovers.SequenceEqual(input.ApprovalMergeRequestApprovers))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.ClosedAt != input.ClosedAt || (this.ClosedAt != null && !this.ClosedAt.Equals(input.ClosedAt))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DevcloudSourceBranch != input.DevcloudSourceBranch || (this.DevcloudSourceBranch != null && !this.DevcloudSourceBranch.Equals(input.DevcloudSourceBranch))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.IsSourceBranchExist != input.IsSourceBranchExist || (this.IsSourceBranchExist != null && !this.IsSourceBranchExist.Equals(input.IsSourceBranchExist))) return false;
            if (this.MergeRequestAssigneeList != input.MergeRequestAssigneeList || (this.MergeRequestAssigneeList != null && input.MergeRequestAssigneeList != null && !this.MergeRequestAssigneeList.SequenceEqual(input.MergeRequestAssigneeList))) return false;
            if (this.MergeRequestDiff != input.MergeRequestDiff || (this.MergeRequestDiff != null && !this.MergeRequestDiff.Equals(input.MergeRequestDiff))) return false;
            if (this.MergeStatus != input.MergeStatus || (this.MergeStatus != null && !this.MergeStatus.Equals(input.MergeStatus))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.ApprovalMergeRequestApprovers != null) hashCode = hashCode * 59 + this.ApprovalMergeRequestApprovers.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.ClosedAt != null) hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DevcloudSourceBranch != null) hashCode = hashCode * 59 + this.DevcloudSourceBranch.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Iid != null) hashCode = hashCode * 59 + this.Iid.GetHashCode();
                if (this.IsSourceBranchExist != null) hashCode = hashCode * 59 + this.IsSourceBranchExist.GetHashCode();
                if (this.MergeRequestAssigneeList != null) hashCode = hashCode * 59 + this.MergeRequestAssigneeList.GetHashCode();
                if (this.MergeRequestDiff != null) hashCode = hashCode * 59 + this.MergeRequestDiff.GetHashCode();
                if (this.MergeStatus != null) hashCode = hashCode * 59 + this.MergeStatus.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
