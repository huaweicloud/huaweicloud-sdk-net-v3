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
    public class ListPersonalMergeRequestsRequest 
    {
        /// <summary>
        /// **参数解释：** 合并请求状态 **约束限制：** - all，返回所有状态的合并请求。 - opened，返回开启中的合并请求。 - closed，返回关闭的合并请求。 - locked，返回锁定的合并请求。 - merged，返回已合并的合并请求。
        /// </summary>
        /// <value>**参数解释：** 合并请求状态 **约束限制：** - all，返回所有状态的合并请求。 - opened，返回开启中的合并请求。 - closed，返回关闭的合并请求。 - locked，返回锁定的合并请求。 - merged，返回已合并的合并请求。</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum OPENED for value: opened
            /// </summary>
            public static readonly StateEnum OPENED = new StateEnum("opened");

            /// <summary>
            /// Enum CLOSED for value: closed
            /// </summary>
            public static readonly StateEnum CLOSED = new StateEnum("closed");

            /// <summary>
            /// Enum LOCKED for value: locked
            /// </summary>
            public static readonly StateEnum LOCKED = new StateEnum("locked");

            /// <summary>
            /// Enum MERGED for value: merged
            /// </summary>
            public static readonly StateEnum MERGED = new StateEnum("merged");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly StateEnum ALL = new StateEnum("all");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "opened", OPENED },
                { "closed", CLOSED },
                { "locked", LOCKED },
                { "merged", MERGED },
                { "all", ALL },
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
        /// **参数解释：** 排序方式 **约束限制：** - created_at，根据创建时间排序。 - updated_at，根据更新时间排序。 - merged_at，根据合并时间排序。
        /// </summary>
        /// <value>**参数解释：** 排序方式 **约束限制：** - created_at，根据创建时间排序。 - updated_at，根据更新时间排序。 - merged_at，根据合并时间排序。</value>
        [JsonConverter(typeof(EnumClassConverter<OrderByEnum>))]
        public class OrderByEnum
        {
            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly OrderByEnum CREATED_AT = new OrderByEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly OrderByEnum UPDATED_AT = new OrderByEnum("updated_at");

            /// <summary>
            /// Enum MERGED_AT for value: merged_at
            /// </summary>
            public static readonly OrderByEnum MERGED_AT = new OrderByEnum("merged_at");

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
                { "merged_at", MERGED_AT },
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
        /// **参数解释：** 排序顺序 **约束限制：**   - asc，正序排序。   - desc，倒序排序。
        /// </summary>
        /// <value>**参数解释：** 排序顺序 **约束限制：**   - asc，正序排序。   - desc，倒序排序。</value>
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
        /// **参数解释：** 结果集属性，根据给定的参数返回不同的结果， simple，返回简单数据，basic返回基本数据。
        /// </summary>
        /// <value>**参数解释：** 结果集属性，根据给定的参数返回不同的结果， simple，返回简单数据，basic返回基本数据。</value>
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

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "simple", SIMPLE },
                { "basic", BASIC },
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
        /// **参数解释：**   - created_by_me 我创建的合并请求   - assigned_to_me 待我合并的合并请求   - need_my_review 待我检视的合并请求   - need_my_approve 待我审核的合并请求   - all 所有有权限访问的合并请求
        /// </summary>
        /// <value>**参数解释：**   - created_by_me 我创建的合并请求   - assigned_to_me 待我合并的合并请求   - need_my_review 待我检视的合并请求   - need_my_approve 待我审核的合并请求   - all 所有有权限访问的合并请求</value>
        [JsonConverter(typeof(EnumClassConverter<ScopeEnum>))]
        public class ScopeEnum
        {
            /// <summary>
            /// Enum CREATED_BY_ME for value: created_by_me
            /// </summary>
            public static readonly ScopeEnum CREATED_BY_ME = new ScopeEnum("created_by_me");

            /// <summary>
            /// Enum ASSIGNED_TO_ME for value: assigned_to_me
            /// </summary>
            public static readonly ScopeEnum ASSIGNED_TO_ME = new ScopeEnum("assigned_to_me");

            /// <summary>
            /// Enum NEED_MY_REVIEW for value: need_my_review
            /// </summary>
            public static readonly ScopeEnum NEED_MY_REVIEW = new ScopeEnum("need_my_review");

            /// <summary>
            /// Enum NEED_MY_APPROVE for value: need_my_approve
            /// </summary>
            public static readonly ScopeEnum NEED_MY_APPROVE = new ScopeEnum("need_my_approve");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ScopeEnum ALL = new ScopeEnum("all");

            private static readonly Dictionary<string, ScopeEnum> StaticFields =
            new Dictionary<string, ScopeEnum>()
            {
                { "created_by_me", CREATED_BY_ME },
                { "assigned_to_me", ASSIGNED_TO_ME },
                { "need_my_review", NEED_MY_REVIEW },
                { "need_my_approve", NEED_MY_APPROVE },
                { "all", ALL },
            };

            private string _value;

            public ScopeEnum()
            {

            }

            public ScopeEnum(string value)
            {
                _value = value;
            }

            public static ScopeEnum FromValue(string value)
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

                if (this.Equals(obj as ScopeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScopeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ScopeEnum a, ScopeEnum b)
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

            public static bool operator !=(ScopeEnum a, ScopeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 合并请求标题是否有WIP关键字
        /// </summary>
        /// <value>**参数解释：** 合并请求标题是否有WIP关键字</value>
        [JsonConverter(typeof(EnumClassConverter<WipEnum>))]
        public class WipEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly WipEnum TRUE = new WipEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly WipEnum FALSE = new WipEnum("false");

            private static readonly Dictionary<string, WipEnum> StaticFields =
            new Dictionary<string, WipEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public WipEnum()
            {

            }

            public WipEnum(string value)
            {
                _value = value;
            }

            public static WipEnum FromValue(string value)
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

                if (this.Equals(obj as WipEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WipEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WipEnum a, WipEnum b)
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

            public static bool operator !=(WipEnum a, WipEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 合并请求状态 **约束限制：** - all，返回所有状态的合并请求。 - opened，返回开启中的合并请求。 - closed，返回关闭的合并请求。 - locked，返回锁定的合并请求。 - merged，返回已合并的合并请求。
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// **参数解释：** 排序方式 **约束限制：** - created_at，根据创建时间排序。 - updated_at，根据更新时间排序。 - merged_at，根据合并时间排序。
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释：** 排序顺序 **约束限制：**   - asc，正序排序。   - desc，倒序排序。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 合并请求关联标签
        /// </summary>
        [SDKProperty("labels", IsQuery = true)]
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public string Labels { get; set; }

        /// <summary>
        /// **参数解释：** 指定时间前创建
        /// </summary>
        [SDKProperty("created_before", IsQuery = true)]
        [JsonProperty("created_before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// **参数解释：** 指定时间后创建
        /// </summary>
        [SDKProperty("created_after", IsQuery = true)]
        [JsonProperty("created_after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// **参数解释：** 指定时间后更新
        /// </summary>
        [SDKProperty("updated_after", IsQuery = true)]
        [JsonProperty("updated_after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAfter { get; set; }

        /// <summary>
        /// **参数解释：** 指定时间前更新
        /// </summary>
        [SDKProperty("updated_before", IsQuery = true)]
        [JsonProperty("updated_before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedBefore { get; set; }

        /// <summary>
        /// **参数解释：** 结果集属性，根据给定的参数返回不同的结果， simple，返回简单数据，basic返回基本数据。
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// **参数解释：** 合并请求创建人
        /// </summary>
        [SDKProperty("author_id", IsQuery = true)]
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorId { get; set; }

        /// <summary>
        /// **参数解释：**   - created_by_me 我创建的合并请求   - assigned_to_me 待我合并的合并请求   - need_my_review 待我检视的合并请求   - need_my_approve 待我审核的合并请求   - all 所有有权限访问的合并请求
        /// </summary>
        [SDKProperty("scope", IsQuery = true)]
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public ScopeEnum Scope { get; set; }
        /// <summary>
        /// **参数解释：** 合并请求原分支
        /// </summary>
        [SDKProperty("source_branch", IsQuery = true)]
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求目标分支
        /// </summary>
        [SDKProperty("target_branch", IsQuery = true)]
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释：** 根据合并请求标题、描述信息过滤关键字
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求标题是否有WIP关键字
        /// </summary>
        [SDKProperty("wip", IsQuery = true)]
        [JsonProperty("wip", NullValueHandling = NullValueHandling.Ignore)]
        public WipEnum Wip { get; set; }
        /// <summary>
        /// **参数解释：** 合并请求合并人
        /// </summary>
        [SDKProperty("merged_by", IsQuery = true)]
        [JsonProperty("merged_by", NullValueHandling = NullValueHandling.Ignore)]
        public string MergedBy { get; set; }

        /// <summary>
        /// **参数解释：** 指定时间后合入
        /// </summary>
        [SDKProperty("merged_after", IsQuery = true)]
        [JsonProperty("merged_after", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MergedAfter { get; set; }

        /// <summary>
        /// **参数解释：** 指定时间前合入
        /// </summary>
        [SDKProperty("merged_before", IsQuery = true)]
        [JsonProperty("merged_before", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MergedBefore { get; set; }

        /// <summary>
        /// **参数解释：** 分页参数偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 分页参数结果数量限制
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 是否只返回合并请求总数
        /// </summary>
        [SDKProperty("only_count", IsQuery = true)]
        [JsonProperty("only_count", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPersonalMergeRequestsRequest {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  createdBefore: ").Append(CreatedBefore).Append("\n");
            sb.Append("  createdAfter: ").Append(CreatedAfter).Append("\n");
            sb.Append("  updatedAfter: ").Append(UpdatedAfter).Append("\n");
            sb.Append("  updatedBefore: ").Append(UpdatedBefore).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  wip: ").Append(Wip).Append("\n");
            sb.Append("  mergedBy: ").Append(MergedBy).Append("\n");
            sb.Append("  mergedAfter: ").Append(MergedAfter).Append("\n");
            sb.Append("  mergedBefore: ").Append(MergedBefore).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  onlyCount: ").Append(OnlyCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPersonalMergeRequestsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPersonalMergeRequestsRequest input)
        {
            if (input == null) return false;
            if (this.State != input.State) return false;
            if (this.OrderBy != input.OrderBy) return false;
            if (this.Sort != input.Sort) return false;
            if (this.Labels != input.Labels || (this.Labels != null && !this.Labels.Equals(input.Labels))) return false;
            if (this.CreatedBefore != input.CreatedBefore || (this.CreatedBefore != null && !this.CreatedBefore.Equals(input.CreatedBefore))) return false;
            if (this.CreatedAfter != input.CreatedAfter || (this.CreatedAfter != null && !this.CreatedAfter.Equals(input.CreatedAfter))) return false;
            if (this.UpdatedAfter != input.UpdatedAfter || (this.UpdatedAfter != null && !this.UpdatedAfter.Equals(input.UpdatedAfter))) return false;
            if (this.UpdatedBefore != input.UpdatedBefore || (this.UpdatedBefore != null && !this.UpdatedBefore.Equals(input.UpdatedBefore))) return false;
            if (this.View != input.View) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.Scope != input.Scope) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Wip != input.Wip) return false;
            if (this.MergedBy != input.MergedBy || (this.MergedBy != null && !this.MergedBy.Equals(input.MergedBy))) return false;
            if (this.MergedAfter != input.MergedAfter || (this.MergedAfter != null && !this.MergedAfter.Equals(input.MergedAfter))) return false;
            if (this.MergedBefore != input.MergedBefore || (this.MergedBefore != null && !this.MergedBefore.Equals(input.MergedBefore))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OnlyCount != input.OnlyCount || (this.OnlyCount != null && !this.OnlyCount.Equals(input.OnlyCount))) return false;

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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.CreatedBefore != null) hashCode = hashCode * 59 + this.CreatedBefore.GetHashCode();
                if (this.CreatedAfter != null) hashCode = hashCode * 59 + this.CreatedAfter.GetHashCode();
                if (this.UpdatedAfter != null) hashCode = hashCode * 59 + this.UpdatedAfter.GetHashCode();
                if (this.UpdatedBefore != null) hashCode = hashCode * 59 + this.UpdatedBefore.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                hashCode = hashCode * 59 + this.Wip.GetHashCode();
                if (this.MergedBy != null) hashCode = hashCode * 59 + this.MergedBy.GetHashCode();
                if (this.MergedAfter != null) hashCode = hashCode * 59 + this.MergedAfter.GetHashCode();
                if (this.MergedBefore != null) hashCode = hashCode * 59 + this.MergedBefore.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.OnlyCount != null) hashCode = hashCode * 59 + this.OnlyCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
