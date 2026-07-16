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
    /// **参数解释**：监控指标描述。
    /// </summary>
    public class PoolMonitorMetric 
    {

        /// <summary>
        /// **参数解释**：指标维度信息。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolMonitorMetricDimensions> Dimensions { get; set; }

        /// <summary>
        /// **参数解释**：指标名称。 **取值范围**：可选值如下： - cpuUsage：CPU使用量。 - memUsedRate：内存利用率。 - gpuUtil：GPU显卡使用量。 - gpuMemUsage：GPU显存使用量。 - npuUtil：NPU显卡使用量。 - npuMemUsage：NPU显存使用量。 - diskCapacity：磁盘容量。 - diskAvailableCapacity：磁盘可用容量。 - diskUsedRate：磁盘利用率。
        /// </summary>
        [JsonProperty("metricName", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// **参数解释**：指标命名空间。 **取值范围**：可选值如下： -  PAAS.CONTAINER：组件指标、实例指标、进程指标和容器指标的命名空间 - PAAS.NODE： 主机指标、网络指标、磁盘指标和文件系统指标的命名空间 -  PAAS.SLA：SLA指标的命名空间 - PAAS.AGGR：集群指标的命名空间 - CUSTOMMETRICS：默认的自定义指标的命名空间
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolMonitorMetric {\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolMonitorMetric);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolMonitorMetric input)
        {
            if (input == null) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;

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
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
