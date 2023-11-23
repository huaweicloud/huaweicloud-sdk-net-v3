using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstancesSessionStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 总客户端连接数。
        /// </summary>
        [JsonProperty("total_connection_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalConnectionCount { get; set; }

        /// <summary>
        /// active_connection_count
        /// </summary>
        [JsonProperty("active_connection_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveConnectionCount { get; set; }

        /// <summary>
        /// 节点连接的各个客户端连接数汇总，从大到小取前十个，最多十个，展示客户端的ip地址和连接总数。
        /// </summary>
        [JsonProperty("top_source_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListInstancesSessionStatisticsRespondBodyTopSourceIps> TopSourceIps { get; set; }

        /// <summary>
        /// 节点各数据库连接的客户端的ip和该ip连接节点的连接数，按连接数从高到低取前十个，最多十个。
        /// </summary>
        [JsonProperty("top_dbs", NullValueHandling = NullValueHandling.Ignore)]
        public Object TopDbs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesSessionStatisticsResponse {\n");
            sb.Append("  totalConnectionCount: ").Append(TotalConnectionCount).Append("\n");
            sb.Append("  activeConnectionCount: ").Append(ActiveConnectionCount).Append("\n");
            sb.Append("  topSourceIps: ").Append(TopSourceIps).Append("\n");
            sb.Append("  topDbs: ").Append(TopDbs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesSessionStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesSessionStatisticsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalConnectionCount == input.TotalConnectionCount ||
                    (this.TotalConnectionCount != null &&
                    this.TotalConnectionCount.Equals(input.TotalConnectionCount))
                ) && 
                (
                    this.ActiveConnectionCount == input.ActiveConnectionCount ||
                    (this.ActiveConnectionCount != null &&
                    this.ActiveConnectionCount.Equals(input.ActiveConnectionCount))
                ) && 
                (
                    this.TopSourceIps == input.TopSourceIps ||
                    this.TopSourceIps != null &&
                    input.TopSourceIps != null &&
                    this.TopSourceIps.SequenceEqual(input.TopSourceIps)
                ) && 
                (
                    this.TopDbs == input.TopDbs ||
                    (this.TopDbs != null &&
                    this.TopDbs.Equals(input.TopDbs))
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
                if (this.TotalConnectionCount != null)
                    hashCode = hashCode * 59 + this.TotalConnectionCount.GetHashCode();
                if (this.ActiveConnectionCount != null)
                    hashCode = hashCode * 59 + this.ActiveConnectionCount.GetHashCode();
                if (this.TopSourceIps != null)
                    hashCode = hashCode * 59 + this.TopSourceIps.GetHashCode();
                if (this.TopDbs != null)
                    hashCode = hashCode * 59 + this.TopDbs.GetHashCode();
                return hashCode;
            }
        }
    }
}
