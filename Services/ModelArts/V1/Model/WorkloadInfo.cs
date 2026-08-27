using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 资源可用容量，不考虑资源已分配量，即资源总容量减去故障资源和热备节点的资源
    /// </summary>
    public class WorkloadInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("allocated", NullValueHandling = NullValueHandling.Ignore)]
        public WorkloadStatistics Allocated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("queue", NullValueHandling = NullValueHandling.Ignore)]
        public WorkloadStatistics Queue { get; set; }

        /// <summary>
        /// UTC时间，格式yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// 统计间隔，1s表示1秒，1m表示一分钟，1h为一小时。
        /// </summary>
        [JsonProperty("window", NullValueHandling = NullValueHandling.Ignore)]
        public string Window { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkloadInfo {\n");
            sb.Append("  allocated: ").Append(Allocated).Append("\n");
            sb.Append("  queue: ").Append(Queue).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  window: ").Append(Window).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkloadInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkloadInfo input)
        {
            if (input == null) return false;
            if (this.Allocated != input.Allocated || (this.Allocated != null && !this.Allocated.Equals(input.Allocated))) return false;
            if (this.Queue != input.Queue || (this.Queue != null && !this.Queue.Equals(input.Queue))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.Window != input.Window || (this.Window != null && !this.Window.Equals(input.Window))) return false;

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
                if (this.Allocated != null) hashCode = hashCode * 59 + this.Allocated.GetHashCode();
                if (this.Queue != null) hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Window != null) hashCode = hashCode * 59 + this.Window.GetHashCode();
                return hashCode;
            }
        }
    }
}
