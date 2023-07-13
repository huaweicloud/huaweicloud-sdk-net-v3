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
    /// 双活实例rsync同步状态指标值
    /// </summary>
    public class NoSQLDrDateSyncIndicators 
    {

        /// <summary>
        /// 节点内同步命令的执行速率,每秒多少条数据；
        /// </summary>
        [JsonProperty("rsync_ops", NullValueHandling = NullValueHandling.Ignore)]
        public long? RsyncOps { get; set; }

        /// <summary>
        /// 节点内的同步WAL堆积大小,单位MB；
        /// </summary>
        [JsonProperty("rsync_wal_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? RsyncWalSize { get; set; }

        /// <summary>
        /// 同步消息从放入消息队列，直到收到对端响应的平均耗时，单位us；
        /// </summary>
        [JsonProperty("rsync_push_cost", NullValueHandling = NullValueHandling.Ignore)]
        public long? RsyncPushCost { get; set; }

        /// <summary>
        /// 同步消息从消息队列取出，直到收到对端响应的平均耗时，单位us；
        /// </summary>
        [JsonProperty("rsync_send_cost", NullValueHandling = NullValueHandling.Ignore)]
        public long? RsyncSendCost { get; set; }

        /// <summary>
        /// 采集周期内rsync的同步推送耗时最大值，单位us;
        /// </summary>
        [JsonProperty("rsync_max_push_cost", NullValueHandling = NullValueHandling.Ignore)]
        public long? RsyncMaxPushCost { get; set; }

        /// <summary>
        /// 采集周期内rsync的同步发送耗时最大值，单位us;
        /// </summary>
        [JsonProperty("rsync_max_send_cost", NullValueHandling = NullValueHandling.Ignore)]
        public long? RsyncMaxSendCost { get; set; }

        /// <summary>
        /// rsync的同步状态，1表示正在同步，0表示没有同步;
        /// </summary>
        [JsonProperty("rsync_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? RsyncStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoSQLDrDateSyncIndicators {\n");
            sb.Append("  rsyncOps: ").Append(RsyncOps).Append("\n");
            sb.Append("  rsyncWalSize: ").Append(RsyncWalSize).Append("\n");
            sb.Append("  rsyncPushCost: ").Append(RsyncPushCost).Append("\n");
            sb.Append("  rsyncSendCost: ").Append(RsyncSendCost).Append("\n");
            sb.Append("  rsyncMaxPushCost: ").Append(RsyncMaxPushCost).Append("\n");
            sb.Append("  rsyncMaxSendCost: ").Append(RsyncMaxSendCost).Append("\n");
            sb.Append("  rsyncStatus: ").Append(RsyncStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NoSQLDrDateSyncIndicators);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NoSQLDrDateSyncIndicators input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RsyncOps == input.RsyncOps ||
                    (this.RsyncOps != null &&
                    this.RsyncOps.Equals(input.RsyncOps))
                ) && 
                (
                    this.RsyncWalSize == input.RsyncWalSize ||
                    (this.RsyncWalSize != null &&
                    this.RsyncWalSize.Equals(input.RsyncWalSize))
                ) && 
                (
                    this.RsyncPushCost == input.RsyncPushCost ||
                    (this.RsyncPushCost != null &&
                    this.RsyncPushCost.Equals(input.RsyncPushCost))
                ) && 
                (
                    this.RsyncSendCost == input.RsyncSendCost ||
                    (this.RsyncSendCost != null &&
                    this.RsyncSendCost.Equals(input.RsyncSendCost))
                ) && 
                (
                    this.RsyncMaxPushCost == input.RsyncMaxPushCost ||
                    (this.RsyncMaxPushCost != null &&
                    this.RsyncMaxPushCost.Equals(input.RsyncMaxPushCost))
                ) && 
                (
                    this.RsyncMaxSendCost == input.RsyncMaxSendCost ||
                    (this.RsyncMaxSendCost != null &&
                    this.RsyncMaxSendCost.Equals(input.RsyncMaxSendCost))
                ) && 
                (
                    this.RsyncStatus == input.RsyncStatus ||
                    (this.RsyncStatus != null &&
                    this.RsyncStatus.Equals(input.RsyncStatus))
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
                if (this.RsyncOps != null)
                    hashCode = hashCode * 59 + this.RsyncOps.GetHashCode();
                if (this.RsyncWalSize != null)
                    hashCode = hashCode * 59 + this.RsyncWalSize.GetHashCode();
                if (this.RsyncPushCost != null)
                    hashCode = hashCode * 59 + this.RsyncPushCost.GetHashCode();
                if (this.RsyncSendCost != null)
                    hashCode = hashCode * 59 + this.RsyncSendCost.GetHashCode();
                if (this.RsyncMaxPushCost != null)
                    hashCode = hashCode * 59 + this.RsyncMaxPushCost.GetHashCode();
                if (this.RsyncMaxSendCost != null)
                    hashCode = hashCode * 59 + this.RsyncMaxSendCost.GetHashCode();
                if (this.RsyncStatus != null)
                    hashCode = hashCode * 59 + this.RsyncStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
