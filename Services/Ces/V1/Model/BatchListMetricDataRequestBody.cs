using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchListMetricDataRequestBody 
    {

        /// <summary>
        /// **参数解释** 指标数据 **约束限制** 包含的指标数据对象个数为[1,500] 
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricInfo> Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public BatchPeriod Period { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; set; }
        /// <summary>
        /// **参数解释** 查询数据起始时间，UNIX时间戳，单位毫秒 **约束限制** 当period为1时，若(to- from) &gt;4*3600*1000，则from调整为 to - 4*3600*1000 当period为300时，若(to - from) &gt;24*3600*1000，则from调整为 to - 24*3600*1000 当period为1200时，若(to - from) &gt;3*24*3600*1000，则from调整为 to - 3*24*3600*1000 当period为3600时，若(to -from) &gt; 10*24*3600*1000，则from调整为 to -10*24*3600*1000 当period为14400时，若(to - from) &gt;30*24*3600*1000，则from调整为 to - 30*24*3600*1000 当period为86400时，若(to -from) &gt; 180*24*3600*1000，则from调整为 to - 180*24*3600*1000 **取值范围** 毫秒级时间戳范围为[1111111111111,9999999999999] **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// **参数解释** 查询数据截止时间，UNIX时间戳，单位毫秒 **约束限制** from 必须小于to **取值范围** 毫秒级时间戳范围为[1111111111111,9999999999999] **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListMetricDataRequestBody {\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListMetricDataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListMetricDataRequestBody input)
        {
            if (input == null) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;
            if (this.Period != input.Period) return false;
            if (this.Filter != input.Filter) return false;
            if (this.From != input.From || (this.From != null && !this.From.Equals(input.From))) return false;
            if (this.To != input.To || (this.To != null && !this.To.Equals(input.To))) return false;

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
                hashCode = hashCode * 59 + this.Period.GetHashCode();
                hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.From != null) hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null) hashCode = hashCode * 59 + this.To.GetHashCode();
                return hashCode;
            }
        }
    }
}
