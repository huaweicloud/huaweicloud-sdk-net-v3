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
    /// 指标
    /// </summary>
    public class MetricDataItem 
    {

        /// <summary>
        /// 数据收集时间支持过去1天和未来半小时范围内的数据上报。数据收集时间需要满足：  当前UTC时间减去collect_time小于等于24小时或者collect_time减去当前UTC时间小于等于30分钟。  若数据上报时间早于当天8点，则指标监控页面只显示当天8点后的数据。取值范围： UNIX时间戳，单位毫秒。
        /// </summary>
        [JsonProperty("collect_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CollectTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricItemInfo Metric { get; set; }

        /// <summary>
        /// 指标数据的值。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<ValueData> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricDataItem {\n");
            sb.Append("  collectTime: ").Append(CollectTime).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricDataItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricDataItem input)
        {
            if (input == null) return false;
            if (this.CollectTime != input.CollectTime || (this.CollectTime != null && !this.CollectTime.Equals(input.CollectTime))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                if (this.CollectTime != null) hashCode = hashCode * 59 + this.CollectTime.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
