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
    /// 参数项。
    /// </summary>
    public class QuerySeriesOptionParam 
    {

        /// <summary>
        /// 时间序列命名空间。取值范围：PAAS.CONTAINER、PAAS.NODE、PAAS.SLA、PAAS.AGGR、CUSTOMMETRICS等。PAAS.CONTAINER：应用时间序列命名空间；PAAS.NODE：节点时间序列命名空间；PAAS.SLA：SLA时间序列命名空间；PAAS.AGGR：集群时间序列命名空间；CUSTOMMETRICS：自定义时间序列命名空间。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 时间序列名称，名称长度取值范围为1~255个字符。取值范围：AOM提供的基础时间序列名称，cpuUsage、cpuCoreUsed等：cpuUsage：cpu使用率；cpuCoreUsed：cpu内核占用；用户上报的自定义时间序列名称。
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 时间序列维度列表。可通过/v2/{project_id}/series接口中namespace+metric_name，查询当前监控的时间序列名称的时间序列维度列表。
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<DimensionSeries> Dimensions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySeriesOptionParam {\n");
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
            return this.Equals(input as QuerySeriesOptionParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuerySeriesOptionParam input)
        {
            if (input == null) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
