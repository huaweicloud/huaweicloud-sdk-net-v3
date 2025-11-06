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
    /// Request Object
    /// </summary>
    public class ListPersonalRepositoryImportRecordsRequest 
    {
        /// <summary>
        /// **参数解释：** 状态 **取值范围：** - finished, 导入成功 - fail, 导入失败 - importing, 导入中
        /// </summary>
        /// <value>**参数解释：** 状态 **取值范围：** - finished, 导入成功 - fail, 导入失败 - importing, 导入中</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum FINISHED for value: finished
            /// </summary>
            public static readonly StateEnum FINISHED = new StateEnum("finished");

            /// <summary>
            /// Enum FAIL for value: fail
            /// </summary>
            public static readonly StateEnum FAIL = new StateEnum("fail");

            /// <summary>
            /// Enum IMPORTING for value: importing
            /// </summary>
            public static readonly StateEnum IMPORTING = new StateEnum("importing");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "finished", FINISHED },
                { "fail", FAIL },
                { "importing", IMPORTING },
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
        /// **参数解释：** 导入来源 **取值范围：** - gitee - self_managed_gitlab - gitlab - github - git - svn - coding - bitbucket - gerrit - codeup
        /// </summary>
        /// <value>**参数解释：** 导入来源 **取值范围：** - gitee - self_managed_gitlab - gitlab - github - git - svn - coding - bitbucket - gerrit - codeup</value>
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
        /// **参数解释：** 排序方式。 **取值范围：** - created_at, 导入时间 - source_repo_name, 源仓库路径 - size, 源仓库容量
        /// </summary>
        /// <value>**参数解释：** 排序方式。 **取值范围：** - created_at, 导入时间 - source_repo_name, 源仓库路径 - size, 源仓库容量</value>
        [JsonConverter(typeof(EnumClassConverter<OrderByEnum>))]
        public class OrderByEnum
        {
            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly OrderByEnum CREATED_AT = new OrderByEnum("created_at");

            /// <summary>
            /// Enum SOURCE_REPO_NAME for value: source_repo_name
            /// </summary>
            public static readonly OrderByEnum SOURCE_REPO_NAME = new OrderByEnum("source_repo_name");

            /// <summary>
            /// Enum SIZE for value: size
            /// </summary>
            public static readonly OrderByEnum SIZE = new OrderByEnum("size");

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "created_at", CREATED_AT },
                { "source_repo_name", SOURCE_REPO_NAME },
                { "size", SIZE },
            };

            private string _value;

            public OrderByEnum()
            {

            }

            public OrderByEnum(string value)
            {
                _value = value;
            }

            public static OrderByEnum FromValue(string value)
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

                if (this.Equals(obj as OrderByEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderByEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderByEnum a, OrderByEnum b)
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

            public static bool operator !=(OrderByEnum a, OrderByEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 返回排序 - asc 正序返回 - desc 倒序返回
        /// </summary>
        /// <value>**参数解释：** 返回排序 - asc 正序返回 - desc 倒序返回</value>
        [JsonConverter(typeof(EnumClassConverter<SortEnum>))]
        public class SortEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortEnum ASC = new SortEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortEnum DESC = new SortEnum("desc");

            private static readonly Dictionary<string, SortEnum> StaticFields =
            new Dictionary<string, SortEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortEnum()
            {

            }

            public SortEnum(string value)
            {
                _value = value;
            }

            public static SortEnum FromValue(string value)
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

                if (this.Equals(obj as SortEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortEnum a, SortEnum b)
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

            public static bool operator !=(SortEnum a, SortEnum b)
            {
                return !(a == b);
            }
        }


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
        /// **参数解释：** 状态 **取值范围：** - finished, 导入成功 - fail, 导入失败 - importing, 导入中
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// **参数解释：** 导入来源 **取值范围：** - gitee - self_managed_gitlab - gitlab - github - git - svn - coding - bitbucket - gerrit - codeup
        /// </summary>
        [SDKProperty("source_type", IsQuery = true)]
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// **参数解释：** 筛选在该时间之后导入的
        /// </summary>
        [SDKProperty("created_after", IsQuery = true)]
        [JsonProperty("created_after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// **参数解释：** 筛选在该时间之前导入的
        /// </summary>
        [SDKProperty("created_before", IsQuery = true)]
        [JsonProperty("created_before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// **参数解释：** 筛选在该时间之后导入完成的
        /// </summary>
        [SDKProperty("finished_after", IsQuery = true)]
        [JsonProperty("finished_after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FinishedAfter { get; set; }

        /// <summary>
        /// **参数解释：** 筛选在该时间之前导入完成的
        /// </summary>
        [SDKProperty("finished_before", IsQuery = true)]
        [JsonProperty("finished_before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FinishedBefore { get; set; }

        /// <summary>
        /// **参数解释：** 搜索仓库
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 排序方式。 **取值范围：** - created_at, 导入时间 - source_repo_name, 源仓库路径 - size, 源仓库容量
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释：** 返回排序 - asc 正序返回 - desc 倒序返回
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPersonalRepositoryImportRecordsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  createdAfter: ").Append(CreatedAfter).Append("\n");
            sb.Append("  createdBefore: ").Append(CreatedBefore).Append("\n");
            sb.Append("  finishedAfter: ").Append(FinishedAfter).Append("\n");
            sb.Append("  finishedBefore: ").Append(FinishedBefore).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPersonalRepositoryImportRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPersonalRepositoryImportRecordsRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.State != input.State) return false;
            if (this.SourceType != input.SourceType) return false;
            if (this.CreatedAfter != input.CreatedAfter || (this.CreatedAfter != null && !this.CreatedAfter.Equals(input.CreatedAfter))) return false;
            if (this.CreatedBefore != input.CreatedBefore || (this.CreatedBefore != null && !this.CreatedBefore.Equals(input.CreatedBefore))) return false;
            if (this.FinishedAfter != input.FinishedAfter || (this.FinishedAfter != null && !this.FinishedAfter.Equals(input.FinishedAfter))) return false;
            if (this.FinishedBefore != input.FinishedBefore || (this.FinishedBefore != null && !this.FinishedBefore.Equals(input.FinishedBefore))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.OrderBy != input.OrderBy) return false;
            if (this.Sort != input.Sort) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.CreatedAfter != null) hashCode = hashCode * 59 + this.CreatedAfter.GetHashCode();
                if (this.CreatedBefore != null) hashCode = hashCode * 59 + this.CreatedBefore.GetHashCode();
                if (this.FinishedAfter != null) hashCode = hashCode * 59 + this.FinishedAfter.GetHashCode();
                if (this.FinishedBefore != null) hashCode = hashCode * 59 + this.FinishedBefore.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                return hashCode;
            }
        }
    }
}
