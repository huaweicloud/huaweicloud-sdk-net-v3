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
    public class MergeRequestBasicDiscussionDto 
    {

        /// <summary>
        /// 评论id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// individual_note
        /// </summary>
        [JsonProperty("individual_note", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndividualNote { get; set; }

        /// <summary>
        /// 主评和回复列表
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<NoteDto> Notes { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 目标类型
        /// </summary>
        [JsonProperty("noteable_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NoteableType { get; set; }

        /// <summary>
        /// 关联的提交id
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// 仓库路径
        /// </summary>
        [JsonProperty("project_full_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectFullPath { get; set; }

        /// <summary>
        /// 变更前文件模式
        /// </summary>
        [JsonProperty("a_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AMode { get; set; }

        /// <summary>
        /// 变更后文件模式
        /// </summary>
        [JsonProperty("b_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string BMode { get; set; }

        /// <summary>
        /// 此次变更是否删除文件
        /// </summary>
        [JsonProperty("deleted_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletedFile { get; set; }

        /// <summary>
        /// 此次变更是否新增文件
        /// </summary>
        [JsonProperty("new_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewFile { get; set; }

        /// <summary>
        /// 检视意见是否解决
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolved { get; set; }

        /// <summary>
        /// 检视意见是否存档
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// 检视意见分类
        /// </summary>
        [JsonProperty("review_categories", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategories { get; set; }

        /// <summary>
        /// 检视意见分类中文名
        /// </summary>
        [JsonProperty("review_categories_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategoriesCn { get; set; }

        /// <summary>
        /// 检视意见分类英文名
        /// </summary>
        [JsonProperty("review_categories_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategoriesEn { get; set; }

        /// <summary>
        /// 检视意见模块
        /// </summary>
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewModules { get; set; }

        /// <summary>
        /// 严重程度
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// 严重程度中文名
        /// </summary>
        [JsonProperty("severity_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityCn { get; set; }

        /// <summary>
        /// 严重程度英文名
        /// </summary>
        [JsonProperty("severity_en", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityEn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proposer", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Proposer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("merge_request_version_params", NullValueHandling = NullValueHandling.Ignore)]
        public MergeRequestVersionParamsDto MergeRequestVersionParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestBasicDiscussionDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  individualNote: ").Append(IndividualNote).Append("\n");
            sb.Append("  notes: ").Append(Notes).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  noteableType: ").Append(NoteableType).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  projectFullPath: ").Append(ProjectFullPath).Append("\n");
            sb.Append("  aMode: ").Append(AMode).Append("\n");
            sb.Append("  bMode: ").Append(BMode).Append("\n");
            sb.Append("  deletedFile: ").Append(DeletedFile).Append("\n");
            sb.Append("  newFile: ").Append(NewFile).Append("\n");
            sb.Append("  resolved: ").Append(Resolved).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  reviewCategories: ").Append(ReviewCategories).Append("\n");
            sb.Append("  reviewCategoriesCn: ").Append(ReviewCategoriesCn).Append("\n");
            sb.Append("  reviewCategoriesEn: ").Append(ReviewCategoriesEn).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  severityCn: ").Append(SeverityCn).Append("\n");
            sb.Append("  severityEn: ").Append(SeverityEn).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  proposer: ").Append(Proposer).Append("\n");
            sb.Append("  mergeRequestVersionParams: ").Append(MergeRequestVersionParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestBasicDiscussionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestBasicDiscussionDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IndividualNote != input.IndividualNote || (this.IndividualNote != null && !this.IndividualNote.Equals(input.IndividualNote))) return false;
            if (this.Notes != input.Notes || (this.Notes != null && input.Notes != null && !this.Notes.SequenceEqual(input.Notes))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.NoteableType != input.NoteableType || (this.NoteableType != null && !this.NoteableType.Equals(input.NoteableType))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.ProjectFullPath != input.ProjectFullPath || (this.ProjectFullPath != null && !this.ProjectFullPath.Equals(input.ProjectFullPath))) return false;
            if (this.AMode != input.AMode || (this.AMode != null && !this.AMode.Equals(input.AMode))) return false;
            if (this.BMode != input.BMode || (this.BMode != null && !this.BMode.Equals(input.BMode))) return false;
            if (this.DeletedFile != input.DeletedFile || (this.DeletedFile != null && !this.DeletedFile.Equals(input.DeletedFile))) return false;
            if (this.NewFile != input.NewFile || (this.NewFile != null && !this.NewFile.Equals(input.NewFile))) return false;
            if (this.Resolved != input.Resolved || (this.Resolved != null && !this.Resolved.Equals(input.Resolved))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.ReviewCategories != input.ReviewCategories || (this.ReviewCategories != null && !this.ReviewCategories.Equals(input.ReviewCategories))) return false;
            if (this.ReviewCategoriesCn != input.ReviewCategoriesCn || (this.ReviewCategoriesCn != null && !this.ReviewCategoriesCn.Equals(input.ReviewCategoriesCn))) return false;
            if (this.ReviewCategoriesEn != input.ReviewCategoriesEn || (this.ReviewCategoriesEn != null && !this.ReviewCategoriesEn.Equals(input.ReviewCategoriesEn))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && !this.ReviewModules.Equals(input.ReviewModules))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.SeverityCn != input.SeverityCn || (this.SeverityCn != null && !this.SeverityCn.Equals(input.SeverityCn))) return false;
            if (this.SeverityEn != input.SeverityEn || (this.SeverityEn != null && !this.SeverityEn.Equals(input.SeverityEn))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Proposer != input.Proposer || (this.Proposer != null && !this.Proposer.Equals(input.Proposer))) return false;
            if (this.MergeRequestVersionParams != input.MergeRequestVersionParams || (this.MergeRequestVersionParams != null && !this.MergeRequestVersionParams.Equals(input.MergeRequestVersionParams))) return false;

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
                if (this.IndividualNote != null) hashCode = hashCode * 59 + this.IndividualNote.GetHashCode();
                if (this.Notes != null) hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.NoteableType != null) hashCode = hashCode * 59 + this.NoteableType.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.ProjectFullPath != null) hashCode = hashCode * 59 + this.ProjectFullPath.GetHashCode();
                if (this.AMode != null) hashCode = hashCode * 59 + this.AMode.GetHashCode();
                if (this.BMode != null) hashCode = hashCode * 59 + this.BMode.GetHashCode();
                if (this.DeletedFile != null) hashCode = hashCode * 59 + this.DeletedFile.GetHashCode();
                if (this.NewFile != null) hashCode = hashCode * 59 + this.NewFile.GetHashCode();
                if (this.Resolved != null) hashCode = hashCode * 59 + this.Resolved.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.ReviewCategories != null) hashCode = hashCode * 59 + this.ReviewCategories.GetHashCode();
                if (this.ReviewCategoriesCn != null) hashCode = hashCode * 59 + this.ReviewCategoriesCn.GetHashCode();
                if (this.ReviewCategoriesEn != null) hashCode = hashCode * 59 + this.ReviewCategoriesEn.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SeverityCn != null) hashCode = hashCode * 59 + this.SeverityCn.GetHashCode();
                if (this.SeverityEn != null) hashCode = hashCode * 59 + this.SeverityEn.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Proposer != null) hashCode = hashCode * 59 + this.Proposer.GetHashCode();
                if (this.MergeRequestVersionParams != null) hashCode = hashCode * 59 + this.MergeRequestVersionParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
