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
    public class ShowPoolMonitorRequest 
    {

        /// <summary>
        /// **参数解释**：资源池的ID，取值自资源池详情的metadata.name字段。 **约束限制**：不涉及。 **取值范围**：只能以小写字母开头，数字、中划线组成，不能以中划线结尾，且长度为[36-63]个字符。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("pool_name", IsPath = true)]
        [JsonProperty("pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// **参数解释**：查询资源池监控信息的时间范围，格式为startTimeInMillis.endTimeInMillis.durationInMinutes。其中，startTimeInMillis表示查询的开始时间，格式为UTC毫秒，如果指定为-1，服务端将按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。endTimeInMillis表示查询的结束时间，格式为UTC毫秒，如果指定为-1，服务端将按(startTimeInMillis + durationInMinutes * 60 * 1000)计算结束时间，如果计算出的结束时间大于当前系统时间，则使用当前系统时间。durationInMinutes表示查询时间的跨度分钟数。 取值范围大于0并且小于等于(endTimeInMillis - startTimeInMillis) / (60 * 1000) - 1。当开始时间与结束时间都设置为-1时，系统会将结束时间设置为当前时间UTC毫秒值，并按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。如：-1.-1.60(表示最近60分钟)。 **约束限制**：单次请求中，查询时长与周期需要满足以下条件: durationInMinutes * 60 / period &lt;&#x3D; 1440。 **取值范围**：不涉及。 **默认取值**：-1.-1.60。  查询时间范围，默认值“-1.-1.60”。格式为startTimeInMillis.endTimeInMillis.durationInMinutes，参数解释： - startTimeInMillis: 查询的开始时间，格式为UTC毫秒，如果指定为-1，服务端将按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间 - endTimeInMillis: 查询的结束时间，格式为UTC毫秒，如果指定为-1，服务端将按(startTimeInMillis + durationInMinutes * 60 * 1000)计算结束时间，如果计算出的结束时间大于当前系统时间，则使用当前系统时间 - durationInMinutes：查询时间的跨度分钟数。 取值范围大于0并且小于等于(endTimeInMillis - startTimeInMillis) / (60 * 1000) - 1 当开始时间与结束时间都设置为-1时，系统会将结束时间设置为当前时间UTC毫秒值，并按(endTimeInMillis - durationInMinutes * 60 * 1000)计算开始时间。如：-1.-1.60(表示最近60分钟)约束：单次请求中，查询时长与周期需要满足以下条件: durationInMinutes * 60 / period &lt;&#x3D; 1440。
        /// </summary>
        [SDKProperty("time_range", IsQuery = true)]
        [JsonProperty("time_range", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeRange { get; set; }

        /// <summary>
        /// **参数解释**：资源池监控信息在指定时间粒度下的统计方式。 **约束限制**：不涉及。 **取值范围**：可选值如下： - maximum：最大值统计，默认值。 - minimum：最小值统计。 - sum：求和统计。 - average：平均值统计。 - sampleCount：采样统计。 **默认取值**：maximum。
        /// </summary>
        [SDKProperty("statistics", IsQuery = true)]
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public string Statistics { get; set; }

        /// <summary>
        /// **参数解释**：查询资源池监控信息的时间粒度，以秒为单位。 **约束限制**：不涉及。 **取值范围**：可选值如下： - 60：粒度为1分钟，默认值。 - 300：粒度为5分钟。 - 900：粒度为15分钟。 - 3600：粒度为1小时。 **默认取值**：60。
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPoolMonitorRequest {\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("  timeRange: ").Append(TimeRange).Append("\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPoolMonitorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPoolMonitorRequest input)
        {
            if (input == null) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;
            if (this.TimeRange != input.TimeRange || (this.TimeRange != null && !this.TimeRange.Equals(input.TimeRange))) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && !this.Statistics.Equals(input.Statistics))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;

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
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.TimeRange != null) hashCode = hashCode * 59 + this.TimeRange.GetHashCode();
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
