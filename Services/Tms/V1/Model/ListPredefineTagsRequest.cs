using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPredefineTagsRequest 
    {
        /// <summary>
        /// order_field字段的排序方法。 可输入的值包含（区分大小写）： asc（升序） desc（降序） 只能选择以上值的其中之一。 不传则默认值为：desc
        /// </summary>
        /// <value>order_field字段的排序方法。 可输入的值包含（区分大小写）： asc（升序） desc（降序） 只能选择以上值的其中之一。 不传则默认值为：desc</value>
        [JsonConverter(typeof(EnumClassConverter<OrderMethodEnum>))]
        public class OrderMethodEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderMethodEnum ASC = new OrderMethodEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderMethodEnum DESC = new OrderMethodEnum("desc");

            private static readonly Dictionary<string, OrderMethodEnum> StaticFields =
            new Dictionary<string, OrderMethodEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public OrderMethodEnum()
            {

            }

            public OrderMethodEnum(string value)
            {
                _value = value;
            }

            public static OrderMethodEnum FromValue(string value)
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

                if (this.Equals(obj as OrderMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OrderMethodEnum a, OrderMethodEnum b)
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

            public static bool operator !=(OrderMethodEnum a, OrderMethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 键，支持模糊查询，不区分大小写，如果包含“non-URL-safe”的字符，需要进行“urlencoded”。
        /// </summary>
        [SDKProperty("key", IsQuery = true)]
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 值，支持模糊查询，不区分大小写，如果包含“non-URL-safe”的字符，需要进行“urlencoded”。
        /// </summary>
        [SDKProperty("value", IsQuery = true)]
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 查询记录数。 最小为1，最大为1000，未输入时默认为10，为0时不限制查询数据条数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页位置标识（索引）。 从marker指定索引的下一条数据开始查询。 说明： 查询第一页数据时，不需要传入此参数，查询后续页码数据时，将查询前一页数据响应体中marker值配入此参数，当返回的tags为空列表时表示查询到最后一页。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 排序字段： 可输入的值包含（区分大小写）：update_time（更新时间）、key（键）、value（值）。 只能选择以上排序字段中的一个，并按照排序方法字段order_method进行排序，如果不传则默认值为：update_time。 如以下： 若该字段为update_time，则剩余两个默认字段排序为key升序，value升序。 若该字段如为key，则剩余两个默认字段排序为update_time降序，value升序。 若该字段如为value，则剩余两个默认字段排序为update_time降序，key升序。 若该字段不传，默认字段为update_time，则剩余两个默认字段排序为key升序，value升序。
        /// </summary>
        [SDKProperty("order_field", IsQuery = true)]
        [JsonProperty("order_field", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderField { get; set; }

        /// <summary>
        /// order_field字段的排序方法。 可输入的值包含（区分大小写）： asc（升序） desc（降序） 只能选择以上值的其中之一。 不传则默认值为：desc
        /// </summary>
        [SDKProperty("order_method", IsQuery = true)]
        [JsonProperty("order_method", NullValueHandling = NullValueHandling.Ignore)]
        public OrderMethodEnum OrderMethod { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPredefineTagsRequest {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  orderField: ").Append(OrderField).Append("\n");
            sb.Append("  orderMethod: ").Append(OrderMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPredefineTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPredefineTagsRequest input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.OrderField != input.OrderField || (this.OrderField != null && !this.OrderField.Equals(input.OrderField))) return false;
            if (this.OrderMethod != input.OrderMethod) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.OrderField != null) hashCode = hashCode * 59 + this.OrderField.GetHashCode();
                hashCode = hashCode * 59 + this.OrderMethod.GetHashCode();
                return hashCode;
            }
        }
    }
}
