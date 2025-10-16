using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStatusClusterResponse : SdkResponse
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 集群列表
        /// </summary>
        [JsonProperty("cluster_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusClusterItem> ClusterList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusClusterResponse {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  clusterList: ").Append(ClusterList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusClusterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusClusterResponse input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.ClusterList != input.ClusterList || (this.ClusterList != null && input.ClusterList != null && !this.ClusterList.SequenceEqual(input.ClusterList))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.ClusterList != null) hashCode = hashCode * 59 + this.ClusterList.GetHashCode();
                return hashCode;
            }
        }
    }
}
