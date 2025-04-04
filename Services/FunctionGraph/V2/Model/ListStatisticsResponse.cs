using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 月度调用次数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public List<MonthUsed> Count { get; set; }

        /// <summary>
        /// 月度资源用量
        /// </summary>
        [JsonProperty("gbs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MonthUsed> Gbs { get; set; }

        /// <summary>
        /// 月度gpu资源用量
        /// </summary>
        [JsonProperty("gpu_gbs", NullValueHandling = NullValueHandling.Ignore)]
        public List<MonthUsed> GpuGbs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public ListFunctionStatisticsResponseBody Statistics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStatisticsResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  gbs: ").Append(Gbs).Append("\n");
            sb.Append("  gpuGbs: ").Append(GpuGbs).Append("\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && input.Count != null && !this.Count.SequenceEqual(input.Count))) return false;
            if (this.Gbs != input.Gbs || (this.Gbs != null && input.Gbs != null && !this.Gbs.SequenceEqual(input.Gbs))) return false;
            if (this.GpuGbs != input.GpuGbs || (this.GpuGbs != null && input.GpuGbs != null && !this.GpuGbs.SequenceEqual(input.GpuGbs))) return false;
            if (this.Statistics != input.Statistics || (this.Statistics != null && !this.Statistics.Equals(input.Statistics))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Gbs != null) hashCode = hashCode * 59 + this.Gbs.GetHashCode();
                if (this.GpuGbs != null) hashCode = hashCode * 59 + this.GpuGbs.GetHashCode();
                if (this.Statistics != null) hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
