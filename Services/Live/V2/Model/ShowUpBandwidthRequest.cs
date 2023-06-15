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
    public class ShowUpBandwidthRequest 
    {
        /// <summary>
        /// 查询数据的时间粒度。支持300（默认值），3600和86400秒。不传值时，使用默认值300秒。 
        /// </summary>
        /// <value>查询数据的时间粒度。支持300（默认值），3600和86400秒。不传值时，使用默认值300秒。 </value>
        [JsonConverter(typeof(EnumClassConverter<IntervalEnum>))]
        public class IntervalEnum
        {
            /// <summary>
            /// Enum NUMBER_300 for value: 300
            /// </summary>
            public static readonly IntervalEnum NUMBER_300 = new IntervalEnum(300);

            /// <summary>
            /// Enum NUMBER_3600 for value: 3600
            /// </summary>
            public static readonly IntervalEnum NUMBER_3600 = new IntervalEnum(3600);

            /// <summary>
            /// Enum NUMBER_86400 for value: 86400
            /// </summary>
            public static readonly IntervalEnum NUMBER_86400 = new IntervalEnum(86400);

            private static readonly Dictionary<int?, IntervalEnum> StaticFields =
            new Dictionary<int?, IntervalEnum>()
            {
                { 300, NUMBER_300 },
                { 3600, NUMBER_3600 },
                { 86400, NUMBER_86400 },
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

            public static bool operator !=(IntervalEnum a, IntervalEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 类型： - RELAY：转推 不填默认查询推流 
        /// </summary>
        /// <value>类型： - RELAY：转推 不填默认查询推流 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum RELAY for value: RELAY
            /// </summary>
            public static readonly TypeEnum RELAY = new TypeEnum("RELAY");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "RELAY", RELAY },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 推流域名列表，最多支持查询100个域名，多个域名以逗号分隔，若查询多个域名，则返回的是多个域名合并数据。 
        /// </summary>
        [SDKProperty("publish_domains", IsQuery = true)]
        [JsonProperty("publish_domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublishDomains { get; set; }

        /// <summary>
        /// 应用名称。 
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 流名。 
        /// </summary>
        [SDKProperty("stream", IsQuery = true)]
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 区域列表。具体取值请参考[省份名称缩写](live_03_0043.xml)，不填写查询所有区域。 
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Region { get; set; }

        /// <summary>
        /// 运营商列表，取值如下： - CMCC ：移动 - CTCC ： 电信 - CUCC ：联通 - OTHER ：其他  不填写查询所有运营商。 
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 查询数据的时间粒度。支持300（默认值），3600和86400秒。不传值时，使用默认值300秒。 
        /// </summary>
        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalEnum Interval { get; set; }
        /// <summary>
        /// 类型： - RELAY：转推 不填默认查询推流 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 起始时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。 最大查询跨度31天，最大查询周期1年。  若参数为空，默认查询7天数据。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ。  若参数为空，默认为当前时间，最大查询跨度31天，最大查询周期1年。结束时间需大于起始时间。 
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
            sb.Append("class ShowUpBandwidthRequest {\n");
            sb.Append("  publishDomains: ").Append(PublishDomains).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ShowUpBandwidthRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUpBandwidthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublishDomains == input.PublishDomains ||
                    this.PublishDomains != null &&
                    input.PublishDomains != null &&
                    this.PublishDomains.SequenceEqual(input.PublishDomains)
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.Region == input.Region ||
                    this.Region != null &&
                    input.Region != null &&
                    this.Region.SequenceEqual(input.Region)
                ) && 
                (
                    this.Isp == input.Isp ||
                    this.Isp != null &&
                    input.Isp != null &&
                    this.Isp.SequenceEqual(input.Isp)
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PublishDomains != null)
                    hashCode = hashCode * 59 + this.PublishDomains.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Isp != null)
                    hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
