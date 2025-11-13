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
    public class CollectSubscriptionMonitorResponse : SdkResponse
    {

        /// <summary>
        /// 订阅关联的快照代理的运行状态。取值如下:  started:已启动。 succeeded:成功。 in_progress:正在运行。 idle:空闲。 retrying:重试中。 failed:失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据更改的最长延迟时间（以秒为单位）。
        /// </summary>
        [JsonProperty("latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Latency { get; set; }

        /// <summary>
        /// 上一次分发代理运行时间。格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("last_dist_sync", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDistSync { get; set; }

        /// <summary>
        /// 代理未运行的时长（以小时为单位）。
        /// </summary>
        [JsonProperty("agent_not_running", NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentNotRunning { get; set; }

        /// <summary>
        /// 订阅未执行的命令数。
        /// </summary>
        [JsonProperty("pending_cmd_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingCmdCount { get; set; }

        /// <summary>
        /// 预计执行完未执行的命令数所需时间（以秒为单位）。
        /// </summary>
        [JsonProperty("estimated_process_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? EstimatedProcessTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectSubscriptionMonitorResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  latency: ").Append(Latency).Append("\n");
            sb.Append("  lastDistSync: ").Append(LastDistSync).Append("\n");
            sb.Append("  agentNotRunning: ").Append(AgentNotRunning).Append("\n");
            sb.Append("  pendingCmdCount: ").Append(PendingCmdCount).Append("\n");
            sb.Append("  estimatedProcessTime: ").Append(EstimatedProcessTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectSubscriptionMonitorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectSubscriptionMonitorResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Latency != input.Latency || (this.Latency != null && !this.Latency.Equals(input.Latency))) return false;
            if (this.LastDistSync != input.LastDistSync || (this.LastDistSync != null && !this.LastDistSync.Equals(input.LastDistSync))) return false;
            if (this.AgentNotRunning != input.AgentNotRunning || (this.AgentNotRunning != null && !this.AgentNotRunning.Equals(input.AgentNotRunning))) return false;
            if (this.PendingCmdCount != input.PendingCmdCount || (this.PendingCmdCount != null && !this.PendingCmdCount.Equals(input.PendingCmdCount))) return false;
            if (this.EstimatedProcessTime != input.EstimatedProcessTime || (this.EstimatedProcessTime != null && !this.EstimatedProcessTime.Equals(input.EstimatedProcessTime))) return false;

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
                if (this.Latency != null) hashCode = hashCode * 59 + this.Latency.GetHashCode();
                if (this.LastDistSync != null) hashCode = hashCode * 59 + this.LastDistSync.GetHashCode();
                if (this.AgentNotRunning != null) hashCode = hashCode * 59 + this.AgentNotRunning.GetHashCode();
                if (this.PendingCmdCount != null) hashCode = hashCode * 59 + this.PendingCmdCount.GetHashCode();
                if (this.EstimatedProcessTime != null) hashCode = hashCode * 59 + this.EstimatedProcessTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
