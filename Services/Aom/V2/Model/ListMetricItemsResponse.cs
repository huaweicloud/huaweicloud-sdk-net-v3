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
    /// Response Object
    /// </summary>
    public class ListMetricItemsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metaData", NullValueHandling = NullValueHandling.Ignore)]
        public MetaDataSeries MetaData { get; set; }

        /// <summary>
        /// 指标对象列表。
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricItemResultAPI> Metrics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMetricItemsResponse {\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMetricItemsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMetricItemsResponse input)
        {
            if (input == null) return false;
            if (this.MetaData != input.MetaData || (this.MetaData != null && !this.MetaData.Equals(input.MetaData))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;

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
                if (this.MetaData != null) hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
