using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowResourceHistoryRequest 
    {
        /// <summary>
        /// 指定返回数据的时间顺序，默认为倒序
        /// </summary>
        /// <value>指定返回数据的时间顺序，默认为倒序</value>
        [JsonConverter(typeof(EnumClassConverter<ChronologicalOrderEnum>))]
        public class ChronologicalOrderEnum
        {
            /// <summary>
            /// Enum FORWARD for value: Forward
            /// </summary>
            public static readonly ChronologicalOrderEnum FORWARD = new ChronologicalOrderEnum("Forward");

            /// <summary>
            /// Enum REVERSE for value: Reverse
            /// </summary>
            public static readonly ChronologicalOrderEnum REVERSE = new ChronologicalOrderEnum("Reverse");

            private static readonly Dictionary<string, ChronologicalOrderEnum> StaticFields =
            new Dictionary<string, ChronologicalOrderEnum>()
            {
                { "Forward", FORWARD },
                { "Reverse", REVERSE },
            };

            private string _value;

            public ChronologicalOrderEnum()
            {

            }

            public ChronologicalOrderEnum(string value)
            {
                _value = value;
            }

            public static ChronologicalOrderEnum FromValue(string value)
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

                if (this.Equals(obj as ChronologicalOrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChronologicalOrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChronologicalOrderEnum a, ChronologicalOrderEnum b)
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

            public static bool operator !=(ChronologicalOrderEnum a, ChronologicalOrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源ID
        /// </summary>
        [SDKProperty("resource_id", IsPath = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 指定查询范围的起始时间点，如果不设置此参数，默认为最早的时间
        /// </summary>
        [SDKProperty("earlier_time", IsQuery = true)]
        [JsonProperty("earlier_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EarlierTime { get; set; }

        /// <summary>
        /// 指定查询范围的结束时间点，如果不设置此参数，默认为当前时间
        /// </summary>
        [SDKProperty("later_time", IsQuery = true)]
        [JsonProperty("later_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LaterTime { get; set; }

        /// <summary>
        /// 指定返回数据的时间顺序，默认为倒序
        /// </summary>
        [SDKProperty("chronological_order", IsQuery = true)]
        [JsonProperty("chronological_order", NullValueHandling = NullValueHandling.Ignore)]
        public ChronologicalOrderEnum ChronologicalOrder { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceHistoryRequest {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  earlierTime: ").Append(EarlierTime).Append("\n");
            sb.Append("  laterTime: ").Append(LaterTime).Append("\n");
            sb.Append("  chronologicalOrder: ").Append(ChronologicalOrder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceHistoryRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceHistoryRequest input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.EarlierTime != input.EarlierTime || (this.EarlierTime != null && !this.EarlierTime.Equals(input.EarlierTime))) return false;
            if (this.LaterTime != input.LaterTime || (this.LaterTime != null && !this.LaterTime.Equals(input.LaterTime))) return false;
            if (this.ChronologicalOrder != input.ChronologicalOrder) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.EarlierTime != null) hashCode = hashCode * 59 + this.EarlierTime.GetHashCode();
                if (this.LaterTime != null) hashCode = hashCode * 59 + this.LaterTime.GetHashCode();
                hashCode = hashCode * 59 + this.ChronologicalOrder.GetHashCode();
                return hashCode;
            }
        }
    }
}
