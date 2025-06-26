using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInstanceNamespacesRequest 
    {
        /// <summary>
        /// 按列排序，可设置为updated_at（按更新时间排序）
        /// </summary>
        /// <value>按列排序，可设置为updated_at（按更新时间排序）</value>
        [JsonConverter(typeof(EnumClassConverter<OrderColumnEnum>))]
        public class OrderColumnEnum
        {
            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly OrderColumnEnum UPDATED_AT = new OrderColumnEnum("updated_at");

            private static readonly Dictionary<string, OrderColumnEnum> StaticFields =
            new Dictionary<string, OrderColumnEnum>()
            {
                { "updated_at", UPDATED_AT },
            };

            private string _value;

            public OrderColumnEnum()
            {

            }

            public OrderColumnEnum(string value)
            {
                _value = value;
            }

            public static OrderColumnEnum FromValue(string value)
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

                if (this.Equals(obj as OrderColumnEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderColumnEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderColumnEnum a, OrderColumnEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OrderColumnEnum a, OrderColumnEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序类型，可设置为desc（降序）、asc（升序），与order_column配合使用
        /// </summary>
        /// <value>排序类型，可设置为desc（降序）、asc（升序），与order_column配合使用</value>
        [JsonConverter(typeof(EnumClassConverter<OrderTypeEnum>))]
        public class OrderTypeEnum
        {
            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderTypeEnum DESC = new OrderTypeEnum("desc");

            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderTypeEnum ASC = new OrderTypeEnum("asc");

            private static readonly Dictionary<string, OrderTypeEnum> StaticFields =
            new Dictionary<string, OrderTypeEnum>()
            {
                { "desc", DESC },
                { "asc", ASC },
            };

            private string _value;

            public OrderTypeEnum()
            {

            }

            public OrderTypeEnum(string value)
            {
                _value = value;
            }

            public static OrderTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OrderTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderTypeEnum a, OrderTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OrderTypeEnum a, OrderTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 企业仓库实例ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 起始索引，默认值为0。**注意：offset和limit参数需要配套使用，offset必须为0或者为limit的倍数。**
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 返回条数，默认为10，最大值为100。**注意：offset和limit参数需要配套使用，offset必须为0或者为limit的倍数。**
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 按列排序，可设置为updated_at（按更新时间排序）
        /// </summary>
        [SDKProperty("order_column", IsQuery = true)]
        [JsonProperty("order_column", NullValueHandling = NullValueHandling.Ignore)]
        public OrderColumnEnum OrderColumn { get; set; }
        /// <summary>
        /// 排序类型，可设置为desc（降序）、asc（升序），与order_column配合使用
        /// </summary>
        [SDKProperty("order_type", IsQuery = true)]
        [JsonProperty("order_type", NullValueHandling = NullValueHandling.Ignore)]
        public OrderTypeEnum OrderType { get; set; }
        /// <summary>
        /// 命名空间名称，小写字母或数字开头，后面跟小写字母、数字、点、下划线或中划线（其中点、下划线、中划线不能直接连续），小写字母或数字结尾，1-64个字符。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否公开，非空且非true默认返回false
        /// </summary>
        [SDKProperty("public", IsQuery = true)]
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public string Public { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceNamespacesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orderColumn: ").Append(OrderColumn).Append("\n");
            sb.Append("  orderType: ").Append(OrderType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceNamespacesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceNamespacesRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OrderColumn != input.OrderColumn) return false;
            if (this.OrderType != input.OrderType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Public != input.Public || (this.Public != null && !this.Public.Equals(input.Public))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.OrderColumn.GetHashCode();
                hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Public != null) hashCode = hashCode * 59 + this.Public.GetHashCode();
                return hashCode;
            }
        }
    }
}
