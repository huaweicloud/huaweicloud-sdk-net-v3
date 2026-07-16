using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWorkspaceRequest 
    {
        /// <summary>
        /// 指定排序字段，可选&#39;name&#39;、&#39;update_time&#39;、&#39;status&#39;，默认是&#39;name&#39;。
        /// </summary>
        /// <value>指定排序字段，可选&#39;name&#39;、&#39;update_time&#39;、&#39;status&#39;，默认是&#39;name&#39;。</value>
        [JsonConverter(typeof(EnumClassConverter<SortByEnum>))]
        public class SortByEnum
        {
            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly SortByEnum NAME = new SortByEnum("name");

            /// <summary>
            /// Enum UPDATE_TIME for value: update_time
            /// </summary>
            public static readonly SortByEnum UPDATE_TIME = new SortByEnum("update_time");

            /// <summary>
            /// Enum STATUS for value: status
            /// </summary>
            public static readonly SortByEnum STATUS = new SortByEnum("status");

            private static readonly Dictionary<string, SortByEnum> StaticFields =
            new Dictionary<string, SortByEnum>()
            {
                { "name", NAME },
                { "update_time", UPDATE_TIME },
                { "status", STATUS },
            };

            private string _value;

            public SortByEnum()
            {

            }

            public SortByEnum(string value)
            {
                _value = value;
            }

            public static SortByEnum FromValue(string value)
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

                if (this.Equals(obj as SortByEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortByEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortByEnum a, SortByEnum b)
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

            public static bool operator !=(SortByEnum a, SortByEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 可选值。&#39;asc&#39;为递增排序。&#39;desc&#39;为递减排序，默认为&#39;desc&#39;。
        /// </summary>
        /// <value>可选值。&#39;asc&#39;为递增排序。&#39;desc&#39;为递减排序，默认为&#39;desc&#39;。</value>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("desc");

            private static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public OrderEnum()
            {

            }

            public OrderEnum(string value)
            {
                _value = value;
            }

            public static OrderEnum FromValue(string value)
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

                if (this.Equals(obj as OrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderEnum a, OrderEnum b)
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

            public static bool operator !=(OrderEnum a, OrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 分页列表的起始页，默认为&#39;0&#39;。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 指定每一页返回的最大条目数，默认为&#39;1000&#39;。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 指定排序字段，可选&#39;name&#39;、&#39;update_time&#39;、&#39;status&#39;，默认是&#39;name&#39;。
        /// </summary>
        [SDKProperty("sort_by", IsQuery = true)]
        [JsonProperty("sort_by", NullValueHandling = NullValueHandling.Ignore)]
        public SortByEnum SortBy { get; set; }
        /// <summary>
        /// 可选值。&#39;asc&#39;为递增排序。&#39;desc&#39;为递减排序，默认为&#39;desc&#39;。
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// 企业项目id，指定此参数会只返回该企业项目id下的工作空间。默认显示所有工作空间。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 工作空间名称查询参数，指定此参数会模糊查询该名称的工作空间。默认显示所有工作空间。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该参数用于筛选可访问的工作空间。指定该参数为true，则会筛选掉当前用户无权限访问的工作空间。该参数默认为false，即为显示所有工作空间。
        /// </summary>
        [SDKProperty("filter_accessible", IsQuery = true)]
        [JsonProperty("filter_accessible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FilterAccessible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkspaceRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortBy: ").Append(SortBy).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  filterAccessible: ").Append(FilterAccessible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkspaceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkspaceRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortBy != input.SortBy) return false;
            if (this.Order != input.Order) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FilterAccessible != input.FilterAccessible || (this.FilterAccessible != null && !this.FilterAccessible.Equals(input.FilterAccessible))) return false;

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
                hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FilterAccessible != null) hashCode = hashCode * 59 + this.FilterAccessible.GetHashCode();
                return hashCode;
            }
        }
    }
}
