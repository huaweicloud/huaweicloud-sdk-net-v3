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
    /// Response Object
    /// </summary>
    public class UpdateMergeRequestDiscussionInfoResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 意见类型。 **取值范围：** - MergeRequest: 合并请求下提的检视意见。 - Commit: 代码页或提交记录下提的检视意见。
        /// </summary>
        /// <value>**参数解释：** 意见类型。 **取值范围：** - MergeRequest: 合并请求下提的检视意见。 - Commit: 代码页或提交记录下提的检视意见。</value>
        [JsonConverter(typeof(EnumClassConverter<NoteableTypeEnum>))]
        public class NoteableTypeEnum
        {
            /// <summary>
            /// Enum MERGEREQUEST for value: MergeRequest
            /// </summary>
            public static readonly NoteableTypeEnum MERGEREQUEST = new NoteableTypeEnum("MergeRequest");

            /// <summary>
            /// Enum COMMIT for value: Commit
            /// </summary>
            public static readonly NoteableTypeEnum COMMIT = new NoteableTypeEnum("Commit");

            private static readonly Dictionary<string, NoteableTypeEnum> StaticFields =
            new Dictionary<string, NoteableTypeEnum>()
            {
                { "MergeRequest", MERGEREQUEST },
                { "Commit", COMMIT },
            };

            private string _value;

            public NoteableTypeEnum()
            {

            }

            public NoteableTypeEnum(string value)
            {
                _value = value;
            }

            public static NoteableTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NoteableTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NoteableTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NoteableTypeEnum a, NoteableTypeEnum b)
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

            public static bool operator !=(NoteableTypeEnum a, NoteableTypeEnum b)
            {
                return !(a == b);
            }
        }

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
        /// **参数解释：** 评论id(主评论和回复不共用)。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 评论类型。 **取值范围：** - DiscussionNote: 需要解决的关联代码行的评论。 - DiffNote: 一般。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 评论内容。
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// **参数解释：** 附件(弃用)。
        /// </summary>
        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public string Attachment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Author { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 是否为系统添加的。
        /// </summary>
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? System { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求id或issue id。
        /// </summary>
        [JsonProperty("noteable_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NoteableId { get; set; }

        /// <summary>
        /// **参数解释：** 意见类型。 **取值范围：** - MergeRequest: 合并请求下提的检视意见。 - Commit: 代码页或提交记录下提的检视意见。
        /// </summary>
        [JsonProperty("noteable_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteableTypeEnum NoteableType { get; set; }
        /// <summary>
        /// **参数解释：** 提交记录id。
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// **参数解释：** 是否需要解决。
        /// </summary>
        [JsonProperty("resolvable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolvable { get; set; }

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
        /// **参数解释：** 合并请求iid或issue iid。
        /// </summary>
        [JsonProperty("noteable_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? NoteableIid { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见id(主评论和回复共用)。
        /// </summary>
        [JsonProperty("discussion_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscussionId { get; set; }

        /// <summary>
        /// **参数解释：** 仓库路径。
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public string Repository { get; set; }

        /// <summary>
        /// **参数解释：** 关联代码行所在文件的文件名。
        /// </summary>
        [JsonProperty("diff_file", NullValueHandling = NullValueHandling.Ignore)]
        public string DiffFile { get; set; }

        /// <summary>
        /// **参数解释：** 关联代码行的代码片段。
        /// </summary>
        [JsonProperty("diff", NullValueHandling = NullValueHandling.Ignore)]
        public string Diff { get; set; }

        /// <summary>
        /// **参数解释：** 是否已归档。
        /// </summary>
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类key。
        /// </summary>
        [JsonProperty("review_categories", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategories { get; set; }

        /// <summary>
        /// **参数解释：** 意见分类中文名。
        /// </summary>
        [JsonProperty("review_categories_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategoriesCn { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求版本信息。
        /// </summary>
        [JsonProperty("review_categories_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategoriesEn { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求版本信息。
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
        /// **参数解释：** 文件路径(弃用)。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** 行号(弃用)。
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public string Line { get; set; }

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
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public PositionDto Position { get; set; }

        /// <summary>
        /// **参数解释：** 是否已解决。
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolved { get; set; }

        /// <summary>
        /// **参数解释：** 是否已过期。
        /// </summary>
        [JsonProperty("is_outdated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOutdated { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMergeRequestDiscussionInfoResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  attachment: ").Append(Attachment).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  system: ").Append(System).Append("\n");
            sb.Append("  noteableId: ").Append(NoteableId).Append("\n");
            sb.Append("  noteableType: ").Append(NoteableType).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  resolvable: ").Append(Resolvable).Append("\n");
            sb.Append("  isReply: ").Append(IsReply).Append("\n");
            sb.Append("  resolvedBy: ").Append(ResolvedBy).Append("\n");
            sb.Append("  noteableIid: ").Append(NoteableIid).Append("\n");
            sb.Append("  discussionId: ").Append(DiscussionId).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  diffFile: ").Append(DiffFile).Append("\n");
            sb.Append("  diff: ").Append(Diff).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  reviewCategories: ").Append(ReviewCategories).Append("\n");
            sb.Append("  reviewCategoriesCn: ").Append(ReviewCategoriesCn).Append("\n");
            sb.Append("  reviewCategoriesEn: ").Append(ReviewCategoriesEn).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  severityCn: ").Append(SeverityCn).Append("\n");
            sb.Append("  severityEn: ").Append(SeverityEn).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  line: ").Append(Line).Append("\n");
            sb.Append("  assignee: ").Append(Assignee).Append("\n");
            sb.Append("  proposer: ").Append(Proposer).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  resolved: ").Append(Resolved).Append("\n");
            sb.Append("  isOutdated: ").Append(IsOutdated).Append("\n");
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
            return this.Equals(input as UpdateMergeRequestDiscussionInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMergeRequestDiscussionInfoResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;
            if (this.Attachment != input.Attachment || (this.Attachment != null && !this.Attachment.Equals(input.Attachment))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.System != input.System || (this.System != null && !this.System.Equals(input.System))) return false;
            if (this.NoteableId != input.NoteableId || (this.NoteableId != null && !this.NoteableId.Equals(input.NoteableId))) return false;
            if (this.NoteableType != input.NoteableType) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.Resolvable != input.Resolvable || (this.Resolvable != null && !this.Resolvable.Equals(input.Resolvable))) return false;
            if (this.IsReply != input.IsReply || (this.IsReply != null && !this.IsReply.Equals(input.IsReply))) return false;
            if (this.ResolvedBy != input.ResolvedBy || (this.ResolvedBy != null && !this.ResolvedBy.Equals(input.ResolvedBy))) return false;
            if (this.NoteableIid != input.NoteableIid || (this.NoteableIid != null && !this.NoteableIid.Equals(input.NoteableIid))) return false;
            if (this.DiscussionId != input.DiscussionId || (this.DiscussionId != null && !this.DiscussionId.Equals(input.DiscussionId))) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;
            if (this.DiffFile != input.DiffFile || (this.DiffFile != null && !this.DiffFile.Equals(input.DiffFile))) return false;
            if (this.Diff != input.Diff || (this.Diff != null && !this.Diff.Equals(input.Diff))) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.ReviewCategories != input.ReviewCategories || (this.ReviewCategories != null && !this.ReviewCategories.Equals(input.ReviewCategories))) return false;
            if (this.ReviewCategoriesCn != input.ReviewCategoriesCn || (this.ReviewCategoriesCn != null && !this.ReviewCategoriesCn.Equals(input.ReviewCategoriesCn))) return false;
            if (this.ReviewCategoriesEn != input.ReviewCategoriesEn || (this.ReviewCategoriesEn != null && !this.ReviewCategoriesEn.Equals(input.ReviewCategoriesEn))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && !this.ReviewModules.Equals(input.ReviewModules))) return false;
            if (this.Severity != input.Severity) return false;
            if (this.SeverityCn != input.SeverityCn || (this.SeverityCn != null && !this.SeverityCn.Equals(input.SeverityCn))) return false;
            if (this.SeverityEn != input.SeverityEn) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.Line != input.Line || (this.Line != null && !this.Line.Equals(input.Line))) return false;
            if (this.Assignee != input.Assignee || (this.Assignee != null && !this.Assignee.Equals(input.Assignee))) return false;
            if (this.Proposer != input.Proposer || (this.Proposer != null && !this.Proposer.Equals(input.Proposer))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.Resolved != input.Resolved || (this.Resolved != null && !this.Resolved.Equals(input.Resolved))) return false;
            if (this.IsOutdated != input.IsOutdated || (this.IsOutdated != null && !this.IsOutdated.Equals(input.IsOutdated))) return false;
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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Attachment != null) hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.System != null) hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.NoteableId != null) hashCode = hashCode * 59 + this.NoteableId.GetHashCode();
                hashCode = hashCode * 59 + this.NoteableType.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.Resolvable != null) hashCode = hashCode * 59 + this.Resolvable.GetHashCode();
                if (this.IsReply != null) hashCode = hashCode * 59 + this.IsReply.GetHashCode();
                if (this.ResolvedBy != null) hashCode = hashCode * 59 + this.ResolvedBy.GetHashCode();
                if (this.NoteableIid != null) hashCode = hashCode * 59 + this.NoteableIid.GetHashCode();
                if (this.DiscussionId != null) hashCode = hashCode * 59 + this.DiscussionId.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.DiffFile != null) hashCode = hashCode * 59 + this.DiffFile.GetHashCode();
                if (this.Diff != null) hashCode = hashCode * 59 + this.Diff.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.ReviewCategories != null) hashCode = hashCode * 59 + this.ReviewCategories.GetHashCode();
                if (this.ReviewCategoriesCn != null) hashCode = hashCode * 59 + this.ReviewCategoriesCn.GetHashCode();
                if (this.ReviewCategoriesEn != null) hashCode = hashCode * 59 + this.ReviewCategoriesEn.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SeverityCn != null) hashCode = hashCode * 59 + this.SeverityCn.GetHashCode();
                hashCode = hashCode * 59 + this.SeverityEn.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Line != null) hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Proposer != null) hashCode = hashCode * 59 + this.Proposer.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Resolved != null) hashCode = hashCode * 59 + this.Resolved.GetHashCode();
                if (this.IsOutdated != null) hashCode = hashCode * 59 + this.IsOutdated.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                if (this.ModerationTime != null) hashCode = hashCode * 59 + this.ModerationTime.GetHashCode();
                if (this.ModerationStatus != null) hashCode = hashCode * 59 + this.ModerationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
