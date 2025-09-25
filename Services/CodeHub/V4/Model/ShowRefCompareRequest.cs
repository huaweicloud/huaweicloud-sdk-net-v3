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
    /// Request Object
    /// </summary>
    public class ShowRefCompareRequest 
    {
        /// <summary>
        /// **参数解释：** 对比类型。 **取值范围：** - branch，分支。 - commit，提交。 - tag，标签。
        /// </summary>
        /// <value>**参数解释：** 对比类型。 **取值范围：** - branch，分支。 - commit，提交。 - tag，标签。</value>
        [JsonConverter(typeof(EnumClassConverter<CompareTypeEnum>))]
        public class CompareTypeEnum
        {
            /// <summary>
            /// Enum BRANCH for value: branch
            /// </summary>
            public static readonly CompareTypeEnum BRANCH = new CompareTypeEnum("branch");

            /// <summary>
            /// Enum COMMIT for value: commit
            /// </summary>
            public static readonly CompareTypeEnum COMMIT = new CompareTypeEnum("commit");

            /// <summary>
            /// Enum TAG for value: tag
            /// </summary>
            public static readonly CompareTypeEnum TAG = new CompareTypeEnum("tag");

            private static readonly Dictionary<string, CompareTypeEnum> StaticFields =
            new Dictionary<string, CompareTypeEnum>()
            {
                { "branch", BRANCH },
                { "commit", COMMIT },
                { "tag", TAG },
            };

            private string _value;

            public CompareTypeEnum()
            {

            }

            public CompareTypeEnum(string value)
            {
                _value = value;
            }

            public static CompareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CompareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareTypeEnum a, CompareTypeEnum b)
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

            public static bool operator !=(CompareTypeEnum a, CompareTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 是否忽略空白数量更改。 **取值范围：** - count，数量。 - commits，提交信息。 - diffs，差异信息。 - files，文件信息。 - commits,diffs，提交信息和差异信息。
        /// </summary>
        /// <value>**参数解释：** 是否忽略空白数量更改。 **取值范围：** - count，数量。 - commits，提交信息。 - diffs，差异信息。 - files，文件信息。 - commits,diffs，提交信息和差异信息。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewEnum>))]
        public class ViewEnum
        {
            /// <summary>
            /// Enum COUNT for value: count
            /// </summary>
            public static readonly ViewEnum COUNT = new ViewEnum("count");

            /// <summary>
            /// Enum COMMITS for value: commits
            /// </summary>
            public static readonly ViewEnum COMMITS = new ViewEnum("commits");

            /// <summary>
            /// Enum DIFFS for value: diffs
            /// </summary>
            public static readonly ViewEnum DIFFS = new ViewEnum("diffs");

            /// <summary>
            /// Enum FILES for value: files
            /// </summary>
            public static readonly ViewEnum FILES = new ViewEnum("files");

            /// <summary>
            /// Enum COMMITS_DIFFS for value: commits,diffs
            /// </summary>
            public static readonly ViewEnum COMMITS_DIFFS = new ViewEnum("commits,diffs");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "count", COUNT },
                { "commits", COMMITS },
                { "diffs", DIFFS },
                { "files", FILES },
                { "commits,diffs", COMMITS_DIFFS },
            };

            private string _value;

            public ViewEnum()
            {

            }

            public ViewEnum(string value)
            {
                _value = value;
            }

            public static ViewEnum FromValue(string value)
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

                if (this.Equals(obj as ViewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewEnum a, ViewEnum b)
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

            public static bool operator !=(ViewEnum a, ViewEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 根据给定的参数返回不同的结果。 **取值范围：** - change_lines，变更行数。
        /// </summary>
        /// <value>**参数解释：** 根据给定的参数返回不同的结果。 **取值范围：** - change_lines，变更行数。</value>
        [JsonConverter(typeof(EnumClassConverter<AdditionalFieldsEnum>))]
        public class AdditionalFieldsEnum
        {
            /// <summary>
            /// Enum CHANGE_LINES for value: change_lines
            /// </summary>
            public static readonly AdditionalFieldsEnum CHANGE_LINES = new AdditionalFieldsEnum("change_lines");

            private static readonly Dictionary<string, AdditionalFieldsEnum> StaticFields =
            new Dictionary<string, AdditionalFieldsEnum>()
            {
                { "change_lines", CHANGE_LINES },
            };

            private string _value;

            public AdditionalFieldsEnum()
            {

            }

            public AdditionalFieldsEnum(string value)
            {
                _value = value;
            }

            public static AdditionalFieldsEnum FromValue(string value)
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

                if (this.Equals(obj as AdditionalFieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdditionalFieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdditionalFieldsEnum a, AdditionalFieldsEnum b)
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

            public static bool operator !=(AdditionalFieldsEnum a, AdditionalFieldsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 要开始比较的分支名称、标签名称或者commitid。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public string From { get; set; }

        /// <summary>
        /// **参数解释：** 要停止比较的分支名称、标签名称或者commitid。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public string To { get; set; }

        /// <summary>
        /// **参数解释：** 对比类型。 **取值范围：** - branch，分支。 - commit，提交。 - tag，标签。
        /// </summary>
        [SDKProperty("compare_type", IsQuery = true)]
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public CompareTypeEnum CompareType { get; set; }
        /// <summary>
        /// **参数解释：** 合并请求的目标仓库，默认为仓库ID。
        /// </summary>
        [SDKProperty("target_id", IsQuery = true)]
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetId { get; set; }

        /// <summary>
        /// **参数解释：** 比较方法。 **取值范围：** - true，用于&#x60;from&#x60;和&#x60;to&#x60;之间的直接比较(&#x60;from&#x60;..&#x60;to&#x60;)。 - false，使用merge base进行比较(&#x60;from&#x60;...&#x60;to&#x60;)。
        /// </summary>
        [SDKProperty("straight", IsQuery = true)]
        [JsonProperty("straight", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Straight { get; set; }

        /// <summary>
        /// **参数解释：** 是否忽略空白数量更改。 **取值范围：** - true，忽略空白数量的更改。 - false，不会忽略空白数量的更改。
        /// </summary>
        [SDKProperty("ignore_whitespace_change", IsQuery = true)]
        [JsonProperty("ignore_whitespace_change", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreWhitespaceChange { get; set; }

        /// <summary>
        /// **参数解释：** 是否忽略空白数量更改。 **取值范围：** - count，数量。 - commits，提交信息。 - diffs，差异信息。 - files，文件信息。 - commits,diffs，提交信息和差异信息。
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// **参数解释：** 是否仅返回带有提交计数和diffs计数的结果。 **取值范围：** - true，仅返回带有提交计数和diffs计数的结果。 - false，按照compare_view参数返回结果信息。
        /// </summary>
        [SDKProperty("only_count", IsQuery = true)]
        [JsonProperty("only_count", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyCount { get; set; }

        /// <summary>
        /// **参数解释：** 根据给定的文件路径返回不同的结果。如果文件已重命名，则file_path应包括old_path和new_path，如“file_path&#x3D;old_path,new_path”。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("file_path", IsQuery = true)]
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** 根据给定的参数返回不同的结果。 **取值范围：** - change_lines，变更行数。
        /// </summary>
        [SDKProperty("additional_fields", IsQuery = true)]
        [JsonProperty("additional_fields", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalFieldsEnum AdditionalFields { get; set; }
        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRefCompareRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  straight: ").Append(Straight).Append("\n");
            sb.Append("  ignoreWhitespaceChange: ").Append(IgnoreWhitespaceChange).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  onlyCount: ").Append(OnlyCount).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  additionalFields: ").Append(AdditionalFields).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRefCompareRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRefCompareRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;
            if (this.CompareType != input.CompareType) return false;
            if (this.TargetId != input.TargetId || (this.TargetId != null && !this.TargetId.Equals(input.TargetId))) return false;
            if (this.Straight != input.Straight || (this.Straight != null && !this.Straight.Equals(input.Straight))) return false;
            if (this.IgnoreWhitespaceChange != input.IgnoreWhitespaceChange || (this.IgnoreWhitespaceChange != null && !this.IgnoreWhitespaceChange.Equals(input.IgnoreWhitespaceChange))) return false;
            if (this.View != input.View) return false;
            if (this.OnlyCount != input.OnlyCount || (this.OnlyCount != null && !this.OnlyCount.Equals(input.OnlyCount))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.AdditionalFields != input.AdditionalFields) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.TargetId != null) hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.Straight != null) hashCode = hashCode * 59 + this.Straight.GetHashCode();
                if (this.IgnoreWhitespaceChange != null) hashCode = hashCode * 59 + this.IgnoreWhitespaceChange.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.OnlyCount != null) hashCode = hashCode * 59 + this.OnlyCount.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionalFields.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
