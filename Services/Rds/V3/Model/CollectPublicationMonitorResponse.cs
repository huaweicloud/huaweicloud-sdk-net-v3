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
    public class CollectPublicationMonitorResponse : SdkResponse
    {

        /// <summary>
        /// 发布关联的快照代理的运行状态。取值如下:  started:已启动。 succeeded:成功。 in_progress:正在运行。 idle:空闲。 retrying:重试中。 failed:失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据更改的最长延迟时间（以秒为单位）。
        /// </summary>
        [JsonProperty("worst_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? WorstLatency { get; set; }

        /// <summary>
        /// 数据更改的最短延迟时间（以秒为单位）。
        /// </summary>
        [JsonProperty("best_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? BestLatency { get; set; }

        /// <summary>
        /// 数据更改的平均延迟时间（以秒为单位）。
        /// </summary>
        [JsonProperty("average_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? AverageLatency { get; set; }

        /// <summary>
        /// 上一次分发代理运行时间。格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("last_dist_sync", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDistSync { get; set; }

        /// <summary>
        /// 等待传送到分发数据库的事务数。
        /// </summary>
        [JsonProperty("replicated_transactions", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicatedTransactions { get; set; }

        /// <summary>
        /// 平均每秒传送到分发数据库的事务数。
        /// </summary>
        [JsonProperty("replication_rate_trans", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ReplicationRateTrans { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectPublicationMonitorResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  worstLatency: ").Append(WorstLatency).Append("\n");
            sb.Append("  bestLatency: ").Append(BestLatency).Append("\n");
            sb.Append("  averageLatency: ").Append(AverageLatency).Append("\n");
            sb.Append("  lastDistSync: ").Append(LastDistSync).Append("\n");
            sb.Append("  replicatedTransactions: ").Append(ReplicatedTransactions).Append("\n");
            sb.Append("  replicationRateTrans: ").Append(ReplicationRateTrans).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectPublicationMonitorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectPublicationMonitorResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.WorstLatency != input.WorstLatency || (this.WorstLatency != null && !this.WorstLatency.Equals(input.WorstLatency))) return false;
            if (this.BestLatency != input.BestLatency || (this.BestLatency != null && !this.BestLatency.Equals(input.BestLatency))) return false;
            if (this.AverageLatency != input.AverageLatency || (this.AverageLatency != null && !this.AverageLatency.Equals(input.AverageLatency))) return false;
            if (this.LastDistSync != input.LastDistSync || (this.LastDistSync != null && !this.LastDistSync.Equals(input.LastDistSync))) return false;
            if (this.ReplicatedTransactions != input.ReplicatedTransactions || (this.ReplicatedTransactions != null && !this.ReplicatedTransactions.Equals(input.ReplicatedTransactions))) return false;
            if (this.ReplicationRateTrans != input.ReplicationRateTrans || (this.ReplicationRateTrans != null && !this.ReplicationRateTrans.Equals(input.ReplicationRateTrans))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.WorstLatency != null) hashCode = hashCode * 59 + this.WorstLatency.GetHashCode();
                if (this.BestLatency != null) hashCode = hashCode * 59 + this.BestLatency.GetHashCode();
                if (this.AverageLatency != null) hashCode = hashCode * 59 + this.AverageLatency.GetHashCode();
                if (this.LastDistSync != null) hashCode = hashCode * 59 + this.LastDistSync.GetHashCode();
                if (this.ReplicatedTransactions != null) hashCode = hashCode * 59 + this.ReplicatedTransactions.GetHashCode();
                if (this.ReplicationRateTrans != null) hashCode = hashCode * 59 + this.ReplicationRateTrans.GetHashCode();
                return hashCode;
            }
        }
    }
}
