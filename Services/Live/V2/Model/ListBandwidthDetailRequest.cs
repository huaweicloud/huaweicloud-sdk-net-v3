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
    public class ListBandwidthDetailRequest 
    {
        /// <summary>
        /// 请求协议
        /// </summary>
        /// <value>请求协议</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum FLV for value: flv
            /// </summary>
            public static readonly ProtocolEnum FLV = new ProtocolEnum("flv");

            /// <summary>
            /// Enum HLS for value: hls
            /// </summary>
            public static readonly ProtocolEnum HLS = new ProtocolEnum("hls");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "flv", FLV },
                { "hls", HLS },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询数据的时间粒度。支持300（默认值）, 3600和86400秒。不传值时，使用默认值300秒。 
        /// </summary>
        /// <value>查询数据的时间粒度。支持300（默认值）, 3600和86400秒。不传值时，使用默认值300秒。 </value>
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
        /// 服务类型： - Live：直播 - LLL：超低时延直播 - ALL：默认所有直播 
        /// </summary>
        /// <value>服务类型： - Live：直播 - LLL：超低时延直播 - ALL：默认所有直播 </value>
        [JsonConverter(typeof(EnumClassConverter<ServiceTypeEnum>))]
        public class ServiceTypeEnum
        {
            /// <summary>
            /// Enum LIVE for value: Live
            /// </summary>
            public static readonly ServiceTypeEnum LIVE = new ServiceTypeEnum("Live");

            /// <summary>
            /// Enum LLL for value: LLL
            /// </summary>
            public static readonly ServiceTypeEnum LLL = new ServiceTypeEnum("LLL");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly ServiceTypeEnum ALL = new ServiceTypeEnum("ALL");

            private static readonly Dictionary<string, ServiceTypeEnum> StaticFields =
            new Dictionary<string, ServiceTypeEnum>()
            {
                { "Live", LIVE },
                { "LLL", LLL },
                { "ALL", ALL },
            };

            private string _value;

            public ServiceTypeEnum()
            {

            }

            public ServiceTypeEnum(string value)
            {
                _value = value;
            }

            public static ServiceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ServiceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServiceTypeEnum a, ServiceTypeEnum b)
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

            public static bool operator !=(ServiceTypeEnum a, ServiceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 播放域名列表，最多支持查询100个域名，多个域名以逗号分隔。  如果不传入域名，则查询租户下所有播放域名的带宽数据。 
        /// </summary>
        [SDKProperty("play_domains", IsQuery = true)]
        [JsonProperty("play_domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PlayDomains { get; set; }

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
        /// 国家列表。具体取值请参考[国家名称缩写](vod_08_0172.xml)，不填写查询所有国家。 
        /// </summary>
        [SDKProperty("country", IsQuery = true)]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Country { get; set; }

        /// <summary>
        /// 区域列表。具体取值请参考[省份名称缩写](live_03_0043.xml)，不填写查询所有区域。 
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Region { get; set; }

        /// <summary>
        /// 运营商列表，取值如下： - CMCC ：移动 - CTCC ：电信 - CUCC ：联通 - OTHER ：其他  不填写查询所有运营商。 
        /// </summary>
        [SDKProperty("isp", IsQuery = true)]
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Isp { get; set; }

        /// <summary>
        /// 请求协议
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 查询数据的时间粒度。支持300（默认值）, 3600和86400秒。不传值时，使用默认值300秒。 
        /// </summary>
        [SDKProperty("interval", IsQuery = true)]
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public IntervalEnum Interval { get; set; }
        /// <summary>
        /// 起始时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。最大查询跨度31天，最大查询周期一年。  若参数为空，默认查询7天数据。 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。日期格式按照ISO8601表示法，并使用UTC时间。  格式为：YYYY-MM-DDThh:mm:ssZ。  若参数为空，默认为当前时间。结束时间需大于起始时间。 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 服务类型： - Live：直播 - LLL：超低时延直播 - ALL：默认所有直播 
        /// </summary>
        [SDKProperty("service_type", IsQuery = true)]
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceTypeEnum ServiceType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBandwidthDetailRequest {\n");
            sb.Append("  playDomains: ").Append(PlayDomains).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBandwidthDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBandwidthDetailRequest input)
        {
            if (input == null) return false;
            if (this.PlayDomains != input.PlayDomains || (this.PlayDomains != null && input.PlayDomains != null && !this.PlayDomains.SequenceEqual(input.PlayDomains))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.Country != input.Country || (this.Country != null && input.Country != null && !this.Country.SequenceEqual(input.Country))) return false;
            if (this.Region != input.Region || (this.Region != null && input.Region != null && !this.Region.SequenceEqual(input.Region))) return false;
            if (this.Isp != input.Isp || (this.Isp != null && input.Isp != null && !this.Isp.SequenceEqual(input.Isp))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.Interval != input.Interval) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ServiceType != input.ServiceType) return false;

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
                if (this.PlayDomains != null) hashCode = hashCode * 59 + this.PlayDomains.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Isp != null) hashCode = hashCode * 59 + this.Isp.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
