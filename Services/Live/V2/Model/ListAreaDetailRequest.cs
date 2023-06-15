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
    public class ListAreaDetailRequest 
    {
        /// <summary>
        /// 查询数据的时间粒度。支持300（默认值）、3600和86400秒。若参数为空，则默认为300秒。  注意，若metric的值为player（观众数），则interval填入的值不起效果，查询粒度interval默认为60秒。 
        /// </summary>
        /// <value>查询数据的时间粒度。支持300（默认值）、3600和86400秒。若参数为空，则默认为300秒。  注意，若metric的值为player（观众数），则interval填入的值不起效果，查询粒度interval默认为60秒。 </value>
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
        /// 查询起始时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。最大查询跨度1天，最大查询周期90天。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询结束时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。最大查询跨度1天，最大查询周期90天。 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 需查询的播放域名列表，最多支持查询100个域名。 
        /// </summary>
        [SDKProperty("play_domains", IsQuery = true)]
        [JsonProperty("play_domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PlayDomains { get; set; }

        /// <summary>
        /// 需查询的app。 
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [SDKProperty("stream", IsQuery = true)]
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 查询数据的时间粒度。支持300（默认值）、3600和86400秒。若参数为空，则默认为300秒。  注意，若metric的值为player（观众数），则interval填入的值不起效果，查询粒度interval默认为60秒。 
        /// </summary>
        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalEnum Interval { get; set; }
        /// <summary>
        /// 运营商列表，取值如下： - CMCC：移动 - CTCC：电信 - CUCC：联通 - OTHER：其他  若参数为空，则查询所有运营商。 
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 需查询的计费大区，取值如下： - CN：中国内地。 - AP1：亚太1区。 - AP2：亚太2区。 - AP3：亚太3区。 - MEAA：中东非洲。 - SA：南美。 - EU：欧洲。 - ALL：全部。  中国内地返回结果为省份/直辖市的中文名称，比如：广东、上海； 海外大区与地区/国家的对应关系请参考[地区/国家代码对照表](live_03_0049.xml)。 
        /// </summary>
        [SDKProperty("area", IsQuery = true)]
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Area { get; set; }

        /// <summary>
        /// 指标，取值如下： - bandwidth：带宽 - traffic：流量 - player：观众数 
        /// </summary>
        [SDKProperty("metric", IsQuery = true)]
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public string Metric { get; set; }

        /// <summary>
        /// 请求协议，取值如下： - flv - hls 
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAreaDetailRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  playDomains: ").Append(PlayDomains).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAreaDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAreaDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.PlayDomains == input.PlayDomains ||
                    this.PlayDomains != null &&
                    input.PlayDomains != null &&
                    this.PlayDomains.SequenceEqual(input.PlayDomains)
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
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Isp == input.Isp ||
                    this.Isp != null &&
                    input.Isp != null &&
                    this.Isp.SequenceEqual(input.Isp)
                ) && 
                (
                    this.Area == input.Area ||
                    this.Area != null &&
                    input.Area != null &&
                    this.Area.SequenceEqual(input.Area)
                ) && 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.PlayDomains != null)
                    hashCode = hashCode * 59 + this.PlayDomains.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Isp != null)
                    hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
