using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTranscodeConcurrencyNumRequest 
    {
        /// <summary>
        /// 查询数据的时间粒度。支持60, 300（默认值）和3600秒。不传值时，使用默认值300秒。 
        /// </summary>
        /// <value>查询数据的时间粒度。支持60, 300（默认值）和3600秒。不传值时，使用默认值300秒。 </value>
        [JsonConverter(typeof(EnumClassConverter<IntervalEnum>))]
        public class IntervalEnum
        {
            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            public static readonly IntervalEnum NUMBER_60 = new IntervalEnum(60);

            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly IntervalEnum NUMBER_300 = new IntervalEnum(300);

            /// <summary>
            /// Enum NUMBER_3600 for value: 3600
            /// </summary>
            public static readonly IntervalEnum NUMBER_3600 = new IntervalEnum(3600);

            private static readonly Dictionary<int?, IntervalEnum> StaticFields =
            new Dictionary<int?, IntervalEnum>()
            {
                { 60, NUMBER_60 },
                { 300, NUMBER_300 },
                { 3600, NUMBER_3600 },
            };

            private int? _value;

            public IntervalEnum()
            {

            }

            public IntervalEnum(int? value)
            {
                _value = value;
            }

            public static IntervalEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as IntervalEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IntervalEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IntervalEnum a, IntervalEnum b)
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

            public static bool operator !=(IntervalEnum a, IntervalEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 推流域名列表，最多支持查询100个域名，多个域名以逗号分隔。  若查询多个域名，则返回的是多个域名合并数据。 
        /// </summary>
        [SDKProperty("publish_domains", IsQuery = true)]
        [JsonProperty("publish_domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublishDomains { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 查询数据的时间粒度。支持60, 300（默认值）和3600秒。不传值时，使用默认值300秒。 
        /// </summary>
        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalEnum Interval { get; set; }
        /// <summary>
        /// 起始时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。最大查询跨度1天，最大查询周期90天。  若参数为空，默认查询1天数据。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。最大查询跨度1天，最大查询周期90天。  若参数为空，默认为当前时间。结束时间需大于起始时间。 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTranscodeConcurrencyNumRequest {\n");
            sb.Append("  publishDomains: ").Append(PublishDomains).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTranscodeConcurrencyNumRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTranscodeConcurrencyNumRequest input)
        {
            if (input == null) return false;
            if (this.PublishDomains != input.PublishDomains || (this.PublishDomains != null && input.PublishDomains != null && !this.PublishDomains.SequenceEqual(input.PublishDomains))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Interval != input.Interval) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.PublishDomains != null) hashCode = hashCode * 59 + this.PublishDomains.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
