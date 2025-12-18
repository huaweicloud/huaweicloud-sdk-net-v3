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
    public class ListBranchesRequest 
    {
        /// <summary>
        /// **参数解释：** 分支类型，默认返回全部分支，not_protect，返回非保护分支。 **约束限制：** 不涉及。 **取值范围：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 分支类型，默认返回全部分支，not_protect，返回非保护分支。 **约束限制：** 不涉及。 **取值范围：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<BranchTypeEnum>))]
        public class BranchTypeEnum
        {
            /// <summary>
            /// Enum NOT_PROTECT for value: not_protect
            /// </summary>
            public static readonly BranchTypeEnum NOT_PROTECT = new BranchTypeEnum("not_protect");

            private static readonly Dictionary<string, BranchTypeEnum> StaticFields =
            new Dictionary<string, BranchTypeEnum>()
            {
                { "not_protect", NOT_PROTECT },
            };

            private string _value;

            public BranchTypeEnum()
            {

            }

            public BranchTypeEnum(string value)
            {
                _value = value;
            }

            public static BranchTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BranchTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BranchTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BranchTypeEnum a, BranchTypeEnum b)
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

            public static bool operator !=(BranchTypeEnum a, BranchTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 排序方式 **约束限制：** - name，分支名倒序。 - updated_desc，更新时间倒序。 - updated_asc，更新时间正序。
        /// </summary>
        /// <value>**参数解释：** 排序方式 **约束限制：** - name，分支名倒序。 - updated_desc，更新时间倒序。 - updated_asc，更新时间正序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortEnum>))]
        public class SortEnum
        {
            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly SortEnum NAME = new SortEnum("name");

            /// <summary>
            /// Enum UPDATED_DESC for value: updated_desc
            /// </summary>
            public static readonly SortEnum UPDATED_DESC = new SortEnum("updated_desc");

            /// <summary>
            /// Enum UPDATED_ASC for value: updated_asc
            /// </summary>
            public static readonly SortEnum UPDATED_ASC = new SortEnum("updated_asc");

            private static readonly Dictionary<string, SortEnum> StaticFields =
            new Dictionary<string, SortEnum>()
            {
                { "name", NAME },
                { "updated_desc", UPDATED_DESC },
                { "updated_asc", UPDATED_ASC },
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
        /// **参数解释：** 分支类型 **约束限制：** - my_branches，个人分支。 - active，活跃分支。 - stale，过时分支。 - all_branches，所有分支。
        /// </summary>
        /// <value>**参数解释：** 分支类型 **约束限制：** - my_branches，个人分支。 - active，活跃分支。 - stale，过时分支。 - all_branches，所有分支。</value>
        [JsonConverter(typeof(EnumClassConverter<QueryViewEnum>))]
        public class QueryViewEnum
        {
            /// <summary>
            /// Enum MY_BRANCHES for value: my_branches
            /// </summary>
            public static readonly QueryViewEnum MY_BRANCHES = new QueryViewEnum("my_branches");

            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly QueryViewEnum ACTIVE = new QueryViewEnum("active");

            /// <summary>
            /// Enum STALE for value: stale
            /// </summary>
            public static readonly QueryViewEnum STALE = new QueryViewEnum("stale");

            /// <summary>
            /// Enum ALL_BRANCHES for value: all_branches
            /// </summary>
            public static readonly QueryViewEnum ALL_BRANCHES = new QueryViewEnum("all_branches");

            private static readonly Dictionary<string, QueryViewEnum> StaticFields =
            new Dictionary<string, QueryViewEnum>()
            {
                { "my_branches", MY_BRANCHES },
                { "active", ACTIVE },
                { "stale", STALE },
                { "all_branches", ALL_BRANCHES },
            };

            private string _value;

            public QueryViewEnum()
            {

            }

            public QueryViewEnum(string value)
            {
                _value = value;
            }

            public static QueryViewEnum FromValue(string value)
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

                if (this.Equals(obj as QueryViewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QueryViewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QueryViewEnum a, QueryViewEnum b)
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

            public static bool operator !=(QueryViewEnum a, QueryViewEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 结果集属性，根据给定的参数返回不同的结果 **约束限制：** - all，返回分支的所有信息。 - basic，返回分支的基本信息。 - simple，返回分支的简单信息。
        /// </summary>
        /// <value>**参数解释：** 结果集属性，根据给定的参数返回不同的结果 **约束限制：** - all，返回分支的所有信息。 - basic，返回分支的基本信息。 - simple，返回分支的简单信息。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewEnum>))]
        public class ViewEnum
        {
            /// <summary>
            /// Enum SIMPLE for value: simple
            /// </summary>
            public static readonly ViewEnum SIMPLE = new ViewEnum("simple");

            /// <summary>
            /// Enum BASIC for value: basic
            /// </summary>
            public static readonly ViewEnum BASIC = new ViewEnum("basic");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ViewEnum ALL = new ViewEnum("all");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "simple", SIMPLE },
                { "basic", BASIC },
                { "all", ALL },
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
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[[查询用户所有仓库](https://support.huaweicloud.com/eu/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_eu)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 分支类型，默认返回全部分支，not_protect，返回非保护分支。 **约束限制：** 不涉及。 **取值范围：** 不涉及。
        /// </summary>
        [SDKProperty("branch_type", IsQuery = true)]
        [JsonProperty("branch_type", NullValueHandling = NullValueHandling.Ignore)]
        public BranchTypeEnum BranchType { get; set; }
        /// <summary>
        /// **参数解释：** 创建者，用户ID或者IamId。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("creator", IsQuery = true)]
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释：** 排序方式 **约束限制：** - name，分支名倒序。 - updated_desc，更新时间倒序。 - updated_asc，更新时间正序。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 分支类型 **约束限制：** - my_branches，个人分支。 - active，活跃分支。 - stale，过时分支。 - all_branches，所有分支。
        /// </summary>
        [SDKProperty("query_view", IsQuery = true)]
        [JsonProperty("query_view", NullValueHandling = NullValueHandling.Ignore)]
        public QueryViewEnum QueryView { get; set; }
        /// <summary>
        /// **参数解释：** 结果集属性，根据给定的参数返回不同的结果 **约束限制：** - all，返回分支的所有信息。 - basic，返回分支的基本信息。 - simple，返回分支的简单信息。
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
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
            sb.Append("class ListBranchesRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  branchType: ").Append(BranchType).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  queryView: ").Append(QueryView).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
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
            return this.Equals(input as ListBranchesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBranchesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.BranchType != input.BranchType) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Sort != input.Sort) return false;
            if (this.QueryView != input.QueryView) return false;
            if (this.View != input.View) return false;
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
                hashCode = hashCode * 59 + this.BranchType.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                hashCode = hashCode * 59 + this.QueryView.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
