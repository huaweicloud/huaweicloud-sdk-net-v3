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
    public class BatchMetricData 
    {

        /// <summary>
        /// 指标单位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 指标数据列表。由于查询数据时，云监控会根据所选择的聚合粒度向前取整from参数，所以datapoints中包含的数据点有可能会多于预期。
        /// </summary>
        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatapointForBatchMetric> Datapoints { get; set; }

        /// <summary>
        /// 指标命名空间，格式为service.item；service和item必须是字符串，必须以字母开头，只能包含0-9/a-z/A-Z/_，总长度最短为3，最大为32；各服务的命名空间可查看：“[服务命名空间](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 指标名称，例如弹性云服务器监控指标中的cpu_util；各服务的指标名称可查看：“[服务指标名称](https://support.huaweicloud.com/usermanual-ces/zh-cn_topic_0202622212.html)”。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标维度列表。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricsDimension> Dimensions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchMetricData {\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchMetricData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchMetricData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Datapoints == input.Datapoints ||
                    this.Datapoints != null &&
                    input.Datapoints != null &&
                    this.Datapoints.SequenceEqual(input.Datapoints)
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
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
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Datapoints != null)
                    hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
