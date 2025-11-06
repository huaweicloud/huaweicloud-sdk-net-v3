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
    public class ListRepositoryLabelsRequest 
    {
        /// <summary>
        /// **参数解释：**  排序。 **约束限制：** 不涉及。 **取值范围：** - name_asc，按标签名升序。 - name_desc，按标签名降序。 - created_asc，按标签创建时间升序。 - created_desc，按标签创建时间降序。 - updated_asc，按标签更新时间升序。 - updated_desc，按标签更新时间降序。 **默认取值：** name_asc
        /// </summary>
        /// <value>**参数解释：**  排序。 **约束限制：** 不涉及。 **取值范围：** - name_asc，按标签名升序。 - name_desc，按标签名降序。 - created_asc，按标签创建时间升序。 - created_desc，按标签创建时间降序。 - updated_asc，按标签更新时间升序。 - updated_desc，按标签更新时间降序。 **默认取值：** name_asc</value>
        [JsonConverter(typeof(EnumClassConverter<SortEnum>))]
        public class SortEnum
        {
            /// <summary>
            /// Enum NAME_ASC for value: name_asc
            /// </summary>
            public static readonly SortEnum NAME_ASC = new SortEnum("name_asc");

            /// <summary>
            /// Enum NAME_DESC for value: name_desc
            /// </summary>
            public static readonly SortEnum NAME_DESC = new SortEnum("name_desc");

            /// <summary>
            /// Enum CREATED_ASC for value: created_asc
            /// </summary>
            public static readonly SortEnum CREATED_ASC = new SortEnum("created_asc");

            /// <summary>
            /// Enum CREATED_DESC for value: created_desc
            /// </summary>
            public static readonly SortEnum CREATED_DESC = new SortEnum("created_desc");

            /// <summary>
            /// Enum UPDATED_ASC for value: updated_asc
            /// </summary>
            public static readonly SortEnum UPDATED_ASC = new SortEnum("updated_asc");

            /// <summary>
            /// Enum UPDATED_DESC for value: updated_desc
            /// </summary>
            public static readonly SortEnum UPDATED_DESC = new SortEnum("updated_desc");

            private static readonly Dictionary<string, SortEnum> StaticFields =
            new Dictionary<string, SortEnum>()
            {
                { "name_asc", NAME_ASC },
                { "name_desc", NAME_DESC },
                { "created_asc", CREATED_ASC },
                { "created_desc", CREATED_DESC },
                { "updated_asc", UPDATED_ASC },
                { "updated_desc", UPDATED_DESC },
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
        /// **参数解释：** 结果集属性，根据给定的参数返回不同的结果。 **约束限制：** 不涉及。 **取值范围：** - simple，返回简略信息。 - basic，返回基本信息。 - detail，返回详细信息。 **默认取值：** basic
        /// </summary>
        /// <value>**参数解释：** 结果集属性，根据给定的参数返回不同的结果。 **约束限制：** 不涉及。 **取值范围：** - simple，返回简略信息。 - basic，返回基本信息。 - detail，返回详细信息。 **默认取值：** basic</value>
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
        /// **参数解释：** 查询关键字，可模糊匹配标签名。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：**  排序。 **约束限制：** 不涉及。 **取值范围：** - name_asc，按标签名升序。 - name_desc，按标签名降序。 - created_asc，按标签创建时间升序。 - created_desc，按标签创建时间降序。 - updated_asc，按标签更新时间升序。 - updated_desc，按标签更新时间降序。 **默认取值：** name_asc
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 是否包含失效的标签。 **约束限制：** 不涉及。 **取值范围：** - true，包含。 - false，不包含。 **默认取值：** true
        /// </summary>
        [SDKProperty("include_expired", IsQuery = true)]
        [JsonProperty("include_expired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeExpired { get; set; }

        /// <summary>
        /// **参数解释：** 结果集属性，根据给定的参数返回不同的结果。 **约束限制：** 不涉及。 **取值范围：** - simple，返回简略信息。 - basic，返回基本信息。 - detail，返回详细信息。 **默认取值：** basic
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryLabelsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  includeExpired: ").Append(IncludeExpired).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryLabelsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryLabelsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Sort != input.Sort) return false;
            if (this.IncludeExpired != input.IncludeExpired || (this.IncludeExpired != null && !this.IncludeExpired.Equals(input.IncludeExpired))) return false;
            if (this.View != input.View) return false;

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
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.IncludeExpired != null) hashCode = hashCode * 59 + this.IncludeExpired.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                return hashCode;
            }
        }
    }
}
