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
    public class ListRepositoryReviewAuthorsRequest 
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
        /// **参数解释：** 解决状态。 **取值范围：** - resolved，已解决。 - unresolved，未解决。   - all，全部。
        /// </summary>
        /// <value>**参数解释：** 解决状态。 **取值范围：** - resolved，已解决。 - unresolved，未解决。   - all，全部。</value>
        [JsonConverter(typeof(EnumClassConverter<ResolvedStatusEnum>))]
        public class ResolvedStatusEnum
        {
            /// <summary>
            /// Enum RESOLVED for value: resolved
            /// </summary>
            public static readonly ResolvedStatusEnum RESOLVED = new ResolvedStatusEnum("resolved");

            /// <summary>
            /// Enum UNRESOLVED for value: unresolved
            /// </summary>
            public static readonly ResolvedStatusEnum UNRESOLVED = new ResolvedStatusEnum("unresolved");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ResolvedStatusEnum ALL = new ResolvedStatusEnum("all");

            private static readonly Dictionary<string, ResolvedStatusEnum> StaticFields =
            new Dictionary<string, ResolvedStatusEnum>()
            {
                { "resolved", RESOLVED },
                { "unresolved", UNRESOLVED },
                { "all", ALL },
            };

            private string _value;

            public ResolvedStatusEnum()
            {

            }

            public ResolvedStatusEnum(string value)
            {
                _value = value;
            }

            public static ResolvedStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ResolvedStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResolvedStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResolvedStatusEnum a, ResolvedStatusEnum b)
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

            public static bool operator !=(ResolvedStatusEnum a, ResolvedStatusEnum b)
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
        /// **参数解释：** 意见类型。 **取值范围：** - Commit，提交。 - MergeRequest，合并请求。  
        /// </summary>
        [SDKProperty("noteable_type", IsQuery = true)]
        [JsonProperty("noteable_type", NullValueHandling = NullValueHandling.Ignore)]
        public NoteableTypeEnum NoteableType { get; set; }
        /// <summary>
        /// **参数解释：** 解决状态。 **取值范围：** - resolved，已解决。 - unresolved，未解决。   - all，全部。
        /// </summary>
        [SDKProperty("resolved_status", IsQuery = true)]
        [JsonProperty("resolved_status", NullValueHandling = NullValueHandling.Ignore)]
        public ResolvedStatusEnum ResolvedStatus { get; set; }
        /// <summary>
        /// **参数解释：** 根据检视人名字或用户名筛选意见。
        /// </summary>
        [SDKProperty("reviewers_filter", IsQuery = true)]
        [JsonProperty("reviewers_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewersFilter { get; set; }

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
            sb.Append("class ListRepositoryReviewAuthorsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  noteableType: ").Append(NoteableType).Append("\n");
            sb.Append("  resolvedStatus: ").Append(ResolvedStatus).Append("\n");
            sb.Append("  reviewersFilter: ").Append(ReviewersFilter).Append("\n");
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
            return this.Equals(input as ListRepositoryReviewAuthorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryReviewAuthorsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.NoteableType != input.NoteableType) return false;
            if (this.ResolvedStatus != input.ResolvedStatus) return false;
            if (this.ReviewersFilter != input.ReviewersFilter || (this.ReviewersFilter != null && !this.ReviewersFilter.Equals(input.ReviewersFilter))) return false;
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
                hashCode = hashCode * 59 + this.ResolvedStatus.GetHashCode();
                if (this.ReviewersFilter != null) hashCode = hashCode * 59 + this.ReviewersFilter.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
