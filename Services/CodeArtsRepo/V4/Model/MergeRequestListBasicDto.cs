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
    /// 合并请求基本信息
    /// </summary>
    public class MergeRequestListBasicDto 
    {

        /// <summary>
        /// **参数解释：** 合并请求ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求位于当前仓库序号。
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求源分支。
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求目标分支。
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求源仓库ID。
        /// </summary>
        [JsonProperty("source_repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceRepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求检视模式。
        /// </summary>
        [JsonProperty("review_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Author { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求关闭时间。
        /// </summary>
        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("closed_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto ClosedBy { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求合并时间。
        /// </summary>
        [JsonProperty("merged_at", NullValueHandling = NullValueHandling.Ignore)]
        public string MergedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merged_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto MergedBy { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求流水线状态。
        /// </summary>
        [JsonProperty("pipeline_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineStatus { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求代码质量状态。
        /// </summary>
        [JsonProperty("codequality_status", NullValueHandling = NullValueHandling.Ignore)]
        public string CodequalityStatus { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求流水线状态。
        /// </summary>
        [JsonProperty("pipeline_status_with_code_quality", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineStatusWithCodeQuality { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求检视意见。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_repository", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectSimpleDto SourceRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_repository", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectSimpleDto TargetRepository { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求URL地址。
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求新增代码行数。
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求删除代码行数。
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求检视模式。
        /// </summary>
        [JsonProperty("merge_request_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestType { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求git地址。
        /// </summary>
        [JsonProperty("source_git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceGitUrl { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求标签。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> Labels { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求分数。
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? Score { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求最小合入分数。
        /// </summary>
        [JsonProperty("min_merged_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinMergedScore { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求源项目ID。
        /// </summary>
        [JsonProperty("source_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceProductId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求目标项目ID。
        /// </summary>
        [JsonProperty("target_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProductId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求项目名。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notes_count", NullValueHandling = NullValueHandling.Ignore)]
        public NotesCountDto NotesCount { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求审核结果。
        /// </summary>
        [JsonProperty("moderation_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModerationResult { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求审核时间。
        /// </summary>
        [JsonProperty("moderation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModerationTime { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求审核状态。
        /// </summary>
        [JsonProperty("moderation_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModerationStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestListBasicDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  sourceRepositoryId: ").Append(SourceRepositoryId).Append("\n");
            sb.Append("  reviewMode: ").Append(ReviewMode).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  closedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  closedBy: ").Append(ClosedBy).Append("\n");
            sb.Append("  mergedAt: ").Append(MergedAt).Append("\n");
            sb.Append("  mergedBy: ").Append(MergedBy).Append("\n");
            sb.Append("  pipelineStatus: ").Append(PipelineStatus).Append("\n");
            sb.Append("  codequalityStatus: ").Append(CodequalityStatus).Append("\n");
            sb.Append("  pipelineStatusWithCodeQuality: ").Append(PipelineStatusWithCodeQuality).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  sourceRepository: ").Append(SourceRepository).Append("\n");
            sb.Append("  targetRepository: ").Append(TargetRepository).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("  mergeRequestType: ").Append(MergeRequestType).Append("\n");
            sb.Append("  sourceGitUrl: ").Append(SourceGitUrl).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  minMergedScore: ").Append(MinMergedScore).Append("\n");
            sb.Append("  sourceProductId: ").Append(SourceProductId).Append("\n");
            sb.Append("  targetProductId: ").Append(TargetProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  notesCount: ").Append(NotesCount).Append("\n");
            sb.Append("  moderationResult: ").Append(ModerationResult).Append("\n");
            sb.Append("  moderationTime: ").Append(ModerationTime).Append("\n");
            sb.Append("  moderationStatus: ").Append(ModerationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestListBasicDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestListBasicDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.SourceRepositoryId != input.SourceRepositoryId || (this.SourceRepositoryId != null && !this.SourceRepositoryId.Equals(input.SourceRepositoryId))) return false;
            if (this.ReviewMode != input.ReviewMode || (this.ReviewMode != null && !this.ReviewMode.Equals(input.ReviewMode))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.ClosedAt != input.ClosedAt || (this.ClosedAt != null && !this.ClosedAt.Equals(input.ClosedAt))) return false;
            if (this.ClosedBy != input.ClosedBy || (this.ClosedBy != null && !this.ClosedBy.Equals(input.ClosedBy))) return false;
            if (this.MergedAt != input.MergedAt || (this.MergedAt != null && !this.MergedAt.Equals(input.MergedAt))) return false;
            if (this.MergedBy != input.MergedBy || (this.MergedBy != null && !this.MergedBy.Equals(input.MergedBy))) return false;
            if (this.PipelineStatus != input.PipelineStatus || (this.PipelineStatus != null && !this.PipelineStatus.Equals(input.PipelineStatus))) return false;
            if (this.CodequalityStatus != input.CodequalityStatus || (this.CodequalityStatus != null && !this.CodequalityStatus.Equals(input.CodequalityStatus))) return false;
            if (this.PipelineStatusWithCodeQuality != input.PipelineStatusWithCodeQuality || (this.PipelineStatusWithCodeQuality != null && !this.PipelineStatusWithCodeQuality.Equals(input.PipelineStatusWithCodeQuality))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && !this.Notes.Equals(input.Notes))) return false;
            if (this.SourceRepository != input.SourceRepository || (this.SourceRepository != null && !this.SourceRepository.Equals(input.SourceRepository))) return false;
            if (this.TargetRepository != input.TargetRepository || (this.TargetRepository != null && !this.TargetRepository.Equals(input.TargetRepository))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;
            if (this.MergeRequestType != input.MergeRequestType || (this.MergeRequestType != null && !this.MergeRequestType.Equals(input.MergeRequestType))) return false;
            if (this.SourceGitUrl != input.SourceGitUrl || (this.SourceGitUrl != null && !this.SourceGitUrl.Equals(input.SourceGitUrl))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;
            if (this.MinMergedScore != input.MinMergedScore || (this.MinMergedScore != null && !this.MinMergedScore.Equals(input.MinMergedScore))) return false;
            if (this.SourceProductId != input.SourceProductId || (this.SourceProductId != null && !this.SourceProductId.Equals(input.SourceProductId))) return false;
            if (this.TargetProductId != input.TargetProductId || (this.TargetProductId != null && !this.TargetProductId.Equals(input.TargetProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.NotesCount != input.NotesCount || (this.NotesCount != null && !this.NotesCount.Equals(input.NotesCount))) return false;
            if (this.ModerationResult != input.ModerationResult || (this.ModerationResult != null && !this.ModerationResult.Equals(input.ModerationResult))) return false;
            if (this.ModerationTime != input.ModerationTime || (this.ModerationTime != null && !this.ModerationTime.Equals(input.ModerationTime))) return false;
            if (this.ModerationStatus != input.ModerationStatus || (this.ModerationStatus != null && !this.ModerationStatus.Equals(input.ModerationStatus))) return false;

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
                if (this.Iid != null) hashCode = hashCode * 59 + this.Iid.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.SourceRepositoryId != null) hashCode = hashCode * 59 + this.SourceRepositoryId.GetHashCode();
                if (this.ReviewMode != null) hashCode = hashCode * 59 + this.ReviewMode.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.ClosedAt != null) hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.ClosedBy != null) hashCode = hashCode * 59 + this.ClosedBy.GetHashCode();
                if (this.MergedAt != null) hashCode = hashCode * 59 + this.MergedAt.GetHashCode();
                if (this.MergedBy != null) hashCode = hashCode * 59 + this.MergedBy.GetHashCode();
                if (this.PipelineStatus != null) hashCode = hashCode * 59 + this.PipelineStatus.GetHashCode();
                if (this.CodequalityStatus != null) hashCode = hashCode * 59 + this.CodequalityStatus.GetHashCode();
                if (this.PipelineStatusWithCodeQuality != null) hashCode = hashCode * 59 + this.PipelineStatusWithCodeQuality.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.SourceRepository != null) hashCode = hashCode * 59 + this.SourceRepository.GetHashCode();
                if (this.TargetRepository != null) hashCode = hashCode * 59 + this.TargetRepository.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                if (this.MergeRequestType != null) hashCode = hashCode * 59 + this.MergeRequestType.GetHashCode();
                if (this.SourceGitUrl != null) hashCode = hashCode * 59 + this.SourceGitUrl.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.MinMergedScore != null) hashCode = hashCode * 59 + this.MinMergedScore.GetHashCode();
                if (this.SourceProductId != null) hashCode = hashCode * 59 + this.SourceProductId.GetHashCode();
                if (this.TargetProductId != null) hashCode = hashCode * 59 + this.TargetProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.NotesCount != null) hashCode = hashCode * 59 + this.NotesCount.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                if (this.ModerationTime != null) hashCode = hashCode * 59 + this.ModerationTime.GetHashCode();
                if (this.ModerationStatus != null) hashCode = hashCode * 59 + this.ModerationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
