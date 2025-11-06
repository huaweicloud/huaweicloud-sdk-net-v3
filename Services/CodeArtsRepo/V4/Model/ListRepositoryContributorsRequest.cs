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
    public class ListRepositoryContributorsRequest 
    {
        /// <summary>
        /// **参数解释：** 排序方式。 **取值范围：** - name，名字。 - email，邮箱。 - commits，提交数量。
        /// </summary>
        /// <value>**参数解释：** 排序方式。 **取值范围：** - name，名字。 - email，邮箱。 - commits，提交数量。</value>
        [JsonConverter(typeof(EnumClassConverter<OrderByEnum>))]
        public class OrderByEnum
        {
            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly OrderByEnum NAME = new OrderByEnum("name");

            /// <summary>
            /// Enum EMAIL for value: email
            /// </summary>
            public static readonly OrderByEnum EMAIL = new OrderByEnum("email");

            /// <summary>
            /// Enum COMMITS for value: commits
            /// </summary>
            public static readonly OrderByEnum COMMITS = new OrderByEnum("commits");

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "name", NAME },
                { "email", EMAIL },
                { "commits", COMMITS },
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
        /// **参数解释：** 返回排序 - asc 按提交数量正序返回 - desc 按提交数量倒序返回
        /// </summary>
        /// <value>**参数解释：** 返回排序 - asc 按提交数量正序返回 - desc 按提交数量倒序返回</value>
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
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

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
        /// **参数解释：** 排序方式。 **取值范围：** - name，名字。 - email，邮箱。 - commits，提交数量。
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释：** 返回排序 - asc 按提交数量正序返回 - desc 按提交数量倒序返回
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 分支或者tag名称。 **约束限制：** 不支持以 - . refs/heads/ refs/remotes/ 开头，不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾。 **取值范围：** 字符串长度不少于1，不超过200。 **默认取值：** 仓库默认分支。
        /// </summary>
        [SDKProperty("ref_name", IsQuery = true)]
        [JsonProperty("ref_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RefName { get; set; }

        /// <summary>
        /// **参数解释：** 是否跳过合并。 **约束限制：** 不涉及。 **取值范围：** - false, 跳过合并 - true, 不跳过合并
        /// </summary>
        [SDKProperty("skip_merge", IsQuery = true)]
        [JsonProperty("skip_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipMerge { get; set; }

        /// <summary>
        /// **参数解释：** 提交者。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("author", IsQuery = true)]
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryContributorsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  refName: ").Append(RefName).Append("\n");
            sb.Append("  skipMerge: ").Append(SkipMerge).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryContributorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryContributorsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OrderBy != input.OrderBy) return false;
            if (this.Sort != input.Sort) return false;
            if (this.RefName != input.RefName || (this.RefName != null && !this.RefName.Equals(input.RefName))) return false;
            if (this.SkipMerge != input.SkipMerge || (this.SkipMerge != null && !this.SkipMerge.Equals(input.SkipMerge))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.RefName != null) hashCode = hashCode * 59 + this.RefName.GetHashCode();
                if (this.SkipMerge != null) hashCode = hashCode * 59 + this.SkipMerge.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                return hashCode;
            }
        }
    }
}
