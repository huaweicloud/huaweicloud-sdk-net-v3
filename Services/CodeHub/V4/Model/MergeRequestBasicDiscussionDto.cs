using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 合并请求单个检视意见基础信息。
    /// </summary>
    public class MergeRequestBasicDiscussionDto 
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
        /// **参数解释：** 严重程度key。 **取值范围：** - suggestion: 建议。 - minor: 一般。 - major: 严重。 - fatal: 致命。
        /// </summary>
        /// <value>**参数解释：** 严重程度key。 **取值范围：** - suggestion: 建议。 - minor: 一般。 - major: 严重。 - fatal: 致命。</value>
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
        /// **参数解释：** 严重程度英文。 **取值范围：** - Suggestion: 建议。 - Minor: 一般。 - major: 严重。 - fatal: 致命。
        /// </summary>
        /// <value>**参数解释：** 严重程度英文。 **取值范围：** - Suggestion: 建议。 - Minor: 一般。 - major: 严重。 - fatal: 致命。</value>
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
        /// **参数解释：** 检视意见id(主评论和回复共用)。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 个人检视意见(不需要解决)。
        /// </summary>
        [JsonProperty("individual_note", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndividualNote { get; set; }

        /// <summary>
        /// **参数解释：** 评论列表(主评+回复)。
        /// </summary>
        [JsonProperty("notes", NullValueHandling = NullValueHandling.Ignore)]
        public List<NoteDto> Notes { get; set; }

        /// <summary>
        /// **参数解释：** 仓库id。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

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
        /// **参数解释：** 仓库路径。
        /// </summary>
        [JsonProperty("repository_full_path", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryFullPath { get; set; }

        /// <summary>
        /// **参数解释：** 文件旧权限(默认100644)。
        /// </summary>
        [JsonProperty("a_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AMode { get; set; }

        /// <summary>
        /// **参数解释：** 文件新权限(默认100644)。
        /// </summary>
        [JsonProperty("b_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string BMode { get; set; }

        /// <summary>
        /// **参数解释：** 是否为删除文件。
        /// </summary>
        [JsonProperty("deleted_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletedFile { get; set; }

        /// <summary>
        /// **参数解释：** 是否为新增文件。
        /// </summary>
        [JsonProperty("new_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewFile { get; set; }

        /// <summary>
        /// **参数解释：** 是否已解决。
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolved { get; set; }

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
        /// **参数解释：** 意见模块。
        /// </summary>
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewModules { get; set; }

        /// <summary>
        /// **参数解释：** 严重程度key。 **取值范围：** - suggestion: 建议。 - minor: 一般。 - major: 严重。 - fatal: 致命。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// **参数解释：** 严重程度中文。 **取值范围：** - 建议 - 一般 - 严重 - 致命
        /// </summary>
        [JsonProperty("severity_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string SeverityCn { get; set; }

        /// <summary>
        /// **参数解释：** 严重程度英文。 **取值范围：** - Suggestion: 建议。 - Minor: 一般。 - major: 严重。 - fatal: 致命。
        /// </summary>
        [JsonProperty("severity_en", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnEnum SeverityEn { get; set; }
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
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  noteableType: ").Append(NoteableType).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  repositoryFullPath: ").Append(RepositoryFullPath).Append("\n");
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
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.NoteableType != input.NoteableType) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.RepositoryFullPath != input.RepositoryFullPath || (this.RepositoryFullPath != null && !this.RepositoryFullPath.Equals(input.RepositoryFullPath))) return false;
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
            if (this.Severity != input.Severity) return false;
            if (this.SeverityCn != input.SeverityCn || (this.SeverityCn != null && !this.SeverityCn.Equals(input.SeverityCn))) return false;
            if (this.SeverityEn != input.SeverityEn) return false;
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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                hashCode = hashCode * 59 + this.NoteableType.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.RepositoryFullPath != null) hashCode = hashCode * 59 + this.RepositoryFullPath.GetHashCode();
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
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.SeverityCn != null) hashCode = hashCode * 59 + this.SeverityCn.GetHashCode();
                hashCode = hashCode * 59 + this.SeverityEn.GetHashCode();
                if (this.Assignee != null) hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Proposer != null) hashCode = hashCode * 59 + this.Proposer.GetHashCode();
                if (this.MergeRequestVersionParams != null) hashCode = hashCode * 59 + this.MergeRequestVersionParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
