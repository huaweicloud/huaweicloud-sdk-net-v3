using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PointStatus 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("taskType", NullValueHandling = NullValueHandling.Ignore)]
        public TaskType TaskType { get; set; }
        /// <summary>
        /// 升级任务项ID
        /// </summary>
        [JsonProperty("taskID", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeWorkflowTaskStatus Status { get; set; }
        /// <summary>
        /// 升级任务开始时间
        /// </summary>
        [JsonProperty("startTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTimeStamp { get; set; }

        /// <summary>
        /// 升级任务结束时间
        /// </summary>
        [JsonProperty("endTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTimeStamp { get; set; }

        /// <summary>
        /// 升级任务过期时间（当前仅升级前检查任务适用）
        /// </summary>
        [JsonProperty("expireTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeStamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PointStatus {\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  taskID: ").Append(TaskID).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  startTimeStamp: ").Append(StartTimeStamp).Append("\n");
            sb.Append("  endTimeStamp: ").Append(EndTimeStamp).Append("\n");
            sb.Append("  expireTimeStamp: ").Append(ExpireTimeStamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PointStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PointStatus input)
        {
            if (input == null) return false;
            if (this.TaskType != input.TaskType) return false;
            if (this.TaskID != input.TaskID || (this.TaskID != null && !this.TaskID.Equals(input.TaskID))) return false;
            if (this.Status != input.Status) return false;
            if (this.StartTimeStamp != input.StartTimeStamp || (this.StartTimeStamp != null && !this.StartTimeStamp.Equals(input.StartTimeStamp))) return false;
            if (this.EndTimeStamp != input.EndTimeStamp || (this.EndTimeStamp != null && !this.EndTimeStamp.Equals(input.EndTimeStamp))) return false;
            if (this.ExpireTimeStamp != input.ExpireTimeStamp || (this.ExpireTimeStamp != null && !this.ExpireTimeStamp.Equals(input.ExpireTimeStamp))) return false;

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
                hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.TaskID != null) hashCode = hashCode * 59 + this.TaskID.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTimeStamp != null) hashCode = hashCode * 59 + this.StartTimeStamp.GetHashCode();
                if (this.EndTimeStamp != null) hashCode = hashCode * 59 + this.EndTimeStamp.GetHashCode();
                if (this.ExpireTimeStamp != null) hashCode = hashCode * 59 + this.ExpireTimeStamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
