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
    /// Response Object
    /// </summary>
    public class BatchListMetricDataResponse : SdkResponse
    {

        /// <summary>
        /// 监控指标。
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchMetricData> Metrics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchListMetricDataResponse {\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchListMetricDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchListMetricDataResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
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
                if (this.Metrics != null)
                    hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
