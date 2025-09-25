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
    public class ListTagsRequest 
    {
        /// <summary>
        /// **参数解释：** 排序方式。 **约束限制：** - asc，升序。 - desc，降序。
        /// </summary>
        /// <value>**参数解释：** 排序方式。 **约束限制：** - asc，升序。 - desc，降序。</value>
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
        /// **参数解释：** 排序方式。 **取值范围：** - name，名字。 - created，创建时间。 - updated，更新时间。
        /// </summary>
        /// <value>**参数解释：** 排序方式。 **取值范围：** - name，名字。 - created，创建时间。 - updated，更新时间。</value>
        [JsonConverter(typeof(EnumClassConverter<OrderByEnum>))]
        public class OrderByEnum
        {
            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly OrderByEnum NAME = new OrderByEnum("name");

            /// <summary>
            /// Enum UPDATED for value: updated
            /// </summary>
            public static readonly OrderByEnum UPDATED = new OrderByEnum("updated");

            /// <summary>
            /// Enum CREATED for value: created
            /// </summary>
            public static readonly OrderByEnum CREATED = new OrderByEnum("created");

            private static readonly Dictionary<string, OrderByEnum> StaticFields =
            new Dictionary<string, OrderByEnum>()
            {
                { "name", NAME },
                { "updated", UPDATED },
                { "created", CREATED },
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
        /// **参数解释：** 结果集展示内容。 **取值范围：** - detail，返回标签的所有信息。 - basic，返回标签的基本信息。 - simple，返回标签的简单信息。
        /// </summary>
        /// <value>**参数解释：** 结果集展示内容。 **取值范围：** - detail，返回标签的所有信息。 - basic，返回标签的基本信息。 - simple，返回标签的简单信息。</value>
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
            /// Enum DETAIL for value: detail
            /// </summary>
            public static readonly ViewEnum DETAIL = new ViewEnum("detail");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "simple", SIMPLE },
                { "basic", BASIC },
                { "detail", DETAIL },
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
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 创建者，用户ID或者IamId。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("creator", IsQuery = true)]
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// **参数解释：** 排序方式。 **约束限制：** - asc，升序。 - desc，降序。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 搜索条件，按标签名称搜索。 **取值范围：** 字符串长度不少于1，不超过2000。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 排序方式。 **取值范围：** - name，名字。 - created，创建时间。 - updated，更新时间。
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释：** 结果集展示内容。 **取值范围：** - detail，返回标签的所有信息。 - basic，返回标签的基本信息。 - simple，返回标签的简单信息。
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
            sb.Append("class ListTagsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
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
            return this.Equals(input as ListTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTagsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Sort != input.Sort) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.OrderBy != input.OrderBy) return false;
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
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
