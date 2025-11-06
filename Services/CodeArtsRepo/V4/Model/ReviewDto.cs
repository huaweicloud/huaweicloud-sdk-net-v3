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
    /// 检视意见详细信息
    /// </summary>
    public class ReviewDto 
    {
        /// <summary>
        /// **参数解释：** 严重程度key。
        /// </summary>
        /// <value>**参数解释：** 严重程度key。</value>
        [JsonConverter(typeof(EnumClassConverter<SeverityEnum>))]
        public class SeverityEnum
        {
            /// <summary>
            /// Enum SUGGESTION for value: suggestion
            /// </summary>
            public static readonly SeverityEnum SUGGESTION = new SeverityEnum("suggestion");

            /// <summary>
            /// Enum MINOR for value: minor
            /// </summary>
            public static readonly SeverityEnum MINOR = new SeverityEnum("minor");

            /// <summary>
            /// Enum MAJOR for value: major
            /// </summary>
            public static readonly SeverityEnum MAJOR = new SeverityEnum("major");

            /// <summary>
            /// Enum FATAL for value: fatal
            /// </summary>
            public static readonly SeverityEnum FATAL = new SeverityEnum("fatal");

            private static readonly Dictionary<string, SeverityEnum> StaticFields =
            new Dictionary<string, SeverityEnum>()
            {
                { "suggestion", SUGGESTION },
                { "minor", MINOR },
                { "major", MAJOR },
                { "fatal", FATAL },
            };

            private string _value;

            public SeverityEnum()
            {

            }

            public SeverityEnum(string value)
            {
                _value = value;
            }

            public static SeverityEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as SeverityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SeverityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SeverityEnum a, SeverityEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SeverityEnum a, SeverityEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 严重程度英文。
        /// </summary>
        /// <value>**参数解释：** 严重程度英文。</value>
        [JsonConverter(typeof(EnumClassConverter<SeverityEnEnum>))]
        public class SeverityEnEnum
        {
            /// <summary>
            /// Enum SUGGESTION for value: Suggestion
            /// </summary>
            public static readonly SeverityEnEnum SUGGESTION = new SeverityEnEnum("Suggestion");

            /// <summary>
            /// Enum MINOR for value: Minor
            /// </summary>
            public static readonly SeverityEnEnum MINOR = new SeverityEnEnum("Minor");

            /// <summary>
            /// Enum MAJOR for value: Major
            /// </summary>
            public static readonly SeverityEnEnum MAJOR = new SeverityEnEnum("Major");

            /// <summary>
            /// Enum FATAL for value: Fatal
            /// </summary>
            public static readonly SeverityEnEnum FATAL = new SeverityEnEnum("Fatal");

            private static readonly Dictionary<string, SeverityEnEnum> StaticFields =
            new Dictionary<string, SeverityEnEnum>()
            {
                { "Suggestion", SUGGESTION },
                { "Minor", MINOR },
                { "Major", MAJOR },
                { "Fatal", FATAL },
            };

            private string _value;

            public SeverityEnEnum()
            {

            }

            public SeverityEnEnum(string value)
            {
                _value = value;
            }

            public static SeverityEnEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as SeverityEnEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SeverityEnEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SeverityEnEnum a, SeverityEnEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SeverityEnEnum a, SeverityEnEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assignee", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Author { get; set; }

        /// <summary>
        /// **参数解释：** 评论内容。
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 是否为回复。
        /// </summary>
        [JsonProperty("is_reply", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReply { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resolved_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto ResolvedBy { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见id(主评论和回复共用)。
        /// </summary>
        [JsonProperty("discussion_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscussionId { get; set; }

        /// <summary>
        /// **参数解释：** 仓库路径。
        /// </summary>
        [JsonProperty("repository_path", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryPath { get; set; }

        /// <summary>
        /// **参数解释：** 仓库id。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类key。
        /// </summary>
        [JsonProperty("review_categories", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategories { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类中文。
        /// </summary>
        [JsonProperty("review_categories_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategoriesCn { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类英文。
        /// </summary>
        [JsonProperty("review_categories_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategoriesEn { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见模块。
        /// </summary>
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewModules { get; set; }

        /// <summary>
        /// **参数解释：** 严重程度key。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// **参数解释：** 严重程度中文。 **约束限制：** - 建议 - 一般 - 严重 - 致命
        /// </summary>
        [JsonProperty("severity_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityCn { get; set; }

        /// <summary>
        /// **参数解释：** 严重程度英文。
        /// </summary>
        [JsonProperty("severity_en", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnEnum SeverityEn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proposer", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Proposer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Reviewer { get; set; }

        /// <summary>
        /// **参数解释：** 是否已解决。
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolved { get; set; }

        /// <summary>
        /// **参数解释：** 解决时间。
        /// </summary>
        [JsonProperty("resolved_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ResolvedAt { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求或commit链接。
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        /// <summary>
        /// **参数解释：** 内容审核结果。
        /// </summary>
        [JsonProperty("moderation_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModerationResult { get; set; }

        /// <summary>
        /// **参数解释：** 内容审核时间。
        /// </summary>
        [JsonProperty("moderation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModerationTime { get; set; }

        /// <summary>
        /// **参数解释：** 内容审核状态。
        /// </summary>
        [JsonProperty("moderation_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModerationStatus { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求id(noteable_type&#x3D;MergRequest时返回)。
        /// </summary>
        [JsonProperty("merge_request_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestId { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求iid(noteable_type&#x3D;MergRequest时返回)。
        /// </summary>
        [JsonProperty("merge_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestIid { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求标题(noteable_type&#x3D;MergRequest时返回)。
        /// </summary>
        [JsonProperty("merge_request_title", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestTitle { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求状态(noteable_type&#x3D;MergRequest时返回)。
        /// </summary>
        [JsonProperty("merge_request_state", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestState { get; set; }

        /// <summary>
        /// **参数解释：** commit id(noteable_type&#x3D;Commit时返回)。
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewDto {\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  note: ").Append(Note).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  isReply: ").Append(IsReply).Append("\n");
            sb.Append("  resolvedBy: ").Append(ResolvedBy).Append("\n");
            sb.Append("  discussionId: ").Append(DiscussionId).Append("\n");
            sb.Append("  repositoryPath: ").Append(RepositoryPath).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  reviewCategories: ").Append(ReviewCategories).Append("\n");
            sb.Append("  reviewCategoriesCn: ").Append(ReviewCategoriesCn).Append("\n");
            sb.Append("  reviewCategoriesEn: ").Append(ReviewCategoriesEn).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  severityCn: ").Append(SeverityCn).Append("\n");
            sb.Append("  severityEn: ").Append(SeverityEn).Append("\n");
            sb.Append("  proposer: ").Append(Proposer).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  resolved: ").Append(Resolved).Append("\n");
            sb.Append("  resolvedAt: ").Append(ResolvedAt).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("  moderationResult: ").Append(ModerationResult).Append("\n");
            sb.Append("  moderationTime: ").Append(ModerationTime).Append("\n");
            sb.Append("  moderationStatus: ").Append(ModerationStatus).Append("\n");
            sb.Append("  mergeRequestId: ").Append(MergeRequestId).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  mergeRequestTitle: ").Append(MergeRequestTitle).Append("\n");
            sb.Append("  mergeRequestState: ").Append(MergeRequestState).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewDto input)
        {
            if (input == null) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Note != input.Note || (this.Note != null && !this.Note.Equals(input.Note))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.IsReply != input.IsReply || (this.IsReply != null && !this.IsReply.Equals(input.IsReply))) return false;
            if (this.ResolvedBy != input.ResolvedBy || (this.ResolvedBy != null && !this.ResolvedBy.Equals(input.ResolvedBy))) return false;
            if (this.DiscussionId != input.DiscussionId || (this.DiscussionId != null && !this.DiscussionId.Equals(input.DiscussionId))) return false;
            if (this.RepositoryPath != input.RepositoryPath || (this.RepositoryPath != null && !this.RepositoryPath.Equals(input.RepositoryPath))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.ReviewCategories != input.ReviewCategories || (this.ReviewCategories != null && !this.ReviewCategories.Equals(input.ReviewCategories))) return false;
            if (this.ReviewCategoriesCn != input.ReviewCategoriesCn || (this.ReviewCategoriesCn != null && !this.ReviewCategoriesCn.Equals(input.ReviewCategoriesCn))) return false;
            if (this.ReviewCategoriesEn != input.ReviewCategoriesEn || (this.ReviewCategoriesEn != null && !this.ReviewCategoriesEn.Equals(input.ReviewCategoriesEn))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && !this.ReviewModules.Equals(input.ReviewModules))) return false;
            if (this.Severity != input.Severity) return false;
            if (this.SeverityCn != input.SeverityCn || (this.SeverityCn != null && !this.SeverityCn.Equals(input.SeverityCn))) return false;
            if (this.SeverityEn != input.SeverityEn) return false;
            if (this.Proposer != input.Proposer || (this.Proposer != null && !this.Proposer.Equals(input.Proposer))) return false;
            if (this.Reviewer != input.Reviewer || (this.Reviewer != null && !this.Reviewer.Equals(input.Reviewer))) return false;
            if (this.Resolved != input.Resolved || (this.Resolved != null && !this.Resolved.Equals(input.Resolved))) return false;
            if (this.ResolvedAt != input.ResolvedAt || (this.ResolvedAt != null && !this.ResolvedAt.Equals(input.ResolvedAt))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;
            if (this.ModerationResult != input.ModerationResult || (this.ModerationResult != null && !this.ModerationResult.Equals(input.ModerationResult))) return false;
            if (this.ModerationTime != input.ModerationTime || (this.ModerationTime != null && !this.ModerationTime.Equals(input.ModerationTime))) return false;
            if (this.ModerationStatus != input.ModerationStatus || (this.ModerationStatus != null && !this.ModerationStatus.Equals(input.ModerationStatus))) return false;
            if (this.MergeRequestId != input.MergeRequestId || (this.MergeRequestId != null && !this.MergeRequestId.Equals(input.MergeRequestId))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.MergeRequestTitle != input.MergeRequestTitle || (this.MergeRequestTitle != null && !this.MergeRequestTitle.Equals(input.MergeRequestTitle))) return false;
            if (this.MergeRequestState != input.MergeRequestState || (this.MergeRequestState != null && !this.MergeRequestState.Equals(input.MergeRequestState))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;

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
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Note != null) hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.IsReply != null) hashCode = hashCode * 59 + this.IsReply.GetHashCode();
                if (this.ResolvedBy != null) hashCode = hashCode * 59 + this.ResolvedBy.GetHashCode();
                if (this.DiscussionId != null) hashCode = hashCode * 59 + this.DiscussionId.GetHashCode();
                if (this.RepositoryPath != null) hashCode = hashCode * 59 + this.RepositoryPath.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.ReviewCategories != null) hashCode = hashCode * 59 + this.ReviewCategories.GetHashCode();
                if (this.ReviewCategoriesCn != null) hashCode = hashCode * 59 + this.ReviewCategoriesCn.GetHashCode();
                if (this.ReviewCategoriesEn != null) hashCode = hashCode * 59 + this.ReviewCategoriesEn.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SeverityCn != null) hashCode = hashCode * 59 + this.SeverityCn.GetHashCode();
                hashCode = hashCode * 59 + this.SeverityEn.GetHashCode();
                if (this.Proposer != null) hashCode = hashCode * 59 + this.Proposer.GetHashCode();
                if (this.Reviewer != null) hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Resolved != null) hashCode = hashCode * 59 + this.Resolved.GetHashCode();
                if (this.ResolvedAt != null) hashCode = hashCode * 59 + this.ResolvedAt.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                if (this.ModerationTime != null) hashCode = hashCode * 59 + this.ModerationTime.GetHashCode();
                if (this.ModerationStatus != null) hashCode = hashCode * 59 + this.ModerationStatus.GetHashCode();
                if (this.MergeRequestId != null) hashCode = hashCode * 59 + this.MergeRequestId.GetHashCode();
                if (this.MergeRequestIid != null) hashCode = hashCode * 59 + this.MergeRequestIid.GetHashCode();
                if (this.MergeRequestTitle != null) hashCode = hashCode * 59 + this.MergeRequestTitle.GetHashCode();
                if (this.MergeRequestState != null) hashCode = hashCode * 59 + this.MergeRequestState.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
