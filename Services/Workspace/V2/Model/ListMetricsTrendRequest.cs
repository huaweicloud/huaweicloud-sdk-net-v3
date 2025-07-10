using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMetricsTrendRequest 
    {
        /// <summary>
        /// 数据周期 | MIN - 分钟级 5MIN - 5分钟级 DAY - 天级数据 HOUR - 小时级数据。
        /// </summary>
        /// <value>数据周期 | MIN - 分钟级 5MIN - 5分钟级 DAY - 天级数据 HOUR - 小时级数据。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum MIN for value: MIN
            /// </summary>
            public static readonly PeriodEnum MIN = new PeriodEnum("MIN");

            /// <summary>
            /// Enum _5MIN for value: 5MIN
            /// </summary>
            public static readonly PeriodEnum _5MIN = new PeriodEnum("5MIN");

            /// <summary>
            /// Enum DAY for value: DAY
            /// </summary>
            public static readonly PeriodEnum DAY = new PeriodEnum("DAY");

            /// <summary>
            /// Enum HOUR for value: HOUR
            /// </summary>
            public static readonly PeriodEnum HOUR = new PeriodEnum("HOUR");

            private static readonly Dictionary<string, PeriodEnum> StaticFields =
            new Dictionary<string, PeriodEnum>()
            {
                { "MIN", MIN },
                { "5MIN", _5MIN },
                { "DAY", DAY },
                { "HOUR", HOUR },
            };

            private string _value;

            public PeriodEnum()
            {

            }

            public PeriodEnum(string value)
            {
                _value = value;
            }

            public static PeriodEnum FromValue(string value)
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

                if (this.Equals(obj as PeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PeriodEnum a, PeriodEnum b)
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

            public static bool operator !=(PeriodEnum a, PeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 开始时间。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 指标维度 | 目前最大支持3个维度，必须从0开始；维度格式为dim.{i}&#x3D;key,value，key的最大长度32，value的最大长度为256。 单维度：dim.0&#x3D;instance_id,6f3c6f91-4b24-4e1b-b7d1-a94ac1cb011d 多维度：dim.0&#x3D;key,value&amp;dim.1&#x3D;key,value。
        /// </summary>
        [SDKProperty("dim", IsQuery = true)]
        [JsonProperty("dim", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim { get; set; }

        /// <summary>
        /// 指标名称列表。
        /// </summary>
        [SDKProperty("metric_names", IsQuery = true)]
        [JsonProperty("metric_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MetricNames { get; set; }

        /// <summary>
        /// 数据周期 | MIN - 分钟级 5MIN - 5分钟级 DAY - 天级数据 HOUR - 小时级数据。
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMetricsTrendRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  dim: ").Append(Dim).Append("\n");
            sb.Append("  metricNames: ").Append(MetricNames).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMetricsTrendRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMetricsTrendRequest input)
        {
            if (input == null) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Dim != input.Dim || (this.Dim != null && !this.Dim.Equals(input.Dim))) return false;
            if (this.MetricNames != input.MetricNames || (this.MetricNames != null && input.MetricNames != null && !this.MetricNames.SequenceEqual(input.MetricNames))) return false;
            if (this.Period != input.Period) return false;

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
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Dim != null) hashCode = hashCode * 59 + this.Dim.GetHashCode();
                if (this.MetricNames != null) hashCode = hashCode * 59 + this.MetricNames.GetHashCode();
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
