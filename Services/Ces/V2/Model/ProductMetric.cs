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
    /// 
    /// </summary>
    public class ProductMetric 
    {

        /// <summary>
        /// 按云产品维度屏蔽时的指标维度信息，有多个时用\&quot;,\&quot;连接
        /// </summary>
        [JsonProperty("dimension_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimensionName { get; set; }

        /// <summary>
        /// 资源的监控指标名称，必须以字母开头，只能包含0-9/a-z/A-Z/_，字符长度最短为1，最大为64；如：弹性云服务器中的监控指标cpu_util，表示弹性服务器的CPU使用率；文档数据库中的指标mongo001_command_ps，表示command执行频率；各服务的指标名称可查看：“[服务指标名称](ces_03_0059.xml)”。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductMetric {\n");
            sb.Append("  dimensionName: ").Append(DimensionName).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductMetric);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductMetric input)
        {
            if (input == null) return false;
            if (this.DimensionName != input.DimensionName || (this.DimensionName != null && !this.DimensionName.Equals(input.DimensionName))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;

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
                if (this.DimensionName != null) hashCode = hashCode * 59 + this.DimensionName.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                return hashCode;
            }
        }
    }
}
