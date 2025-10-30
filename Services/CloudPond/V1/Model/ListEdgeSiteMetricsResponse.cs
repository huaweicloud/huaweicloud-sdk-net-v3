using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEdgeSiteMetricsResponse : SdkResponse
    {

        /// <summary>
        /// 监控数据
        /// </summary>
        [JsonProperty("metric_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricDataDetail> MetricData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEdgeSiteMetricsResponse {\n");
            sb.Append("  metricData: ").Append(MetricData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEdgeSiteMetricsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEdgeSiteMetricsResponse input)
        {
            if (input == null) return false;
            if (this.MetricData != input.MetricData || (this.MetricData != null && input.MetricData != null && !this.MetricData.SequenceEqual(input.MetricData))) return false;

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
                if (this.MetricData != null) hashCode = hashCode * 59 + this.MetricData.GetHashCode();
                return hashCode;
            }
        }
    }
}
