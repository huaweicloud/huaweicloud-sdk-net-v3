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
    public class ListCurrentUserRepositoriesRequest 
    {
        /// <summary>
        /// **参数解释：** 排序字段。 **取值范围：** - created_at，创建时间。 - updated_at，更新时间。 **约束限制：** 不涉及。 **默认取值：** created_at。
        /// </summary>
        /// <value>**参数解释：** 排序字段。 **取值范围：** - created_at，创建时间。 - updated_at，更新时间。 **约束限制：** 不涉及。 **默认取值：** created_at。</value>
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
        /// **参数解释：** 排序字段。 **取值范围：** - asc，升序。 - desc，逆序。 **约束限制：** 不涉及。 **默认取值：** desc。
        /// </summary>
        /// <value>**参数解释：** 排序字段。 **取值范围：** - asc，升序。 - desc，逆序。 **约束限制：** 不涉及。 **默认取值：** desc。</value>
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
        /// **参数解释：** 排序字段。 **取值范围：** - created_at，创建时间。 - updated_at，更新时间。 **约束限制：** 不涉及。 **默认取值：** created_at。
        /// </summary>
        [SDKProperty("order_by", IsQuery = true)]
        [JsonProperty("order_by", NullValueHandling = NullValueHandling.Ignore)]
        public OrderByEnum OrderBy { get; set; }
        /// <summary>
        /// **参数解释：** 排序字段。 **取值范围：** - asc，升序。 - desc，逆序。 **约束限制：** 不涉及。 **默认取值：** desc。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public SortEnum Sort { get; set; }
        /// <summary>
        /// **参数解释：** 是否归档。 **取值范围：** - true，归档。 - false，未归档。 **约束限制：** 不涉及。 **默认取值：** false。
        /// </summary>
        [SDKProperty("archived", IsQuery = true)]
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        /// <summary>
        /// **参数解释：** 仓库搜索。 **取值范围：** 1-512。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 关注的仓库。 **取值范围：** - true，关注。 - false，未关注。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("starred", IsQuery = true)]
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }

        /// <summary>
        /// **参数解释：** 参与的仓库（有仓库成员身份）。 **取值范围：** - true，筛选我参与的仓库。 - false，不筛选。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("membership", IsQuery = true)]
        [JsonProperty("membership", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Membership { get; set; }

        /// <summary>
        /// **参数解释：** 创建的仓库。 **取值范围：** - true，筛选我创建的仓库。 - false，不筛选。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("user_created", IsQuery = true)]
        [JsonProperty("user_created", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserCreated { get; set; }

        /// <summary>
        /// **参数解释：** 包含异常状态的仓库。 **取值范围：** - true，筛选包含异常状态的仓库。 - false，不筛选。 **约束限制：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("include_abnormal", IsQuery = true)]
        [JsonProperty("include_abnormal", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAbnormal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCurrentUserRepositoriesRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orderBy: ").Append(OrderBy).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  archived: ").Append(Archived).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("  membership: ").Append(Membership).Append("\n");
            sb.Append("  userCreated: ").Append(UserCreated).Append("\n");
            sb.Append("  includeAbnormal: ").Append(IncludeAbnormal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCurrentUserRepositoriesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCurrentUserRepositoriesRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OrderBy != input.OrderBy) return false;
            if (this.Sort != input.Sort) return false;
            if (this.Archived != input.Archived || (this.Archived != null && !this.Archived.Equals(input.Archived))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;
            if (this.Membership != input.Membership || (this.Membership != null && !this.Membership.Equals(input.Membership))) return false;
            if (this.UserCreated != input.UserCreated || (this.UserCreated != null && !this.UserCreated.Equals(input.UserCreated))) return false;
            if (this.IncludeAbnormal != input.IncludeAbnormal || (this.IncludeAbnormal != null && !this.IncludeAbnormal.Equals(input.IncludeAbnormal))) return false;

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
                hashCode = hashCode * 59 + this.OrderBy.GetHashCode();
                hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Archived != null) hashCode = hashCode * 59 + this.Archived.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.Membership != null) hashCode = hashCode * 59 + this.Membership.GetHashCode();
                if (this.UserCreated != null) hashCode = hashCode * 59 + this.UserCreated.GetHashCode();
                if (this.IncludeAbnormal != null) hashCode = hashCode * 59 + this.IncludeAbnormal.GetHashCode();
                return hashCode;
            }
        }
    }
}
