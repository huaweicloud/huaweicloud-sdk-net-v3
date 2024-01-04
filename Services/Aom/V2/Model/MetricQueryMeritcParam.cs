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
    /// 查询参数集
    /// </summary>
    public class MetricQueryMeritcParam 
    {

        /// <summary>
        /// 指标维度列表。取值范围：数组不能为空，同时数组中任何一个dimension对象name和value属性的值也不能为空。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        /// 指标名称。名称长度取值范围为1~255个字符。取值范围：AOM提供的基础指标，cpuUsage、cpuCoreUsed等cpuUsage：cpu使用率；cpuCoreUsed：cpu内核占用；用户上报的自定义指标名称。
        /// </summary>
        [JsonProperty("metricName", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标命名空间。取值范围：PAAS.CONTAINER：组件指标、实例指标、进程指标和容器指标的命名空间，PAAS.NODE： 主机指标、网络指标、磁盘指标和文件系统指标的命名空间，PAAS.SLA：SLA指标的命名空间，PAAS.AGGR：集群指标的命名空间，CUSTOMMETRICS：默认的自定义指标的命名空间。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricQueryMeritcParam {\n");
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
            return this.Equals(input as MetricQueryMeritcParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricQueryMeritcParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dimensions == input.Dimensions ||
                    this.Dimensions != null &&
                    input.Dimensions != null &&
                    this.Dimensions.SequenceEqual(input.Dimensions)
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                return hashCode;
            }
        }
    }
}
