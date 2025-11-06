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
    public class RepositoryImportRecordDto 
    {
        /// <summary>
        /// **参数解释：** 规则名称。 **约束限制：** 不涉及。 **取值范围：** - finished, 导入成功 - fail, 导入失败 - importing, 导入中 **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 规则名称。 **约束限制：** 不涉及。 **取值范围：** - finished, 导入成功 - fail, 导入失败 - importing, 导入中 **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum FINISHED_ for value: finished, 导入成功
            /// </summary>
            public static readonly StateEnum FINISHED_ = new StateEnum("finished, 导入成功");

            /// <summary>
            /// Enum FAIL_ for value: fail, 导入失败
            /// </summary>
            public static readonly StateEnum FAIL_ = new StateEnum("fail, 导入失败");

            /// <summary>
            /// Enum IMPORTING_ for value: importing, 导入中
            /// </summary>
            public static readonly StateEnum IMPORTING_ = new StateEnum("importing, 导入中");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "finished, 导入成功", FINISHED_ },
                { "fail, 导入失败", FAIL_ },
                { "importing, 导入中", IMPORTING_ },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 导入来源。 **取值范围：** - gitee - self_managed_gitlab - gitlab - github - git - svn - coding - bitbucket - gerrit - codeup
        /// </summary>
        /// <value>**参数解释：** 导入来源。 **取值范围：** - gitee - self_managed_gitlab - gitlab - github - git - svn - coding - bitbucket - gerrit - codeup</value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum GITEE for value: gitee
            /// </summary>
            public static readonly SourceTypeEnum GITEE = new SourceTypeEnum("gitee");

            /// <summary>
            /// Enum SELF_MANAGED_GITLAB for value: self_managed_gitlab
            /// </summary>
            public static readonly SourceTypeEnum SELF_MANAGED_GITLAB = new SourceTypeEnum("self_managed_gitlab");

            /// <summary>
            /// Enum GITLAB for value: gitlab
            /// </summary>
            public static readonly SourceTypeEnum GITLAB = new SourceTypeEnum("gitlab");

            /// <summary>
            /// Enum GITHUB for value: github
            /// </summary>
            public static readonly SourceTypeEnum GITHUB = new SourceTypeEnum("github");

            /// <summary>
            /// Enum GIT for value: git
            /// </summary>
            public static readonly SourceTypeEnum GIT = new SourceTypeEnum("git");

            /// <summary>
            /// Enum SVN for value: svn
            /// </summary>
            public static readonly SourceTypeEnum SVN = new SourceTypeEnum("svn");

            /// <summary>
            /// Enum CODING for value: coding
            /// </summary>
            public static readonly SourceTypeEnum CODING = new SourceTypeEnum("coding");

            /// <summary>
            /// Enum BITBUCKET for value: bitbucket
            /// </summary>
            public static readonly SourceTypeEnum BITBUCKET = new SourceTypeEnum("bitbucket");

            /// <summary>
            /// Enum GERRIT for value: gerrit
            /// </summary>
            public static readonly SourceTypeEnum GERRIT = new SourceTypeEnum("gerrit");

            /// <summary>
            /// Enum CODEUP for value: codeup
            /// </summary>
            public static readonly SourceTypeEnum CODEUP = new SourceTypeEnum("codeup");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "gitee", GITEE },
                { "self_managed_gitlab", SELF_MANAGED_GITLAB },
                { "gitlab", GITLAB },
                { "github", GITHUB },
                { "git", GIT },
                { "svn", SVN },
                { "coding", CODING },
                { "bitbucket", BITBUCKET },
                { "gerrit", GERRIT },
                { "codeup", CODEUP },
            };

            private string _value;

            public SourceTypeEnum()
            {

            }

            public SourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 主键ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 规则名称。 **约束限制：** 不涉及。 **取值范围：** - finished, 导入成功 - fail, 导入失败 - importing, 导入中 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public RepositorySimpleDto Repository { get; set; }

        /// <summary>
        /// **参数解释：** 源仓库路径。
        /// </summary>
        [JsonProperty("origin_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginFullName { get; set; }

        /// <summary>
        /// **参数解释：** 源仓库地址。
        /// </summary>
        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// **参数解释：** 导入来源。 **取值范围：** - gitee - self_managed_gitlab - gitlab - github - git - svn - coding - bitbucket - gerrit - codeup
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// **参数解释：** 导入时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 导入完成时间。
        /// </summary>
        [JsonProperty("finished_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// **参数解释：** 源仓库容量。
        /// </summary>
        [JsonProperty("repository_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? RepositorySize { get; set; }

        /// <summary>
        /// **参数解释：** 失败原因。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// **参数解释：** 仓库路径。
        /// </summary>
        [JsonProperty("target_full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetFullName { get; set; }

        /// <summary>
        /// **参数解释：** 项目ID。
        /// </summary>
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryImportRecordDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  repository: ").Append(Repository).Append("\n");
            sb.Append("  originFullName: ").Append(OriginFullName).Append("\n");
            sb.Append("  sourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  finishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  repositorySize: ").Append(RepositorySize).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  targetFullName: ").Append(TargetFullName).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryImportRecordDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryImportRecordDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.State != input.State) return false;
            if (this.Repository != input.Repository || (this.Repository != null && !this.Repository.Equals(input.Repository))) return false;
            if (this.OriginFullName != input.OriginFullName || (this.OriginFullName != null && !this.OriginFullName.Equals(input.OriginFullName))) return false;
            if (this.SourceUrl != input.SourceUrl || (this.SourceUrl != null && !this.SourceUrl.Equals(input.SourceUrl))) return false;
            if (this.SourceType != input.SourceType) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.FinishedAt != input.FinishedAt || (this.FinishedAt != null && !this.FinishedAt.Equals(input.FinishedAt))) return false;
            if (this.RepositorySize != input.RepositorySize || (this.RepositorySize != null && !this.RepositorySize.Equals(input.RepositorySize))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.TargetFullName != input.TargetFullName || (this.TargetFullName != null && !this.TargetFullName.Equals(input.TargetFullName))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;

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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Repository != null) hashCode = hashCode * 59 + this.Repository.GetHashCode();
                if (this.OriginFullName != null) hashCode = hashCode * 59 + this.OriginFullName.GetHashCode();
                if (this.SourceUrl != null) hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.FinishedAt != null) hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.RepositorySize != null) hashCode = hashCode * 59 + this.RepositorySize.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.TargetFullName != null) hashCode = hashCode * 59 + this.TargetFullName.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
