using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstancesResourceMetricsResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 资源监控信息
        /// </summary>
        [JsonProperty("resource_monitoring_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceMonitoringInfo> ResourceMonitoringInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesResourceMetricsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  resourceMonitoringInfos: ").Append(ResourceMonitoringInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesResourceMetricsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesResourceMetricsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.ResourceMonitoringInfos == input.ResourceMonitoringInfos ||
                    this.ResourceMonitoringInfos != null &&
                    input.ResourceMonitoringInfos != null &&
                    this.ResourceMonitoringInfos.SequenceEqual(input.ResourceMonitoringInfos)
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
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ResourceMonitoringInfos != null)
                    hashCode = hashCode * 59 + this.ResourceMonitoringInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
