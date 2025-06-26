using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServerMetricDataResponse : SdkResponse
    {

        /// <summary>
        /// 监控数据。
        /// </summary>
        [JsonProperty("server_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerMetricData> ServerMetrics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServerMetricDataResponse {\n");
            sb.Append("  serverMetrics: ").Append(ServerMetrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServerMetricDataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerMetricDataResponse input)
        {
            if (input == null) return false;
            if (this.ServerMetrics != input.ServerMetrics || (this.ServerMetrics != null && input.ServerMetrics != null && !this.ServerMetrics.SequenceEqual(input.ServerMetrics))) return false;

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
                if (this.ServerMetrics != null) hashCode = hashCode * 59 + this.ServerMetrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
