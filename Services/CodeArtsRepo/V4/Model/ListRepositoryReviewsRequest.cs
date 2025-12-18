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
    public class ListRepositoryReviewsRequest 
    {
        /// <summary>
        /// **参数解释：** 意见类型。 **取值范围：** - Commit，提交。 - MergeRequest，合并请求。  
        /// </summary>
        /// <value>**参数解释：** 意见类型。 **取值范围：** - Commit，提交。 - MergeRequest，合并请求。  </value>
        [JsonConverter(typeof(EnumClassConverter<NoteableTypeEnum>))]
        public class NoteableTypeEnum
        {
            /// <summary>
            /// Enum COMMIT for value: Commit
            /// </summary>
            public static readonly NoteableTypeEnum COMMIT = new NoteableTypeEnum("Commit");

            /// <summary>
            /// Enum MERGEREQUEST for value: MergeRequest
            /// </summary>
            public static readonly NoteableTypeEnum MERGEREQUEST = new NoteableTypeEnum("MergeRequest");

            private static readonly Dictionary<string, NoteableTypeEnum> StaticFields =
            new Dictionary<string, NoteableTypeEnum>()
            {
                { "Commit", COMMIT },
                { "MergeRequest", MERGEREQUEST },
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
        /// **参数解释：** 检视意见严重程度
        /// </summary>
        /// <value>**参数解释：** 检视意见严重程度</value>
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
        /// **参数解释：** 排序方式。 **取值范围：** - created，创建时间。 - updated，更新时间。
        /// </summary>
        /// <value>**参数解释：** 排序方式。 **取值范围：** - created，创建时间。 - updated，更新时间。</value>
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

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
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
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[[查询用户所有仓库](https://support.huaweicloud.com/eu/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_eu)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 意见类型。 **取值范围：** - Commit，提交。 - MergeRequest，合并请求。  
        /// </summary>
        [SDKProperty("noteable_type", IsQuery = true)]
        [JsonProperty("noteable_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteableTypeEnum NoteableType { get; set; }
        /// <summary>
        /// **参数解释：** 查询评论内容。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 开始日期。
        /// </summary>
        [SDKProperty("start_date", IsQuery = true)]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// **参数解释：** 结束日期。
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// **参数解释：** 是否仅返回带有提交计数和diffs计数的结果。 **取值范围：** - true，仅返回带有提交计数和diffs计数的结果。 - false，按照compare_view参数返回结果信息。
        /// </summary>
        [SDKProperty("only_count", IsQuery = true)]
        [JsonProperty("only_count", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyCount { get; set; }

        /// <summary>
        /// **参数解释：** 搜索的检视意见分类。 **取值范围：** 字符串长度不少于1，不超过200。
        /// </summary>
        [SDKProperty("review_categories", IsQuery = true)]
        [JsonProperty("review_categories", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategories { get; set; }

        /// <summary>
        /// **参数解释：** 搜索的检视意见模块。 **取值范围：** 字符串长度不少于1，不超过200。
        /// </summary>
        [SDKProperty("review_modules", IsQuery = true)]
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewModules { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见严重程度
        /// </summary>
        [SDKProperty("severity", IsQuery = true)]
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// **参数解释：** 检视意见指派人id。
        /// </summary>
        [SDKProperty("assignee_id", IsQuery = true)]
        [JsonProperty("assignee_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见检视人id。
        /// </summary>
        [SDKProperty("proposer_id", IsQuery = true)]
        [JsonProperty("proposer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProposerId { get; set; }

        /// <summary>
        /// **参数解释：** 目标分支名称。 **取值范围：** 字符串长度不少于1，不超过2000。
        /// </summary>
        [SDKProperty("target_branch", IsQuery = true)]
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释：** 是否包含回复。 **取值范围：** - true，包含。 - false，不包含。
        /// </summary>
        [SDKProperty("include_reply", IsQuery = true)]
        [JsonProperty("include_reply", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeReply { get; set; }

        /// <summary>
        /// **参数解释：** 排序方式。 **取值范围：** - created，创建时间。 - updated，更新时间。
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释：** 检视意见返回排序 - asc 按创建时间正序返回 - desc 按创建时间倒序返回
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

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
            sb.Append("class ListRepositoryReviewsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  noteableType: ").Append(NoteableType).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  onlyCount: ").Append(OnlyCount).Append("\n");
            sb.Append("  reviewCategories: ").Append(ReviewCategories).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  assigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  proposerId: ").Append(ProposerId).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  includeReply: ").Append(IncludeReply).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
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
            return this.Equals(input as ListRepositoryReviewsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryReviewsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.NoteableType != input.NoteableType) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.OnlyCount != input.OnlyCount || (this.OnlyCount != null && !this.OnlyCount.Equals(input.OnlyCount))) return false;
            if (this.ReviewCategories != input.ReviewCategories || (this.ReviewCategories != null && !this.ReviewCategories.Equals(input.ReviewCategories))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && !this.ReviewModules.Equals(input.ReviewModules))) return false;
            if (this.Severity != input.Severity) return false;
            if (this.AssigneeId != input.AssigneeId || (this.AssigneeId != null && !this.AssigneeId.Equals(input.AssigneeId))) return false;
            if (this.ProposerId != input.ProposerId || (this.ProposerId != null && !this.ProposerId.Equals(input.ProposerId))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.IncludeReply != input.IncludeReply || (this.IncludeReply != null && !this.IncludeReply.Equals(input.IncludeReply))) return false;
            if (this.OrderBy != input.OrderBy) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
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
                hashCode = hashCode * 59 + this.NoteableType.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.OnlyCount != null) hashCode = hashCode * 59 + this.OnlyCount.GetHashCode();
                if (this.ReviewCategories != null) hashCode = hashCode * 59 + this.ReviewCategories.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.AssigneeId != null) hashCode = hashCode * 59 + this.AssigneeId.GetHashCode();
                if (this.ProposerId != null) hashCode = hashCode * 59 + this.ProposerId.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.IncludeReply != null) hashCode = hashCode * 59 + this.IncludeReply.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
