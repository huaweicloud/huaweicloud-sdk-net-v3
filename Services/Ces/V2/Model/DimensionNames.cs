using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 启用一键告警关联告警规则的维度列表，包括指标告警&amp;事件告警，且至少开启一个
    /// </summary>
    public class DimensionNames 
    {

        /// <summary>
        /// 启用一键告警关联指标告警规则的维度列表，未指定的维度默认不开启
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Metric { get; set; }

        /// <summary>
        /// 启用一键告警关联事件告警规则的维度列表，未指定的维度默认不开启，其中\&quot;\&quot;代表全部资源
        /// </summary>
        [JsonProperty("event", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Event { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionNames {\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DimensionNames);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DimensionNames input)
        {
            if (input == null) return false;
            if (this.Metric != input.Metric || (this.Metric != null && input.Metric != null && !this.Metric.SequenceEqual(input.Metric))) return false;
            if (this.Event != input.Event || (this.Event != null && input.Event != null && !this.Event.SequenceEqual(input.Event))) return false;

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
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Event != null) hashCode = hashCode * 59 + this.Event.GetHashCode();
                return hashCode;
            }
        }
    }
}
