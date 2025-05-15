using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 该参数用来指定需要查询的数据维度，数据周期等。
    /// </summary>
    public class QueryMetricDataParam 
    {

        /// <summary>
        /// 指标对象列表。 取值范围 JSON数组大小不超过20
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricQueryMetricParam> Metrics { get; set; }

        /// <summary>
        /// 监控数据粒度。取值范围（枚举）：60（表示粒度为1分钟），300（表示粒度为5分钟），900（表示粒度为15分钟），3600（表示粒度为1小时）。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 统计方式。 取值范围 maximum，minimum，sum，average，sampleCount
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Statistics { get; set; }

        /// <summary>
        /// timeRange用于指标查询时间范围，主要用于解决客户端时间和服务端时间不一致情况下，查询最近N分钟的数据。另可用于精确查询某一段时间的数据。   如：   - -1.-1.60(表示最近60分钟)，不管当前客户端是什么时间，都以服务端时间为准查询最近60分钟。   - 1650852000000.1650852300000.5(表示GMT+8 2022-04-25 10:00:00至2022-04-25 10:05:00指定的5分钟)   格式：   startTimeInMillis.endTimeInMillis.durationInMinutes   参数解释：   - startTimeInMillis: 查询的开始时间，格式为UTC毫秒，如果指定为-1，服务端将按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。如-1.1650852300000.5，则相当于1650852000000.1650852300000.5   - endTimeInMillis: 查询的结束时间，格式为UTC毫秒，如果指定为-1，服务端将按(startTimeInMillis + durationInMinutes * 60 * 1000)计算结束时间，如果计算出的结束时间大于当前系统时间，则使用当前系统时间。如1650852000000.-1.5，则相当于1650852000000.1650852300000.5   - durationInMinutes：查询时间的跨度分钟数。 取值范围大于0并且大于等于(endTimeInMillis - startTimeInMillis) / (60 * 1000) - 1。当开始时间与结束时间都设置为-1时，系统会将结束时间设置为当前时间UTC毫秒值，并按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。如：-1.-1.60(表示最近60分钟)   约束：   单次请求中，查询时长与周期需要满足以下条件: durationInMinutes * 60 / period &lt;&#x3D; 1440
        /// </summary>
        [JsonProperty("timerange", NullValueHandling = NullValueHandling.Ignore)]
        public string Timerange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryMetricDataParam {\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("  timerange: ").Append(Timerange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryMetricDataParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryMetricDataParam input)
        {
            if (input == null) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && input.Statistics != null && !this.Statistics.SequenceEqual(input.Statistics))) return false;
            if (this.Timerange != input.Timerange || (this.Timerange != null && !this.Timerange.Equals(input.Timerange))) return false;

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
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.Timerange != null) hashCode = hashCode * 59 + this.Timerange.GetHashCode();
                return hashCode;
            }
        }
    }
}
