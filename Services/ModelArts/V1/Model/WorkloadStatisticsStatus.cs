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
    /// **参数描述**：不同状态下作业个数。
    /// </summary>
    public class WorkloadStatisticsStatus 
    {

        /// <summary>
        /// **参数描述**： 排队中的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Queue", NullValueHandling = NullValueHandling.Ignore)]
        public int? Queue { get; set; }

        /// <summary>
        /// **参数描述**： 等待中的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Pending", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pending { get; set; }

        /// <summary>
        /// **参数描述**： 异常的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Abnormal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Abnormal { get; set; }

        /// <summary>
        /// **参数描述**： 终止中的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Terminating", NullValueHandling = NullValueHandling.Ignore)]
        public int? Terminating { get; set; }

        /// <summary>
        /// **参数描述**： 创建中的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Creating", NullValueHandling = NullValueHandling.Ignore)]
        public int? Creating { get; set; }

        /// <summary>
        /// **参数描述**： 运行中的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Running", NullValueHandling = NullValueHandling.Ignore)]
        public int? Running { get; set; }

        /// <summary>
        /// **参数描述**： 已完成的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Completed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Completed { get; set; }

        /// <summary>
        /// **参数描述**： 已终止的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Terminated", NullValueHandling = NullValueHandling.Ignore)]
        public int? Terminated { get; set; }

        /// <summary>
        /// **参数描述**：运行失败的作业个数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("Failed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkloadStatisticsStatus {\n");
            sb.Append("  queue: ").Append(Queue).Append("\n");
            sb.Append("  pending: ").Append(Pending).Append("\n");
            sb.Append("  abnormal: ").Append(Abnormal).Append("\n");
            sb.Append("  terminating: ").Append(Terminating).Append("\n");
            sb.Append("  creating: ").Append(Creating).Append("\n");
            sb.Append("  running: ").Append(Running).Append("\n");
            sb.Append("  completed: ").Append(Completed).Append("\n");
            sb.Append("  terminated: ").Append(Terminated).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkloadStatisticsStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkloadStatisticsStatus input)
        {
            if (input == null) return false;
            if (this.Queue != input.Queue || (this.Queue != null && !this.Queue.Equals(input.Queue))) return false;
            if (this.Pending != input.Pending || (this.Pending != null && !this.Pending.Equals(input.Pending))) return false;
            if (this.Abnormal != input.Abnormal || (this.Abnormal != null && !this.Abnormal.Equals(input.Abnormal))) return false;
            if (this.Terminating != input.Terminating || (this.Terminating != null && !this.Terminating.Equals(input.Terminating))) return false;
            if (this.Creating != input.Creating || (this.Creating != null && !this.Creating.Equals(input.Creating))) return false;
            if (this.Running != input.Running || (this.Running != null && !this.Running.Equals(input.Running))) return false;
            if (this.Completed != input.Completed || (this.Completed != null && !this.Completed.Equals(input.Completed))) return false;
            if (this.Terminated != input.Terminated || (this.Terminated != null && !this.Terminated.Equals(input.Terminated))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && !this.Failed.Equals(input.Failed))) return false;

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
                if (this.Queue != null) hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.Pending != null) hashCode = hashCode * 59 + this.Pending.GetHashCode();
                if (this.Abnormal != null) hashCode = hashCode * 59 + this.Abnormal.GetHashCode();
                if (this.Terminating != null) hashCode = hashCode * 59 + this.Terminating.GetHashCode();
                if (this.Creating != null) hashCode = hashCode * 59 + this.Creating.GetHashCode();
                if (this.Running != null) hashCode = hashCode * 59 + this.Running.GetHashCode();
                if (this.Completed != null) hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.Terminated != null) hashCode = hashCode * 59 + this.Terminated.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                return hashCode;
            }
        }
    }
}
